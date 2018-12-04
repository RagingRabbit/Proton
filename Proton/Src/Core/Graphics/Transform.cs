using System;

namespace Proton
{
    public struct Transform
    {
        public Vector3 position;
        public Quaternion rotation;

        public Transform(Vector3 position, Quaternion rotation)
        {
            this.position = position;
            this.rotation = rotation;
        }

        public Vector3 right { get { return rotation * Vector3.right; } }

        public Vector3 left { get { return rotation * Vector3.left; } }

        public Vector3 up { get { return rotation * Vector3.up; } }

        public Vector3 down { get { return rotation * Vector3.down; } }

        public Vector3 back { get { return rotation * Vector3.back; } }

        public Vector3 forward { get { return rotation * Vector3.forward; } }
    }
}
