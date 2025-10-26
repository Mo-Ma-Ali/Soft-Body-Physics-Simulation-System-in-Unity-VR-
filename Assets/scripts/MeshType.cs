using UnityEngine;
using static UnityEngine.Rendering.DebugUI;


public class SimulationState
{
    public Vector3[] vertices;
    public Vector3[] velocities;
    public Vector3[] forces;
    public int[,] springs;
    public float[] restLengths;
    public Vector3[] previousPositions;

}
public class CollisionDet
{
    public float depth;
    public Vector3 normal;
    public Vector3 point;
    public Vector3[] velocities;
}
public abstract class MeshType
{
    public abstract float K { get; } 
    public abstract float M { get; } 
    public abstract float Damping { get; }
    public abstract float StiffnessFactor { get; } 
    public abstract float PlasticThreshold { get; } 

    public virtual CollisionDet Collision(CollisionDet col, SimulationState s)
    {
        return col;
    }
    public virtual void SimulatePhysics(SimulationState state,Transform transform, MeshObject1 self, MeshObject1[] allObjects)
    { }

    public virtual void ApplySettings(MeshObject1 obj)
    {
    }
}
