using System;
using System.Collections.Generic;

namespace Proton
{
    using static Glfw;

    public static class Input
    {
        static Input()
        {
            keys = new bool[GLFW_KEY_LAST];
            buttons = new bool[GLFW_MOUSE_BUTTON_LAST];

            keyListeners = new List<KeyListener>();
            cursorPosListeners = new List<CursorPosListener>();
        }

        static IntPtr win;
        static bool[] keys;
        static bool[] buttons;
        static double curX, curY;

        static GLFWkeyfun keyCallback;

        static List<KeyListener> keyListeners;
        static List<CursorPosListener> cursorPosListeners;

        internal static void Initialize(IntPtr window)
        {
            win = window;

            keyCallback = HandleGLFWkeyfun;

            glfwGetCursorPos(window, ref curX, ref curY);

            glfwSetKeyCallback(window, keyCallback);
            glfwSetMouseButtonCallback(window, HandleGLFWmousebuttonfun);
            glfwSetScrollCallback(window, HandleGLFWscrollfun);
            glfwSetCursorPosCallback(window, HandleGLFWcursorposfun);
        }

        static void HandleGLFWkeyfun(IntPtr window, int key, int scancode, int action, int mods)
        {
            keys[key] = action != GLFW_RELEASE;
            foreach (KeyListener listener in keyListeners)
            {
                listener.OnKeyEvent((KeyCode)key, action != GLFW_RELEASE, (KeyMod)mods);
            }
        }

        static void HandleGLFWmousebuttonfun(IntPtr window, int button, int action, int mods)
        {
            buttons[button] = action != GLFW_RELEASE;
        }

        static void HandleGLFWscrollfun(IntPtr window, double xoffset, double yoffset)
        {
        }

        static void HandleGLFWcursorposfun(IntPtr window, double x, double y)
        {
            if (x != curX || y != curY)
            {
                foreach (CursorPosListener listener in cursorPosListeners)
                {
                    listener.OnCursorMove((int)(x - curX), (int)(y - curY));
                }
                curX = (int)x;
                curY = (int)y;
            }
        }

        public static void AddKeyListener(KeyListener listener)
        {
            keyListeners.Add(listener);
        }

        public static void AddCursorPosListener(CursorPosListener listener)
        {
            cursorPosListeners.Add(listener);
        }

        public static bool GetKeyDown(KeyCode key)
        {
            return keys[(int)key];
        }

        public static bool GetButtonDown(MouseButton button)
        {
            return buttons[(int)button];
        }

        public static Vector2i cursorPosition
        {
            get { return new Vector2i((int)curX, (int)curY); }
            set { glfwSetCursorPos(win, value.x, value.y); }
        }

        public static CursorMode cursorMode
        {
            set { glfwSetInputMode(win, GLFW_CURSOR, (int)value); }
        }
    }

    public interface KeyListener
    {
        void OnKeyEvent(KeyCode key, bool down, KeyMod mods);
    }

    public interface CursorPosListener
    {
        void OnCursorMove(int dx, int dy);
    }

    public enum CursorMode
    {
        Normal = GLFW_CURSOR_NORMAL,
        Hidden = GLFW_CURSOR_HIDDEN,
        Disabled = GLFW_CURSOR_DISABLED
    }

    public enum KeyCode
    {
        Unknown = -1,
        Space = 32,
        Apostrophe = 39,
        Comma = 44,
        Minus = 45,
        Period = 46,
        Slash = 47,
        Num0 = 48,
        Num1 = 49,
        Num2 = 50,
        Num3 = 51,
        Num4 = 52,
        Num5 = 53,
        Num6 = 54,
        Num7 = 55,
        Num8 = 56,
        Num9 = 57,
        Semicolon = 59,
        Equal = 61,
        A = 65,
        B = 66,
        C = 67,
        D = 68,
        E = 69,
        F = 70,
        G = 71,
        H = 72,
        I = 73,
        J = 74,
        K = 75,
        L = 76,
        M = 77,
        N = 78,
        O = 79,
        P = 80,
        Q = 81,
        R = 82,
        S = 83,
        T = 84,
        U = 85,
        V = 86,
        W = 87,
        X = 88,
        Y = 89,
        Z = 90,
        LeftBracket = 91,
        Backslash = 92,
        RightBracket = 93,
        GRAVE_ACCENT = 96,
        World1 = 161,
        World2 = 162,
        Escape = 256,
        Enter = 257,
        Tab = 258,
        Backspace = 259,
        Insert = 260,
        Delete = 261,
        Right = 262,
        Left = 263,
        Down = 264,
        Up = 265,
        PageUp = 266,
        PageDown = 267,
        Home = 268,
        End = 269,
        CapsLock = 280,
        ScrollLock = 281,
        NumLock = 282,
        PrintScreen = 283,
        Pause = 284,
        F1 = 290,
        F2 = 291,
        F3 = 292,
        F4 = 293,
        F5 = 294,
        F6 = 295,
        F7 = 296,
        F8 = 297,
        F9 = 298,
        F10 = 299,
        F11 = 300,
        F12 = 301,
        F13 = 302,
        F14 = 303,
        F15 = 304,
        F16 = 305,
        F17 = 306,
        F18 = 307,
        F19 = 308,
        F20 = 309,
        F21 = 310,
        F22 = 311,
        F23 = 312,
        F24 = 313,
        F25 = 314,
        Kp0 = 320,
        Kp1 = 321,
        Kp2 = 322,
        Kp3 = 323,
        Kp4 = 324,
        Kp5 = 325,
        Kp6 = 326,
        Kp7 = 327,
        Kp8 = 328,
        Kp9 = 329,
        KpDecimal = 330,
        KpDivide = 331,
        KpMultiply = 332,
        KpSubtract = 333,
        KpAdd = 334,
        KpEnter = 335,
        KpEqual = 336,
        LeftShift = 340,
        LeftControl = 341,
        LeftAlt = 342,
        LeftSuper = 343,
        RightShift = 344,
        RightControl = 345,
        RightAlt = 346,
        RightSuper = 347,
        Menu = 348,
        Last = Menu
    }

    public enum KeyMod
    {
        Shift = 1,
        Control = 2,
        Alt = 4,
        Super = 8
    }

    public enum MouseButton
    {
        Button0 = 0,
        Button1 = 1,
        Button2 = 2,
        Button3 = 3,
        Button4 = 4,
        Button5 = 5,
        Button6 = 6,
        Button7 = 7,
        Left = 0,
        Right = 1,
        Middle = 2,
        Last = Button7
    }

    public enum JoystickButton
    {
        Button0 = 0,
        Button1 = 1,
        Button2 = 2,
        Button3 = 3,
        Button4 = 4,
        Button5 = 5,
        Button6 = 6,
        Button7 = 7,
        Button8 = 8,
        Button9 = 9,
        Button10 = 10,
        Button11 = 11,
        Button12 = 12,
        Button13 = 13,
        Button14 = 14,
        Button15 = 15,
        Last = Button15
    }
}

