using System.Linq;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class MetalShape : MeshType
{
    public float K_Value;
    public float M_Value;
    public float Damping_Value;
    public float StiffnessFactor_Value;
    public float PlasticThreshold_Value;

    public float DragCoefficient;
    public float FrictionCoefficient;
    float γ;
    public override void ApplySettings(MeshObject1 obj)
    {
        K_Value = obj.K_Value;
        M_Value = obj.M_Value;
        Damping_Value = obj.Damping_Value;
        StiffnessFactor_Value = obj.StiffnessFactor_Value;
        PlasticThreshold_Value = obj.PlasticThreshold_Value;
        DragCoefficient = obj.DragCoefficient;
        FrictionCoefficient = obj.FrictionCoefficient;
        γ = obj.γ;
    }

    public override float K => K_Value;
    public override float M => M_Value;
    public override float Damping => Damping_Value;
    public override float StiffnessFactor => StiffnessFactor_Value;
    public override float PlasticThreshold => PlasticThreshold_Value;
    Vector3[] Oldvelocities;


    public override void SimulatePhysics(SimulationState s, Transform transform, MeshObject1 self, MeshObject1[] allObjects)
    {
        Vector3[] vertices = s.vertices;
        Vector3[] velocities = s.velocities;
        Vector3[] forces = s.forces;
        int[,] springs = s.springs;
        float[] rest = s.restLengths;

        Vector3 gravity = transform.InverseTransformDirection(Vector3.down * 9.81f);



        // === SHAPE COLLISION WITH OTHER OBJECTS ===
        foreach (var other in allObjects)
        {
            if (other == self || other.state == null)
                continue;

            if (self.GetInstanceID() > other.GetInstanceID())
                continue;

            //if (!MeshType.AABBOverlap(self.GetAABB1(), other.GetAABB1()))
            //continue;

            Vector3[] worldVertsA = s.vertices.Select(v => transform.TransformPoint(v)).ToArray();
            Vector3[] worldVertsB = other.state.vertices.Select(v => other.transform.TransformPoint(v)).ToArray();

            GJK gjk = new GJK(worldVertsA, worldVertsB);
            if (!gjk.Intersect()) continue;

            EPA epa = new EPA(dir => gjk.Support(dir));
            epa.Initialize(gjk.simplex);
            (Vector3 normal, float depth, Vector3 contact) = epa.ComputePenetration();

            if (depth <= 0 || float.IsNaN(depth) || normal == Vector3.zero)
                continue;

            float restitution = .1f;
            float mA = self.M_Value;
            float mB = other.M_Value;
            float totalMass = mA + mB;

            for (int i = 0; i < s.vertices.Length; i++)
            {
                Vector3 worldV = transform.TransformPoint(s.vertices[i]);
                Vector3 toPoint = worldV - contact;
                float proj = Vector3.Dot(toPoint, normal);

                //if (proj < .1f)
                {
                    // === POSITION CORRECTION ===
                    Vector3 correction = -normal * ( depth * Time.fixedDeltaTime);
                    Vector3 correctionA = correction * (mB / totalMass);
                    Vector3 correctionB = correction * (mA / totalMass);

                    s.vertices[i] = transform.InverseTransformPoint(worldV + correctionA);

                    int jIndex = other.FindClosestVertexIndex(contact);
                    Vector3 otherWorldV = other.transform.TransformPoint(other.state.vertices[jIndex]);
                    //other.state.vertices[jIndex] = other.transform.InverseTransformPoint(otherWorldV - correctionB);

                    // === IMPULSE
                    Vector3 vA = s.velocities[i];
                    Vector3 vB = other.GetVelocityAtPoint(contact);
                    float vRel = Vector3.Dot(vA, normal);


                    float j = -(1 + restitution) * vRel / (1 / mA + 1 / mB);
                    Vector3 impulse = j * normal;

                    s.velocities[i] += impulse / mA;
                    other.state.velocities[jIndex] -= impulse / mB;

                    Vector3 tangent = (vA - vB) - Vector3.Dot(vA - vB, normal) * normal;
                    if (tangent.magnitude > 0.001f)
                    {
                        float friction = Mathf.Min(self.FrictionCoefficient, other.FrictionCoefficient);
                        Vector3 frictionImpulse = -friction * tangent.normalized * impulse.magnitude;

                        s.velocities[i] += frictionImpulse / mA;
                        other.state.velocities[jIndex] -= frictionImpulse / mB;
                    }

                }
            }
        }


        // Reset forces and apply gravity
        for (int i = 0; i < vertices.Length; i++)
        {
            forces[i] = M * gravity;
        }

        // === SPRING FORCE ===
        for (int i = 0; i < springs.GetLength(0); i++)
        {
            int a = springs[i, 0];
            int b = springs[i, 1];
            Vector3 delta = vertices[b] - vertices[a];
            float dist = delta.magnitude;
            Vector3 dir = delta.normalized;
            float x = dist - rest[i];

            Vector3 springForce = K * x * dir;
            Vector3 damping = Damping * Vector3.Dot(velocities[b] - velocities[a], dir) * dir;
            Vector3 totalForce = springForce + damping;
            //Debug.Log(Mathf.Abs(x));
            if (Mathf.Abs(x) > PlasticThreshold)
                rest[i] = Mathf.Lerp(rest[i], dist, 0.1f);

            forces[a] += totalForce;
            forces[b] -= totalForce;

            // === PLASTIC DEFORMATION BASED ON ENERGY LOST ===
            float relativeSpeed = Vector3.Dot(velocities[b] - velocities[a], dir);
            float kineticBefore = 0.5f * M * relativeSpeed * relativeSpeed;

            float relativeSpeedAfter = Vector3.Dot((velocities[b] + totalForce / M * Time.fixedDeltaTime) - (velocities[a] - totalForce / M * Time.fixedDeltaTime), dir);
            float kineticAfter = 0.5f * M * relativeSpeedAfter * relativeSpeedAfter;

            float energyLost = kineticBefore - kineticAfter;
            //Debug.Log(energyLost);
            if (energyLost > PlasticThreshold)
            {
                rest[i] = Mathf.Lerp(rest[i], dist, 0.1f);
            }
        }

        //===Air Force=== 
        for (int i = 0; i < vertices.Length; i++)
        {
            forces[i] += -γ * velocities[i] * velocities[i].magnitude;
        }

        // === GROUND FRICTION FORCE ===
        Vector3 groundNormal = Vector3.up; 

        for (int i = 0; i < vertices.Length; i++)
        {
            Vector3 worldV = transform.TransformPoint(vertices[i]);

            if (worldV.y <= 0.01f) 
            {
                Vector3 horizontalVel = velocities[i];
                horizontalVel.y = 0; 

                if (horizontalVel.magnitude > 0.001f)
                {
                    Vector3 frictionDir = -horizontalVel.normalized;
                    float normalForce = M * 9.81f;
                    float frictionMag = self.FrictionCoefficient * normalForce;
                    Vector3 friction = frictionMag * frictionDir;

                    // قيد: لا تتجاوز القوة قيمة السرعة الحالية حتى لا تعكس الاتجاه
                    if (friction.magnitude > horizontalVel.magnitude * M / Time.fixedDeltaTime)
                    {
                        friction = horizontalVel * -M / Time.fixedDeltaTime;
                    }

                    forces[i] += friction;
                }
            }
        }





        // === INTEGRATION ===
        for (int i = 0; i < vertices.Length; i++)
        {
            Vector3 acc = forces[i] / M;
            velocities[i] += acc * Time.fixedDeltaTime;
            //velocities[i] *= 0.98f;
            vertices[i] += velocities[i] * Time.fixedDeltaTime;

            Vector3 worldV = transform.TransformPoint(vertices[i]);
            if (worldV.y < 0)
            {
                worldV.y = 0;
                vertices[i] = transform.InverseTransformPoint(worldV);
                velocities[i].y = 0;
            }
        }

        // === CORRECTION ===
        //for (int iter = 0; iter < 5; iter++)
        //{
        //    for (int i = 0; i < springs.GetLength(0); i++)
        //    {
        //        int a = springs[i, 0];
        //        int b = springs[i, 1];
        //        Vector3 delta = vertices[b] - vertices[a];
        //        float error = delta.magnitude - rest[i];
        //        Vector3 correction = 0.5f * error * delta.normalized * StiffnessFactor;

        //        vertices[a] += correction;
        //        vertices[b] -= correction;
        //    }
        //}

        s.vertices = vertices;
        s.velocities = velocities;
        s.forces = forces;
        //s.restLengths = rest;
    }

    public static bool AABBOverlap((Vector3 min, Vector3 max) a, (Vector3 min, Vector3 max) b)
    {
        return (a.min.x <= b.max.x && a.max.x >= b.min.x) &&
               (a.min.y <= b.max.y && a.max.y >= b.min.y) &&
               (a.min.z <= b.max.z && a.max.z >= b.min.z);
    }
}
