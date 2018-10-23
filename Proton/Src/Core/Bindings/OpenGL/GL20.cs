﻿using System;
using System.Runtime.InteropServices;

namespace Proton
{
	static class GL20
	{
		#region Constants
		public const uint GL_BLEND_EQUATION_RGB = 32777;
		public const uint GL_VERTEX_ATTRIB_ARRAY_ENABLED = 34338;
		public const uint GL_VERTEX_ATTRIB_ARRAY_SIZE = 34339;
		public const uint GL_VERTEX_ATTRIB_ARRAY_STRIDE = 34340;
		public const uint GL_VERTEX_ATTRIB_ARRAY_TYPE = 34341;
		public const uint GL_CURRENT_VERTEX_ATTRIB = 34342;
		public const uint GL_VERTEX_PROGRAM_POINT_SIZE = 34370;
		public const uint GL_VERTEX_ATTRIB_ARRAY_POINTER = 34373;
		public const uint GL_STENCIL_BACK_FUNC = 34816;
		public const uint GL_STENCIL_BACK_FAIL = 34817;
		public const uint GL_STENCIL_BACK_PASS_DEPTH_FAIL = 34818;
		public const uint GL_STENCIL_BACK_PASS_DEPTH_PASS = 34819;
		public const uint GL_MAX_DRAW_BUFFERS = 34852;
		public const uint GL_DRAW_BUFFER0 = 34853;
		public const uint GL_DRAW_BUFFER1 = 34854;
		public const uint GL_DRAW_BUFFER2 = 34855;
		public const uint GL_DRAW_BUFFER3 = 34856;
		public const uint GL_DRAW_BUFFER4 = 34857;
		public const uint GL_DRAW_BUFFER5 = 34858;
		public const uint GL_DRAW_BUFFER6 = 34859;
		public const uint GL_DRAW_BUFFER7 = 34860;
		public const uint GL_DRAW_BUFFER8 = 34861;
		public const uint GL_DRAW_BUFFER9 = 34862;
		public const uint GL_DRAW_BUFFER10 = 34863;
		public const uint GL_DRAW_BUFFER11 = 34864;
		public const uint GL_DRAW_BUFFER12 = 34865;
		public const uint GL_DRAW_BUFFER13 = 34866;
		public const uint GL_DRAW_BUFFER14 = 34867;
		public const uint GL_DRAW_BUFFER15 = 34868;
		public const uint GL_BLEND_EQUATION_ALPHA = 34877;
		public const uint GL_MAX_VERTEX_ATTRIBS = 34921;
		public const uint GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 34922;
		public const uint GL_MAX_TEXTURE_IMAGE_UNITS = 34930;
		public const uint GL_FRAGMENT_SHADER = 35632;
		public const uint GL_VERTEX_SHADER = 35633;
		public const uint GL_MAX_FRAGMENT_UNIFORM_COMPONENTS = 35657;
		public const uint GL_MAX_VERTEX_UNIFORM_COMPONENTS = 35658;
		public const uint GL_MAX_VARYING_FLOATS = 35659;
		public const uint GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS = 35660;
		public const uint GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS = 35661;
		public const uint GL_SHADER_TYPE = 35663;
		public const uint GL_FLOAT_VEC2 = 35664;
		public const uint GL_FLOAT_VEC3 = 35665;
		public const uint GL_FLOAT_VEC4 = 35666;
		public const uint GL_INT_VEC2 = 35667;
		public const uint GL_INT_VEC3 = 35668;
		public const uint GL_INT_VEC4 = 35669;
		public const uint GL_BOOL = 35670;
		public const uint GL_BOOL_VEC2 = 35671;
		public const uint GL_BOOL_VEC3 = 35672;
		public const uint GL_BOOL_VEC4 = 35673;
		public const uint GL_FLOAT_MAT2 = 35674;
		public const uint GL_FLOAT_MAT3 = 35675;
		public const uint GL_FLOAT_MAT4 = 35676;
		public const uint GL_SAMPLER_1D = 35677;
		public const uint GL_SAMPLER_2D = 35678;
		public const uint GL_SAMPLER_3D = 35679;
		public const uint GL_SAMPLER_CUBE = 35680;
		public const uint GL_SAMPLER_1D_SHADOW = 35681;
		public const uint GL_SAMPLER_2D_SHADOW = 35682;
		public const uint GL_DELETE_STATUS = 35712;
		public const uint GL_COMPILE_STATUS = 35713;
		public const uint GL_LINK_STATUS = 35714;
		public const uint GL_VALIDATE_STATUS = 35715;
		public const uint GL_INFO_LOG_LENGTH = 35716;
		public const uint GL_ATTACHED_SHADERS = 35717;
		public const uint GL_ACTIVE_UNIFORMS = 35718;
		public const uint GL_ACTIVE_UNIFORM_MAX_LENGTH = 35719;
		public const uint GL_SHADER_SOURCE_LENGTH = 35720;
		public const uint GL_ACTIVE_ATTRIBUTES = 35721;
		public const uint GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 35722;
		public const uint GL_FRAGMENT_SHADER_DERIVATIVE_HINT = 35723;
		public const uint GL_SHADING_LANGUAGE_VERSION = 35724;
		public const uint GL_CURRENT_PROGRAM = 35725;
		public const uint GL_POINT_SPRITE_COORD_ORIGIN = 36000;
		public const uint GL_LOWER_LEFT = 36001;
		public const uint GL_UPPER_LEFT = 36002;
		public const uint GL_STENCIL_BACK_REF = 36003;
		public const uint GL_STENCIL_BACK_VALUE_MASK = 36004;
		public const uint GL_STENCIL_BACK_WRITEMASK = 36005;
		#endregion

