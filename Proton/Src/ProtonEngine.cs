#region Include
using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Reflection;
using System.Collections.Generic;
using System.Runtime.InteropServices;
#endregion

namespace Proton
{
    using static Glfw;
    using static CSGL;
    using static GL11;

    public static class ProtonEngine
    {
        static IntPtr window;

        public static void Launch(EngineAdapter adapter, LaunchParams lParams)
        {
            csglLoadGlfw();
            glfwInit();

            window = glfwCreateWindow(lParams.width, lParams.height, lParams.title, IntPtr.Zero, IntPtr.Zero);
            glfwMakeContextCurrent(window);
            csglLoadGL();

            while (glfwWindowShouldClose(window) == 0)
            {
                glfwSwapBuffers(window);
                glClearColor(0.0f, 0.47f, 0.84f, 1.0f);
                glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
                glfwPollEvents();
            }

            glfwTerminate();
        }
    }

    public interface EngineAdapter
    {
        void Start();
        void Update();
        void Stop();
    }

    public struct LaunchParams
    {
        public int width;
        public int height;
        public string title;

        public LaunchParams(int width, int height, string title)
        {
            this.width = width;
            this.height = height;
            this.title = title;
        }
    }
}
