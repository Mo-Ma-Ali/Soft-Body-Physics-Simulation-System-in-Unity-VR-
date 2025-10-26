using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class WoodShape : MeshType
{
    public float K_Value;
    public float M_Value;
    public float Damping_Value;
    public float StiffnessFactor_Value;
    public float PlasticThreshold_Value;
    public float γ;

    private HashSet<int> brokenSprings = new();

    public override float K => K_Value;
    public override float M => M_Value;
    public override float Damping => Damping_Value;
    public override float StiffnessFactor => StiffnessFactor_Value;
    public override float PlasticThreshold => PlasticThreshold_Value;

    public override void ApplySettings(MeshObject1 obj)
    {
        K_Value = obj.K_Value;
        M_Value = obj.M_Value;
        Damping_Value = obj.Damping_Value;
        StiffnessFactor_Value = obj.StiffnessFactor_Value;
        PlasticThreshold_Value = obj.PlasticThreshold_Value;
        γ = obj.γ;
    }
    Vector3[] newVertces;

    public override void SimulatePhysics(SimulationState s, Transform transform, MeshObject1 self, MeshObject1[] allObjects)
    {
        var vertices = s.vertices;
        var velocities = s.velocities;
        var forces = s.forces;
        var springs = s.springs;
        var rest = s.restLengths;

        Vector3 gravity = transform.InverseTransformDirection(Vector3.down * 9.81f);

        // === Reset forces and apply gravity ===
        for (int i = 0; i < vertices.Length; i++)
        {
            if (brokenSprings.Contains(i)) continue;
            forces[i] = M * gravity;
        }

        // === Brittle Spring Force ===
        for (int i = 0; i < springs.GetLength(0); i++)
        {
            if (brokenSprings.Contains(i)) continue;

            int a = springs[i, 0];
            int b = springs[i, 1];

            Vector3 delta = vertices[b] - vertices[a];
            float dist = delta.magnitude;
            Vector3 dir = delta.normalized;
            float x = dist - rest[i];

            if (Mathf.Abs(x) > PlasticThreshold)
            {
                brokenSprings.Add(i);
                continue;
            }

            Vector3 springForce = K * x * dir;
            Vector3 damping = Damping * Vector3.Dot(velocities[b] - velocities[a], dir) * dir;
            Vector3 totalForce = springForce + damping;

            forces[a] += totalForce;
            forces[b] -= totalForce;
        }

        // === Air Resistance ===
        for (int i = 0; i < vertices.Length; i++)
        {
            if (brokenSprings.Contains(i)) continue;

            forces[i] += -γ * velocities[i] * velocities[i].magnitude;
        }

        // === Ground Friction ===
        for (int i = 0; i < vertices.Length; i++)
        {
            if (brokenSprings.Contains(i)) continue;

            Vector3 worldV = transform.TransformPoint(vertices[i]);
            if (worldV.y <= 0.01f)
            {
                Vector3 horizontalVel = velocities[i];
                horizontalVel.y = 0;

                if (horizontalVel.magnitude > 0.001f)
                {
                    Vector3 frictionDir = -horizontalVel.normalized;
                    float frictionMag = self.FrictionCoefficient * M * 9.81f;
                    Vector3 friction = frictionMag * frictionDir;

                    if (friction.magnitude > horizontalVel.magnitude * M / Time.fixedDeltaTime)
                        friction = horizontalVel * -M / Time.fixedDeltaTime;

                    forces[i] += friction;
                }
            }
        }

        // === Integration ===
        for (int i = 0; i < vertices.Length; i++)
        {
            if (brokenSprings.Contains(i))
            {
                //vertices[i]=Vector3.zero;
                continue;
            }

            Vector3 acc = forces[i] / M;
            velocities[i] += acc * Time.fixedDeltaTime;
            vertices[i] += velocities[i] * Time.fixedDeltaTime;

            Vector3 worldV = transform.TransformPoint(vertices[i]);
            if (worldV.y < 0)
            {
                worldV.y = 0;
                vertices[i] = transform.InverseTransformPoint(worldV);
                velocities[i].y = 0;
            }
        }
        if (brokenSprings.Count > 0)
        {
            RemoveBrokenSprings(ref springs, ref rest, brokenSprings);
            //SplitDisconnectedParts(s, self);
            brokenSprings.Clear(); // أعد التهيئة
        }

        s.vertices = vertices;
        s.velocities = velocities;
        s.forces = forces;
    }

    private void RemoveBrokenSprings(ref int[,] springs, ref float[] rest, HashSet<int> broken)
    {
        List<int[]> newSprings = new();
        List<float> newRest = new();

        for (int i = 0; i < springs.GetLength(0); i++)
        {
            if (broken.Contains(i)) continue;

            newSprings.Add(new int[] { springs[i, 0], springs[i, 1] });
            newRest.Add(rest[i]);
        }

        springs = new int[newSprings.Count, 2];
        for (int i = 0; i < newSprings.Count; i++)
        {
            springs[i, 0] = newSprings[i][0];
            springs[i, 1] = newSprings[i][1];
        }

        rest = newRest.ToArray();
    }

}
