using System;

namespace Proton
{
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

		public static Matrix4 Perspective(float fov, float aspect, float near, float far)
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

		public static Matrix4 Translate(Vector3 v)
		{
			return Translate(v.x, v.y, v.z);
		}

		public static Matrix4 Translate(float x, float y, float z)
		{
			Matrix4 mat = identity;
			mat.m30 = x;
			mat.m31 = y;
			mat.m32 = z;

			return mat;
		}

		public static Matrix4 Rotate(Quaternion q)
		{
			Vector4 axisAngle = q.axisAngle;
			return Rotate(axisAngle.xyz, axisAngle.w);
		}

		public static Matrix4 Rotate(Vector3 axis, float deg)
		{
			return Rotate(axis.x, axis.y, axis.z, deg);
		}

		public static Matrix4 Rotate(float x, float y, float z, float deg)
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

			float m00 = left.m00 * right.m00 + left.m10 * right.m01 + left.m20 * right.m02 + left.m30 * right.m03;
			float m01 = left.m01 * right.m00 + left.m11 * right.m01 + left.m21 * right.m02 + left.m31 * right.m03;
			float m02 = left.m02 * right.m00 + left.m12 * right.m01 + left.m22 * right.m02 + left.m32 * right.m03;
			float m03 = left.m03 * right.m00 + left.m13 * right.m01 + left.m23 * right.m02 + left.m33 * right.m03;
			float m10 = left.m00 * right.m10 + left.m10 * right.m11 + left.m20 * right.m12 + left.m30 * right.m13;
			float m11 = left.m01 * right.m10 + left.m11 * right.m11 + left.m21 * right.m12 + left.m31 * right.m13;
			float m12 = left.m02 * right.m10 + left.m12 * right.m11 + left.m22 * right.m12 + left.m32 * right.m13;
			float m13 = left.m03 * right.m10 + left.m13 * right.m11 + left.m23 * right.m12 + left.m33 * right.m13;
			float m20 = left.m00 * right.m20 + left.m10 * right.m21 + left.m20 * right.m22 + left.m30 * right.m23;
			float m21 = left.m01 * right.m20 + left.m11 * right.m21 + left.m21 * right.m22 + left.m31 * right.m23;
			float m22 = left.m02 * right.m20 + left.m12 * right.m21 + left.m22 * right.m22 + left.m32 * right.m23;
			float m23 = left.m03 * right.m20 + left.m13 * right.m21 + left.m23 * right.m22 + left.m33 * right.m23;
			float m30 = left.m00 * right.m30 + left.m10 * right.m31 + left.m20 * right.m32 + left.m30 * right.m33;
			float m31 = left.m01 * right.m30 + left.m11 * right.m31 + left.m21 * right.m32 + left.m31 * right.m33;
			float m32 = left.m02 * right.m30 + left.m12 * right.m31 + left.m22 * right.m32 + left.m32 * right.m33;
			float m33 = left.m03 * right.m30 + left.m13 * right.m31 + left.m23 * right.m32 + left.m33 * right.m33;

			mat.m00 = m00;
			mat.m01 = m01;
			mat.m02 = m02;
			mat.m03 = m03;
			mat.m10 = m10;
			mat.m11 = m11;
			mat.m12 = m12;
			mat.m13 = m13;
			mat.m20 = m20;
			mat.m21 = m21;
			mat.m22 = m22;
			mat.m23 = m23;
			mat.m30 = m30;
			mat.m31 = m31;
			mat.m32 = m32;
			mat.m33 = m33;

			return mat;
		}
	}
}
