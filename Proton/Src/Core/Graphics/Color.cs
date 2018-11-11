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

		public Color(int hex, bool alpha = false)
		{
			r = (hex & 0xFF0000) >> 16;
			g = (hex & 0x00FF00) >> 8;
			b = (hex & 0x0000FF) >> 0;
			a = alpha ? (hex & 0xFF000000) >> 24 : 255;
		}

		public Color Brightness(float f)
		{
			return new Color(r * f, g * f, b * f, a);
		}
	}
}
