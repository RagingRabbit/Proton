using System;
using System.Runtime.InteropServices;

namespace Proton
{
	//[StructLayout(LayoutKind.Sequential)]
	public struct Matrix4
	{
		public static Matrix4 identity
		{
			get { return new Matrix4(1.0f); }
		}

		public float m00, m10, m20, m30;
		public float m01, m11, m21, m31;
		public float m02, m12, m22, m32;
		public float m03, m13, m23, m33;

		public Matrix4(float diag)
		{
			m00 = diag;
			m10 = 0.0f;
			m20 = 0.0f;
			m30 = 0.0f;
			m01 = 0.0f;
			m11 = diag;
			m21 = 0.0f;
			m31 = 0.0f;
			m02 = 0.0f;
			m12 = 0.0f;
			m22 = diag;
			m32 = 0.0f;
			m03 = 0.0f;
			m13 = 0.0f;
			m23 = 0.0f;
			m33 = 1.0f;
		}

		public float this[int x, int y]
		{
			get
			{
				switch (x)
				{
					case 0:
						switch (y)
						{
							case 0: return m00;
							case 1: return m01;
							case 2: return m02;
							case 3: return m03;
							default: return 0.0f;
						}
					case 1:
						switch (y)
						{
							case 0: return m10;
							case 1: return m11;
							case 2: return m12;
							case 3: return m13;
							default: return 0.0f;
						}
					case 2:
						switch (y)
						{
							case 0: return m20;
							case 1: return m21;
							case 2: return m22;
							case 3: return m23;
							default: return 0.0f;
						}
					case 3:
						switch (y)
						{
							case 0: return m30;
							case 1: return m31;
							case 2: return m32;
							case 3: return m33;
							default: return 0.0f;
						}
					default:
						return 0.0f;
				}
			}
			set
			{
				switch (x)
				{
					case 0:
						switch (y)
						{
							case 0: value = m00; return;
							case 1: value = m01; return;
							case 2: value = m02; return;
							case 3: value = m03; return;
							default: return;
						}
					case 1:
						switch (y)
						{
							case 0: value = m10; return;
							case 1: value = m11; return;
							case 2: value = m12; return;
							case 3: value = m13; return;
							default: return;
						}
					case 2:
						switch (y)
						{
							case 0: value = m20; return;
							case 1: value = m21; return;
							case 2: value = m22; return;
							case 3: value = m23; return;
							default: return;
						}
					case 3:
						switch (y)
						{
							case 0: value = m30; return;
							case 1: value = m31; return;
							case 2: value = m32; return;
							case 3: value = m33; return;
							default: return;
						}
					default:
						return;
				}
			}
		}

		public static Matrix4 perspective(float fov, float aspect, float near, float far)
		{
			double rad = fov / 180.0 * Math.PI;
			double y = 1.0 / Math.Tan(0.5 * rad) * aspect;
			double x = y / aspect;
			double l = far - near;

			Matrix4 mat = identity;
			mat.m00 = (float)x;
			mat.m11 = (float)y;
			mat.m22 = (float)((far + near) / -l);
			mat.m23 = -1.0f;
			mat.m32 = -2.0f * near * far / (float)l;
			mat.m33 = 0.0f;

			return mat;
		}

		public static Matrix4 translate(float x, float y, float z)
		{
			Matrix4 mat = identity;
			mat.m30 = x;
			mat.m31 = y;
			mat.m32 = z;

			return mat;
		}

		public static Matrix4 rotate(float x, float y, float z, float deg)
		{
			double rad = deg / 180.0 * Math.PI;
			double c = Math.Cos(rad);
			double s = Math.Sin(rad);
			double t = 1.0 - c;

			Vector3 axis = new Vector3(x, y, z).normalized;
			Matrix4 mat = identity;
			mat.m00 = (float)(c + axis.x * axis.x * t);
			mat.m11 = (float)(c + axis.y * axis.y * t);
			mat.m22 = (float)(c + axis.z * axis.z * t);

			float tmp1 = axis.x * axis.y * (float)t;
			float tmp2 = axis.z * (float)s;
			mat.m10 = tmp1 + tmp2;
			mat.m01 = tmp1 - tmp2;
			tmp1 = axis.x * axis.z * (float)t;
			tmp2 = axis.y * (float)s;
			mat.m20 = tmp1 - tmp2;
			mat.m02 = tmp1 + tmp2;
			tmp1 = axis.y * axis.z * (float)t;
			tmp2 = axis.x * (float)s;
			mat.m21 = tmp1 + tmp2;
			mat.m12 = tmp1 - tmp2;

			return mat;
		}

		public static Matrix4 operator *(Matrix4 left, Matrix4 right)
		{
			Matrix4 mat = identity;
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					float sum = 0.0f;
					for (int k = 0; k < 4; k++)
					{
						sum += left[k, j] * right[i, k];
					}
					mat[i, j] = sum;
				}
			}
			return mat;
		}
	}
}
