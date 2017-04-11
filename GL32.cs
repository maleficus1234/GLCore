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
    public class GL32
        : GL31
    {

        public GL32(Context context)
            : base(context)
        {

        }

        public int  GL_CONTEXT_CORE_PROFILE_BIT        { get { return 0x00000001; } } 
        public int  GL_CONTEXT_COMPATIBILITY_PROFILE_BIT  { get { return 0x00000002; } } 
        public int  GL_LINES_ADJACENCY                 { get { return 0x000A; } } 
        public int  GL_LINE_STRIP_ADJACENCY            { get { return 0x000B; } } 
        public int  GL_TRIANGLES_ADJACENCY             { get { return 0x000C; } } 
        public int  GL_TRIANGLE_STRIP_ADJACENCY        { get { return 0x000D; } } 
        public int  GL_PROGRAM_POINT_SIZE              { get { return 0x8642; } } 
        public int  GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS  { get { return 0x8C29; } } 
        public int  GL_FRAMEBUFFER_ATTACHMENT_LAYERED  { get { return 0x8DA7; } } 
        public int  GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS  { get { return 0x8DA8; } } 
        public int  GL_GEOMETRY_SHADER                 { get { return 0x8DD9; } } 
        public int  GL_GEOMETRY_VERTICES_OUT           { get { return 0x8916; } } 
        public int  GL_GEOMETRY_INPUT_TYPE             { get { return 0x8917; } } 
        public int  GL_GEOMETRY_OUTPUT_TYPE            { get { return 0x8918; } } 
        public int  GL_MAX_GEOMETRY_UNIFORM_COMPONENTS  { get { return 0x8DDF; } } 
        public int  GL_MAX_GEOMETRY_OUTPUT_VERTICES    { get { return 0x8DE0; } } 
        public int  GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS  { get { return 0x8DE1; } } 
        public int  GL_MAX_VERTEX_OUTPUT_COMPONENTS    { get { return 0x9122; } } 
        public int  GL_MAX_GEOMETRY_INPUT_COMPONENTS   { get { return 0x9123; } } 
        public int  GL_MAX_GEOMETRY_OUTPUT_COMPONENTS  { get { return 0x9124; } } 
        public int  GL_MAX_FRAGMENT_INPUT_COMPONENTS   { get { return 0x9125; } } 
        public int  GL_CONTEXT_PROFILE_MASK            { get { return 0x9126; } } 
        public int  GL_DEPTH_CLAMP                     { get { return 0x864F; } } 
        public int  GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION  { get { return 0x8E4C; } } 
        public int  GL_FIRST_VERTEX_CONVENTION         { get { return 0x8E4D; } } 
        public int  GL_LAST_VERTEX_CONVENTION          { get { return 0x8E4E; } } 
        public int  GL_PROVOKING_VERTEX                { get { return 0x8E4F; } } 
        public int  GL_TEXTURE_CUBE_MAP_SEAMLESS       { get { return 0x884F; } } 
        public int  GL_MAX_SERVER_WAIT_TIMEOUT         { get { return 0x9111; } } 
        public int  GL_OBJECT_TYPE                     { get { return 0x9112; } } 
        public int  GL_SYNC_CONDITION                  { get { return 0x9113; } } 
        public int  GL_SYNC_STATUS                     { get { return 0x9114; } } 
        public int  GL_SYNC_FLAGS                      { get { return 0x9115; } } 
        public int  GL_SYNC_FENCE                      { get { return 0x9116; } } 
        public int  GL_SYNC_GPU_COMMANDS_COMPLETE      { get { return 0x9117; } } 
        public int  GL_UNSIGNALED                      { get { return 0x9118; } } 
        public int  GL_SIGNALED                        { get { return 0x9119; } } 
        public int  GL_ALREADY_SIGNALED                { get { return 0x911A; } } 
        public int  GL_TIMEOUT_EXPIRED                 { get { return 0x911B; } } 
        public int  GL_CONDITION_SATISFIED             { get { return 0x911C; } } 
        public int  GL_WAIT_FAILED                     { get { return 0x911D; } } 
        public int  GL_TIMEOUT_IGNORED                 { get { return unchecked((int)0xFFFFFFFFFFFFFFFF); } }
        public int  GL_SYNC_FLUSH_COMMANDS_BIT         { get { return 0x00000001; } } 
        public int  GL_SAMPLE_POSITION                 { get { return 0x8E50; } } 
        public int  GL_SAMPLE_MASK                     { get { return 0x8E51; } } 
        public int  GL_SAMPLE_MASK_VALUE               { get { return 0x8E52; } } 
        public int  GL_MAX_SAMPLE_MASK_WORDS           { get { return 0x8E59; } } 
        public int  GL_TEXTURE_2D_MULTISAMPLE          { get { return 0x9100; } } 
        public int  GL_PROXY_TEXTURE_2D_MULTISAMPLE    { get { return 0x9101; } } 
        public int  GL_TEXTURE_2D_MULTISAMPLE_ARRAY    { get { return 0x9102; } } 
        public int  GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY  { get { return 0x9103; } } 
        public int  GL_TEXTURE_BINDING_2D_MULTISAMPLE  { get { return 0x9104; } } 
        public int  GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY  { get { return 0x9105; } } 
        public int  GL_TEXTURE_SAMPLES                 { get { return 0x9106; } } 
        public int  GL_TEXTURE_FIXED_SAMPLE_LOCATIONS  { get { return 0x9107; } } 
        public int  GL_SAMPLER_2D_MULTISAMPLE          { get { return 0x9108; } } 
        public int  GL_INT_SAMPLER_2D_MULTISAMPLE      { get { return 0x9109; } } 
        public int  GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE  { get { return 0x910A; } } 
        public int  GL_SAMPLER_2D_MULTISAMPLE_ARRAY    { get { return 0x910B; } } 
        public int  GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY  { get { return 0x910C; } } 
        public int  GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY  { get { return 0x910D; } } 
        public int  GL_MAX_COLOR_TEXTURE_SAMPLES       { get { return 0x910E; } } 
        public int  GL_MAX_DEPTH_TEXTURE_SAMPLES       { get { return 0x910F; } }
        public int GL_MAX_INTEGER_SAMPLES { get { return 0x9110; } } 

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawElementsBaseVertexDelegate(uint drawMode, Int32 count, int type, IntPtr indices, Int32 basevertex);
        internal DrawElementsBaseVertexDelegate glDrawElementsBaseVertex;

        public void DrawElementsBaseVertex<T3>(int drawMode, Int32 count, int drawElementsType, [InAttribute, OutAttribute] T3[] indices, Int32 basevertex)
            where T3 : struct
        {
                GCHandle indices_ptr = GCHandle.Alloc(indices, GCHandleType.Pinned);
                try
                {
                    glDrawElementsBaseVertex((uint)drawMode, (Int32)count, drawElementsType, (IntPtr)indices_ptr.AddrOfPinnedObject(), (Int32)basevertex);
                    CheckForErrors();
                }
                finally
                {
                    indices_ptr.Free();
                }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawRangeElementsBaseVertexDelegate(int drawMode, UInt32 start, UInt32 end, Int32 count, int type, IntPtr indices, Int32 basevertex);
        internal DrawRangeElementsBaseVertexDelegate glDrawRangeElementsBaseVertex;

        public void DrawRangeElementsBaseVertex<T5>(int drawMode, Int32 start, Int32 end, Int32 count, int drawElementsType, [InAttribute, OutAttribute] T5[] indices, Int32 basevertex)
            where T5 : struct
        {
            GCHandle indices_ptr = GCHandle.Alloc(indices, GCHandleType.Pinned);
            try
            {
                glDrawRangeElementsBaseVertex(drawMode, (UInt32)start, (UInt32)end, (Int32)count, drawElementsType, (IntPtr)indices_ptr.AddrOfPinnedObject(), (Int32)basevertex);
                CheckForErrors();
            }
            finally
            {
                indices_ptr.Free();
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawElementsInstancedBaseVertexDelegate(int drawMode, Int32 count, int type, IntPtr indices, Int32 primcount, Int32 basevertex);
        internal DrawElementsInstancedBaseVertexDelegate glDrawElementsInstancedBaseVertex;

        public void DrawElementsInstancedBaseVertex<T3>(int drawMode, Int32 count, int drawElementsType, [InAttribute, OutAttribute] T3[] indices, Int32 primcount, Int32 basevertex)
            where T3 : struct
        {
            GCHandle indices_ptr = GCHandle.Alloc(indices, GCHandleType.Pinned);
            try
            {
                glDrawElementsInstancedBaseVertex(drawMode, (Int32)count, drawElementsType, (IntPtr)indices_ptr.AddrOfPinnedObject(), (Int32)primcount, (Int32)basevertex);
                CheckForErrors();
            }
            finally
            {
                indices_ptr.Free();
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiDrawElementsBaseVertexDelegate(int drawMode, Int32* count, int type, IntPtr indices, Int32 primcount, Int32* basevertex);
        internal unsafe MultiDrawElementsBaseVertexDelegate glMultiDrawElementsBaseVertex;

        public void MultiDrawElementsBaseVertex<T3>(int drawMode, Int32[] count, int drawElementsType, [InAttribute, OutAttribute] T3[] indices, Int32 primcount, Int32[] basevertex)
            where T3 : struct
        {
            unsafe
            {
                fixed (Int32* count_ptr = count)
                fixed (Int32* basevertex_ptr = basevertex)
                {
                    GCHandle indices_ptr = GCHandle.Alloc(indices, GCHandleType.Pinned);
                    try
                    {
                        glMultiDrawElementsBaseVertex(drawMode, (Int32*)count_ptr, drawElementsType, (IntPtr)indices_ptr.AddrOfPinnedObject(), (Int32)primcount, (Int32*)basevertex_ptr);
                        CheckForErrors();
                    }
                    finally
                    {
                        indices_ptr.Free();
                    }
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProvokingVertexDelegate(int mode);
        internal ProvokingVertexDelegate glProvokingVertex;

        public void ProvokingVertex(int mode)
        {
            glProvokingVertex(mode);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMultisamplefvDelegate(int multisamplePName, UInt32 index, [OutAttribute] Single* val);
        internal unsafe GetMultisamplefvDelegate glGetMultisamplefv;

        public void GetMultisample(int multisamplePName, int index, [OutAttribute] Single[] val)
        {
            unsafe
            {
                fixed (Single* val_ptr = val)
                {
                    glGetMultisamplefv(multisamplePName, (UInt32)index, (Single*)val_ptr);
                    CheckForErrors();
                }
            }
        }

        public void GetMultisample(int multisamplePName, int index, [OutAttribute] out Single val)
        {
            unsafe
            {
                fixed (Single* val_ptr = &val)
                {
                    glGetMultisamplefv(multisamplePName, (UInt32)index, (Single*)val_ptr);
                    CheckForErrors();
                    val = *val_ptr;
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexImage3DMultisampleDelegate(int target, Int32 samples, int internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations);
        internal TexImage3DMultisampleDelegate glTexImage3DMultisample;

        public void TexImage3DMultisample(int multisampleTarget, Int32 samples, int internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations)
        {
            glTexImage3DMultisample(multisampleTarget, (Int32)samples, internalFormat, (Int32)width, (Int32)height, (Int32)depth, (bool)fixedsamplelocations);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexImage2DMultisampleDelegate(int target, Int32 samples, int internalformat, Int32 width, Int32 height, bool fixedsamplelocations);
        internal TexImage2DMultisampleDelegate glTexImage2DMultisample;

        public void TexImage2DMultisample(int multisampleTarget, Int32 samples, int internalformat, Int32 width, Int32 height, bool fixedsamplelocations)
        {
            glTexImage2DMultisample(multisampleTarget, (Int32)samples, internalformat, (Int32)width, (Int32)height, (bool)fixedsamplelocations);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate IntPtr FenceSyncDelegate(int condition, UInt32 flags);
        internal FenceSyncDelegate glFenceSync;

        public IntPtr FenceSync(int syncCondition, int flags)
        {
            IntPtr r = glFenceSync(syncCondition, (uint)flags);
            CheckForErrors();
            return r;
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DeleteSyncDelegate(IntPtr sync);
        internal DeleteSyncDelegate glDeleteSync;

        public void DeleteSync(IntPtr sync)
        {
            glDeleteSync(sync);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int ClientWaitSyncDelegate(IntPtr sync, UInt32 flags, UInt64 timeout);
        internal ClientWaitSyncDelegate glClientWaitSync;

        public int ClientWaitSync(IntPtr sync, int flags, long timeout)
        {
            int r = glClientWaitSync(sync, (uint)flags, (ulong)timeout);
            CheckForErrors();
            return r;
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WaitSyncDelegate(IntPtr sync, UInt32 flags, long timeout);
        internal WaitSyncDelegate glWaitSync;

        public void WaitSync(IntPtr sync, int flags, long timeout)
        {
            glWaitSync(sync, (uint)flags, timeout);
            CheckForErrors();
        }

        public void WaitSync(IntPtr sync, int flags)
        {
            WaitSync(sync, flags, unchecked((int)0xFFFFFFFFFFFFFFFF));
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetSyncivDelegate(IntPtr sync, int pname, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* values);
        internal unsafe GetSyncivDelegate glGetSynciv;

        public void GetSync(IntPtr sync, int syncPName, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] out Int32 values)
        {
            unsafe
            {
                fixed (Int32* length_ptr = &length)
                fixed (Int32* values_ptr = &values)
                {
                    glGetSynciv((IntPtr)sync, syncPName, (Int32)bufSize, (Int32*)length_ptr, (Int32*)values_ptr);
                    CheckForErrors();
                    length = *length_ptr;
                    values = *values_ptr;
                }
            }
        }

        public void GetSync(IntPtr sync, int syncPName, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] Int32[] values)
        {
            unsafe
            {
                fixed (Int32* values_ptr = values)
                fixed (Int32* length_ptr = &length)
                {
                    glGetSynciv((IntPtr)sync, syncPName, (Int32)bufSize, (Int32*)length_ptr, (Int32*)values_ptr);
                    length = *length_ptr;
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate bool IsSyncDelegate(IntPtr sync);
        internal IsSyncDelegate glIsSync;

        public bool IsSync(IntPtr sync)
        {
            bool r = glIsSync(sync);
            CheckForErrors();
            return r;
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetInteger64i_vDelegate(int target, UInt32 index, [OutAttribute] long* data);
        internal unsafe GetInteger64i_vDelegate glGetInteger64i_v;

        public void Get(int getPName, Int32 index, [OutAttribute] long[] data)
        {
            unsafe
            {
                fixed (long* data_ptr = data)
                {
                    glGetInteger64i_v(getPName, (UInt32)index, data_ptr);
                    CheckForErrors();
                }
            }
        }

        public void GetInteger(int getPName, Int32 index, [OutAttribute] out long data)
        {
                unsafe
                {
                    fixed (long* data_ptr = &data)
                    {
                        glGetInteger64i_v(getPName, (UInt32)index, data_ptr);
                        CheckForErrors();
                        data = *data_ptr;
                    }
                }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetBufferParameteri64vDelegate(int bufferTarget, int pname, [OutAttribute] long* @params);
        internal unsafe GetBufferParameteri64vDelegate glGetBufferParameteri64v;

        public void GetBufferParameter(int bufferTarget, int bufferPName, [OutAttribute] long[] @params)
        {
            unsafe
            {
                fixed (long* @params_ptr = @params)
                {
                    glGetBufferParameteri64v(bufferTarget, bufferPName, @params_ptr);
                    CheckForErrors();
                }
            }
        }

        public void GetBufferParameter(int bufferTarget, int bufferPName, [OutAttribute] out Int64 @params)
        {
                unsafe
                {
                    fixed (Int64* @params_ptr = &@params)
                    {
                        glGetBufferParameteri64v(bufferTarget, bufferPName, (Int64*)@params_ptr);
                        CheckForErrors();
                        @params = *@params_ptr;
                    }
                }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FramebufferTextureDelegate(int framebufferTarget, int framebufferAttachment, UInt32 texture, Int32 level);
        internal FramebufferTextureDelegate glFramebufferTexture;

        public void FramebufferTexture(int framebufferTarget, int framebufferAttachment, Int32 texture, Int32 level)
        {
            glFramebufferTexture(framebufferTarget, framebufferAttachment, (UInt32)texture, (Int32)level);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SampleMaskiDelegate(int index, int mask);
        internal SampleMaskiDelegate glSampleMaski;

        public void SampleMask(int index, int mask)
        {
            glSampleMaski(index, mask);
            CheckForErrors();
        }
    }
}
