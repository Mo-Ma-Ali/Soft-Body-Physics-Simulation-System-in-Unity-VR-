using System.Collections.Generic;
using UnityEngine;

public class ShapeVoxelizer2 : MonoBehaviour
{
    [Header("Input Mesh")]
    public MeshFilter meshFilter;

    [Header("Voxel Settings")]
    public float maxEdgeLength = 0.3f; // ?? Control this to manage vertex density
    [Header("Simplification Settings")]
    public float vertexMergeThreshold = 0.05f; // ?? Lower = more accurate, Higher = fewer vertices


    [Header("Generated Data (Read-Only)")]
    public Vector3[] vertices;
    public int[,] springConnections;
    public float[] restLengths;
    public int[] triangles;

    private void Start()
    {
        if (meshFilter == null || meshFilter.sharedMesh == null)
        {
            Debug.LogError("MeshFilter or mesh not assigned.");
            return;
        }

        GenerateAdaptiveMesh();
    }

    void GenerateAdaptiveMesh()
    {
        Mesh mesh = meshFilter.sharedMesh;
        Vector3[] meshVertices = mesh.vertices;
        int[] meshTriangles = mesh.triangles;

        this.triangles = meshTriangles; // Needed for AutoSetParameters
        //AutoSetParameters(meshVertices); // ?? Auto tune based on mesh scale

        List<Vector3> newVerts = new List<Vector3>();
        List<int> newTris = new List<int>();
        Dictionary<Vector3, int> vertIndexMap = new Dictionary<Vector3, int>();

        for (int i = 0; i < meshTriangles.Length; i += 3)
        {
            Vector3 v0 = meshFilter.transform.TransformPoint(meshVertices[meshTriangles[i]]);
            Vector3 v1 = meshFilter.transform.TransformPoint(meshVertices[meshTriangles[i + 1]]);
            Vector3 v2 = meshFilter.transform.TransformPoint(meshVertices[meshTriangles[i + 2]]);

            SubdivideTriangle(v0, v1, v2, newVerts, newTris, vertIndexMap);
        }

        for (int i = 0; i < newVerts.Count; i++)
        {
            newVerts[i] = meshFilter.transform.InverseTransformPoint(newVerts[i]);
        }

        SimplifyVertices(ref newVerts, ref newTris); // ?? Apply simplification
        vertices = newVerts.ToArray();
        triangles = newTris.ToArray();
        Vector3 center = Vector3.zero;
        //foreach (var v in vertices)
        //{
        //    center += v;
        //}
        //center /= vertices.Length;

        // Convert list to modifiable list and add center point
        //List<Vector3> extendedVerts = new List<Vector3>(vertices);
        //int centerIndex = extendedVerts.Count;
        //extendedVerts.Add(center);
        //vertices = extendedVerts.ToArray();

        GenerateSprings();

        //Debug.Log($"[AutoConfig] maxEdgeLength = {maxEdgeLength:F3}, vertexMergeThreshold = {vertexMergeThreshold:F3}");
        //Debug.Log($"Generated {vertices.Length} vertices and {springConnections.GetLength(0)} springs.");

        ReconstructMeshWithEnhancedVertices();
    }


    void SubdivideTriangle(
        Vector3 v0, Vector3 v1, Vector3 v2,
        List<Vector3> verts, List<int> tris,
        Dictionary<Vector3, int> vertIndexMap)
    {
        Queue<(Vector3, Vector3, Vector3)> triQueue = new Queue<(Vector3, Vector3, Vector3)>();
        triQueue.Enqueue((v0, v1, v2));

        while (triQueue.Count > 0)
        {
            var (a, b, c) = triQueue.Dequeue();

            float ab = Vector3.Distance(a, b);
            float bc = Vector3.Distance(b, c);
            float ca = Vector3.Distance(c, a);

            if (ab > maxEdgeLength || bc > maxEdgeLength || ca > maxEdgeLength)
            {
                if (ab >= bc && ab >= ca)
                {
                    Vector3 m = (a + b) * 0.5f;
                    triQueue.Enqueue((a, m, c));
                    triQueue.Enqueue((m, b, c));
                }
                else if (bc >= ab && bc >= ca)
                {
                    Vector3 m = (b + c) * 0.5f;
                    triQueue.Enqueue((a, b, m));
                    triQueue.Enqueue((a, m, c));
                }
                else
                {
                    Vector3 m = (c + a) * 0.5f;
                    triQueue.Enqueue((a, b, m));
                    triQueue.Enqueue((m, b, c));
                }
            }
            else
            {
                int ia = GetVertexIndex(a, verts, vertIndexMap);
                int ib = GetVertexIndex(b, verts, vertIndexMap);
                int ic = GetVertexIndex(c, verts, vertIndexMap);

                tris.Add(ia);
                tris.Add(ib);
                tris.Add(ic);
            }
        }
    }

