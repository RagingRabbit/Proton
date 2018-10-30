using System;
using System.Collections.Generic;

namespace Proton
{
	using static GL11;
	using static GL30;
	using static GL20;

	class VertexArray
	{
		uint handle;
		Dictionary<uint, ArrayBuffer> arrayBuffers;
		ElementArrayBuffer elementBuffer;

		internal VertexArray()
		{
			glGenVertexArrays(1, ref handle);
			arrayBuffers = new Dictionary<uint, ArrayBuffer>();
			elementBuffer = null;
		}

		~VertexArray()
		{
			if (handle != 0)
			{
				Dispose();
			}
		}

		internal void Dispose()
		{
			while (arrayBuffers.Count > 0)
			{
				arrayBuffers[0].Dispose();
				arrayBuffers.Remove(0);
			}
			if (elementBuffer != null)
			{
				elementBuffer.Dispose();
				elementBuffer = null;
			}
			glDeleteVertexArrays(1, ref handle);
			handle = 0;
		}

		internal void Bind()
		{
			glBindVertexArray(handle);
		}

		internal void Unbind()
		{
			glBindVertexArray(0);
		}

		internal void EnableAttributes()
		{
			foreach (uint attrib in arrayBuffers.Keys)
			{
				glEnableVertexAttribArray(attrib);
			}
		}

		internal void DisableAttributes()
		{
			foreach (uint attrib in arrayBuffers.Keys)
			{
				glDisableVertexAttribArray(attrib);
			}
		}

		internal void AddBuffer(uint index, int size, int[] data, BufferUsage usage)
		{
			ArrayBuffer buffer = GetArrayBuffer(index);
			buffer.Bind();
			buffer.SetData(data ?? new int[] { }, size, usage);
			glVertexAttribIPointer(index, size, GL_UNSIGNED_INT, 0, IntPtr.Zero);
		}

		internal void AddBuffer(uint index, int size, float[] data, BufferUsage usage)
		{
			ArrayBuffer buffer = GetArrayBuffer(index);
			buffer.Bind();
			buffer.SetData(data ?? new float[] { }, size, usage);
			glVertexAttribPointer(index, size, GL_FLOAT, GL_FALSE, 0, IntPtr.Zero);
			buffer.Unbind();
		}

		internal void AddElementBuffer(short[] data, BufferUsage usage)
		{
			ElementArrayBuffer buffer = GetElementArrayBuffer();
			buffer.Bind();
			buffer.SetData(data ?? new short[] { }, 1, usage);
		}

		internal void AddElementBuffer(int[] data, BufferUsage usage)
		{
			ElementArrayBuffer buffer = GetElementArrayBuffer();
			buffer.Bind();
			buffer.SetData(data ?? new int[] { }, 1, usage);
		}

		internal void Draw(DrawMode mode, int count, int offset)
		{
			if (elementBuffer == null)
			{
				glDrawArrays((uint)mode, offset, count);
			}
			else
			{
				glDrawElements((uint)mode, count, elementBuffer.type, (IntPtr)offset);
			}
		}

		internal void Draw()
		{
			if (elementBuffer == null)
			{
				glDrawArrays(GL_TRIANGLES, 0, arrayBuffers[0].length / arrayBuffers[0].size);
			}
			else
			{
				glDrawElements(GL_TRIANGLES, elementBuffer.length, elementBuffer.type, IntPtr.Zero);
			}
		}

		ArrayBuffer GetArrayBuffer(uint index)
		{
			if (!arrayBuffers.ContainsKey(index))
			{
				ArrayBuffer buffer = new ArrayBuffer();
				arrayBuffers.Add(index, buffer);
			}
			return arrayBuffers[index];
		}

		ElementArrayBuffer GetElementArrayBuffer()
		{
			if (elementBuffer == null)
			{
				elementBuffer = new ElementArrayBuffer();
			}
			return elementBuffer;
		}
	}

	enum DrawMode : uint
	{
		GL_TRIANGLES
	}
}
