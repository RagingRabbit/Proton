﻿using System;

namespace Proton
{
    public struct Vector3
    {
        public float x, y, z;

        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return x + "," + y + "," + z;
        }

        public float length
        {
            get { return (float)Math.Sqrt(x * x + y * y + z * z); }
        }

        public Vector3 normalized
        {
            get
            {
                float l = length;
                return l < 0.001f ? new Vector3() : new Vector3(x / l, y / l, z / l);
            }
        }

        public Vector3 inverted
        {
            get { return new Vector3(-x, -y, -z); }
        }

        public static Vector3 operator +(Vector3 left, Vector3 right)
        {
            return new Vector3(left.x + right.x, left.y + right.y, left.z + right.z);
        }

        public static Vector3 operator /(Vector3 left, float right)
        {
            return new Vector3(left.x / right, left.y / right, left.z / right);
        }
    }
}
