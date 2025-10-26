using System.Collections.Generic;
using UnityEngine;

public class GJK
{
    Vector3[] shape1, shape2;
    Vector3 direction;

    // Simplex: ????? ??????? ?? ???? ????????? + ?????? ??????? ?? ?? ???
    public List<(Vector3 point, Vector3 supportA, Vector3 supportB)> simplex = new();

    public GJK(Vector3[] shape1, Vector3[] shape2)
    {
        this.shape1 = shape1;
        this.shape2 = shape2;

        // ?? ???? ?? ??????? ????????: ???? ?????? ??? ????????
        Vector3 center1 = ComputeCenter(shape1);
        Vector3 center2 = ComputeCenter(shape2);
        direction = center1 - center2;

        if (direction == Vector3.zero)
            direction = Vector3.right; // ???????
    }

    // ???? ?????: ???? ?? ???? ???? ??? ??? ??????? ?? ???????
    public (Vector3, Vector3) Support(Vector3 dir)
    {
        Vector3 supportA = FarthestPoint(dir, shape1);
        Vector3 supportB = FarthestPoint(-dir, shape2);
        return (supportA, supportB);
    }

    // ????? ???????? GJK
    public bool Intersect()
    {
        simplex.Clear();

        var (supportA, supportB) = Support(direction);
        Vector3 p = supportA - supportB;
        simplex.Add((p, supportA, supportB));

        direction = -p;

        const int maxIterations = 100;
        for (int i = 0; i < maxIterations; i++)
        {
            (supportA, supportB) = Support(direction);
            p = supportA - supportB;

            // ?? ??? ?? ????? ??? ????? ???? ???? ?? ???? ?????
            if (Vector3.Dot(p, direction) < 1e-6f)
                return false;

            simplex.Add((p, supportA, supportB));

            if (HandleSimplex(ref direction))
                return true;
        }

        return false;
    }

    // ???? ???? ?????? ???????
    private Vector3 ComputeCenter(Vector3[] shape)
    {
        Vector3 sum = Vector3.zero;
        foreach (var v in shape)
            sum += v;

        return sum / shape.Length;
    }

    // ??????? ?? ??? simplex ??????? ??????? ??????
    bool HandleSimplex(ref Vector3 direction)
    {
        if (simplex.Count == 2)
        {
            var A = simplex[1].point;
            var B = simplex[0].point;

            Vector3 AB = B - A;
            Vector3 AO = -A;

            direction = Vector3.Cross(Vector3.Cross(AB, AO), AB);
        }
        else if (simplex.Count == 3)
        {
            var A = simplex[2].point;
            var B = simplex[1].point;
            var C = simplex[0].point;

            Vector3 AB = B - A;
            Vector3 AC = C - A;
            Vector3 AO = -A;

            Vector3 ABC = Vector3.Cross(AB, AC);

            // ???? ?? ?? ??? ?????
            Vector3 ABPerp = Vector3.Cross(Vector3.Cross(AC, AB), AB);
            if (Vector3.Dot(ABPerp, AO) > 0)
            {
                simplex.RemoveAt(0); // ???? C
                direction = ABPerp;
                return false;
            }

            Vector3 ACPerp = Vector3.Cross(Vector3.Cross(AB, AC), AC);
            if (Vector3.Dot(ACPerp, AO) > 0)
            {
                simplex.RemoveAt(1); // ???? B
                direction = ACPerp;
                return false;
            }

            // ???? ????
            direction = ABC;
        }
        else if (simplex.Count == 4)
        {
            var A = simplex[3].point;
            var B = simplex[2].point;
            var C = simplex[1].point;
            var D = simplex[0].point;

            Vector3 AO = -A;
            Vector3 AB = B - A;
            Vector3 AC = C - A;
            Vector3 AD = D - A;

            Vector3 ABC = Vector3.Cross(AB, AC);
            Vector3 ACD = Vector3.Cross(AC, AD);
            Vector3 ADB = Vector3.Cross(AD, AB);

            if (Vector3.Dot(ABC, AO) > 0)
            {
                simplex.RemoveAt(0); // ???? D
                direction = ABC;
                return false;
            }

            if (Vector3.Dot(ACD, AO) > 0)
            {
                simplex.RemoveAt(2); // ???? B
                direction = ACD;
                return false;
            }

            if (Vector3.Dot(ADB, AO) > 0)
            {
                simplex.RemoveAt(1); // ???? C
                direction = ADB;
                return false;
            }

            return true; // ?????!
        }

        return false;
    }

    // ????? ???? ???? ?? ????? ????
    private Vector3 FarthestPoint(Vector3 dir, Vector3[] vertices)
    {
        dir.Normalize();
        float maxDot = float.MinValue;
        Vector3 best = vertices[0];

        foreach (var v in vertices)
        {
            float dot = Vector3.Dot(v, dir);
            if (dot > maxDot)
            {
                maxDot = dot;
                best = v;
            }
        }
        ////
        return best;
    }
}
