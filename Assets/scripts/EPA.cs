using System;
using System.Collections.Generic;
using UnityEngine;

public class EPA
{
    class Face
    {
        public Vector3 A, B, C;
        public Vector3 Normal;
        public float Distance;
        public (Vector3 a, Vector3 b, Vector3 c) SupA, SupB;

        public Face(Vector3 a, Vector3 b, Vector3 c,
                    Vector3 sa, Vector3 sb, Vector3 sc,
                    Vector3 ma, Vector3 mb, Vector3 mc)
        {
            A = a; B = b; C = c;
            SupA = (sa, sb, sc);
            SupB = (ma, mb, mc);

            Normal = Vector3.Normalize(Vector3.Cross(B - A, C - A));
            Distance = Vector3.Dot(Normal, A);
        }

        public bool IsFacing(Vector3 point)
        {
            return Vector3.Dot(Normal, point - A) > 1e-6f;
        }

        public Vector3 GetContactPoint()
        {
            Vector3 p = ClosestPointOnTriangle(Vector3.zero, A, B, C);
            Vector3 bary = GetBarycentric(p, A, B, C);

            Vector3 sa = SupA.a * bary.x + SupA.b * bary.y + SupA.c * bary.z;
            Vector3 sb = SupB.a * bary.x + SupB.b * bary.y + SupB.c * bary.z;
            return (sa + sb) * 0.5f;
        }

        private Vector3 ClosestPointOnTriangle(Vector3 p, Vector3 a, Vector3 b, Vector3 c)
        {
            Vector3 ab = b - a, ac = c - a, ap = p - a;
            float d1 = Vector3.Dot(ab, ap), d2 = Vector3.Dot(ac, ap);
            if (d1 <= 0f && d2 <= 0f) return a;

            Vector3 bp = p - b;
            float d3 = Vector3.Dot(ab, bp), d4 = Vector3.Dot(ac, bp);
            if (d3 >= 0f && d4 <= d3) return b;

            float vc = d1 * d4 - d3 * d2;
            if (vc <= 0f && d1 >= 0f && d3 <= 0f)
                return a + ab * (d1 / (d1 - d3));

            Vector3 cp = p - c;
            float d5 = Vector3.Dot(ab, cp), d6 = Vector3.Dot(ac, cp);
            if (d6 >= 0f && d5 <= d6) return c;

            float vb = d5 * d2 - d1 * d6;
            if (vb <= 0f && d2 >= 0f && d6 <= 0f)
                return a + ac * (d2 / (d2 - d6));

            float va = d3 * d6 - d5 * d4;
            if (va <= 0f && (d4 - d3) >= 0f && (d5 - d6) >= 0f)
                return b + (c - b) * ((d4 - d3) / ((d4 - d3) + (d5 - d6)));

            float denom = 1f / (va + vb + vc);
            return a + ab * (vb * denom) + ac * (vc * denom);
        }

        private Vector3 GetBarycentric(Vector3 p, Vector3 a, Vector3 b, Vector3 c)
        {
            Vector3 v0 = b - a, v1 = c - a, v2 = p - a;
            float d00 = Vector3.Dot(v0, v0);
            float d01 = Vector3.Dot(v0, v1);
            float d11 = Vector3.Dot(v1, v1);
            float d20 = Vector3.Dot(v2, v0);
            float d21 = Vector3.Dot(v2, v1);
            float denom = d00 * d11 - d01 * d01;

            float v = (d11 * d20 - d01 * d21) / denom;
            float w = (d00 * d21 - d01 * d20) / denom;
            float u = 1f - v - w;

            return new Vector3(u, v, w);
        }
    }

    private List<Face> faces = new();
    private Func<Vector3, (Vector3, Vector3)> support;

    public EPA(Func<Vector3, (Vector3, Vector3)> support)
    {
        this.support = support;
    }

