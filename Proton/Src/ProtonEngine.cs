using System;

using static Proton.Glfw;
using static Proton.Dll;

namespace Proton
{
	public static class ProtonEngine
	{
		static IntPtr window;

		public static void Launch(EngineAdapter adapter, LaunchParams lParams)
		{
			csglLoadGL();
			csglLoadGlfw();
			glfwInit();

			window = glfwCreateWindow(lParams.width, lParams.height, lParams.title, IntPtr.Zero, IntPtr.Zero);

			while (glfwWindowShouldClose(window) == 0)
			{
				glfwPollEvents();
				glfwSwapBuffers(window);
			}

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
