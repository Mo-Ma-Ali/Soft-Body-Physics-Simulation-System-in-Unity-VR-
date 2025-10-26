using System.Linq;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    private MeshObject1[] Shapes;

    void Start()
    {
        Shapes = FindObjectsOfType<MeshObject1>();
    }

    void FixedUpdate()
    {
        for (int i = 0; i < Shapes.Length; i++)
        {
            for (int j = i + 1; j < Shapes.Length; j++)
            {
                var A = Shapes[i];
                var B = Shapes[j];

                if (!AABB(A, B)) continue;

                Vector3[] worldA = A.voxelizer.vertices.Select(v => A.transform.TransformPoint(v)).ToArray();
                Vector3[] worldB = B.voxelizer.vertices.Select(v => B.transform.TransformPoint(v)).ToArray();

                GJK gjk = new GJK(worldA, worldB);
                if (!gjk.Intersect()) continue;

                EPA epa = new EPA((dir) => gjk.Support(dir));
                epa.Initialize(gjk.simplex);
                (Vector3 normal, float depth, Vector3 contactPoint) = epa.ComputePenetration();

                if (depth > 0.0f)
                {
                    ApplyImpulseAndCorrection(A, B, normal, depth, contactPoint);
                    Debug.Log($"? Collision resolved: {A.name} vs {B.name} the depth and normal are : {depth} and {normal} and point {contactPoint}");
                    A.mesh.vertices = A.state.vertices;
                    B.mesh.vertices = B.state.vertices;
                }
            }
        }

        ClampToGround();
    }

    void ApplyImpulseAndCorrection(MeshObject1 A, MeshObject1 B, Vector3 normal, float depth, Vector3 contactPoint)
    {
        float totalMass = A.material.M + B.material.M;
        float ratioA = A.material.M / totalMass;
        float ratioB = B.material.M / totalMass;

        ApplyToObject(A, contactPoint, normal, depth, false);
        ApplyToObject(B, contactPoint, normal, depth, true);
    }

    void ApplyToObject(MeshObject1 obj, Vector3 contactPoint, Vector3 normal, float depth, bool flip)
    {
        Vector3 worldNormal = flip ? -normal : normal;

        for (int i = 0; i < obj.state.vertices.Length; i++)
        {
            Vector3 worldV = obj.transform.TransformPoint(obj.state.vertices[i]);
            Vector3 toPoint = worldV - contactPoint;
            float projection = Vector3.Dot(toPoint, worldNormal);

            // If inside the penetration region
            if (projection < 0.01f)
            {
                // PUSH OUT
                Vector3 correctedWorld = worldV + worldNormal * (depth);
                obj.state.vertices[i] = obj.transform.InverseTransformPoint(correctedWorld);

                // STOP VELOCITY IN COLLISION DIRECTION
                Vector3 v = obj.state.velocities[i];
                obj.state.velocities[i] = v - Vector3.Project(v, worldNormal);
            }
        }
    }

    void ClampToGround()
    {
        foreach (var shape in Shapes)
        {
            for (int i = 0; i < shape.state.vertices.Length; i++)
            {
                Vector3 worldV = shape.transform.TransformPoint(shape.state.vertices[i]);

                if (worldV.y < 0f)
                {
                    worldV.y = 0f;
                    shape.state.vertices[i] = shape.transform.InverseTransformPoint(worldV);
                    shape.state.velocities[i].y = 0f;
                }

                if (shape.isGround)
                    shape.state.vertices[i].y = 0f;
            }
        }
    }

    bool AABB(MeshObject1 a, MeshObject1 b)
    {
        (Vector3 minA, Vector3 maxA) = a.GetAABB1();
        (Vector3 minB, Vector3 maxB) = b.GetAABB1();

        return (minA.x <= maxB.x && maxA.x >= minB.x) &&
               (minA.y <= maxB.y && maxA.y >= minB.y) &&
               (minA.z <= maxB.z && maxA.z >= minB.z);
    }
}
