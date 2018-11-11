using System;

namespace Proton
{
	public static class Mathf
	{
		public static float ToRad(float deg)
		{
			return (float)(deg / 180.0 * Math.PI);
		}

		public static float ToDeg(float rad)
		{
			return (float)(rad / Math.PI * 180.0);
		}
	}
}