		#region Delegates
		public delegate void PFNGLBLENDEQUATIONSEPARATEPROC(uint modeRGB, uint modeAlpha);
		public delegate void PFNGLDRAWBUFFERSPROC(int n, ref uint bufs);
		public delegate void PFNGLSTENCILOPSEPARATEPROC(uint face, uint sfail, uint dpfail, uint dppass);
		public delegate void PFNGLSTENCILFUNCSEPARATEPROC(uint face, uint func, int refer, uint mask);
		public delegate void PFNGLSTENCILMASKSEPARATEPROC(uint face, uint mask);
		public delegate void PFNGLATTACHSHADERPROC(uint program, uint shader);
		public delegate void PFNGLBINDATTRIBLOCATIONPROC(uint program, uint index, [In] [MarshalAs(UnmanagedType.LPStr)] string name);
		public delegate void PFNGLCOMPILESHADERPROC(uint shader);
		public delegate uint PFNGLCREATEPROGRAMPROC();
		public delegate uint PFNGLCREATESHADERPROC(uint type);
		public delegate void PFNGLDELETEPROGRAMPROC(uint program);
		public delegate void PFNGLDELETESHADERPROC(uint shader);
		public delegate void PFNGLDETACHSHADERPROC(uint program, uint shader);
		public delegate void PFNGLDISABLEVERTEXATTRIBARRAYPROC(uint index);
		public delegate void PFNGLENABLEVERTEXATTRIBARRAYPROC(uint index);
		public delegate void PFNGLGETACTIVEATTRIBPROC(uint program, uint index, int bufSize, ref int length, ref int size, ref uint type, IntPtr name);
		public delegate void PFNGLGETACTIVEUNIFORMPROC(uint program, uint index, int bufSize, ref int length, ref int size, ref uint type, IntPtr name);
		public delegate void PFNGLGETATTACHEDSHADERSPROC(uint program, int maxCount, ref int count, ref uint shaders);
		public delegate int PFNGLGETATTRIBLOCATIONPROC(uint program, [In] [MarshalAs(UnmanagedType.LPStr)] string name);
		public delegate void PFNGLGETPROGRAMIVPROC(uint program, uint pname, ref int parameters);
		public delegate void PFNGLGETPROGRAMINFOLOGPROC(uint program, int bufSize, ref int length, IntPtr infoLog);
		public delegate void PFNGLGETSHADERIVPROC(uint shader, uint pname, ref int parameters);
		public delegate void PFNGLGETSHADERINFOLOGPROC(uint shader, int bufSize, ref int length, IntPtr infoLog);
		public delegate void PFNGLGETSHADERSOURCEPROC(uint shader, int bufSize, ref int length, IntPtr source);
		public delegate int PFNGLGETUNIFORMLOCATIONPROC(uint program, [In] [MarshalAs(UnmanagedType.LPStr)] string name);
		public delegate void PFNGLGETUNIFORMFVPROC(uint program, int location, ref float parameters);
		public delegate void PFNGLGETUNIFORMIVPROC(uint program, int location, ref int parameters);
		public delegate void PFNGLGETVERTEXATTRIBDVPROC(uint index, uint pname, ref double parameters);
		public delegate void PFNGLGETVERTEXATTRIBFVPROC(uint index, uint pname, ref float parameters);
		public delegate void PFNGLGETVERTEXATTRIBIVPROC(uint index, uint pname, ref int parameters);
		public delegate void PFNGLGETVERTEXATTRIBPOINTERVPROC(uint index, uint pname, ref IntPtr pointer);
		public delegate byte PFNGLISPROGRAMPROC(uint program);
		public delegate byte PFNGLISSHADERPROC(uint shader);
		public delegate void PFNGLLINKPROGRAMPROC(uint program);
		public delegate void PFNGLSHADERSOURCEPROC(uint shader, int count, ref IntPtr str, ref int length);
		public delegate void PFNGLUSEPROGRAMPROC(uint program);
		public delegate void PFNGLUNIFORM1FPROC(int location, float v0);
		public delegate void PFNGLUNIFORM2FPROC(int location, float v0, float v1);
		public delegate void PFNGLUNIFORM3FPROC(int location, float v0, float v1, float v2);
		public delegate void PFNGLUNIFORM4FPROC(int location, float v0, float v1, float v2, float v3);
		public delegate void PFNGLUNIFORM1IPROC(int location, int v0);
		public delegate void PFNGLUNIFORM2IPROC(int location, int v0, int v1);
		public delegate void PFNGLUNIFORM3IPROC(int location, int v0, int v1, int v2);
		public delegate void PFNGLUNIFORM4IPROC(int location, int v0, int v1, int v2, int v3);
		public delegate void PFNGLUNIFORM1FVPROC(int location, int count, ref float value);
		public delegate void PFNGLUNIFORM2FVPROC(int location, int count, ref float value);
		public delegate void PFNGLUNIFORM3FVPROC(int location, int count, ref float value);
		public delegate void PFNGLUNIFORM4FVPROC(int location, int count, ref float value);
		public delegate void PFNGLUNIFORM1IVPROC(int location, int count, ref int value);
		public delegate void PFNGLUNIFORM2IVPROC(int location, int count, ref int value);
		public delegate void PFNGLUNIFORM3IVPROC(int location, int count, ref int value);
		public delegate void PFNGLUNIFORM4IVPROC(int location, int count, ref int value);
		public delegate void PFNGLUNIFORMMATRIX2FVPROC(int location, int count, byte transpose, ref float value);
		public delegate void PFNGLUNIFORMMATRIX3FVPROC(int location, int count, byte transpose, ref float value);
		public delegate void PFNGLUNIFORMMATRIX4FVPROC(int location, int count, byte transpose, ref float value);
		public delegate void PFNGLVALIDATEPROGRAMPROC(uint program);
		public delegate void PFNGLVERTEXATTRIB1DPROC(uint index, double x);
		public delegate void PFNGLVERTEXATTRIB1DVPROC(uint index, ref double v);
		public delegate void PFNGLVERTEXATTRIB1FPROC(uint index, float x);
		public delegate void PFNGLVERTEXATTRIB1FVPROC(uint index, ref float v);
		public delegate void PFNGLVERTEXATTRIB1SPROC(uint index, short x);
		public delegate void PFNGLVERTEXATTRIB1SVPROC(uint index, ref short v);
		public delegate void PFNGLVERTEXATTRIB2DPROC(uint index, double x, double y);
		public delegate void PFNGLVERTEXATTRIB2DVPROC(uint index, ref double v);
		public delegate void PFNGLVERTEXATTRIB2FPROC(uint index, float x, float y);
		public delegate void PFNGLVERTEXATTRIB2FVPROC(uint index, ref float v);
		public delegate void PFNGLVERTEXATTRIB2SPROC(uint index, short x, short y);
		public delegate void PFNGLVERTEXATTRIB2SVPROC(uint index, ref short v);
		public delegate void PFNGLVERTEXATTRIB3DPROC(uint index, double x, double y, double z);
		public delegate void PFNGLVERTEXATTRIB3DVPROC(uint index, ref double v);
		public delegate void PFNGLVERTEXATTRIB3FPROC(uint index, float x, float y, float z);
		public delegate void PFNGLVERTEXATTRIB3FVPROC(uint index, ref float v);
		public delegate void PFNGLVERTEXATTRIB3SPROC(uint index, short x, short y, short z);
		public delegate void PFNGLVERTEXATTRIB3SVPROC(uint index, ref short v);
		public delegate void PFNGLVERTEXATTRIB4NBVPROC(uint index, [In] [MarshalAs(UnmanagedType.LPStr)] string v);
		public delegate void PFNGLVERTEXATTRIB4NIVPROC(uint index, ref int v);
		public delegate void PFNGLVERTEXATTRIB4NSVPROC(uint index, ref short v);
		public delegate void PFNGLVERTEXATTRIB4NUBPROC(uint index, byte x, byte y, byte z, byte w);
		public delegate void PFNGLVERTEXATTRIB4NUBVPROC(uint index, [In] [MarshalAs(UnmanagedType.LPStr)] string v);
		public delegate void PFNGLVERTEXATTRIB4NUIVPROC(uint index, ref uint v);
		public delegate void PFNGLVERTEXATTRIB4NUSVPROC(uint index, ref ushort v);
		public delegate void PFNGLVERTEXATTRIB4BVPROC(uint index, [In] [MarshalAs(UnmanagedType.LPStr)] string v);
		public delegate void PFNGLVERTEXATTRIB4DPROC(uint index, double x, double y, double z, double w);
		public delegate void PFNGLVERTEXATTRIB4DVPROC(uint index, ref double v);
		public delegate void PFNGLVERTEXATTRIB4FPROC(uint index, float x, float y, float z, float w);
		public delegate void PFNGLVERTEXATTRIB4FVPROC(uint index, ref float v);
		public delegate void PFNGLVERTEXATTRIB4IVPROC(uint index, ref int v);
		public delegate void PFNGLVERTEXATTRIB4SPROC(uint index, short x, short y, short z, short w);
		public delegate void PFNGLVERTEXATTRIB4SVPROC(uint index, ref short v);
		public delegate void PFNGLVERTEXATTRIB4UBVPROC(uint index, [In] [MarshalAs(UnmanagedType.LPStr)] string v);
		public delegate void PFNGLVERTEXATTRIB4UIVPROC(uint index, ref uint v);
		public delegate void PFNGLVERTEXATTRIB4USVPROC(uint index, ref ushort v);
		public delegate void PFNGLVERTEXATTRIBPOINTERPROC(uint index, int size, uint type, byte normalized, int stride, IntPtr pointer);
		#endregion

