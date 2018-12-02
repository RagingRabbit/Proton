using System;

namespace Proton
{
    static class GL44
    {
        #region Constants
        public const uint GL_MAX_VERTEX_ATTRIB_STRIDE = 33509;
        public const uint GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED = 33313;
        public const uint GL_TEXTURE_BUFFER_BINDING = 35882;
        public const int GL_MAP_PERSISTENT_BIT = 64;
        public const int GL_MAP_COHERENT_BIT = 128;
        public const int GL_DYNAMIC_STORAGE_BIT = 256;
        public const int GL_CLIENT_STORAGE_BIT = 512;
        public const int GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT = 16384;
        public const uint GL_BUFFER_IMMUTABLE_STORAGE = 33311;
        public const uint GL_BUFFER_STORAGE_FLAGS = 33312;
        public const uint GL_CLEAR_TEXTURE = 37733;
        public const uint GL_LOCATION_COMPONENT = 37706;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_INDEX = 37707;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_STRIDE = 37708;
        public const uint GL_QUERY_BUFFER = 37266;
        public const uint GL_QUERY_BUFFER_BARRIER_BIT = 32768;
        public const uint GL_QUERY_BUFFER_BINDING = 37267;
        public const uint GL_QUERY_RESULT_NO_WAIT = 37268;
        public const uint GL_MIRROR_CLAMP_TO_EDGE = 34627;
        #endregion

        #region Delegates
        public delegate void PFNGLBUFFERSTORAGEPROC(uint target, int size, IntPtr data, uint flags);
        public delegate void PFNGLCLEARTEXIMAGEPROC(uint texture, int level, uint format, uint type, IntPtr data);
        public delegate void PFNGLCLEARTEXSUBIMAGEPROC(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr data);
        public delegate void PFNGLBINDBUFFERSBASEPROC(uint target, uint first, int count, ref uint buffers);
        public delegate void PFNGLBINDBUFFERSRANGEPROC(uint target, uint first, int count, ref uint buffers, ref int offsets, ref int sizes);
        public delegate void PFNGLBINDTEXTURESPROC(uint first, int count, ref uint textures);
        public delegate void PFNGLBINDSAMPLERSPROC(uint first, int count, ref uint samplers);
        public delegate void PFNGLBINDIMAGETEXTURESPROC(uint first, int count, ref uint textures);
        public delegate void PFNGLBINDVERTEXBUFFERSPROC(uint first, int count, ref uint buffers, ref int offsets, ref int strides);
        #endregion

        #region Methods
#pragma warning disable 0649
        public static PFNGLBUFFERSTORAGEPROC glBufferStorage;
        public static PFNGLCLEARTEXIMAGEPROC glClearTexImage;
        public static PFNGLCLEARTEXSUBIMAGEPROC glClearTexSubImage;
        public static PFNGLBINDBUFFERSBASEPROC glBindBuffersBase;
        public static PFNGLBINDBUFFERSRANGEPROC glBindBuffersRange;
        public static PFNGLBINDTEXTURESPROC glBindTextures;
        public static PFNGLBINDSAMPLERSPROC glBindSamplers;
        public static PFNGLBINDIMAGETEXTURESPROC glBindImageTextures;
        public static PFNGLBINDVERTEXBUFFERSPROC glBindVertexBuffers;
        #endregion
    }
}
