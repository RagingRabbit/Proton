using System;
using System.Runtime.InteropServices;

namespace Proton
{
    static class GL31
    {
        #region Constants
        public const uint GL_SAMPLER_2D_RECT = 35683;
        public const uint GL_SAMPLER_2D_RECT_SHADOW = 35684;
        public const uint GL_SAMPLER_BUFFER = 36290;
        public const uint GL_INT_SAMPLER_2D_RECT = 36301;
        public const uint GL_INT_SAMPLER_BUFFER = 36304;
        public const uint GL_UNSIGNED_INT_SAMPLER_2D_RECT = 36309;
        public const uint GL_UNSIGNED_INT_SAMPLER_BUFFER = 36312;
        public const uint GL_TEXTURE_BUFFER = 35882;
        public const uint GL_MAX_TEXTURE_BUFFER_SIZE = 35883;
        public const uint GL_TEXTURE_BINDING_BUFFER = 35884;
        public const uint GL_TEXTURE_BUFFER_DATA_STORE_BINDING = 35885;
        public const uint GL_TEXTURE_RECTANGLE = 34037;
        public const uint GL_TEXTURE_BINDING_RECTANGLE = 34038;
        public const uint GL_PROXY_TEXTURE_RECTANGLE = 34039;
        public const uint GL_MAX_RECTANGLE_TEXTURE_SIZE = 34040;
        public const uint GL_R8_SNORM = 36756;
        public const uint GL_RG8_SNORM = 36757;
        public const uint GL_RGB8_SNORM = 36758;
        public const uint GL_RGBA8_SNORM = 36759;
        public const uint GL_R16_SNORM = 36760;
        public const uint GL_RG16_SNORM = 36761;
        public const uint GL_RGB16_SNORM = 36762;
        public const uint GL_RGBA16_SNORM = 36763;
        public const uint GL_SIGNED_NORMALIZED = 36764;
        public const uint GL_PRIMITIVE_RESTART = 36765;
        public const uint GL_PRIMITIVE_RESTART_INDEX = 36766;
        public const uint GL_COPY_READ_BUFFER = 36662;
        public const uint GL_COPY_WRITE_BUFFER = 36663;
        public const uint GL_UNIFORM_BUFFER = 35345;
        public const uint GL_UNIFORM_BUFFER_BINDING = 35368;
        public const uint GL_UNIFORM_BUFFER_START = 35369;
        public const uint GL_UNIFORM_BUFFER_SIZE = 35370;
        public const uint GL_MAX_VERTEX_UNIFORM_BLOCKS = 35371;
        public const uint GL_MAX_GEOMETRY_UNIFORM_BLOCKS = 35372;
        public const uint GL_MAX_FRAGMENT_UNIFORM_BLOCKS = 35373;
        public const uint GL_MAX_COMBINED_UNIFORM_BLOCKS = 35374;
        public const uint GL_MAX_UNIFORM_BUFFER_BINDINGS = 35375;
        public const uint GL_MAX_UNIFORM_BLOCK_SIZE = 35376;
        public const uint GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 35377;
        public const uint GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS = 35378;
        public const uint GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 35379;
        public const uint GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT = 35380;
        public const uint GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 35381;
        public const uint GL_ACTIVE_UNIFORM_BLOCKS = 35382;
        public const uint GL_UNIFORM_TYPE = 35383;
        public const uint GL_UNIFORM_SIZE = 35384;
        public const uint GL_UNIFORM_NAME_LENGTH = 35385;
        public const uint GL_UNIFORM_BLOCK_INDEX = 35386;
        public const uint GL_UNIFORM_OFFSET = 35387;
        public const uint GL_UNIFORM_ARRAY_STRIDE = 35388;
        public const uint GL_UNIFORM_MATRIX_STRIDE = 35389;
        public const uint GL_UNIFORM_IS_ROW_MAJOR = 35390;
        public const uint GL_UNIFORM_BLOCK_BINDING = 35391;
        public const uint GL_UNIFORM_BLOCK_DATA_SIZE = 35392;
        public const uint GL_UNIFORM_BLOCK_NAME_LENGTH = 35393;
        public const uint GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS = 35394;
        public const uint GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 35395;
        public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 35396;
        public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER = 35397;
        public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 35398;
        public const uint GL_INVALID_INDEX = 4294967295;
        #endregion

        #region Delegates
        public delegate void PFNGLDRAWARRAYSINSTANCEDPROC(uint mode, int first, int count, int instancecount);
        public delegate void PFNGLDRAWELEMENTSINSTANCEDPROC(uint mode, int count, uint type, IntPtr indices, int instancecount);
        public delegate void PFNGLTEXBUFFERPROC(uint target, uint internalformat, uint buffer);
        public delegate void PFNGLPRIMITIVERESTARTINDEXPROC(uint index);
        public delegate void PFNGLCOPYBUFFERSUBDATAPROC(uint readTarget, uint writeTarget, int readOffset, int writeOffset, int size);
        public delegate void PFNGLGETUNIFORMINDICESPROC(uint program, int uniformCount, IntPtr uniformNames, ref uint uniformIndices);
        public delegate void PFNGLGETACTIVEUNIFORMSIVPROC(uint program, int uniformCount, ref uint uniformIndices, uint pname, ref int parameters);
        public delegate void PFNGLGETACTIVEUNIFORMNAMEPROC(uint program, uint uniformIndex, int bufSize, ref int length, IntPtr uniformName);
        public delegate uint PFNGLGETUNIFORMBLOCKINDEXPROC(uint program, [In] [MarshalAs(UnmanagedType.LPStr)] string uniformBlockName);
        public delegate void PFNGLGETACTIVEUNIFORMBLOCKIVPROC(uint program, uint uniformBlockIndex, uint pname, ref int parameters);
        public delegate void PFNGLGETACTIVEUNIFORMBLOCKNAMEPROC(uint program, uint uniformBlockIndex, int bufSize, ref int length, IntPtr uniformBlockName);
        public delegate void PFNGLUNIFORMBLOCKBINDINGPROC(uint program, uint uniformBlockIndex, uint uniformBlockBinding);
        #endregion

        #region Methods
#pragma warning disable 0649
        public static PFNGLDRAWARRAYSINSTANCEDPROC glDrawArraysInstanced;
        public static PFNGLDRAWELEMENTSINSTANCEDPROC glDrawElementsInstanced;
        public static PFNGLTEXBUFFERPROC glTexBuffer;
        public static PFNGLPRIMITIVERESTARTINDEXPROC glPrimitiveRestartIndex;
        public static PFNGLCOPYBUFFERSUBDATAPROC glCopyBufferSubData;
        public static PFNGLGETUNIFORMINDICESPROC glGetUniformIndices;
        public static PFNGLGETACTIVEUNIFORMSIVPROC glGetActiveUniformsiv;
        public static PFNGLGETACTIVEUNIFORMNAMEPROC glGetActiveUniformName;
        public static PFNGLGETUNIFORMBLOCKINDEXPROC glGetUniformBlockIndex;
        public static PFNGLGETACTIVEUNIFORMBLOCKIVPROC glGetActiveUniformBlockiv;
        public static PFNGLGETACTIVEUNIFORMBLOCKNAMEPROC glGetActiveUniformBlockName;
        public static PFNGLUNIFORMBLOCKBINDINGPROC glUniformBlockBinding;
        #endregion
    }
}
