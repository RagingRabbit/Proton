using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Proton
{
	using static GL11;
	using static GL12;
	using static GL13;

	public class Texture
	{
		uint handle;

		public Texture()
		{
			glGenTextures(1, ref handle);

			glBindTexture(GL_TEXTURE_2D, handle);
			glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_S, (int)GL_REPEAT);
			glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_S, (int)GL_REPEAT);
			glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, (int)GL_NEAREST);
			glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, (int)GL_NEAREST);
			glBindTexture(GL_TEXTURE_2D, 0);
		}

		public Texture(string path)
			: this()
		{
			LoadFromFile(path);
		}

		public Texture SetData(int width, int height, byte[] data)
		{
			IntPtr dataPtr = Marshal.AllocHGlobal(data.Length * sizeof(byte));
			Marshal.Copy(data, 0, dataPtr, data.Length);

			glBindTexture(GL_TEXTURE_2D, handle);
			glTexImage2D(GL_TEXTURE_2D, 0, (int)GL_RGBA8, width, height, 0, GL_RGBA, GL_UNSIGNED_BYTE, dataPtr);

			Marshal.FreeHGlobal(dataPtr);
			return this;
		}

		public Texture LoadFromFile(string path)
		{
			Bitmap image = new Bitmap(path);
			byte[] pixels = new byte[image.Width * image.Height * 4];
			for (int y = 0; y < image.Height; y++)
			{
				for (int x = 0; x < image.Width; x++)
				{
					System.Drawing.Color col = image.GetPixel(x, y);
					pixels[(x + y * image.Width) * 4 + 0] = col.R;
					pixels[(x + y * image.Width) * 4 + 1] = col.G;
					pixels[(x + y * image.Width) * 4 + 2] = col.B;
					pixels[(x + y * image.Width) * 4 + 3] = col.A;
				}
			}
			SetData(image.Width, image.Height, pixels);
			return this;
		}

		public void Bind()
		{
			glBindTexture(GL_TEXTURE_2D, handle);
		}

		public void Bind(uint unit)
		{
			glActiveTexture(GL_TEXTURE0 + unit);
			glBindTexture(GL_TEXTURE_2D, handle);
		}

		public void Unbind()
		{
			glBindTexture(GL_TEXTURE_2D, 0);
		}

		public void Unbind(uint unit)
		{
			glActiveTexture(GL_TEXTURE0 + unit);
			glBindTexture(GL_TEXTURE_2D, 0);
		}
	}
}
