using System;

namespace Proton
{
	static class GL32
	{
		#region Constants
		public const uint GL_CONTEXT_CORE_PROFILE_BIT = 1;
		public const uint GL_CONTEXT_COMPATIBILITY_PROFILE_BIT = 2;
		public const uint GL_LINES_ADJACENCY = 10;
		public const uint GL_LINE_STRIP_ADJACENCY = 11;
		public const uint GL_TRIANGLES_ADJACENCY = 12;
		public const uint GL_TRIANGLE_STRIP_ADJACENCY = 13;
		public const uint GL_PROGRAM_POINT_SIZE = 34370;
		public const uint GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS = 35881;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_LAYERED = 36263;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 36264;
		public const uint GL_GEOMETRY_SHADER = 36313;
		public const uint GL_GEOMETRY_VERTICES_OUT = 35094;
		public const uint GL_GEOMETRY_INPUT_TYPE = 35095;
		public const uint GL_GEOMETRY_OUTPUT_TYPE = 35096;
		public const uint GL_MAX_GEOMETRY_UNIFORM_COMPONENTS = 36319;
		public const uint GL_MAX_GEOMETRY_OUTPUT_VERTICES = 36320;
		public const uint GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS = 36321;
		public const uint GL_MAX_VERTEX_OUTPUT_COMPONENTS = 37154;
		public const uint GL_MAX_GEOMETRY_INPUT_COMPONENTS = 37155;
		public const uint GL_MAX_GEOMETRY_OUTPUT_COMPONENTS = 37156;
		public const uint GL_MAX_FRAGMENT_INPUT_COMPONENTS = 37157;
		public const uint GL_CONTEXT_PROFILE_MASK = 37158;
		public const uint GL_DEPTH_CLAMP = 34383;
		public const uint GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION = 36428;
		public const uint GL_FIRST_VERTEX_CONVENTION = 36429;
		public const uint GL_LAST_VERTEX_CONVENTION = 36430;
		public const uint GL_PROVOKING_VERTEX = 36431;
		public const uint GL_TEXTURE_CUBE_MAP_SEAMLESS = 34895;
		public const uint GL_MAX_SERVER_WAIT_TIMEOUT = 37137;
		public const uint GL_OBJECT_TYPE = 37138;
		public const uint GL_SYNC_CONDITION = 37139;
		public const uint GL_SYNC_STATUS = 37140;
		public const uint GL_SYNC_FLAGS = 37141;
		public const uint GL_SYNC_FENCE = 37142;
		public const uint GL_SYNC_GPU_COMMANDS_COMPLETE = 37143;
		public const uint GL_UNSIGNALED = 37144;
		public const uint GL_SIGNALED = 37145;
		public const uint GL_ALREADY_SIGNALED = 37146;
		public const uint GL_TIMEOUT_EXPIRED = 37147;
		public const uint GL_CONDITION_SATISFIED = 37148;
		public const uint GL_WAIT_FAILED = 37149;
		public const ulong GL_TIMEOUT_IGNORED = 18446744073709551615ul;
		public const uint GL_SYNC_FLUSH_COMMANDS_BIT = 1;
		public const uint GL_SAMPLE_POSITION = 36432;
		public const uint GL_SAMPLE_MASK = 36433;
		public const uint GL_SAMPLE_MASK_VALUE = 36434;
		public const uint GL_MAX_SAMPLE_MASK_WORDS = 36441;
		public const uint GL_TEXTURE_2D_MULTISAMPLE = 37120;
		public const uint GL_PROXY_TEXTURE_2D_MULTISAMPLE = 37121;
		public const uint GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 37122;
		public const uint GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 37123;
		public const uint GL_TEXTURE_BINDING_2D_MULTISAMPLE = 37124;
		public const uint GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 37125;
		public const uint GL_TEXTURE_SAMPLES = 37126;
		public const uint GL_TEXTURE_FIXED_SAMPLE_LOCATIONS = 37127;
		public const uint GL_SAMPLER_2D_MULTISAMPLE = 37128;
		public const uint GL_INT_SAMPLER_2D_MULTISAMPLE = 37129;
		public const uint GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 37130;
		public const uint GL_SAMPLER_2D_MULTISAMPLE_ARRAY = 37131;
		public const uint GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 37132;
		public const uint GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 37133;
		public const uint GL_MAX_COLOR_TEXTURE_SAMPLES = 37134;
		public const uint GL_MAX_DEPTH_TEXTURE_SAMPLES = 37135;
		public const uint GL_MAX_INTEGER_SAMPLES = 37136;
		#endregion