		#region Methods
		public static PFNGLBLENDEQUATIONSEPARATEPROC glBlendEquationSeparate;
		public static PFNGLDRAWBUFFERSPROC glDrawBuffers;
		public static PFNGLSTENCILOPSEPARATEPROC glStencilOpSeparate;
		public static PFNGLSTENCILFUNCSEPARATEPROC glStencilFuncSeparate;
		public static PFNGLSTENCILMASKSEPARATEPROC glStencilMaskSeparate;
		public static PFNGLATTACHSHADERPROC glAttachShader;
		public static PFNGLBINDATTRIBLOCATIONPROC glBindAttribLocation;
		public static PFNGLCOMPILESHADERPROC glCompileShader;
		public static PFNGLCREATEPROGRAMPROC glCreateProgram;
		public static PFNGLCREATESHADERPROC glCreateShader;
		public static PFNGLDELETEPROGRAMPROC glDeleteProgram;
		public static PFNGLDELETESHADERPROC glDeleteShader;
		public static PFNGLDETACHSHADERPROC glDetachShader;
		public static PFNGLDISABLEVERTEXATTRIBARRAYPROC glDisableVertexAttribArray;
		public static PFNGLENABLEVERTEXATTRIBARRAYPROC glEnableVertexAttribArray;
		public static PFNGLGETACTIVEATTRIBPROC glGetActiveAttrib;
		public static PFNGLGETACTIVEUNIFORMPROC glGetActiveUniform;
		public static PFNGLGETATTACHEDSHADERSPROC glGetAttachedShaders;
		public static PFNGLGETATTRIBLOCATIONPROC glGetAttribLocation;
		public static PFNGLGETPROGRAMIVPROC glGetProgramiv;
		public static PFNGLGETPROGRAMINFOLOGPROC glGetProgramInfoLog;
		public static PFNGLGETSHADERIVPROC glGetShaderiv;
		public static PFNGLGETSHADERINFOLOGPROC glGetShaderInfoLog;
		public static PFNGLGETSHADERSOURCEPROC glGetShaderSource;
		public static PFNGLGETUNIFORMLOCATIONPROC glGetUniformLocation;
		public static PFNGLGETUNIFORMFVPROC glGetUniformfv;
		public static PFNGLGETUNIFORMIVPROC glGetUniformiv;
		public static PFNGLGETVERTEXATTRIBDVPROC glGetVertexAttribdv;
		public static PFNGLGETVERTEXATTRIBFVPROC glGetVertexAttribfv;
		public static PFNGLGETVERTEXATTRIBIVPROC glGetVertexAttribiv;
		public static PFNGLGETVERTEXATTRIBPOINTERVPROC glGetVertexAttribPointerv;
		public static PFNGLISPROGRAMPROC glIsProgram;
		public static PFNGLISSHADERPROC glIsShader;
		public static PFNGLLINKPROGRAMPROC glLinkProgram;
		public static PFNGLSHADERSOURCEPROC glShaderSource;
		public static PFNGLUSEPROGRAMPROC glUseProgram;
		public static PFNGLUNIFORM1FPROC glUniform1f;
		public static PFNGLUNIFORM2FPROC glUniform2f;
		public static PFNGLUNIFORM3FPROC glUniform3f;
		public static PFNGLUNIFORM4FPROC glUniform4f;
		public static PFNGLUNIFORM1IPROC glUniform1i;
		public static PFNGLUNIFORM2IPROC glUniform2i;
		public static PFNGLUNIFORM3IPROC glUniform3i;
		public static PFNGLUNIFORM4IPROC glUniform4i;
		public static PFNGLUNIFORM1FVPROC glUniform1fv;
		public static PFNGLUNIFORM2FVPROC glUniform2fv;
		public static PFNGLUNIFORM3FVPROC glUniform3fv;
		public static PFNGLUNIFORM4FVPROC glUniform4fv;
		public static PFNGLUNIFORM1IVPROC glUniform1iv;
		public static PFNGLUNIFORM2IVPROC glUniform2iv;
		public static PFNGLUNIFORM3IVPROC glUniform3iv;
		public static PFNGLUNIFORM4IVPROC glUniform4iv;
		public static PFNGLUNIFORMMATRIX2FVPROC glUniformMatrix2fv;
		public static PFNGLUNIFORMMATRIX3FVPROC glUniformMatrix3fv;
		public static PFNGLUNIFORMMATRIX4FVPROC glUniformMatrix4fv;
		public static PFNGLVALIDATEPROGRAMPROC glValidateProgram;
		public static PFNGLVERTEXATTRIB1DPROC glVertexAttrib1d;
		public static PFNGLVERTEXATTRIB1DVPROC glVertexAttrib1dv;
		public static PFNGLVERTEXATTRIB1FPROC glVertexAttrib1f;
		public static PFNGLVERTEXATTRIB1FVPROC glVertexAttrib1fv;
		public static PFNGLVERTEXATTRIB1SPROC glVertexAttrib1s;
		public static PFNGLVERTEXATTRIB1SVPROC glVertexAttrib1sv;
		public static PFNGLVERTEXATTRIB2DPROC glVertexAttrib2d;
		public static PFNGLVERTEXATTRIB2DVPROC glVertexAttrib2dv;
		public static PFNGLVERTEXATTRIB2FPROC glVertexAttrib2f;
		public static PFNGLVERTEXATTRIB2FVPROC glVertexAttrib2fv;
		public static PFNGLVERTEXATTRIB2SPROC glVertexAttrib2s;
		public static PFNGLVERTEXATTRIB2SVPROC glVertexAttrib2sv;
		public static PFNGLVERTEXATTRIB3DPROC glVertexAttrib3d;
		public static PFNGLVERTEXATTRIB3DVPROC glVertexAttrib3dv;
		public static PFNGLVERTEXATTRIB3FPROC glVertexAttrib3f;
		public static PFNGLVERTEXATTRIB3FVPROC glVertexAttrib3fv;
		public static PFNGLVERTEXATTRIB3SPROC glVertexAttrib3s;
		public static PFNGLVERTEXATTRIB3SVPROC glVertexAttrib3sv;
		public static PFNGLVERTEXATTRIB4NBVPROC glVertexAttrib4Nbv;
		public static PFNGLVERTEXATTRIB4NIVPROC glVertexAttrib4Niv;
		public static PFNGLVERTEXATTRIB4NSVPROC glVertexAttrib4Nsv;
		public static PFNGLVERTEXATTRIB4NUBPROC glVertexAttrib4Nub;
		public static PFNGLVERTEXATTRIB4NUBVPROC glVertexAttrib4Nubv;
		public static PFNGLVERTEXATTRIB4NUIVPROC glVertexAttrib4Nuiv;
		public static PFNGLVERTEXATTRIB4NUSVPROC glVertexAttrib4Nusv;
		public static PFNGLVERTEXATTRIB4BVPROC glVertexAttrib4bv;
		public static PFNGLVERTEXATTRIB4DPROC glVertexAttrib4d;
		public static PFNGLVERTEXATTRIB4DVPROC glVertexAttrib4dv;
		public static PFNGLVERTEXATTRIB4FPROC glVertexAttrib4f;
		public static PFNGLVERTEXATTRIB4FVPROC glVertexAttrib4fv;
		public static PFNGLVERTEXATTRIB4IVPROC glVertexAttrib4iv;
		public static PFNGLVERTEXATTRIB4SPROC glVertexAttrib4s;
		public static PFNGLVERTEXATTRIB4SVPROC glVertexAttrib4sv;
		public static PFNGLVERTEXATTRIB4UBVPROC glVertexAttrib4ubv;
		public static PFNGLVERTEXATTRIB4UIVPROC glVertexAttrib4uiv;
		public static PFNGLVERTEXATTRIB4USVPROC glVertexAttrib4usv;
		public static PFNGLVERTEXATTRIBPOINTERPROC glVertexAttribPointer;
		#endregion
	}
}