    int GetVertexIndex(Vector3 v, List<Vector3> verts, Dictionary<Vector3, int> map)
    {
        if (map.TryGetValue(v, out int index))
            return index;

        index = verts.Count;
        verts.Add(v);
        map[v] = index;
        return index;
    }

    void GenerateSprings()
    {
        List<(int, int)> springList = new List<(int, int)>();
        float maxDistance = maxEdgeLength *1.2f;
        int vertexCount = vertices.Length ; // Exclude center for pairwise springs
        if(vertexCount<10)
        {
            for (int i = 0; i < vertexCount; i++)
            {
                for (int j = i + 1; j < vertexCount; j++)
                {
                    
                        springList.Add((i, j));
                    
                }
            }
        }
        else
        {
            for (int i = 0; i < vertexCount; i++)
            {
                for (int j = i + 1; j < vertexCount; j++)
                {
                    float dist = Vector3.Distance(vertices[i], vertices[j]);
                    if (dist <= maxDistance)
                    {
                        springList.Add((i, j));
                    }
                }
            }
        }
        // Add springs from center point to all others
//for (int i = 0; i < vertexCount; i++)
//{
//    springList.Add((i, vertexCount)); // center is at the last index
//}

        springConnections = new int[springList.Count, 2];
        for (int k = 0; k < springList.Count; k++)
        {
            springConnections[k, 0] = springList[k].Item1;
            springConnections[k, 1] = springList[k].Item2;
        }

        CalculateRestLengths();
    }

    void CalculateRestLengths()
    {
        int springCount = springConnections.GetLength(0);
        restLengths = new float[springCount];

        for (int i = 0; i < springCount; i++)
        {
            int a = springConnections[i, 0];
            int b = springConnections[i, 1];
            restLengths[i] = (vertices[a] - vertices[b]).magnitude;
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (vertices == null) return;

        Gizmos.color = Color.cyan;
        foreach (var point in vertices)
        {
            Gizmos.DrawSphere(transform.TransformPoint(point), 0.02f); // ?? Convert back to world for visualization
        }
    }

    public (Vector3[] vs, int[,] sp, float[] r, int[] t) genrate()
    {
        return (vertices, springConnections, restLengths, triangles);
    }
    void SimplifyVertices(ref List<Vector3> verts, ref List<int> tris)
    {
        List<Vector3> simplifiedVerts = new List<Vector3>();
        Dictionary<int, int> oldToNewIndex = new Dictionary<int, int>();
        //if (verts.Count > 200)
        //    vertexMergeThreshold /= 3f;
        for (int i = 0; i < verts.Count; i++)
        {
            Vector3 current = verts[i];
            bool merged = false;

            for (int j = 0; j < simplifiedVerts.Count; j++)
            {
                if (Vector3.Distance(current, simplifiedVerts[j]) < vertexMergeThreshold)
                {
                    oldToNewIndex[i] = j;
                    merged = true;
                    break;
                }
            }

            if (!merged)
            {
                int newIndex = simplifiedVerts.Count;
                simplifiedVerts.Add(current);
                oldToNewIndex[i] = newIndex;
            }
        }

        // Re-map triangle indices
        for (int i = 0; i < tris.Count; i++)
        {
            tris[i] = oldToNewIndex[tris[i]];
        }

        verts = simplifiedVerts;
    }


void ReconstructMeshWithEnhancedVertices()
{
    Mesh original = meshFilter.sharedMesh;
    Mesh enhancedMesh = new Mesh();

    enhancedMesh.vertices = vertices;
    enhancedMesh.triangles = triangles;

    // ???? ??????? UVs ??????? ?? ????
    if (original.uv.Length == vertices.Length)
        enhancedMesh.uv = original.uv;

    // ????? ???? ??? Normals ? Tangents
    enhancedMesh.RecalculateNormals();
    enhancedMesh.RecalculateTangents();
    enhancedMesh.RecalculateBounds();

    meshFilter.sharedMesh = enhancedMesh;
}

}
