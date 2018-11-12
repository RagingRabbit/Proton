using System;

namespace Proton
{
    public struct Vector4
    {
        public float x, y, z, w;

        public Vector4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public Vector4(Vector3 xyz, float w)
        {
            this.x = xyz.x;
            this.y = xyz.y;
            this.z = xyz.z;
            this.w = w;
        }

        public override string ToString()
        {
            return x + " , " + y + " , " + z + " , " + w;
        }

        public Vector3 xyz
        {
            get { return new Vector3(x, y, z); }
            set { x = value.x; y = value.y; z = value.z; }
        }
    }
}
