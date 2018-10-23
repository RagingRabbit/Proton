using System;

namespace Proton
{
	static class GL15
	{
		#region Constants
		public const uint GL_BUFFER_SIZE = 34660;
		public const uint GL_BUFFER_USAGE = 34661;
		public const uint GL_QUERY_COUNTER_BITS = 34916;
		public const uint GL_CURRENT_QUERY = 34917;
		public const uint GL_QUERY_RESULT = 34918;
		public const uint GL_QUERY_RESULT_AVAILABLE = 34919;
		public const uint GL_ARRAY_BUFFER = 34962;
		public const uint GL_ELEMENT_ARRAY_BUFFER = 34963;
		public const uint GL_ARRAY_BUFFER_BINDING = 34964;
		public const uint GL_ELEMENT_ARRAY_BUFFER_BINDING = 34965;
		public const uint GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 34975;
		public const uint GL_READ_ONLY = 35000;
		public const uint GL_WRITE_ONLY = 35001;
		public const uint GL_READ_WRITE = 35002;
		public const uint GL_BUFFER_ACCESS = 35003;
		public const uint GL_BUFFER_MAPPED = 35004;
		public const uint GL_BUFFER_MAP_POINTER = 35005;
		public const uint GL_STREAM_DRAW = 35040;
		public const uint GL_STREAM_READ = 35041;
		public const uint GL_STREAM_COPY = 35042;
		public const uint GL_STATIC_DRAW = 35044;
		public const uint GL_STATIC_READ = 35045;
		public const uint GL_STATIC_COPY = 35046;
		public const uint GL_DYNAMIC_DRAW = 35048;
		public const uint GL_DYNAMIC_READ = 35049;
		public const uint GL_DYNAMIC_COPY = 35050;
		public const uint GL_SAMPLES_PASSED = 35092;
		public const uint GL_SRC1_ALPHA = 34185;
		#endregion

		#region Delegates
		public delegate void PFNGLGENQUERIESPROC(int n, ref uint ids);
		public delegate void PFNGLDELETEQUERIESPROC(int n, ref uint ids);
		public delegate byte PFNGLISQUERYPROC(uint id);
		public delegate void PFNGLBEGINQUERYPROC(uint target, uint id);
		public delegate void PFNGLENDQUERYPROC(uint target);
		public delegate void PFNGLGETQUERYIVPROC(uint target, uint pname, ref int parameters);
		public delegate void PFNGLGETQUERYOBJECTIVPROC(uint id, uint pname, ref int parameters);
		public delegate void PFNGLGETQUERYOBJECTUIVPROC(uint id, uint pname, ref uint parameters);
		public delegate void PFNGLBINDBUFFERPROC(uint target, uint buffer);
		public delegate void PFNGLDELETEBUFFERSPROC(int n, ref uint buffers);
		public delegate void PFNGLGENBUFFERSPROC(int n, ref uint buffers);
		public delegate byte PFNGLISBUFFERPROC(uint buffer);
		public delegate void PFNGLBUFFERDATAPROC(uint target, int size, IntPtr data, uint usage);
		public delegate void PFNGLBUFFERSUBDATAPROC(uint target, int offset, int size, IntPtr data);
		public delegate void PFNGLGETBUFFERSUBDATAPROC(uint target, int offset, int size, IntPtr data);
		public delegate IntPtr PFNGLMAPBUFFERPROC(uint target, uint access);
		public delegate byte PFNGLUNMAPBUFFERPROC(uint target);
		public delegate void PFNGLGETBUFFERPARAMETERIVPROC(uint target, uint pname, ref int parameters);
		public delegate void PFNGLGETBUFFERPOINTERVPROC(uint target, uint pname, ref IntPtr parameters);
		#endregion

		#region Methods
		public static PFNGLGENQUERIESPROC glGenQueries;
		public static PFNGLDELETEQUERIESPROC glDeleteQueries;
		public static PFNGLISQUERYPROC glIsQuery;
		public static PFNGLBEGINQUERYPROC glBeginQuery;
		public static PFNGLENDQUERYPROC glEndQuery;
		public static PFNGLGETQUERYIVPROC glGetQueryiv;
		public static PFNGLGETQUERYOBJECTIVPROC glGetQueryObjectiv;
		public static PFNGLGETQUERYOBJECTUIVPROC glGetQueryObjectuiv;
		public static PFNGLBINDBUFFERPROC glBindBuffer;
		public static PFNGLDELETEBUFFERSPROC glDeleteBuffers;
		public static PFNGLGENBUFFERSPROC glGenBuffers;
		public static PFNGLISBUFFERPROC glIsBuffer;
		public static PFNGLBUFFERDATAPROC glBufferData;
		public static PFNGLBUFFERSUBDATAPROC glBufferSubData;
		public static PFNGLGETBUFFERSUBDATAPROC glGetBufferSubData;
		public static PFNGLMAPBUFFERPROC glMapBuffer;
		public static PFNGLUNMAPBUFFERPROC glUnmapBuffer;
		public static PFNGLGETBUFFERPARAMETERIVPROC glGetBufferParameteriv;
		public static PFNGLGETBUFFERPOINTERVPROC glGetBufferPointerv;
		#endregion
	}
}
