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

			Input.Initialize(window);

			adapter.Start();

			long last = Time.now;
			long delta = 0;

			while (glfwWindowShouldClose(window) == 0)
			{
				long now = Time.now;
				delta = now - last;
				last = now;
				Time.delta = delta / 1000.0f;

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

	public static class Time
	{
		public static float delta { get; internal set; }

		public static long now
		{
			get { return DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond; }
		}
	}
}
