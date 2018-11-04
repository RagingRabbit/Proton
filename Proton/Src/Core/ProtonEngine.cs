using System;

namespace Proton
{
	using static Glfw;
	using static CSGL;
	using static GL11;

	public static class ProtonEngine
	{
		internal static IntPtr window;

		public static void Launch(EngineAdapter adapter, LaunchParams lParams)
		{
			csglLoadGlfw();
			glfwInit();

			window = glfwCreateWindow(lParams.width, lParams.height, lParams.title, IntPtr.Zero, IntPtr.Zero);
			glfwMakeContextCurrent(window);
			csglLoadGL();

			adapter.Start();

			while (glfwWindowShouldClose(window) == 0)
			{
				glfwSwapBuffers(window);
				glfwPollEvents();
				glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);

				adapter.Update();

				Renderer3D.Flush();
			}

			adapter.Stop();
			glfwTerminate();
		}
	}

	public interface EngineAdapter
	{
		void Start();
		void Update();
		void Stop();
	}

	public struct LaunchParams
	{
		public int width;
		public int height;
		public string title;

		public LaunchParams(int width, int height, string title)
		{
			this.width = width;
			this.height = height;
			this.title = title;
		}
	}
}