		#region Delegates
		public delegate void PFNGLDRAWELEMENTSBASEVERTEXPROC(uint mode, int count, uint type, IntPtr indices, int basevertex);
		public delegate void PFNGLDRAWRANGEELEMENTSBASEVERTEXPROC(uint mode, uint start, uint end, int count, uint type, IntPtr indices, int basevertex);
		public delegate void PFNGLDRAWELEMENTSINSTANCEDBASEVERTEXPROC(uint mode, int count, uint type, IntPtr indices, int instancecount, int basevertex);
		public delegate void PFNGLMULTIDRAWELEMENTSBASEVERTEXPROC(uint mode, ref int count, uint type, IntPtr indices, int drawcount, ref int basevertex);
		public delegate void PFNGLPROVOKINGVERTEXPROC(uint mode);
		public delegate IntPtr PFNGLFENCESYNCPROC(uint condition, uint flags);
		public delegate byte PFNGLISSYNCPROC(IntPtr sync);
		public delegate void PFNGLDELETESYNCPROC(IntPtr sync);
		public delegate uint PFNGLCLIENTWAITSYNCPROC(IntPtr sync, uint flags, uint timeout);
		public delegate void PFNGLWAITSYNCPROC(IntPtr sync, uint flags, uint timeout);
		public delegate void PFNGLGETINTEGER64VPROC(uint pname, ref int data);
		public delegate void PFNGLGETSYNCIVPROC(IntPtr sync, uint pname, int bufSize, ref int length, ref int values);
		public delegate void PFNGLGETINTEGER64I_VPROC(uint target, uint index, ref int data);
		public delegate void PFNGLGETBUFFERPARAMETERI64VPROC(uint target, uint pname, ref int parameters);
		public delegate void PFNGLFRAMEBUFFERTEXTUREPROC(uint target, uint attachment, uint texture, int level);
		public delegate void PFNGLTEXIMAGE2DMULTISAMPLEPROC(uint target, int samples, uint internalformat, int width, int height, byte fixedsamplelocations);
		public delegate void PFNGLTEXIMAGE3DMULTISAMPLEPROC(uint target, int samples, uint internalformat, int width, int height, int depth, byte fixedsamplelocations);
		public delegate void PFNGLGETMULTISAMPLEFVPROC(uint pname, uint index, ref float val);
		public delegate void PFNGLSAMPLEMASKIPROC(uint maskNumber, uint mask);
		#endregion

		#region Methods
		public static PFNGLDRAWELEMENTSBASEVERTEXPROC glDrawElementsBaseVertex;
		public static PFNGLDRAWRANGEELEMENTSBASEVERTEXPROC glDrawRangeElementsBaseVertex;
		public static PFNGLDRAWELEMENTSINSTANCEDBASEVERTEXPROC glDrawElementsInstancedBaseVertex;
		public static PFNGLMULTIDRAWELEMENTSBASEVERTEXPROC glMultiDrawElementsBaseVertex;
		public static PFNGLPROVOKINGVERTEXPROC glProvokingVertex;
		public static PFNGLFENCESYNCPROC glFenceSync;
		public static PFNGLISSYNCPROC glIsSync;
		public static PFNGLDELETESYNCPROC glDeleteSync;
		public static PFNGLCLIENTWAITSYNCPROC glClientWaitSync;
		public static PFNGLWAITSYNCPROC glWaitSync;
		public static PFNGLGETINTEGER64VPROC glGetInteger64v;
		public static PFNGLGETSYNCIVPROC glGetSynciv;
		public static PFNGLGETINTEGER64I_VPROC glGetInteger64i_v;
		public static PFNGLGETBUFFERPARAMETERI64VPROC glGetBufferParameteri64v;
		public static PFNGLFRAMEBUFFERTEXTUREPROC glFramebufferTexture;
		public static PFNGLTEXIMAGE2DMULTISAMPLEPROC glTexImage2DMultisample;
		public static PFNGLTEXIMAGE3DMULTISAMPLEPROC glTexImage3DMultisample;
		public static PFNGLGETMULTISAMPLEFVPROC glGetMultisamplefv;
		public static PFNGLSAMPLEMASKIPROC glSampleMaski;
		#endregion
	}
}
