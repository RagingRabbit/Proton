using System;
using System.Runtime.InteropServices;

namespace Proton
{
	using static GL11;
	using static GL15;

	abstract class Buffer
	{
		uint handle;
		BufferTarget target;

		internal int length;
		internal int size;

		internal Buffer(BufferTarget target)
		{
			glGenBuffers(1, ref handle);
			this.target = target;
		}

		internal void Dispose()
		{
			glDeleteBuffers(1, ref handle);
			handle = 0;
		}

		internal void Bind()
		{
			glBindBuffer((uint)target, handle);
		}

		internal void Unbind()
		{
			glBindBuffer((uint)target, 0);
		}

		internal virtual void SetData(short[] data, int elementSize, BufferUsage usage)
		{
			IntPtr dataPtr = Marshal.AllocHGlobal(data.Length * sizeof(short));
			Marshal.Copy(data, 0, dataPtr, data.Length);
			glBufferData((uint)target, data.Length * sizeof(short), dataPtr, (uint)usage);
			Marshal.FreeHGlobal(dataPtr);

			length = data.Length;
			size = elementSize;
		}

		internal virtual void SetData(int[] data, int elementSize, BufferUsage usage)
		{
			IntPtr dataPtr = Marshal.AllocHGlobal(data.Length * sizeof(int));
			Marshal.Copy(data, 0, dataPtr, data.Length);
			glBufferData((uint)target, data.Length * sizeof(int), dataPtr, (uint)usage);
			Marshal.FreeHGlobal(dataPtr);

			length = data.Length;
			size = elementSize;
		}

		internal virtual void SetData(float[] data, int elementSize, BufferUsage usage)
		{
			IntPtr dataPtr = Marshal.AllocHGlobal(data.Length * sizeof(float));
			Marshal.Copy(data, 0, dataPtr, data.Length);
			glBufferData((uint)target, data.Length * sizeof(float), dataPtr, (uint)usage);
			Marshal.FreeHGlobal(dataPtr);

			length = data.Length;
			size = elementSize;
		}
	}

	class ArrayBuffer : Buffer
	{
		internal ArrayBuffer()
			: base(BufferTarget.ArrayBuffer)
		{
		}
	}

	class ElementArrayBuffer : Buffer
	{
		internal uint type;

		internal ElementArrayBuffer()
			: base(BufferTarget.ElementArrayBuffer)
		{
		}

		internal override void SetData(short[] data, int elementSize, BufferUsage usage)
		{
			base.SetData(data, elementSize, usage);
			type = GL_UNSIGNED_SHORT;
		}

		internal override void SetData(int[] data, int elementSize, BufferUsage usage)
		{
			base.SetData(data, elementSize, usage);
			type = GL_UNSIGNED_INT;
		}
	}

	enum BufferTarget : uint
	{
		ArrayBuffer = GL_ARRAY_BUFFER,
		ElementArrayBuffer = GL_ELEMENT_ARRAY_BUFFER
	}

	enum BufferUsage : uint
	{
		StaticDraw = GL_STATIC_DRAW,
		DynamicDraw = GL_DYNAMIC_DRAW,
		StreamDraw = GL_STREAM_DRAW
	}
}
