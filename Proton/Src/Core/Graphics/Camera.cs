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

		public Matrix4 projection { get; private set; }
		public Matrix4 view { get; private set; }

		public Camera(float fov, float range)
		{
			projection = Matrix4.perspective(fov, Display.width / (float)Display.height, 0.1f, range);
			//view = Matrix4.identity;
			view *= Matrix4.translate(0.0f, 0.0f, -4.0f);
			//view *= Matrix4.rotate(0.0f, 1.0f, 0.0f, 0.0f);
		}
	}
}
