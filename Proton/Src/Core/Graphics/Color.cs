using System;

namespace Proton
{
	public struct Color
	{
		public float r, g, b, a;

		public Color(float r, float g, float b, float a)
		{
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = a;
		}

		public Color(float r, float g, float b)
		{
			this.r = r;
			this.g = g;			this.b = b;
			this.a = 255;
		}
	}
}
