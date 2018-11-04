using System;

namespace Proton
{
	using static Glfw;

	public static class Display
	{
		public static int width
		{
			get
			{
				int w = 0, h = 0;
				glfwGetWindowSize(ProtonEngine.window, ref w, ref h);
				return w;
			}
		}

		public static int height
		{
			get
			{
				int w = 0, h = 0;
				glfwGetWindowSize(ProtonEngine.window, ref w, ref h);
				return h;
			}
		}
	}
}
