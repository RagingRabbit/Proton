using System;

namespace Proton
{
    static class GL42
    {
        #region Constants
        public const uint GL_COPY_READ_BUFFER_BINDING = 36662;
        public const uint GL_COPY_WRITE_BUFFER_BINDING = 36663;
        public const uint GL_TRANSFORM_FEEDBACK_ACTIVE = 36388;
        public const uint GL_TRANSFORM_FEEDBACK_PAUSED = 36387;
        public const uint GL_UNPACK_COMPRESSED_BLOCK_WIDTH = 37159;
        public const uint GL_UNPACK_COMPRESSED_BLOCK_HEIGHT = 37160;
        public const uint GL_UNPACK_COMPRESSED_BLOCK_DEPTH = 37161;
        public const uint GL_UNPACK_COMPRESSED_BLOCK_SIZE = 37162;
        public const uint GL_PACK_COMPRESSED_BLOCK_WIDTH = 37163;
        public const uint GL_PACK_COMPRESSED_BLOCK_HEIGHT = 37164;
        public const uint GL_PACK_COMPRESSED_BLOCK_DEPTH = 37165;
        public const uint GL_PACK_COMPRESSED_BLOCK_SIZE = 37166;
        public const uint GL_NUM_SAMPLE_COUNTS = 37760;
        public const uint GL_MIN_MAP_BUFFER_ALIGNMENT = 37052;
        public const uint GL_ATOMIC_COUNTER_BUFFER = 37568;
        public const uint GL_ATOMIC_COUNTER_BUFFER_BINDING = 37569;
        public const uint GL_ATOMIC_COUNTER_BUFFER_START = 37570;
        public const uint GL_ATOMIC_COUNTER_BUFFER_SIZE = 37571;
        public const uint GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE = 37572;
        public const uint GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS = 37573;
        public const uint GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES = 37574;
        public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER = 37575;
        public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER = 37576;
        public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER = 37577;
        public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER = 37578;
        public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER = 37579;
        public const uint GL_MAX_VERTEX_ATOMIC_COUNTER_BUFFERS = 37580;
        public const uint GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS = 37581;
        public const uint GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS = 37582;
        public const uint GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS = 37583;
        public const uint GL_MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS = 37584;
        public const uint GL_MAX_COMBINED_ATOMIC_COUNTER_BUFFERS = 37585;
        public const uint GL_MAX_VERTEX_ATOMIC_COUNTERS = 37586;
        public const uint GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS = 37587;
        public const uint GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS = 37588;
        public const uint GL_MAX_GEOMETRY_ATOMIC_COUNTERS = 37589;
        public const uint GL_MAX_FRAGMENT_ATOMIC_COUNTERS = 37590;
        public const uint GL_MAX_COMBINED_ATOMIC_COUNTERS = 37591;
        public const uint GL_MAX_ATOMIC_COUNTER_BUFFER_SIZE = 37592;
        public const uint GL_MAX_ATOMIC_COUNTER_BUFFER_BINDINGS = 37596;
        public const uint GL_ACTIVE_ATOMIC_COUNTER_BUFFERS = 37593;
        public const uint GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 37594;
        public const uint GL_UNSIGNED_INT_ATOMIC_COUNTER = 37595;
        public const int GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 1;
        public const int GL_ELEMENT_ARRAY_BARRIER_BIT = 2;
        public const int GL_UNIFORM_BARRIER_BIT = 4;
        public const int GL_TEXTURE_FETCH_BARRIER_BIT = 8;
        public const int GL_SHADER_IMAGE_ACCESS_BARRIER_BIT = 32;
        public const int GL_COMMAND_BARRIER_BIT = 64;
        public const int GL_PIXEL_BUFFER_BARRIER_BIT = 128;
        public const int GL_TEXTURE_UPDATE_BARRIER_BIT = 256;
        public const int GL_BUFFER_UPDATE_BARRIER_BIT = 512;
        public const int GL_FRAMEBUFFER_BARRIER_BIT = 1024;
        public const int GL_TRANSFORM_FEEDBACK_BARRIER_BIT = 2048;
        public const int GL_ATOMIC_COUNTER_BARRIER_BIT = 4096;
        public const int GL_ALL_BARRIER_BITS = -1;
        public const uint GL_MAX_IMAGE_UNITS = 36664;
        public const uint GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS = 36665;
        public const uint GL_IMAGE_BINDING_NAME = 36666;
        public const uint GL_IMAGE_BINDING_LEVEL = 36667;
        public const uint GL_IMAGE_BINDING_LAYERED = 36668;
        public const uint GL_IMAGE_BINDING_LAYER = 36669;
        public const uint GL_IMAGE_BINDING_ACCESS = 36670;
        public const uint GL_IMAGE_1D = 36940;
        public const uint GL_IMAGE_2D = 36941;
        public const uint GL_IMAGE_3D = 36942;
        public const uint GL_IMAGE_2D_RECT = 36943;
        public const uint GL_IMAGE_CUBE = 36944;
        public const uint GL_IMAGE_BUFFER = 36945;
        public const uint GL_IMAGE_1D_ARRAY = 36946;
        public const uint GL_IMAGE_2D_ARRAY = 36947;
        public const uint GL_IMAGE_CUBE_MAP_ARRAY = 36948;
        public const uint GL_IMAGE_2D_MULTISAMPLE = 36949;
        public const uint GL_IMAGE_2D_MULTISAMPLE_ARRAY = 36950;
        public const uint GL_INT_IMAGE_1D = 36951;
        public const uint GL_INT_IMAGE_2D = 36952;
        public const uint GL_INT_IMAGE_3D = 36953;
        public const uint GL_INT_IMAGE_2D_RECT = 36954;
        public const uint GL_INT_IMAGE_CUBE = 36955;
        public const uint GL_INT_IMAGE_BUFFER = 36956;
        public const uint GL_INT_IMAGE_1D_ARRAY = 36957;
        public const uint GL_INT_IMAGE_2D_ARRAY = 36958;
        public const uint GL_INT_IMAGE_CUBE_MAP_ARRAY = 36959;
        public const uint GL_INT_IMAGE_2D_MULTISAMPLE = 36960;
        public const uint GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 36961;
        public const uint GL_UNSIGNED_INT_IMAGE_1D = 36962;
        public const uint GL_UNSIGNED_INT_IMAGE_2D = 36963;
        public const uint GL_UNSIGNED_INT_IMAGE_3D = 36964;
        public const uint GL_UNSIGNED_INT_IMAGE_2D_RECT = 36965;
        public const uint GL_UNSIGNED_INT_IMAGE_CUBE = 36966;
        public const uint GL_UNSIGNED_INT_IMAGE_BUFFER = 36967;
        public const uint GL_UNSIGNED_INT_IMAGE_1D_ARRAY = 36968;
        public const uint GL_UNSIGNED_INT_IMAGE_2D_ARRAY = 36969;
        public const uint GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 36970;
        public const uint GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE = 36971;
        public const uint GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 36972;
        public const uint GL_MAX_IMAGE_SAMPLES = 36973;
        public const uint GL_IMAGE_BINDING_FORMAT = 36974;
        public const uint GL_IMAGE_FORMAT_COMPATIBILITY_TYPE = 37063;
        public const uint GL_IMAGE_FORMAT_COMPATIBILITY_BY_SIZE = 37064;
        public const uint GL_IMAGE_FORMAT_COMPATIBILITY_BY_CLASS = 37065;
        public const uint GL_MAX_VERTEX_IMAGE_UNIFORMS = 37066;
        public const uint GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS = 37067;
        public const uint GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS = 37068;
        public const uint GL_MAX_GEOMETRY_IMAGE_UNIFORMS = 37069;
        public const uint GL_MAX_FRAGMENT_IMAGE_UNIFORMS = 37070;
        public const uint GL_MAX_COMBINED_IMAGE_UNIFORMS = 37071;
        public const uint GL_COMPRESSED_RGBA_BPTC_UNORM = 36492;
        public const uint GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 36493;
        public const uint GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 36494;
        public const uint GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 36495;
        public const uint GL_TEXTURE_IMMUTABLE_FORMAT = 37167;
        #endregion

