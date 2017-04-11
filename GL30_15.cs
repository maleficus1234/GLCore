// 
// Copyright (c) 2013 Jason Bell
// 
// Permission is hereby granted, free of charge, to any person obtaining a 
// copy of this software and associated documentation files (the "Software"), 
// to deal in the Software without restriction, including without limitation 
// the rights to use, copy, modify, merge, publish, distribute, sublicense, 
// and/or sell copies of the Software, and to permit persons to whom the 
// Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included 
// in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS 
// OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.
// 

using System;
using System.Reflection;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

// Ignore all the "will always have default value of null" warnings for the delegates: they
// do get values assigned through reflection.
#pragma warning disable 649

namespace GLCore
{
    /* OpenGL 1.5 */
    public partial class GL30
    {
        public int GL_BUFFER_SIZE { get { return 0x8764; } }
        public int GL_BUFFER_USAGE { get { return 0x8765; } }
        public int GL_QUERY_COUNTER_BITS { get { return 0x8864; } }
        public int GL_CURRENT_QUERY { get { return 0x8865; } }
        public int GL_QUERY_RESULT { get { return 0x8866; } }
        public int GL_QUERY_RESULT_AVAILABLE { get { return 0x8867; } }
        public int GL_ARRAY_BUFFER { get { return 0x8892; } }
        public int GL_ELEMENT_ARRAY_BUFFER { get { return 0x8893; } }
        public int GL_ARRAY_BUFFER_BINDING { get { return 0x8894; } }
        public int GL_ELEMENT_ARRAY_BUFFER_BINDING { get { return 0x8895; } }
        public int GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING { get { return 0x889F; } }
        public int GL_READ_ONLY { get { return 0x88B8; } }
        public int GL_WRITE_ONLY { get { return 0x88B9; } }
        public int GL_READ_WRITE { get { return 0x88BA; } }
        public int GL_BUFFER_ACCESS { get { return 0x88BB; } }
        public int GL_BUFFER_MAPPED { get { return 0x88BC; } }
        public int GL_BUFFER_MAP_POINTER { get { return 0x88BD; } }
        public int GL_STREAM_DRAW { get { return 0x88E0; } }
        public int GL_STREAM_READ { get { return 0x88E1; } }
        public int GL_STREAM_COPY { get { return 0x88E2; } }
        public int GL_STATIC_DRAW { get { return 0x88E4; } }
        public int GL_STATIC_READ { get { return 0x88E5; } }
        public int GL_STATIC_COPY { get { return 0x88E6; } }
        public int GL_DYNAMIC_DRAW { get { return 0x88E8; } }
        public int GL_DYNAMIC_READ { get { return 0x88E9; } }
        public int GL_DYNAMIC_COPY { get { return 0x88EA; } }
        public int GL_SAMPLES_PASSED { get { return 0x8914; } }
        public int GL_SRC1_ALPHA { get { return 0x8589; } }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenQueriesdelegate(int n, [OutAttribute] uint* ids);
        internal unsafe GenQueriesdelegate glGenQueries;

