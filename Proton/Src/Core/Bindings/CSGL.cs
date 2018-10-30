using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Reflection;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Proton
{
    using static Glfw;
    using static GL11;
    using static GL12;
    using static GL13;
    using static GL14;
    using static GL15;
    using static GL20;
    using static GL21;
    using static GL30;
    using static GL31;
    using static GL32;
    using static GL33;
    using static GL40;
    using static GL41;
    using static GL42;
    using static GL43;
    using static GL44;
    using static GL45;

    static class CSGL
    {
        #region Extension
        #region Fields
        public static IntPtr NULL = (IntPtr)0;

        private static Type _glType11 = typeof(GL11);
        private static Type _glType12 = typeof(GL12);
        private static Type _glType13 = typeof(GL13);
        private static Type _glType14 = typeof(GL14);
        private static Type _glType15 = typeof(GL15);

        private static Type _glType20 = typeof(GL20);
        private static Type _glType21 = typeof(GL21);

        private static Type _glType30 = typeof(GL30);
        private static Type _glType31 = typeof(GL31);
        private static Type _glType32 = typeof(GL32);
        private static Type _glType33 = typeof(GL33);

        private static Type _glType40 = typeof(GL40);
        private static Type _glType41 = typeof(GL41);
        private static Type _glType42 = typeof(GL42);
        private static Type _glType43 = typeof(GL43);
        private static Type _glType44 = typeof(GL44);
        private static Type _glType45 = typeof(GL45);

        private static Type _delegateType = typeof(MulticastDelegate);
        public static int CSGL_GLVERSION = 0;
        #endregion

        #region Methods
        public static bool csglLoadGL()
        {
            csglLoadGLType(_glType11);
            csglLoadGLType(_glType12);
            csglLoadGLType(_glType13);
            csglLoadGLType(_glType14);
            csglLoadGLType(_glType15);

            csglLoadGLType(_glType20);
            csglLoadGLType(_glType21);

            csglLoadGLType(_glType30);
            csglLoadGLType(_glType31);
            csglLoadGLType(_glType32);
            csglLoadGLType(_glType33);

            csglLoadGLType(_glType40);
            csglLoadGLType(_glType41);
            csglLoadGLType(_glType42);
            csglLoadGLType(_glType43);
            csglLoadGLType(_glType44);
            csglLoadGLType(_glType45);

            #region Detect version
            CSGL_GLVERSION = 0;

            if (glAccum != null)
                CSGL_GLVERSION = 110;

            if (glDrawRangeElements != null)
                CSGL_GLVERSION = 120;

            if (glActiveTexture != null)
                CSGL_GLVERSION = 130;

            if (glBlendFuncSeparate != null)
                CSGL_GLVERSION = 140;

            if (glGenQueries != null)
                CSGL_GLVERSION = 150;

            if (glBlendEquationSeparate != null)
                CSGL_GLVERSION = 200;

            if (glUniformMatrix2x3fv != null)
                CSGL_GLVERSION = 210;

            if (glColorMaski != null)
                CSGL_GLVERSION = 300;

            if (glDrawArraysInstanced != null)
                CSGL_GLVERSION = 310;

            if (glDrawElementsBaseVertex != null)
                CSGL_GLVERSION = 320;

            if (glBindFragDataLocationIndexed != null)
                CSGL_GLVERSION = 330;

            if (glMinSampleShading != null)
                CSGL_GLVERSION = 400;

            if (glReleaseShaderCompiler != null)
                CSGL_GLVERSION = 410;

            if (glDrawArraysInstancedBaseInstance != null)
                CSGL_GLVERSION = 420;

            if (glClearBufferData != null)
                CSGL_GLVERSION = 430;

            if (glBufferStorage != null)
                CSGL_GLVERSION = 440;

            if (glClipControl != null)
                CSGL_GLVERSION = 450;

            if (CSGL_GLVERSION == 0)
                throw new Exception("Could not load OpenGL");
            #endregion

            Console.WriteLine("Linked 'OpenGL' -> VERSION {0}", CSGL_GLVERSION);

            return true;
        }

        private static void csglLoadGLType(Type type)
        {
            #region Loader
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Static);

            foreach (FieldInfo fi in fields)
            {
                if (fi.FieldType.BaseType == _delegateType)
                {
                    IntPtr ptr = glfwGetProcAddress(fi.Name);

                    if (ptr != IntPtr.Zero)
                        fi.SetValue(null, Marshal.GetDelegateForFunctionPointer(ptr, fi.FieldType));
                }
            }
            #endregion
        }

        public static void csglAssert()
        {
            uint glError = glGetError();

            if (glError != GL_NO_ERROR)
                throw new Exception("OpenGL error (" + glError + ")");
        }
        #endregion

        #region Macros
        #region csglBuffer
        public static uint csglBuffer(float[] data, uint buffer = 0, uint target = GL_ARRAY_BUFFER, uint usage = GL_STATIC_DRAW)
        {
            uint BUFF = buffer;

            if (BUFF == 0)
                glGenBuffers(1, ref BUFF);

            glBindBuffer(target, BUFF);

#if UNSAFE
            unsafe
            {
                fixed ( void* ptrData = data )
                    glBufferData( target, sizeof( float ) * data.Length, (IntPtr)ptrData, usage );
            }
#else
            IntPtr ptrData = Marshal.AllocHGlobal(data.Length * sizeof(float));
            Marshal.Copy(data, 0, ptrData, data.Length);

            glBufferData(target, sizeof(float) * data.Length, ptrData, usage);

            Marshal.FreeHGlobal(ptrData);
#endif

            return BUFF;
        }

        public static uint csglBuffer(double[] data, uint buffer = 0, uint target = GL_ARRAY_BUFFER, uint usage = GL_STATIC_DRAW)
        {
            uint BUFF = buffer;

            if (BUFF == 0)
                glGenBuffers(1, ref BUFF);

            glBindBuffer(target, BUFF);

#if UNSAFE
            unsafe
            {
                fixed ( void* ptrData = data )
                    glBufferData( target, sizeof( double ) * data.Length, (IntPtr)ptrData, usage );
            }
#else
            IntPtr ptrData = Marshal.AllocHGlobal(data.Length * sizeof(double));
            Marshal.Copy(data, 0, ptrData, data.Length);

            glBufferData(target, sizeof(double) * data.Length, ptrData, usage);

            Marshal.FreeHGlobal(ptrData);
#endif

            return BUFF;
        }

        public static uint csglBuffer(byte[] data, uint buffer = 0, uint target = GL_ARRAY_BUFFER, uint usage = GL_STATIC_DRAW)
        {
            uint BUFF = buffer;

            if (BUFF == 0)
                glGenBuffers(1, ref BUFF);

            glBindBuffer(target, BUFF);

#if UNSAFE
            unsafe
            {
                fixed ( void* ptrData = data )
                    glBufferData( target, sizeof( byte ) * data.Length, (IntPtr)ptrData, usage );
            }
#else
            IntPtr ptrData = Marshal.AllocHGlobal(data.Length);
            Marshal.Copy(data, 0, ptrData, data.Length);

            glBufferData(target, data.Length, ptrData, usage);

            Marshal.FreeHGlobal(ptrData);
#endif

            return BUFF;
        }

        public static uint csglBuffer(ushort[] data, uint buffer = 0, uint target = GL_ARRAY_BUFFER, uint usage = GL_STATIC_DRAW)
        {
            uint BUFF = buffer;

            if (BUFF == 0)
                glGenBuffers(1, ref BUFF);

            glBindBuffer(target, BUFF);

#if UNSAFE
            unsafe
            {
                fixed ( void* ptrData = data )
                    glBufferData( target, sizeof( ushort ) * data.Length, (IntPtr)ptrData, usage );
            }
#else
            IntPtr ptrData = Marshal.AllocHGlobal(data.Length * sizeof(ushort));
            Marshal.Copy((short[])(Array)data, 0, ptrData, data.Length);

            glBufferData(target, sizeof(ushort) * data.Length, ptrData, usage);

            Marshal.FreeHGlobal(ptrData);
#endif

            return BUFF;
        }

        public static uint csglBuffer(short[] data, uint buffer = 0, uint target = GL_ARRAY_BUFFER, uint usage = GL_STATIC_DRAW)
        {
            uint BUFF = buffer;

            if (BUFF == 0)
                glGenBuffers(1, ref BUFF);

            glBindBuffer(target, BUFF);

#if UNSAFE
            unsafe
            {
                fixed ( void* ptrData = data )
                    glBufferData( target, sizeof( short ) * data.Length, (IntPtr)ptrData, usage );
            }
#else
            IntPtr ptrData = Marshal.AllocHGlobal(data.Length * sizeof(short));
            Marshal.Copy(data, 0, ptrData, data.Length);

            glBufferData(target, sizeof(short) * data.Length, ptrData, usage);

            Marshal.FreeHGlobal(ptrData);
#endif

            return BUFF;
        }

        public static uint csglBuffer(uint[] data, uint buffer = 0, uint target = GL_ARRAY_BUFFER, uint usage = GL_STATIC_DRAW)
        {
            uint BUFF = buffer;

            if (BUFF == 0)
                glGenBuffers(1, ref BUFF);

            glBindBuffer(target, BUFF);

#if UNSAFE
            unsafe
            {
                fixed ( void* ptrData = data )
                    glBufferData( target, sizeof( uint ) * data.Length, (IntPtr)ptrData, usage );
            }
#else
            IntPtr ptrData = Marshal.AllocHGlobal(data.Length * sizeof(uint));
            Marshal.Copy((int[])(Array)data, 0, ptrData, data.Length);

            glBufferData(target, sizeof(uint) * data.Length, ptrData, usage);

            Marshal.FreeHGlobal(ptrData);
#endif

            return BUFF;
        }

        public static uint csglBuffer(int[] data, uint buffer = 0, uint target = GL_ARRAY_BUFFER, uint usage = GL_STATIC_DRAW)
        {
            uint BUFF = buffer;

            if (BUFF == 0)
                glGenBuffers(1, ref BUFF);

            glBindBuffer(target, BUFF);

#if UNSAFE
            unsafe
            {
                fixed ( void* ptrData = data )
                    glBufferData( target, sizeof( int ) * data.Length, (IntPtr)ptrData, usage );
            }
#else
            IntPtr ptrData = Marshal.AllocHGlobal(data.Length * sizeof(int));
            Marshal.Copy(data, 0, ptrData, data.Length);

            glBufferData(target, sizeof(int) * data.Length, ptrData, usage);

            Marshal.FreeHGlobal(ptrData);
#endif

            return BUFF;
        }

        public static uint csglBuffer(ulong[] data, uint buffer = 0, uint target = GL_ARRAY_BUFFER, uint usage = GL_STATIC_DRAW)
        {
            uint BUFF = buffer;

            if (BUFF == 0)
                glGenBuffers(1, ref BUFF);

            glBindBuffer(target, BUFF);

#if UNSAFE
            unsafe
            {
                fixed ( void* ptrData = data )
                    glBufferData( target, sizeof( ulong ) * data.Length, (IntPtr)ptrData, usage );
            }
#else
            IntPtr ptrData = Marshal.AllocHGlobal(data.Length * sizeof(ulong));
            Marshal.Copy((long[])(Array)data, 0, ptrData, data.Length);

            glBufferData(target, sizeof(ulong) * data.Length, ptrData, usage);

            Marshal.FreeHGlobal(ptrData);
#endif

            return BUFF;
        }

        public static uint csglBuffer(long[] data, uint buffer = 0, uint target = GL_ARRAY_BUFFER, uint usage = GL_STATIC_DRAW)
        {
            uint BUFF = buffer;

            if (BUFF == 0)
                glGenBuffers(1, ref BUFF);

            glBindBuffer(target, BUFF);

#if UNSAFE
            unsafe
            {
                fixed ( void* ptrData = data )
                    glBufferData( target, sizeof( long ) * data.Length, (IntPtr)ptrData, usage );
            }
#else
            IntPtr ptrData = Marshal.AllocHGlobal(data.Length * sizeof(long));
            Marshal.Copy(data, 0, ptrData, data.Length);

            glBufferData(target, sizeof(long) * data.Length, ptrData, usage);

            Marshal.FreeHGlobal(ptrData);
#endif

            return BUFF;
        }
        #endregion

        #region csglShader
        public static uint csglShader(IntPtr shaderSource, uint type, int length = 0)
        {
            #region Compile
            uint shader = glCreateShader(type);

            glShaderSource(shader, 1, ref shaderSource, ref length);
            glCompileShader(shader);
            #endregion

            #region Assert
            int success = 0;
            glGetShaderiv(shader, GL_COMPILE_STATUS, ref success);

            if (success == 0)
            {
                IntPtr log = Marshal.AllocHGlobal(512);
                glGetShaderInfoLog(shader, 512, ref length, log);

                byte[] buffer = new byte[length];
                Marshal.Copy(log, buffer, 0, length);
                Marshal.FreeHGlobal(log);

                throw new Exception(Encoding.ASCII.GetString(buffer));
            }
            #endregion

            return shader;
        }

        public static uint csglShader(byte[] shaderSource, uint type)
        {
            IntPtr ptrSource = Marshal.AllocHGlobal(shaderSource.Length);
            Marshal.Copy(shaderSource, 0, ptrSource, shaderSource.Length);

            uint shader = csglShader(ptrSource, type, shaderSource.Length);

            Marshal.FreeHGlobal(ptrSource);

            return shader;
        }

        public static uint csglShader(string shaderSource, uint type)
        {
            return csglShader(Encoding.ASCII.GetBytes(shaderSource), type);
        }

        public static uint csglShaderFile(string filename, uint type, bool ascii = true)
        {
            if (ascii)
                return csglShader(File.ReadAllBytes(filename), type);
            else
                return csglShader(File.ReadAllText(filename), type);
        }

        public static uint csglShaderProgram(params uint[] shaders)
        {
            #region Link
            uint shaderProgram = glCreateProgram();

            foreach (uint shader in shaders)
                glAttachShader(shaderProgram, shader);

            glLinkProgram(shaderProgram);
            #endregion

            #region Assert
            int success = 0;
            glGetProgramiv(shaderProgram, GL_LINK_STATUS, ref success);

            if (success == 0)
            {
                int length = 0;
                IntPtr log = Marshal.AllocHGlobal(512);
                glGetProgramInfoLog(shaderProgram, 512, ref length, log);

                byte[] buffer = new byte[length];
                Marshal.Copy(log, buffer, 0, length);
                Marshal.FreeHGlobal(log);

                throw new Exception(System.Text.Encoding.ASCII.GetString(buffer));
            }
            #endregion

            #region Clean
            foreach (uint shader in shaders)
                glDeleteShader(shader);
            #endregion

            return shaderProgram;
        }
        #endregion

        #region csglVertex
        public static void csglVertexAttribPointer(uint index, int size, uint type, bool normalized, int stride, int offset = 0)
        {
            glVertexAttribPointer(index, size, type, normalized ? GL_TRUE : GL_FALSE, stride, NULL + offset);
        }

        public static void csglVertexAttribPointer(uint index, int size, uint type, int stride, int offset = 0)
        {
            glVertexAttribPointer(index, size, type, GL_FALSE, stride, NULL + offset);
        }
        #endregion

        /*
        #region csglTexture
        private static Stack<uint> _availTexPtrs = new Stack<uint>();

        public static uint csglTexture(int width, int height, IntPtr pixels, uint externalFormat = GL_RGBA, bool generateMipmaps = true, uint texture = 0)
        {
            if (texture == 0)
            {
                if (_availTexPtrs.Count > 0)
                    texture = _availTexPtrs.Pop();
                else
                    glGenTextures(1, ref texture);
            }

            glBindTexture(GL_TEXTURE_2D, texture);

            if (CSGL_GLVERSION < 300 & generateMipmaps)
            {
                glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAX_LEVEL, 4);
                glTexParameteri(GL_TEXTURE_2D, 0x8191, GL_TRUE);
            }

            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_S, (int)GL_CLAMP_TO_EDGE);
            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_T, (int)GL_CLAMP_TO_EDGE);

            if (generateMipmaps)
                glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, (int)GL_LINEAR_MIPMAP_NEAREST);
            else
                glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, (int)GL_LINEAR);

            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, (int)GL_NEAREST);

            glTexImage2D(GL_TEXTURE_2D, 0, (int)GL_RGBA, width, height, 0, externalFormat, GL_UNSIGNED_BYTE, pixels);

            if (CSGL_GLVERSION > 210 & generateMipmaps)
                glGenerateMipmap(GL_TEXTURE_2D);

            csglAssert();

            return texture;
        }

        public static void csglTextureClear(uint texture)
        {
            _availTexPtrs.Push(texture);
        }
        #endregion
        */

		/*
        #region csglClone
        public static byte[] csglClone(byte[] from)
        {
            byte[] result = new byte[from.Length];
            Buffer.BlockCopy(from, 0, result, 0, from.Length);

            return result;
        }

        public static ushort[] csglClone(ushort[] from)
        {
            ushort[] result = new ushort[from.Length];
            Buffer.BlockCopy(from, 0, result, 0, from.Length * sizeof(ushort));

            return result;
        }

        public static short[] csglClone(short[] from)
        {
            short[] result = new short[from.Length];
            Buffer.BlockCopy(from, 0, result, 0, from.Length * sizeof(short));

            return result;
        }

        public static uint[] csglClone(uint[] from)
        {
            uint[] result = new uint[from.Length];
            Buffer.BlockCopy(from, 0, result, 0, from.Length * sizeof(uint));

            return result;
        }

        public static int[] csglClone(int[] from)
        {
            int[] result = new int[from.Length];
            Buffer.BlockCopy(from, 0, result, 0, from.Length * sizeof(int));

            return result;
        }

        public static ulong[] csglClone(ulong[] from)
        {
            ulong[] result = new ulong[from.Length];
            Buffer.BlockCopy(from, 0, result, 0, from.Length * sizeof(ulong));

            return result;
        }

        public static long[] csglClone(long[] from)
        {
            long[] result = new long[from.Length];
            Buffer.BlockCopy(from, 0, result, 0, from.Length * sizeof(long));

            return result;
        }

        public static float[] csglClone(float[] from)
        {
            float[] result = new float[from.Length];
            Buffer.BlockCopy(from, 0, result, 0, from.Length * sizeof(float));

            return result;
        }

        public static double[] csglClone(double[] from)
        {
            double[] result = new double[from.Length];
            Buffer.BlockCopy(from, 0, result, 0, from.Length * sizeof(double));

            return result;
        }

        public static void csglClone(byte[] from, byte[] to)
        {
            Buffer.BlockCopy(from, 0, to, 0, to.Length);
        }

        public static void csglClone(ushort[] from, ushort[] to)
        {
            Buffer.BlockCopy(from, 0, to, 0, to.Length * sizeof(ushort));
        }

        public static void csglClone(short[] from, short[] to)
        {
            Buffer.BlockCopy(from, 0, to, 0, to.Length * sizeof(short));
        }

        public static void csglClone(uint[] from, uint[] to)
        {
            Buffer.BlockCopy(from, 0, to, 0, to.Length * sizeof(uint));
        }

        public static void csglClone(int[] from, int[] to)
        {
            Buffer.BlockCopy(from, 0, to, 0, to.Length * sizeof(int));
        }

        public static void csglClone(ulong[] from, ulong[] to)
        {
            Buffer.BlockCopy(from, 0, to, 0, to.Length * sizeof(ulong));
        }

        public static void csglClone(long[] from, long[] to)
        {
            Buffer.BlockCopy(from, 0, to, 0, to.Length * sizeof(long));
        }

        public static void csglClone(float[] from, float[] to)
        {
            Buffer.BlockCopy(from, 0, to, 0, to.Length * sizeof(float));
        }

        public static void csglClone(double[] from, double[] to)
        {
            Buffer.BlockCopy(from, 0, to, 0, to.Length * sizeof(double));
        }
        #endregion
        */
        #endregion
        #endregion

        #region Math
        #region Unsafe
#if UNSAFE
        public static float csglFastSqrt( float value )
        {
            float result = value;

            unsafe
            {
                int tmp = *(int*)&result;

                tmp -= 1 << 23;
                tmp >>= 1;
                tmp += 1 << 29;

                result = *(float*)&tmp;
            }
            return result;
        }

        public static float csglFastInvSqrt( float value )
        {
            float x = value;

            unsafe
            {
                float xhalf = 0.5f*x;

                int i = *(int*)&x;
                i = 0x5f3759df - ( i >> 1 );
                x = *(float*)&i;
                x = x * ( 1.5f - xhalf * x * x );
            }

            return x;
        }
#endif
        #endregion

        #region Safe
#if !UNSAFE
        public static float csglFastSqrt(float value) { return (float)Math.Sqrt(value); }

        public static float csglFastInvSqrt(float value) { return (float)(1.0 / Math.Sqrt(value)); }
#endif
        #endregion

        #region Vector
        #region Vector scalar
        public static void csglVectorAdd(float[] vector, float value)
        {
            for (int i = 0; i < vector.Length; i++)
                vector[i] += value;
        }

        public static void csglVectorSub(float[] vector, float value)
        {
            for (int i = 0; i < vector.Length; i++)
                vector[i] -= value;
        }

        public static void csglVectorMul(float[] vector, float value)
        {
            for (int i = 0; i < vector.Length; i++)
                vector[i] *= value;
        }

        public static void csglVectorDiv(float[] vector, float value)
        {
            for (int i = 0; i < vector.Length; i++)
                vector[i] /= value;
        }
        #endregion

        #region Vector vector
        public static void csglVectorAdd(float[] vector, float[] value)
        {
            for (int i = 0; i < vector.Length; i++)
                vector[i] += value[i];
        }

        public static void csglVectorSub(float[] vector, float[] value)
        {
            for (int i = 0; i < vector.Length; i++)
                vector[i] -= value[i];
        }

        public static void csglVectorMul(float[] vector, float[] value)
        {
            for (int i = 0; i < vector.Length; i++)
                vector[i] *= value[i];
        }

        public static void csglVectorDiv(float[] vector, float[] value)
        {
            for (int i = 0; i < vector.Length; i++)
                vector[i] /= value[i];
        }
        #endregion

        #region Vector misc
        public static float csglVectorLength(float[] vector)
        {
            float pow = 0;

            for (int i = 0; i < vector.Length; i++)
                pow += vector[i] * vector[i];

            return csglFastSqrt(pow);
        }

        public static float csglVectorDot(float[] v1, float[] v2)
        {
            float dot = 0;
            int min = v1.Length < v2.Length ? v1.Length : v2.Length;

            for (int i = 0; i < min; i++)
                dot += v1[i] * v2[i];

            return dot;
        }

        public static float[] csglVector3Cross(float[] v1, float[] v2)
        {
            return new float[3]
            {
                v1[ 1 ] * v2[ 2 ] - v1[ 2 ] * v2[ 1 ],
                v1[ 2 ] * v2[ 0 ] - v1[ 0 ] * v2[ 2 ],
                v1[ 0 ] * v2[ 1 ] - v1[ 1 ] * v2[ 0 ]
            };
        }
        #endregion
        #endregion

        #region Matrix
        #region Identity
        public static float[] csglIdentity2()
        {
            return new float[4]
            {
                1, 0,
                0, 1
            };
        }

        public static float[] csglIdentity3()
        {
            return new float[9]
            {
                1, 0, 0,
                0, 1, 0,
                0, 0, 1
            };
        }

        public static float[] csglIdentity4()
        {
            return new float[16]
            {
                1, 0, 0, 0,
                0, 1, 0, 0,
                0, 0, 1, 0,
                0, 0, 0, 1
            };
        }
        #endregion

        #region Matrix scalar
        // Vector scalar rules apply
        #endregion

        #region Matrix matrix
        public static float[] csglMatrixMul(float[] m1, float[] m2, int stride)
        {
            int rows = (int)(m1.Length / (float)stride);

            int cols0 = (int)(1 / ((float)stride / m2.Length));
            int cols1 = (int)(1 / ((float)stride / m1.Length));

            if (rows != cols0)
                return new float[0] { };

            float[] result = new float[rows * cols0];

            for (int i = 0; i < rows * cols0; i++)
                result[i] = 0f;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols0; j++)
                {
                    for (int k = 0; k < cols1; k++)
                        result[i * stride + j] += m1[i * stride + k] * m2[k * stride + j];
                }
            }

            return result;
        }
        #endregion

        #region Matrix misc
        public static void csglMatrixColumn(float[] source, ref float[] destination, int stride, int column)
        {
            for (int i = stride * column; i < stride * column + stride; i++)
                destination[i] = source[i];
        }

        public static float[] csglMatrixVector(float[] matrix, float[] vector, int stride)
        {
            int columns = (int)(1 / (vector.Length / (float)stride));

            float[] result = new float[stride];

            for (int i = 0; i < columns; i++)
            {
                float column = 0;

                for (int j = 0; j < stride; j++)
                    column += matrix[i * j + i] * vector[j];

                result[i] = column;
            }

            return result;
        }

        public static void csglMatrixScale(float[] matrix, float[] vector, int stride)
        {
            int rows = (int)(matrix.Length / (float)stride);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < stride; j++)
                    matrix[i * stride + j] *= (i < vector.Length ? vector[i] : 1);
            }
        }

        public static void csglMatrixTranslate(float[] matrix, float[] vector, int stride)
        {
            int last = matrix.Length - stride;
            int min = vector.Length < matrix.Length ? vector.Length : matrix.Length;

            for (int i = 0; i < min; i++)
            {
                for (int j = 0; j < stride; j++)
                    matrix[last + j] += matrix[i * stride + j] * vector[i];
            }
        }

        public static float[] csglMatrixOrtho(float left, float right, float bottom, float top, float zNear = 0f, float zFar = 1f)
        {
            return new float[16]
            {
                2f / ( right - left ), 0, 0, 0,
                0, 2f / ( top - bottom ), 0, 0,
                0, 0, -2f / ( zFar - zNear ), 0,
                -( right + left )/( right - left ), -( top + bottom )/( top - bottom ), -( zFar + zNear )/( zFar - zNear ), 1
            };
        }
        #endregion

        #endregion
        #endregion
    }
}