        #region Delegates
        public delegate void PFNGLDRAWARRAYSINSTANCEDBASEINSTANCEPROC(uint mode, int first, int count, int instancecount, uint baseinstance);
        public delegate void PFNGLDRAWELEMENTSINSTANCEDBASEINSTANCEPROC(uint mode, int count, uint type, IntPtr indices, int instancecount, uint baseinstance);
        public delegate void PFNGLDRAWELEMENTSINSTANCEDBASEVERTEXBASEINSTANCEPROC(uint mode, int count, uint type, IntPtr indices, int instancecount, int basevertex, uint baseinstance);
        public delegate void PFNGLGETINTERNALFORMATIVPROC(uint target, uint internalformat, uint pname, int bufSize, ref int parameters);
        public delegate void PFNGLGETACTIVEATOMICCOUNTERBUFFERIVPROC(uint program, uint bufferIndex, uint pname, ref int parameters);
        public delegate void PFNGLBINDIMAGETEXTUREPROC(uint unit, uint texture, int level, byte layered, int layer, uint access, uint format);
        public delegate void PFNGLMEMORYBARRIERPROC(uint barriers);
        public delegate void PFNGLTEXSTORAGE1DPROC(uint target, int levels, uint internalformat, int width);
        public delegate void PFNGLTEXSTORAGE2DPROC(uint target, int levels, uint internalformat, int width, int height);
        public delegate void PFNGLTEXSTORAGE3DPROC(uint target, int levels, uint internalformat, int width, int height, int depth);
        public delegate void PFNGLDRAWTRANSFORMFEEDBACKINSTANCEDPROC(uint mode, uint id, int instancecount);
        public delegate void PFNGLDRAWTRANSFORMFEEDBACKSTREAMINSTANCEDPROC(uint mode, uint id, uint stream, int instancecount);
        #endregion

        #region Methods
#pragma warning disable 0649
        public static PFNGLDRAWARRAYSINSTANCEDBASEINSTANCEPROC glDrawArraysInstancedBaseInstance;
        public static PFNGLDRAWELEMENTSINSTANCEDBASEINSTANCEPROC glDrawElementsInstancedBaseInstance;
        public static PFNGLDRAWELEMENTSINSTANCEDBASEVERTEXBASEINSTANCEPROC glDrawElementsInstancedBaseVertexBaseInstance;
        public static PFNGLGETINTERNALFORMATIVPROC glGetInternalformativ;
        public static PFNGLGETACTIVEATOMICCOUNTERBUFFERIVPROC glGetActiveAtomicCounterBufferiv;
        public static PFNGLBINDIMAGETEXTUREPROC glBindImageTexture;
        public static PFNGLMEMORYBARRIERPROC glMemoryBarrier;
        public static PFNGLTEXSTORAGE1DPROC glTexStorage1D;
        public static PFNGLTEXSTORAGE2DPROC glTexStorage2D;
        public static PFNGLTEXSTORAGE3DPROC glTexStorage3D;
        public static PFNGLDRAWTRANSFORMFEEDBACKINSTANCEDPROC glDrawTransformFeedbackInstanced;
        public static PFNGLDRAWTRANSFORMFEEDBACKSTREAMINSTANCEDPROC glDrawTransformFeedbackStreamInstanced;
        #endregion
    }
}
