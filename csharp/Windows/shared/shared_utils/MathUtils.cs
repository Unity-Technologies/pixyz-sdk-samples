using System;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;
using System.Xml;

namespace PiXYZDemo
{
    using Newtonsoft.Json;
    using System.Drawing;
    using UnityEngine.Pixyz.API;
    using UnityEngine.Pixyz.Geom;
    using UnityEngine.Pixyz.Scene;
    using UnityEngine.Pixyz.View;


    public static class MathUtils
    {
        public static Point3 PointAdd(Point3 pt1, Point3 pt2)
        {
            return new Point3
            {
                x = pt1.x + pt2.x,
                y = pt1.y + pt2.y,
                z = pt1.z + pt2.z
            };
        }

        public static Point3 PointSub(Point3 pt1, Point3 pt2)
        {
            return new Point3
            {
                x = pt1.x - pt2.x,
                y = pt1.y - pt2.y,
                z = pt1.z - pt2.z
            };
        }

        public static double DotProduct(Point3 pt1, Point3 pt2)
        {
            return pt1.x * pt2.x + pt1.y * pt2.y + pt1.z * pt2.z;
        }

        public static Point3 CrossProduct(Point3 pt1, Point3 pt2)
        {
            return new Point3
            {
                x = pt1.y * pt2.z - pt1.z * pt2.y,
                y = pt1.z * pt2.x - pt1.x * pt2.z,
                z = pt1.z * pt2.z - pt1.z * pt2.z
            };
        }

        public static double VectorLength(Point3 v)
        {
            return Math.Sqrt(DotProduct(v, v));
        }

        public static double AabbDiagLength(AABB aabb)
        {
            return VectorLength(PointSub(aabb.high, aabb.low));
        }

        public static Point3 Center(Point3 pt1, Point3 pt2)
        {
            return new Point3
            {
                x = (pt1.x + pt2.x) / 2,
                y = (pt1.y + pt2.y) / 2,
                z = (pt1.z + pt2.z) / 2
            };
        }

        public static Point3 Normalize(Point3 v)
        {
            double length = VectorLength(v);
            return new Point3 
            { 
                x = v.x / length, 
                y = v.y / length, 
                z = v.z / length 
            };
        }

        public static bool PointInAABB(AABB aabb, Point3 pt)
        {
            if (pt.x < aabb.low.x) return false;
            if (pt.y < aabb.low.y) return false;
            if (pt.z < aabb.low.z) return false;
            if (pt.x > aabb.high.x) return false;
            if (pt.y > aabb.high.y) return false;
            if (pt.z > aabb.high.z) return false;
            return true;
        }
    }
}

