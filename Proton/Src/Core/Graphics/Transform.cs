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

        public Vector3 right { get { return (new Quaternion(1.0f, 0.0f, 0.0f, 0.0f) * rotation).xyz; } }

        public Vector3 left { get { return (new Quaternion(-1.0f, 0.0f, 0.0f, 0.0f) * rotation).xyz; } }

        public Vector3 up { get { return (new Quaternion(0.0f, 1.0f, 0.0f, 0.0f) * rotation).xyz; } }

        public Vector3 down { get { return (new Quaternion(0.0f, -1.0f, 0.0f, 0.0f) * rotation).xyz; } }

        public Vector3 back { get { return (new Quaternion(0.0f, 0.0f, 1.0f, 0.0f) * rotation).xyz; } }

        public Vector3 forward { get { return (new Quaternion(0.0f, 0.0f, -1.0f, 0.0f) * rotation).xyz; } }
    }
}
