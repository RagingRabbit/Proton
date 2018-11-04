using System;

namespace Proton
{
	public struct Vector3
	{
		public float x, y, z;

		public Vector3(float x, float y, float z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public float length
		{
			get { return (float)Math.Sqrt(x * x + y * y + z * z); }
		}

		public Vector3 normalized
		{
			get
			{
				float l = length;
				return new Vector3(x / l, y / l, z / l);
			}
		}
	}
}
