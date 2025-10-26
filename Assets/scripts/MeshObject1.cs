using UnityEngine;
//using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class MeshObject1 : MonoBehaviour
{
    public enum MaterialType { Metal,liteMetal, Wood, Jelly ,Rubber}
    public MaterialType materialType;


    public void SetInitialVelocity(Vector3 velocity)
    {
            startV = velocity;
    }

    public void SetDefaults()
    {
        switch (materialType)
        {
            case MaterialType.Metal:
                K_Value = 25000f;                
                M_Value = 100f;               
                Damping_Value = 50f;         
                StiffnessFactor_Value = 1f;    
                PlasticThreshold_Value = 0.2f; 
                DragCoefficient = 0.2f;        
                FrictionCoefficient = 0.6f;    
                γ = 1.5f;                       
                break;
            case MaterialType.liteMetal:
                K_Value = 1250;                
                M_Value = 5;               
                Damping_Value = 2.5f;         
                StiffnessFactor_Value = 1f;    
                PlasticThreshold_Value = 0.2f; 
                DragCoefficient = 0.2f;        
                FrictionCoefficient = 0.6f;    
                γ = 1.5f;                       
                break;

            case MaterialType.Wood:
                K_Value = 2500f;
                M_Value = 10f;
                Damping_Value = 5f;
                StiffnessFactor_Value = 0.5f;
                PlasticThreshold_Value = 0.5f;
                DragCoefficient = 0.5f;
                FrictionCoefficient = 0.5f;
                break;

            case MaterialType.Jelly:
                K_Value = 100f;
                M_Value = .4f;
                Damping_Value = .2f;
                StiffnessFactor_Value = 0.01f;
                PlasticThreshold_Value = 1.35f;
                DragCoefficient = 0.5f;
                FrictionCoefficient = 0.5f;
                break;

            case MaterialType.Rubber:
                K_Value = 20f;
                M_Value = .08f;
                Damping_Value = .04f;
                StiffnessFactor_Value = 0.01f;
                PlasticThreshold_Value = 1.35f;
                DragCoefficient = 0.5f;
                FrictionCoefficient = 0.5f;
                γ = 2;
                break;
        }
    }

    [Header("Material Parameters")]
    [Range(0, 100000)] public float K_Value;
    [Range(0.1f, 200f)] public float M_Value;
    [Range(0, 1000f)] public float Damping_Value;
    [Range(0f, 1f)] public float StiffnessFactor_Value;
    [Range(0f, 100f)] public float PlasticThreshold_Value;

    [Header("Forces")]
    [Range(0, 25f)] public float DragCoefficient;
    [Range(0, 2f)] public float FrictionCoefficient;
    [Range(0, 5)] public float γ;
    [HideInInspector] public bool isSimulating = true;
    //public enum ShapeType { Cube, Prism, Cylinder, Conical }

    public bool isGround = false;
    public bool Fixed = false;
    public ShapeVoxelizer voxelizer; // Assign in Inspector
    public ShapeVoxelizer2 voxelizer2; // Assign in Inspector
    public GameObject[] points;

    public SimulationState state;
    public MeshType material;
    public Vector3 startV = Vector3.zero;
    public Mesh mesh;
    private int[,] springConnections;
    private float[] rest;
    private Vector3[] voxelVerts;
    private int[] triangles;

    public CollisionDet col;
    MeshObject1[] allShapes;
    Vector3[] velocities;
    //#if UNITY_EDITOR
    //void OnValidate()
    //{
    //    SetDefaults();
    //}
    //#endif
    void Start()
    {
        SetDefaults();
        switch (materialType)
        {
            case MaterialType.Metal:
                material = new MetalShape();
                break;
            case MaterialType.liteMetal:
                material = new MetalShape();
                break;
            case MaterialType.Wood:
                material = new WoodShape();
                break;
            case MaterialType.Jelly:
                material = new JellyShape();
                break;
            case MaterialType.Rubber:
                material = new RubberShape();
                break;
        }
        material.ApplySettings(this);
        if (voxelizer != null)
        { 
            (var verts, var springs, var restLengths, var tris) = voxelizer.genrate();
        voxelVerts = (Vector3[])verts.Clone();
        springConnections = (int[,])springs.Clone();
        rest = (float[])restLengths.Clone();
        triangles = tris;
        velocities = new Vector3[verts.Length];
        for (int i = 0; i < verts.Length; i++) {
            velocities[i] = startV;
        }
        }
        else
        {
            (var verts, var springs, var restLengths, var tris) = voxelizer2.genrate();
            voxelVerts = (Vector3[])verts.Clone();
            springConnections = (int[,])springs.Clone();
            rest = (float[])restLengths.Clone();
            triangles = tris;
            velocities = new Vector3[verts.Length];
            for (int i = 0; i < verts.Length; i++)
            {
                velocities[i] = startV;
            }
        }
        state = new SimulationState
            {
                vertices = (Vector3[])voxelVerts.Clone(),
                velocities = velocities,
                forces = new Vector3[voxelVerts.Length],
                springs = springConnections,
                restLengths = (float[])rest.Clone(),
                previousPositions = (Vector3[])voxelVerts.Clone(),
            };

        mesh = new Mesh();
        mesh.vertices = state.vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;

        //points = new GameObject[state.vertices.Length];
        //for (int i = 0; i < state.vertices.Length; i++)
        //{
        //    //Debug.Log("Vertex: " + transform.TransformPoint(state.vertices[i]));
        //    points[i] = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        //    points[i].transform.position = transform.TransformPoint(state.vertices[i]);
        //    points[i].transform.localScale = Vector3.one * 0.08f;
        //    points[i].transform.parent = transform;
        //}

        col = new CollisionDet
        {
            depth = -1f,
            normal = Vector3.zero,
            velocities = state.velocities,
        };

        isSimulating = true;
    }

    void FixedUpdate()
    {
        allShapes = FindObjectsOfType<MeshObject1>();

        if (isSimulating == false)
            return;
        //Debug.LogWarning($"{isSimulating}");
        //if (voxelizer == null || voxelizer.vertices == null || voxelizer.vertices.Length == 0)
        //    return;
        material.ApplySettings(this);

        //for (int i = 0; i < points.Length; i++)
        //{
        //    state.vertices[i] = transform.InverseTransformPoint(points[i].transform.position);
        //}
        //for (int i = 0; i < 3; i++) 
        if (!Fixed)
            material.SimulatePhysics(state, transform, this, allShapes);

        if (isGround)
        {
            for (int i = 0; i < state.vertices.Length; i++)
            {
                state.vertices[i].y = 0f;
                state.velocities[i] = Vector3.zero;
            }
        }
        mesh.vertices = state.vertices;
        mesh.RecalculateNormals();
        //for (int i = 0; i < points.Length; i++)
        //{
        //    points[i].transform.position = transform.TransformPoint(state.vertices[i]);
        //}

    }

    public (Vector3 min, Vector3 max) GetAABB1()
    {
        Vector3 min = transform.TransformPoint(voxelizer.vertices[0]);
        Vector3 max = transform.TransformPoint(voxelizer.vertices[0]);

        foreach (Vector3 v in voxelizer.vertices)
        {
            Vector3 worldV = transform.TransformPoint(v);
            min = Vector3.Min(min, worldV);
            max = Vector3.Max(max, worldV);
        }

        return (min, max);
    }

    public Vector3 GetVelocityAtPoint(Vector3 worldPoint)
    {
        int index = FindClosestVertexIndex(worldPoint);
        return state.velocities[index];
    }

    public int FindClosestVertexIndex(Vector3 worldPoint)
    {
        float minDist = float.MaxValue;
        int closest = 0;

        for (int i = 0; i < state.vertices.Length; i++)
        {
            Vector3 wp = transform.TransformPoint(state.vertices[i]);
            float dist = Vector3.SqrMagnitude(wp - worldPoint);

            if (dist < minDist)
            {
                minDist = dist;
                closest = i;
            }
        }

        return closest;
    }





}