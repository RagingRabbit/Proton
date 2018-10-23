using System;

namespace Proton
{
	static class GL12
	{
		#region Constants
		public const uint GL_UNSIGNED_BYTE_3_3_2 = 32818;
		public const uint GL_UNSIGNED_SHORT_4_4_4_4 = 32819;
		public const uint GL_UNSIGNED_SHORT_5_5_5_1 = 32820;
		public const uint GL_UNSIGNED_INT_8_8_8_8 = 32821;
		public const uint GL_UNSIGNED_INT_10_10_10_2 = 32822;
		public const uint GL_TEXTURE_BINDING_3D = 32874;
		public const uint GL_PACK_SKIP_IMAGES = 32875;
		public const uint GL_PACK_IMAGE_HEIGHT = 32876;
		public const uint GL_UNPACK_SKIP_IMAGES = 32877;
		public const uint GL_UNPACK_IMAGE_HEIGHT = 32878;
		public const uint GL_TEXTURE_3D = 32879;
		public const uint GL_PROXY_TEXTURE_3D = 32880;
		public const uint GL_TEXTURE_DEPTH = 32881;
		public const uint GL_TEXTURE_WRAP_R = 32882;
		public const uint GL_MAX_3D_TEXTURE_SIZE = 32883;
		public const uint GL_UNSIGNED_BYTE_2_3_3_REV = 33634;
		public const uint GL_UNSIGNED_SHORT_5_6_5 = 33635;
		public const uint GL_UNSIGNED_SHORT_5_6_5_REV = 33636;
		public const uint GL_UNSIGNED_SHORT_4_4_4_4_REV = 33637;
		public const uint GL_UNSIGNED_SHORT_1_5_5_5_REV = 33638;
		public const uint GL_UNSIGNED_INT_8_8_8_8_REV = 33639;
		public const uint GL_UNSIGNED_INT_2_10_10_10_REV = 33640;
		public const uint GL_BGR = 32992;
		public const uint GL_BGRA = 32993;
		public const uint GL_MAX_ELEMENTS_VERTICES = 33000;
		public const uint GL_MAX_ELEMENTS_INDICES = 33001;
		public const uint GL_CLAMP_TO_EDGE = 33071;
		public const uint GL_TEXTURE_MIN_LOD = 33082;
		public const uint GL_TEXTURE_MAX_LOD = 33083;
		public const uint GL_TEXTURE_BASE_LEVEL = 33084;
		public const uint GL_TEXTURE_MAX_LEVEL = 33085;
		public const uint GL_SMOOTH_POINT_SIZE_RANGE = 2834;
		public const uint GL_SMOOTH_POINT_SIZE_GRANULARITY = 2835;
		public const uint GL_SMOOTH_LINE_WIDTH_RANGE = 2850;
		public const uint GL_SMOOTH_LINE_WIDTH_GRANULARITY = 2851;
		public const uint GL_ALIASED_LINE_WIDTH_RANGE = 33902;
		#endregion

		#region Delegates
		public delegate void PFNGLDRAWRANGEELEMENTSPROC(uint mode, uint start, uint end, int count, uint type, IntPtr indices);
		public delegate void PFNGLTEXIMAGE3DPROC(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, IntPtr pixels);
		public delegate void PFNGLTEXSUBIMAGE3DPROC(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels);
		public delegate void PFNGLCOPYTEXSUBIMAGE3DPROC(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
		#endregion

		#region Methods
		public static PFNGLDRAWRANGEELEMENTSPROC glDrawRangeElements;
		public static PFNGLTEXIMAGE3DPROC glTexImage3D;
		public static PFNGLTEXSUBIMAGE3DPROC glTexSubImage3D;
		public static PFNGLCOPYTEXSUBIMAGE3DPROC glCopyTexSubImage3D;
		#endregion
	}
}
