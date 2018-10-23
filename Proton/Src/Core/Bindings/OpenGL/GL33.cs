using System;
using System.Runtime.InteropServices;

namespace Proton
{
	static class GL33
	{
		#region Constants
		public const uint GL_VERTEX_ATTRIB_ARRAY_DIVISOR = 35070;
		public const uint GL_SRC1_COLOR = 35065;
		public const uint GL_ONE_MINUS_SRC1_COLOR = 35066;
		public const uint GL_ONE_MINUS_SRC1_ALPHA = 35067;
		public const uint GL_MAX_DUAL_SOURCE_DRAW_BUFFERS = 35068;
		public const uint GL_ANY_SAMPLES_PASSED = 35887;
		public const uint GL_SAMPLER_BINDING = 35097;
		public const uint GL_RGB10_A2UI = 36975;
		public const uint GL_TEXTURE_SWIZZLE_R = 36418;
		public const uint GL_TEXTURE_SWIZZLE_G = 36419;
		public const uint GL_TEXTURE_SWIZZLE_B = 36420;
		public const uint GL_TEXTURE_SWIZZLE_A = 36421;
		public const uint GL_TEXTURE_SWIZZLE_RGBA = 36422;
		public const uint GL_TIME_ELAPSED = 35007;
		public const uint GL_TIMESTAMP = 36392;
		public const uint GL_INT_2_10_10_10_REV = 36255;
		#endregion

		#region Delegates
		public delegate void PFNGLBINDFRAGDATALOCATIONINDEXEDPROC(uint program, uint colorNumber, uint index, [In] [MarshalAs(UnmanagedType.LPStr)] string name);
		public delegate int PFNGLGETFRAGDATAINDEXPROC(uint program, [In] [MarshalAs(UnmanagedType.LPStr)] string name);
		public delegate void PFNGLGENSAMPLERSPROC(int count, ref uint samplers);
		public delegate void PFNGLDELETESAMPLERSPROC(int count, ref uint samplers);
		public delegate byte PFNGLISSAMPLERPROC(uint sampler);
		public delegate void PFNGLBINDSAMPLERPROC(uint unit, uint sampler);
		public delegate void PFNGLSAMPLERPARAMETERIPROC(uint sampler, uint pname, int param);
		public delegate void PFNGLSAMPLERPARAMETERIVPROC(uint sampler, uint pname, ref int param);
		public delegate void PFNGLSAMPLERPARAMETERFPROC(uint sampler, uint pname, float param);
		public delegate void PFNGLSAMPLERPARAMETERFVPROC(uint sampler, uint pname, ref float param);
		public delegate void PFNGLSAMPLERPARAMETERIIVPROC(uint sampler, uint pname, ref int param);
		public delegate void PFNGLSAMPLERPARAMETERIUIVPROC(uint sampler, uint pname, ref uint param);
		public delegate void PFNGLGETSAMPLERPARAMETERIVPROC(uint sampler, uint pname, ref int parameters);
		public delegate void PFNGLGETSAMPLERPARAMETERIIVPROC(uint sampler, uint pname, ref int parameters);
		public delegate void PFNGLGETSAMPLERPARAMETERFVPROC(uint sampler, uint pname, ref float parameters);
		public delegate void PFNGLGETSAMPLERPARAMETERIUIVPROC(uint sampler, uint pname, ref uint parameters);
		public delegate void PFNGLQUERYCOUNTERPROC(uint id, uint target);
		public delegate void PFNGLGETQUERYOBJECTI64VPROC(uint id, uint pname, ref int parameters);
		public delegate void PFNGLGETQUERYOBJECTUI64VPROC(uint id, uint pname, ref uint parameters);
		public delegate void PFNGLVERTEXATTRIBDIVISORPROC(uint index, uint divisor);
		public delegate void PFNGLVERTEXATTRIBP1UIPROC(uint index, uint type, byte normalized, uint value);
		public delegate void PFNGLVERTEXATTRIBP1UIVPROC(uint index, uint type, byte normalized, ref uint value);
		public delegate void PFNGLVERTEXATTRIBP2UIPROC(uint index, uint type, byte normalized, uint value);
		public delegate void PFNGLVERTEXATTRIBP2UIVPROC(uint index, uint type, byte normalized, ref uint value);
		public delegate void PFNGLVERTEXATTRIBP3UIPROC(uint index, uint type, byte normalized, uint value);
		public delegate void PFNGLVERTEXATTRIBP3UIVPROC(uint index, uint type, byte normalized, ref uint value);
		public delegate void PFNGLVERTEXATTRIBP4UIPROC(uint index, uint type, byte normalized, uint value);
		public delegate void PFNGLVERTEXATTRIBP4UIVPROC(uint index, uint type, byte normalized, ref uint value);
		#endregion

		#region Methods
		public static PFNGLBINDFRAGDATALOCATIONINDEXEDPROC glBindFragDataLocationIndexed;
		public static PFNGLGETFRAGDATAINDEXPROC glGetFragDataIndex;
		public static PFNGLGENSAMPLERSPROC glGenSamplers;
		public static PFNGLDELETESAMPLERSPROC glDeleteSamplers;
		public static PFNGLISSAMPLERPROC glIsSampler;
		public static PFNGLBINDSAMPLERPROC glBindSampler;
		public static PFNGLSAMPLERPARAMETERIPROC glSamplerParameteri;
		public static PFNGLSAMPLERPARAMETERIVPROC glSamplerParameteriv;
		public static PFNGLSAMPLERPARAMETERFPROC glSamplerParameterf;
		public static PFNGLSAMPLERPARAMETERFVPROC glSamplerParameterfv;
		public static PFNGLSAMPLERPARAMETERIIVPROC glSamplerParameterIiv;
		public static PFNGLSAMPLERPARAMETERIUIVPROC glSamplerParameterIuiv;
		public static PFNGLGETSAMPLERPARAMETERIVPROC glGetSamplerParameteriv;
		public static PFNGLGETSAMPLERPARAMETERIIVPROC glGetSamplerParameterIiv;
		public static PFNGLGETSAMPLERPARAMETERFVPROC glGetSamplerParameterfv;
		public static PFNGLGETSAMPLERPARAMETERIUIVPROC glGetSamplerParameterIuiv;
		public static PFNGLQUERYCOUNTERPROC glQueryCounter;
		public static PFNGLGETQUERYOBJECTI64VPROC glGetQueryObjecti64v;
		public static PFNGLGETQUERYOBJECTUI64VPROC glGetQueryObjectui64v;
		public static PFNGLVERTEXATTRIBDIVISORPROC glVertexAttribDivisor;
		public static PFNGLVERTEXATTRIBP1UIPROC glVertexAttribP1ui;
		public static PFNGLVERTEXATTRIBP1UIVPROC glVertexAttribP1uiv;
		public static PFNGLVERTEXATTRIBP2UIPROC glVertexAttribP2ui;
		public static PFNGLVERTEXATTRIBP2UIVPROC glVertexAttribP2uiv;
		public static PFNGLVERTEXATTRIBP3UIPROC glVertexAttribP3ui;
		public static PFNGLVERTEXATTRIBP3UIVPROC glVertexAttribP3uiv;
		public static PFNGLVERTEXATTRIBP4UIPROC glVertexAttribP4ui;
		public static PFNGLVERTEXATTRIBP4UIVPROC glVertexAttribP4uiv;
		#endregion
	}
}
