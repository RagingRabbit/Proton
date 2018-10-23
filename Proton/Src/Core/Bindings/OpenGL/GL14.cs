using System;

namespace Proton
{
	static class GL14
	{
		#region Constants
		public const uint GL_VERSION_1_4 = 1;
		public const uint GL_BLEND_DST_RGB = 32968;
		public const uint GL_BLEND_SRC_RGB = 32969;
		public const uint GL_BLEND_DST_ALPHA = 32970;
		public const uint GL_BLEND_SRC_ALPHA = 32971;
		public const uint GL_POINT_FADE_THRESHOLD_SIZE = 33064;
		public const uint GL_DEPTH_COMPONENT16 = 33189;
		public const uint GL_DEPTH_COMPONENT24 = 33190;
		public const uint GL_DEPTH_COMPONENT32 = 33191;
		public const uint GL_MIRRORED_REPEAT = 33648;
		public const uint GL_MAX_TEXTURE_LOD_BIAS = 34045;
		public const uint GL_TEXTURE_LOD_BIAS = 34049;
		public const uint GL_INCR_WRAP = 34055;
		public const uint GL_DECR_WRAP = 34056;
		public const uint GL_TEXTURE_DEPTH_SIZE = 34890;
		public const uint GL_TEXTURE_COMPARE_MODE = 34892;
		public const uint GL_TEXTURE_COMPARE_FUNC = 34893;
		public const uint GL_FUNC_ADD = 32774;
		public const uint GL_FUNC_SUBTRACT = 32778;
		public const uint GL_FUNC_REVERSE_SUBTRACT = 32779;
		public const uint GL_MIN = 32775;
		public const uint GL_MAX = 32776;
		public const uint GL_CONSTANT_COLOR = 32769;
		public const uint GL_ONE_MINUS_CONSTANT_COLOR = 32770;
		public const uint GL_CONSTANT_ALPHA = 32771;
		public const uint GL_ONE_MINUS_CONSTANT_ALPHA = 32772;
		#endregion

		#region 
		public delegate void PFNGLBLENDFUNCSEPARATEPROC(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);
		public delegate void PFNGLMULTIDRAWARRAYSPROC(uint mode, ref int first, ref int count, int drawcount);
		public delegate void PFNGLMULTIDRAWELEMENTSPROC(uint mode, ref int count, uint type, IntPtr indices, int drawcount);
		public delegate void PFNGLPOINTPARAMETERFPROC(uint pname, float param);
		public delegate void PFNGLPOINTPARAMETERFVPROC(uint pname, ref float parameters);
		public delegate void PFNGLPOINTPARAMETERIPROC(uint pname, int param);
		public delegate void PFNGLPOINTPARAMETERIVPROC(uint pname, ref int parameters);
		public delegate void PFNGLBLENDCOLORPROC(float red, float green, float blue, float alpha);
		public delegate void PFNGLBLENDEQUATIONPROC(uint mode);
		#endregion

		#region Methods
		public static PFNGLBLENDFUNCSEPARATEPROC glBlendFuncSeparate;
		public static PFNGLMULTIDRAWARRAYSPROC glMultiDrawArrays;
		public static PFNGLMULTIDRAWELEMENTSPROC glMultiDrawElements;
		public static PFNGLPOINTPARAMETERFPROC glPointParameterf;
		public static PFNGLPOINTPARAMETERFVPROC glPointParameterfv;
		public static PFNGLPOINTPARAMETERIPROC glPointParameteri;
		public static PFNGLPOINTPARAMETERIVPROC glPointParameteriv;
		public static PFNGLBLENDCOLORPROC glBlendColor;
		public static PFNGLBLENDEQUATIONPROC glBlendEquation;
		#endregion
	}
}
