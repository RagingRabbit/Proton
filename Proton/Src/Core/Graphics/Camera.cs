using System;

namespace Proton
{
    public class Camera
    {
        public static Camera mainCamera;

        static Camera()
        {
            mainCamera = new Camera(70.0f, 1000.0f);
        }

        public Transform transform;
        public float fovy, near, far;

        public Camera(float fov, float farPlane)
        {
            transform = new Transform();
            fovy = fov;
            near = 0.1f;
            far = farPlane;
        }

        public Matrix4 projection
        {
            get { return Matrix4.Perspective(fovy, Display.width / (float)Display.height, near, far); }
        }

        public Matrix4 view
        {
            get
            {
                Matrix4 mat = Matrix4.Rotate(transform.rotation.conjugated) * Matrix4.Translate(transform.position.inverted);
                return mat;
            }
        }
    }
}
