using System;

namespace Proton
{
	using static GL11;

	public static class Graphics
	{
		public static Color backgroundColor
		{
			set { glClearColor(value.r / 255.0f, value.g / 255.0f, value.b / 255.0f, value.a / 255.0f); }
		}

		public static bool wireframeMode
		{
			set { glPolygonMode(GL_FRONT_AND_BACK, value ? GL_LINE : GL_FILL); }
		}
	}
}
