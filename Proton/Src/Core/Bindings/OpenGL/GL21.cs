using System;

namespace Proton
{
    static class GL21
    {
        #region Constants
        public const uint GL_PIXEL_PACK_BUFFER = 35051;
        public const uint GL_PIXEL_UNPACK_BUFFER = 35052;
        public const uint GL_PIXEL_PACK_BUFFER_BINDING = 35053;
        public const uint GL_PIXEL_UNPACK_BUFFER_BINDING = 35055;
        public const uint GL_FLOAT_MAT2x3 = 35685;
        public const uint GL_FLOAT_MAT2x4 = 35686;
        public const uint GL_FLOAT_MAT3x2 = 35687;
        public const uint GL_FLOAT_MAT3x4 = 35688;
        public const uint GL_FLOAT_MAT4x2 = 35689;
        public const uint GL_FLOAT_MAT4x3 = 35690;
        public const uint GL_SRGB = 35904;
        public const uint GL_SRGB8 = 35905;
        public const uint GL_SRGB_ALPHA = 35906;
        public const uint GL_SRGB8_ALPHA8 = 35907;
        public const uint GL_COMPRESSED_SRGB = 35912;
        public const uint GL_COMPRESSED_SRGB_ALPHA = 35913;
        #endregion

        #region Delegates
        public delegate void PFNGLUNIFORMMATRIX2X3FVPROC(int location, int count, byte transpose, ref float value);
        public delegate void PFNGLUNIFORMMATRIX3X2FVPROC(int location, int count, byte transpose, ref float value);
        public delegate void PFNGLUNIFORMMATRIX2X4FVPROC(int location, int count, byte transpose, ref float value);
        public delegate void PFNGLUNIFORMMATRIX4X2FVPROC(int location, int count, byte transpose, ref float value);
        public delegate void PFNGLUNIFORMMATRIX3X4FVPROC(int location, int count, byte transpose, ref float value);
        public delegate void PFNGLUNIFORMMATRIX4X3FVPROC(int location, int count, byte transpose, ref float value);
        #endregion

        #region Methods
#pragma warning disable 0649
        public static PFNGLUNIFORMMATRIX2X3FVPROC glUniformMatrix2x3fv;
        public static PFNGLUNIFORMMATRIX3X2FVPROC glUniformMatrix3x2fv;
        public static PFNGLUNIFORMMATRIX2X4FVPROC glUniformMatrix2x4fv;
        public static PFNGLUNIFORMMATRIX4X2FVPROC glUniformMatrix4x2fv;
        public static PFNGLUNIFORMMATRIX3X4FVPROC glUniformMatrix3x4fv;
        public static PFNGLUNIFORMMATRIX4X3FVPROC glUniformMatrix4x3fv;
        #endregion
    }
}
