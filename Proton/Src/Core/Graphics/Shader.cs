using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Proton
{
    using static GL11;
    using static GL13;
    using static GL20;
    using static GL30;

    public class Shader
    {
        uint program;
        uint vertex;
        uint fragment;

        public Shader(string vertexSrc, string fragmentSrc)
        {
            program = glCreateProgram();
            vertex = loadShader(vertexSrc, GL_VERTEX_SHADER);
            fragment = loadShader(fragmentSrc, GL_FRAGMENT_SHADER);

            glAttachShader(program, vertex);
            glAttachShader(program, fragment);
            glLinkProgram(program);
            glValidateProgram(program);

            glDeleteShader(vertex);
            glDeleteShader(fragment);
        }

        public void Dispose()
        {
            glDetachShader(program, vertex);
            glDetachShader(program, fragment);
            glDeleteProgram(program);
            program = 0;
        }

        public void Enable()
        {
            glUseProgram(program);
        }

        public void Disable()
        {
            glUseProgram(0);
        }

        public void SetVariable(string name, Matrix4 mat)
        {
            glUniformMatrix4fv(GetUniformLocation(name), 1, GL_TRUE, ref mat.m00);
        }

        public void SetVariable(string name, bool b)
        {
            glUniform1i(GetUniformLocation(name), b ? 1 : 0);
        }

        public void BindTexture(string name, Texture texture, uint unit)
        {
            texture.Bind(unit);
            glUniform1ui(GetUniformLocation(name), unit);
        }

        int GetUniformLocation(string name)
        {
            return glGetUniformLocation(program, name);
        }

        uint loadShader(string source, uint type)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(source);
            IntPtr sourcePtr = Marshal.AllocHGlobal(bytes.Length);
            Marshal.Copy(bytes, 0, sourcePtr, bytes.Length);

            uint shader = glCreateShader(type);
            int length = bytes.Length;
            glShaderSource(shader, 1, ref sourcePtr, ref length);
            glCompileShader(shader);

            int result = 0;
            glGetShaderiv(shader, GL_COMPILE_STATUS, ref result);
            if (result == GL_FALSE)
            {
                int logLength = 0;
                glGetShaderiv(shader, GL_INFO_LOG_LENGTH, ref logLength);
                IntPtr logPtr = Marshal.AllocHGlobal(logLength * sizeof(char));
                glGetShaderInfoLog(shader, logLength, ref logLength, logPtr);
                byte[] logBytes = new byte[logLength];
                Marshal.Copy(logPtr, logBytes, 0, logLength);
                Marshal.FreeHGlobal(logPtr);
                string log = Encoding.ASCII.GetString(logBytes);
                Console.Error.WriteLine("Failed to compile " + (type == GL_VERTEX_SHADER ? "vertex shader" : "fragment shader") + ":\n" + log);

                return 0;
            }

            Marshal.FreeHGlobal(sourcePtr);

            return shader;
        }
    }
}
