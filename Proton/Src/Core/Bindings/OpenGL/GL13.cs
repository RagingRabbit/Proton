using System;

namespace Proton
{
    static class GL13
    {
        #region Constants
        public const uint GL_TEXTURE0 = 33984;
        public const uint GL_TEXTURE1 = 33985;
        public const uint GL_TEXTURE2 = 33986;
        public const uint GL_TEXTURE3 = 33987;
        public const uint GL_TEXTURE4 = 33988;
        public const uint GL_TEXTURE5 = 33989;
        public const uint GL_TEXTURE6 = 33990;
        public const uint GL_TEXTURE7 = 33991;
        public const uint GL_TEXTURE8 = 33992;
        public const uint GL_TEXTURE9 = 33993;
        public const uint GL_TEXTURE10 = 33994;
        public const uint GL_TEXTURE11 = 33995;
        public const uint GL_TEXTURE12 = 33996;
        public const uint GL_TEXTURE13 = 33997;
        public const uint GL_TEXTURE14 = 33998;
        public const uint GL_TEXTURE15 = 33999;
        public const uint GL_TEXTURE16 = 34000;
        public const uint GL_TEXTURE17 = 34001;
        public const uint GL_TEXTURE18 = 34002;
        public const uint GL_TEXTURE19 = 34003;
        public const uint GL_TEXTURE20 = 34004;
        public const uint GL_TEXTURE21 = 34005;
        public const uint GL_TEXTURE22 = 34006;
        public const uint GL_TEXTURE23 = 34007;
        public const uint GL_TEXTURE24 = 34008;
        public const uint GL_TEXTURE25 = 34009;
        public const uint GL_TEXTURE26 = 34010;
        public const uint GL_TEXTURE27 = 34011;
        public const uint GL_TEXTURE28 = 34012;
        public const uint GL_TEXTURE29 = 34013;
        public const uint GL_TEXTURE30 = 34014;
        public const uint GL_TEXTURE31 = 34015;
        public const uint GL_ACTIVE_TEXTURE = 34016;
        public const uint GL_MULTISAMPLE = 32925;
        public const uint GL_SAMPLE_ALPHA_TO_COVERAGE = 32926;
        public const uint GL_SAMPLE_ALPHA_TO_ONE = 32927;
        public const uint GL_SAMPLE_COVERAGE = 32928;
        public const uint GL_SAMPLE_BUFFERS = 32936;
        public const uint GL_SAMPLES = 32937;
        public const uint GL_SAMPLE_COVERAGE_VALUE = 32938;
        public const uint GL_SAMPLE_COVERAGE_INVERT = 32939;
        public const uint GL_TEXTURE_CUBE_MAP = 34067;
        public const uint GL_TEXTURE_BINDING_CUBE_MAP = 34068;
        public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_X = 34069;
        public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 34070;
        public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 34071;
        public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 34072;
        public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 34073;
        public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 34074;
        public const uint GL_PROXY_TEXTURE_CUBE_MAP = 34075;
        public const uint GL_MAX_CUBE_MAP_TEXTURE_SIZE = 34076;
        public const uint GL_COMPRESSED_RGB = 34029;
        public const uint GL_COMPRESSED_RGBA = 34030;
        public const uint GL_TEXTURE_COMPRESSION_HINT = 34031;
        public const uint GL_TEXTURE_COMPRESSED_IMAGE_SIZE = 34464;
        public const uint GL_TEXTURE_COMPRESSED = 34465;
        public const uint GL_NUM_COMPRESSED_TEXTURE_FORMATS = 34466;
        public const uint GL_COMPRESSED_TEXTURE_FORMATS = 34467;
        public const uint GL_CLAMP_TO_BORDER = 33069;
        #endregion

        #region Delegates
        public delegate void PFNGLACTIVETEXTUREPROC(uint texture);
        public delegate void PFNGLSAMPLECOVERAGEPROC(float value, byte invert);
        public delegate void PFNGLCOMPRESSEDTEXIMAGE3DPROC(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data);
        public delegate void PFNGLCOMPRESSEDTEXIMAGE2DPROC(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, IntPtr data);
        public delegate void PFNGLCOMPRESSEDTEXIMAGE1DPROC(uint target, int level, uint internalformat, int width, int border, int imageSize, IntPtr data);
        public delegate void PFNGLCOMPRESSEDTEXSUBIMAGE3DPROC(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data);
        public delegate void PFNGLCOMPRESSEDTEXSUBIMAGE2DPROC(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data);
        public delegate void PFNGLCOMPRESSEDTEXSUBIMAGE1DPROC(uint target, int level, int xoffset, int width, uint format, int imageSize, IntPtr data);
        public delegate void PFNGLGETCOMPRESSEDTEXIMAGEPROC(uint target, int level, IntPtr img);
        #endregion

        #region Methods
#pragma warning disable 0649
        public static PFNGLACTIVETEXTUREPROC glActiveTexture;
        public static PFNGLSAMPLECOVERAGEPROC glSampleCoverage;
        public static PFNGLCOMPRESSEDTEXIMAGE3DPROC glCompressedTexImage3D;
        public static PFNGLCOMPRESSEDTEXIMAGE2DPROC glCompressedTexImage2D;
        public static PFNGLCOMPRESSEDTEXIMAGE1DPROC glCompressedTexImage1D;
        public static PFNGLCOMPRESSEDTEXSUBIMAGE3DPROC glCompressedTexSubImage3D;
        public static PFNGLCOMPRESSEDTEXSUBIMAGE2DPROC glCompressedTexSubImage2D;
        public static PFNGLCOMPRESSEDTEXSUBIMAGE1DPROC glCompressedTexSubImage1D;
        public static PFNGLGETCOMPRESSEDTEXIMAGEPROC glGetCompressedTexImage;
        #endregion
    }
}