        public void GenQueries(int n, int[] ids)
        {
            unsafe
            {
                fixed (int* ids_ptr = ids)
                {
                    glGenQueries((int)n, (uint*)ids_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteQueriesdelegate(int n, uint* ids);
        internal unsafe DeleteQueriesdelegate glDeleteQueries;

        public void DeleteQueries(int n, int[] ids)
        {
            unsafe
            {
                fixed (int* ids_ptr = ids)
                {
                    glDeleteQueries((int)n, (uint*)ids_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate bool IsQuerydelegate(uint id);
        internal IsQuerydelegate glIsQuery;

        public bool IsQuery(int id)
        {
            bool r = glIsQuery((uint)id);
            CheckForErrors();
            return r;
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BeginQueryDelegate(int target, uint id);
        internal BeginQueryDelegate glBeginQuery;

        public void BeginQuery(int target, int id)
        {
            glBeginQuery(target, (uint)id);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EndQuerydelegate(int target);
        internal EndQuerydelegate glEndQuery;

        public void EndQuery(int target)
        {
            glEndQuery(target);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetQueryivdelegate(int target, int pname, [OutAttribute] int* @params);
        internal unsafe GetQueryivdelegate glGetQueryiv;

        public void GetQuery(int target, int pname, [OutAttribute] int[] @params)
        {
            unsafe
            {
                fixed (int* @params_ptr = @params)
                {
                    glGetQueryiv(target, pname, (int*)@params_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetQueryObjectivdelegate(uint id, int pname, [OutAttribute] int* @params);
        internal unsafe GetQueryObjectivdelegate glGetQueryObjectiv;

        public void GetQueryObject(int id, int pname, [OutAttribute] int[] @params)
        {
            unsafe
            {
                fixed (int* @params_ptr = @params)
                {
                    glGetQueryObjectiv((uint)id, (int)pname, (int*)@params_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetQueryObjectuivdelegate(uint id, int pname, [OutAttribute] uint* @params);
        internal unsafe GetQueryObjectuivdelegate glGetQueryObjectuiv;

        [System.CLSCompliant(false)]
        public void GetQueryObject(int id, int pname, [OutAttribute] uint[] @params)
        {
            unsafe
            {
                fixed (uint* @params_ptr = @params)
                {
                    glGetQueryObjectuiv((uint)id, (int)pname, (uint*)@params_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenBuffersd(int n, [OutAttribute] uint* buffers);
        internal unsafe GenBuffersd glGenBuffers;

        public void GenBuffers([OutAttribute] int[] buffers)
        {
            unsafe
            {
                fixed (int* buffers_ptr = buffers)
                {
                    glGenBuffers(buffers.Length, (uint*)buffers_ptr);
                    CheckForErrors();
                }
            }
        }

        public int GenBuffer()
        {
            int[] buffer = new int[1];
            GenBuffers(buffer);
            return buffer[0];
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindBufferd(uint target, uint buffer);
        internal BindBufferd glBindBuffer;

        public void BindBuffer(int bufferTarget, int buffer)
        {
            glBindBuffer((uint)bufferTarget, (uint)buffer);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteBuffersd(int n, uint* buffers);
        internal unsafe DeleteBuffersd glDeleteBuffers;

        public void DeleteBuffers(int[] buffers)
        {
            unsafe
            {
                fixed (int* buffers_ptr = buffers)
                {
                    glDeleteBuffers(buffers.Length, (uint*)buffers_ptr);
                    CheckForErrors();
                }
            }
        }

        public void DeleteBuffer(int buffer)
        {
            int[] b = 
            {
                buffer
            };
            DeleteBuffers(b);
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate bool IsBufferDelegate(uint buffer);
        internal IsBufferDelegate glIsBuffer;

        public bool IsBuffer(int buffer)
        {
            bool r = glIsBuffer((uint)buffer);
            CheckForErrors();
            return r;
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BufferSubDataDelegate(int bufferTarget, IntPtr offset, IntPtr size, IntPtr data);
        internal BufferSubDataDelegate glBufferSubData;

        public void BufferSubData<T3>(int bufferTarget, int offset, int size, [InAttribute, OutAttribute] T3[] data)
            where T3 : struct
        {
            GCHandle data_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                glBufferSubData(bufferTarget, new IntPtr(offset), new IntPtr(size), (IntPtr)data_ptr.AddrOfPinnedObject());
                CheckForErrors();
            }
            finally
            {
                data_ptr.Free();
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BufferDatad(uint target, IntPtr size, IntPtr data, int usage);
        internal BufferDatad glBufferData;

        internal void InternalBufferData<T>(int target,
            int size,
            [InAttribute, OutAttribute] T[] data,
            int bufferUsage)
            where T : struct
        {
            GCHandle data_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                glBufferData((uint)target, new IntPtr(size), (IntPtr)data_ptr.AddrOfPinnedObject(), bufferUsage);
                CheckForErrors();
            }
            finally
            {
                data_ptr.Free();
            }
        }

        public void BufferData<T>(int bufferTarget,
            int size,
            [InAttribute, OutAttribute] T[] data,
            int bufferUsage)
            where T : struct
        {
            InternalBufferData<T>((int)bufferTarget, size, data, bufferUsage);
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GetBufferSubDataDelegate(int target, IntPtr offset, IntPtr size, [OutAttribute] IntPtr data);
        internal GetBufferSubDataDelegate glGetBufferSubData;

        public void GetBufferSubData<T3>(int bufferTarget, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] T3[] data)
                where T3 : struct
        {
            GCHandle data_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                glGetBufferSubData(bufferTarget, (IntPtr)offset, (IntPtr)size, (IntPtr)data_ptr.AddrOfPinnedObject());
                CheckForErrors();
            }
            finally
            {
                data_ptr.Free();
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate IntPtr MapBufferDelegate(int target, int access);
        internal unsafe MapBufferDelegate glMapBuffer;

        public IntPtr MapBuffer(int bufferTarget, int access)
        {
            IntPtr i = glMapBuffer(bufferTarget, access);
            CheckForErrors();
            return i;
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate bool UnmapBufferDelegate(int target);
        internal UnmapBufferDelegate glUnmapBuffer;

        public bool UnmapBuffer(int bufferTarget)
        {
            bool r = glUnmapBuffer(bufferTarget);
            CheckForErrors();
            return r;
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GetBufferPointervDelegate(int target, uint pname, [OutAttribute] IntPtr @params);
        internal GetBufferPointervDelegate glGetBufferPointerv;

        public void GetBufferPointer<T2>(int bufferTarget, int pname, [InAttribute, OutAttribute] T2[] @params)
            where T2 : struct
        {
            GCHandle @params_ptr = GCHandle.Alloc(@params, GCHandleType.Pinned);
            try
            {
                glGetBufferPointerv(bufferTarget, (uint)pname, (IntPtr)@params_ptr.AddrOfPinnedObject());
                CheckForErrors();
            }
            finally
            {
                @params_ptr.Free();
            }
        }



        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetBufferParameterivDelegate(int target, int pname, [OutAttribute] int* @params);
        internal unsafe GetBufferParameterivDelegate glGetBufferParameteriv;

        public void GetBufferParameter(int bufferTarget, int bufferPName, [OutAttribute] int[] @params)
        {
            unsafe
            {
                fixed (int* @params_ptr = @params)
                {
                    glGetBufferParameteriv(bufferTarget, bufferPName, (int*)@params_ptr);
                    CheckForErrors();
                }
            }
        }

    }
}