    public void Initialize(List<(Vector3 mink, Vector3 sa, Vector3 sb)> simplex)
    {
        faces.Clear();

        var a = simplex[0];
        var b = simplex[1];
        var c = simplex[2];
        var d = simplex[3];

        AddFace(a, b, c);
        AddFace(a, c, d);
        AddFace(a, d, b);
        AddFace(b, d, c);
    }

    private void AddFace((Vector3, Vector3, Vector3) a, (Vector3, Vector3, Vector3) b, (Vector3, Vector3, Vector3) c)
    {
        var face = new Face(a.Item1, b.Item1, c.Item1, a.Item2, b.Item2, c.Item2, a.Item3, b.Item3, c.Item3);
        if (Vector3.Dot(face.Normal, face.A) < 0)
        {
            face = new Face(a.Item1, c.Item1, b.Item1, a.Item2, c.Item2, b.Item2, a.Item3, c.Item3, b.Item3);
        }
        faces.Add(face);
    }

    public (Vector3 normal, float depth, Vector3 contactPoint) ComputePenetration()
    {
        const int maxIter = 200;

        for (int i = 0; i < maxIter; i++)
        {
            var closest = FindClosestFace();
            if (closest == null) break;

            var dir = closest.Normal;
            var (sa, sb) = support(dir);
            Vector3 p = sa - sb;

            if (float.IsNaN(Vector3.Dot(p, dir)) || float.IsNaN(closest.Distance))
                break;

            float d = Vector3.Dot(p, dir);
            if (Mathf.Abs(d - closest.Distance) < 1e-4f || Vector3.Distance(p, Vector3.zero) > 1e3f)
            {
                return (closest.Normal, d, closest.GetContactPoint());
            }

            bool alreadyExists = faces.Exists(f =>
                Vector3.Distance(f.A, p) < 1e-6f ||
                Vector3.Distance(f.B, p) < 1e-6f ||
                Vector3.Distance(f.C, p) < 1e-6f
            );

            if (alreadyExists)
                return (closest.Normal, d, closest.GetContactPoint());

            Expand(p, sa, sb);
        }

        return (Vector3.zero, 0f, Vector3.zero);
    }

    private Face FindClosestFace()
    {
        float min = float.MaxValue;
        Face closest = null;
        foreach (var f in faces)
        {
            if (f.Distance < min)
            {
                min = f.Distance;
                closest = f;
            }
        }
        return closest;
    }

    private void Expand(Vector3 p, Vector3 sa, Vector3 sb)
    {
        List<Face> visible = new();
        List<(Vector3, Vector3, Vector3, Vector3, Vector3, Vector3)> edges = new();

        foreach (var f in faces)
        {
            if (f.IsFacing(p)) visible.Add(f);
        }

        foreach (var f in visible)
        {
            AddEdge(edges, f.A, f.B, f.SupA.a, f.SupA.b, f.SupB.a, f.SupB.b);
            AddEdge(edges, f.B, f.C, f.SupA.b, f.SupA.c, f.SupB.b, f.SupB.c);
            AddEdge(edges, f.C, f.A, f.SupA.c, f.SupA.a, f.SupB.c, f.SupB.a);
            faces.Remove(f);
        }

        foreach (var e in edges)
        {
            AddFace((e.Item1, e.Item3, e.Item5), (e.Item2, e.Item4, e.Item6), (p, sa, sb));
        }
    }

    private void AddEdge(List<(Vector3, Vector3, Vector3, Vector3, Vector3, Vector3)> edges,
                         Vector3 a, Vector3 b,
                         Vector3 na, Vector3 nb,
                         Vector3 ma, Vector3 mb)
    {
        for (int i = 0; i < edges.Count; i++)
        {
            var e = edges[i];
            if (e.Item1 == b && e.Item2 == a)
            {
                edges.RemoveAt(i);
                return;
            }
        }
        edges.Add((a, b, na, nb, ma, mb));
    }
}
