using System;

namespace Proton
{
    using static Glfw;

    public static class Display
    {
        public static int width
        {
            get
            {
                int w = 0, h = 0;
                glfwGetWindowSize(ProtonEngine.window, ref w, ref h);
                return w;
            }
        }

        public static int height
        {
            get
            {
                int w = 0, h = 0;
                glfwGetWindowSize(ProtonEngine.window, ref w, ref h);
                return h;
            }
        }

        public static string title
        {
            set
            {
                glfwSetWindowTitle(ProtonEngine.window, value);
            }
        }

        public static bool vsync
        {
            set
            {
                glfwSwapInterval(value ? 1 : 0);
            }
        }
    }
}
