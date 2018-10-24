using System;

namespace Proton
{
    using static GL11;

    public static class Graphics
    {
        private static Color _backgroundColor = new Color();

        public static Color backgroundColor
        {
            get { return _backgroundColor; }
            set
            {
                _backgroundColor = value;
                glClearColor(value.r / 255.0f, value.g / 255.0f, value.b / 255.0f, value.a / 255.0f);
            }
        }
    }
}
