using System;
namespace Proton
{
    public struct Quaternion
    {
        public static Quaternion identity
        {
            get { return new Quaternion(0.0f, 0.0f, 0.0f, 1.0f); }
        }

        public float x, y, z, w;

        public Quaternion(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public Quaternion(Vector3 xyz, float w)
            : this(xyz.x, xyz.y, xyz.z, w)
        {
        }

        public override string ToString()
        {
            return x + " , " + y + " , " + z + " , " + w;
        }

        public float lengthSquared
        {
            get { return x * x + y * y + z * z + w * w; }
        }

        public float length
        {
            get { return (float)Math.Sqrt(lengthSquared); }
        }

        public Quaternion normalized
        {
            get { return this / length; }
        }

        public Quaternion conjugated
        {
            get { return new Quaternion(-x, -y, -z, w); }
        }

        public Vector3 xyz
        {
            get { return new Vector3(x, y, z); }
        }

        public Vector4 axisAngle
        {
            get
            {
                Vector4 v = new Vector4();
                Quaternion q = normalized;
                v.w = (float)(2.0 * Math.Acos(q.w) / Math.PI * 180.0);
                float s = (float)Math.Sqrt(1.0f - q.w * q.w);
                v.xyz = q.xyz / (s < 0.001f ? 1.0f : s);

                return v;
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
                double rad = value.w / 180.0 * Math.PI;
                double n = Math.Sqrt(x * x + y * y + z * z);
                float s = (float)(Math.Sin(0.5 * rad) / n);
                x *= s;
                y *= s;
                z *= s;
                w = (float)Math.Cos(0.5 * rad);
            }
        }

        public Vector3 eulerAngles
        {
            get
            {
                Vector3 v;
                float sqx = x * x;
                float sqy = y * y;
                float sqz = z * z;
                float sqw = w * w;
                float unit = sqx + sqy + sqz + sqw;
                float tmp = x * y + z * w;
                if (tmp > 0.499f * unit)
                {
                    v.x = Mathf.ToDeg((float)Math.PI / 2.0f);
                    v.y = Mathf.ToDeg((float)(2.0 * Math.Atan2(x, w)));
                    v.z = 0.0f;
                    return v;
                }
                if (tmp < -0.499f * unit)
                {
                    v.x = Mathf.ToDeg((float)-Math.PI / 2.0f);
                    v.y = Mathf.ToDeg((float)(-2.0 * Math.Atan2(x, w)));
                    v.z = 0.0f;
                    return v;
                }
                v.y = Mathf.ToDeg((float)Math.Atan2(2.0 * y * w - 2.0 * x * z, sqx - sqy - sqz + sqw));
                v.x = Mathf.ToDeg((float)Math.Asin(2.0 * tmp / unit));
                v.z = Mathf.ToDeg((float)Math.Atan2(2.0 * x * w - 2.0 * y * z, -sqx + sqy - sqz + sqw));
                return v;
            }
            set
            {
                float c1 = (float)Math.Cos(Mathf.ToRad(value.y) / 2.0f);
                float s1 = (float)Math.Sin(Mathf.ToRad(value.y) / 2.0f);
                float c2 = (float)Math.Cos(Mathf.ToRad(value.z) / 2.0f);
                float s2 = (float)Math.Sin(Mathf.ToRad(value.z) / 2.0f);
                float c3 = (float)Math.Cos(Mathf.ToRad(value.x) / 2.0f);
                float s3 = (float)Math.Sin(Mathf.ToRad(value.x) / 2.0f);
                float c1c2 = c1 * c2;
                float s1s2 = s1 * s2;
                x = c1c2 * s3 + s1s2 * c3;
                y = s1 * c2 * c3 + c1 * s2 * s3;
                z = c1 * s2 * c3 - s1 * c2 * s3;
                w = c1c2 * c3 - s1s2 * s3;
            }
        }

        public static Quaternion operator *(Quaternion left, Quaternion right)
        {
            Quaternion q;
            q.x = right.x * left.w + right.w * left.x + right.y * left.z - right.z * left.y;
            q.y = right.y * left.w + right.w * left.y + right.z * left.x - right.x * left.z;
            q.z = right.z * left.w + right.w * left.z + right.x * left.y - right.y * left.x;
            q.w = right.w * left.w - right.x * left.x - right.y * left.y - right.z * left.z;

            return q;
        }

        public static Vector3 operator *(Quaternion left, Vector3 right)
        {
            return (left * new Quaternion(right, 0.0f) * left.conjugated).xyz;
        }

        public static Quaternion operator /(Quaternion left, float right)
        {
            return new Quaternion(left.x / right, left.y / right, left.z / right, left.w / right);
        }

        public static Quaternion AxisAngle(Vector3 axis, float deg)
        {
            return AxisAngle(new Vector4(axis, deg));
        }

        public static Quaternion AxisAngle(Vector4 axisAngle)
        {
            Quaternion q = new Quaternion();
            q.axisAngle = axisAngle;
            return q;
        }

        public static Quaternion EulerAngles(Vector3 eulers)
        {
            Quaternion q = new Quaternion();
            q.eulerAngles = eulers;
            return q;
        }
    }
}
