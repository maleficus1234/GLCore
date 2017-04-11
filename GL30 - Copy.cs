﻿// 
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
    /// <summary>
    /// Container class for all OpenGL 3.0 core functions provided by a context.
    /// </summary>
    public partial class GL30
        : GLBase
    {

        /// <summary>
        /// Constructs a new GL30 instance.
        /// </summary>
        /// <param name="context">The context with which this GL30 instance is associated.</param>
        public GL30(Context context)
            : base(context)
        {

        }

        public const int GL_COMPARE_REF_TO_TEXTURE         = 0x884E;
        public const int GL_CLIP_DISTANCE0                 = 0x3000;
        public const int GL_CLIP_DISTANCE1                 = 0x3001;
        public const int GL_CLIP_DISTANCE2                 = 0x3002;
        public const int GL_CLIP_DISTANCE3                 = 0x3003;
        public const int GL_CLIP_DISTANCE4                 = 0x3004;
        public const int GL_CLIP_DISTANCE5                 = 0x3005;
        public const int GL_CLIP_DISTANCE6                 = 0x3006;
        public const int GL_CLIP_DISTANCE7                 = 0x3007;
        public const int GL_MAX_CLIP_DISTANCES             = 0x0D32;
        public const int GL_MAJOR_VERSION                  = 0x821B;
        public const int GL_MINOR_VERSION                  = 0x821C;
        public const int GL_NUM_EXTENSIONS                 = 0x821D;
        public const int GL_CONTEXT_FLAGS                  = 0x821E;
        public const int GL_COMPRESSED_RED                 = 0x8225;
        public const int GL_COMPRESSED_RG                  = 0x8226;
        public const int GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x00000001;
        public const int GL_RGBA32F                        = 0x8814;
        public const int GL_RGB32F                         = 0x8815;
        public const int GL_RGBA16F                        = 0x881A;
        public const int GL_RGB16F                         = 0x881B;
        public const int GL_VERTEX_ATTRIB_ARRAY_INTEGER    = 0x88FD;
        public const int GL_MAX_ARRAY_TEXTURE_LAYERS       = 0x88FF;
        public const int GL_MIN_PROGRAM_TEXEL_OFFSET       = 0x8904;
        public const int GL_MAX_PROGRAM_TEXEL_OFFSET       = 0x8905;
        public const int GL_CLAMP_READ_COLOR               = 0x891C;
        public const int GL_FIXED_ONLY                     = 0x891D;
        public const int GL_MAX_VARYING_COMPONENTS         = 0x8B4B;
        public const int GL_TEXTURE_1D_ARRAY               = 0x8C18;
        public const int GL_PROXY_TEXTURE_1D_ARRAY         = 0x8C19;
        public const int GL_TEXTURE_2D_ARRAY               = 0x8C1A;
        public const int GL_PROXY_TEXTURE_2D_ARRAY         = 0x8C1B;
        public const int GL_TEXTURE_BINDING_1D_ARRAY       = 0x8C1C;
        public const int GL_TEXTURE_BINDING_2D_ARRAY       = 0x8C1D;
        public const int GL_R11F_G11F_B10F                 = 0x8C3A;
        public const int GL_UNSIGNED_INT_10F_11F_11F_REV   = 0x8C3B;
        public const int GL_RGB9_E5                        = 0x8C3D;
        public const int GL_UNSIGNED_INT_5_9_9_9_REV       = 0x8C3E;
        public const int GL_TEXTURE_SHARED_SIZE            = 0x8C3F;
        public const int GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76;
        public const int GL_TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F;
        public const int GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80;
        public const int GL_TRANSFORM_FEEDBACK_VARYINGS    = 0x8C83;
        public const int GL_TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84;
        public const int GL_TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85;
        public const int GL_PRIMITIVES_GENERATED           = 0x8C87;
        public const int GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88;
        public const int GL_RASTERIZER_DISCARD             = 0x8C89;
        public const int GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A;
        public const int GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B;
        public const int GL_INTERLEAVED_ATTRIBS            = 0x8C8C;
        public const int GL_SEPARATE_ATTRIBS               = 0x8C8D;
        public const int GL_TRANSFORM_FEEDBACK_BUFFER      = 0x8C8E;
        public const int GL_TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F;
        public const int GL_RGBA32UI                       = 0x8D70;
        public const int GL_RGB32UI                        = 0x8D71;
        public const int GL_RGBA16UI                       = 0x8D76;
        public const int GL_RGB16UI                        = 0x8D77;
        public const int GL_RGBA8UI                        = 0x8D7C;
        public const int GL_RGB8UI                         = 0x8D7D;
        public const int GL_RGBA32I                        = 0x8D82;
        public const int GL_RGB32I                         = 0x8D83;
        public const int GL_RGBA16I                        = 0x8D88;
        public const int GL_RGB16I                         = 0x8D89;
        public const int GL_RGBA8I                         = 0x8D8E;
        public const int GL_RGB8I                          = 0x8D8F;
        public const int GL_RED_INTEGER                    = 0x8D94;
        public const int GL_GREEN_INTEGER                  = 0x8D95;
        public const int GL_BLUE_INTEGER                   = 0x8D96;
        public const int GL_RGB_INTEGER                    = 0x8D98;
        public const int GL_RGBA_INTEGER                   = 0x8D99;
        public const int GL_BGR_INTEGER                    = 0x8D9A;
        public const int GL_BGRA_INTEGER                   = 0x8D9B;
        public const int GL_SAMPLER_1D_ARRAY               = 0x8DC0;
        public const int GL_SAMPLER_2D_ARRAY               = 0x8DC1;
        public const int GL_SAMPLER_1D_ARRAY_SHADOW        = 0x8DC3;
        public const int GL_SAMPLER_2D_ARRAY_SHADOW        = 0x8DC4;
        public const int GL_SAMPLER_CUBE_SHADOW            = 0x8DC5;
        public const int GL_UNSIGNED_INT_VEC2              = 0x8DC6;
        public const int GL_UNSIGNED_INT_VEC3              = 0x8DC7;
        public const int GL_UNSIGNED_INT_VEC4              = 0x8DC8;
        public const int GL_INT_SAMPLER_1D                 = 0x8DC9;
        public const int GL_INT_SAMPLER_2D                 = 0x8DCA;
        public const int GL_INT_SAMPLER_3D                 = 0x8DCB;
        public const int GL_INT_SAMPLER_CUBE               = 0x8DCC;
        public const int GL_INT_SAMPLER_1D_ARRAY           = 0x8DCE;
        public const int GL_INT_SAMPLER_2D_ARRAY           = 0x8DCF;
        public const int GL_UNSIGNED_INT_SAMPLER_1D        = 0x8DD1;
        public const int GL_UNSIGNED_INT_SAMPLER_2D        = 0x8DD2;
        public const int GL_UNSIGNED_INT_SAMPLER_3D        = 0x8DD3;
        public const int GL_UNSIGNED_INT_SAMPLER_CUBE      = 0x8DD4;
        public const int GL_UNSIGNED_INT_SAMPLER_1D_ARRAY  = 0x8DD6;
        public const int GL_UNSIGNED_INT_SAMPLER_2D_ARRAY  = 0x8DD7;
        public const int GL_QUERY_WAIT                     = 0x8E13;
        public const int GL_QUERY_NO_WAIT                  = 0x8E14;
        public const int GL_QUERY_BY_REGION_WAIT           = 0x8E15;
        public const int GL_QUERY_BY_REGION_NO_WAIT        = 0x8E16;
        public const int GL_BUFFER_ACCESS_FLAGS            = 0x911F;
        public const int GL_BUFFER_MAP_LENGTH              = 0x9120;
        public const int GL_BUFFER_MAP_OFFSET              = 0x9121;
        public const int GL_DEPTH_COMPONENT32F             = 0x8CAC;
        public const int GL_DEPTH32F_STENCIL8              = 0x8CAD;
        public const int GL_FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD;
        public const int GL_INVALID_FRAMEBUFFER_OPERATION  = 0x0506;
        public const int GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210;
        public const int GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211;
        public const int GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212;
        public const int GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213;
        public const int GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214;
        public const int GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215;
        public const int GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216;
        public const int GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217;
        public const int GL_FRAMEBUFFER_DEFAULT            = 0x8218;
        public const int GL_FRAMEBUFFER_UNDEFINED          = 0x8219;
        public const int GL_DEPTH_STENCIL_ATTACHMENT       = 0x821A;
        public const int GL_MAX_RENDERBUFFER_SIZE          = 0x84E8;
        public const int GL_DEPTH_STENCIL                  = 0x84F9;
        public const int GL_UNSIGNED_INT_24_8              = 0x84FA;
        public const int GL_DEPTH24_STENCIL8               = 0x88F0;
        public const int GL_TEXTURE_STENCIL_SIZE           = 0x88F1;
        public const int GL_TEXTURE_RED_TYPE               = 0x8C10;
        public const int GL_TEXTURE_GREEN_TYPE             = 0x8C11;
        public const int GL_TEXTURE_BLUE_TYPE              = 0x8C12;
        public const int GL_TEXTURE_ALPHA_TYPE             = 0x8C13;
        public const int GL_TEXTURE_DEPTH_TYPE             = 0x8C16;
        public const int GL_UNSIGNED_NORMALIZED            = 0x8C17;
        public const int GL_FRAMEBUFFER_BINDING            = 0x8CA6;
        public const int GL_DRAW_FRAMEBUFFER_BINDING       = 0x8CA6;
        public const int GL_RENDERBUFFER_BINDING           = 0x8CA7;
        public const int GL_READ_FRAMEBUFFER               = 0x8CA8;
        public const int GL_DRAW_FRAMEBUFFER               = 0x8CA9;
        public const int GL_READ_FRAMEBUFFER_BINDING       = 0x8CAA;
        public const int GL_RENDERBUFFER_SAMPLES           = 0x8CAB;
        public const int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;
        public const int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;
        public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;
        public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;
        public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4;
        public const int GL_FRAMEBUFFER_COMPLETE           = 0x8CD5;
        public const int GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;
        public const int GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;
        public const int GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB;
        public const int GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC;
        public const int GL_FRAMEBUFFER_UNSUPPORTED        = 0x8CDD;
        public const int GL_MAX_COLOR_ATTACHMENTS          = 0x8CDF;
        public const int GL_COLOR_ATTACHMENT0              = 0x8CE0;
        public const int GL_COLOR_ATTACHMENT1              = 0x8CE1;
        public const int GL_COLOR_ATTACHMENT2              = 0x8CE2;
        public const int GL_COLOR_ATTACHMENT3              = 0x8CE3;
        public const int GL_COLOR_ATTACHMENT4              = 0x8CE4;
        public const int GL_COLOR_ATTACHMENT5              = 0x8CE5;
        public const int GL_COLOR_ATTACHMENT6              = 0x8CE6;
        public const int GL_COLOR_ATTACHMENT7              = 0x8CE7;
        public const int GL_COLOR_ATTACHMENT8              = 0x8CE8;
        public const int GL_COLOR_ATTACHMENT9              = 0x8CE9;
        public const int GL_COLOR_ATTACHMENT10             = 0x8CEA;
        public const int GL_COLOR_ATTACHMENT11             = 0x8CEB;
        public const int GL_COLOR_ATTACHMENT12             = 0x8CEC;
        public const int GL_COLOR_ATTACHMENT13             = 0x8CED;
        public const int GL_COLOR_ATTACHMENT14             = 0x8CEE;
        public const int GL_COLOR_ATTACHMENT15             = 0x8CEF;
        public const int GL_DEPTH_ATTACHMENT               = 0x8D00;
        public const int GL_STENCIL_ATTACHMENT             = 0x8D20;
        public const int GL_FRAMEBUFFER                    = 0x8D40;
        public const int GL_RENDERBUFFER                   = 0x8D41;
        public const int GL_RENDERBUFFER_WIDTH             = 0x8D42;
        public const int GL_RENDERBUFFER_HEIGHT            = 0x8D43;
        public const int GL_RENDERBUFFER_INTERNAL_FORMAT   = 0x8D44;
        public const int GL_STENCIL_INDEX1                 = 0x8D46;
        public const int GL_STENCIL_INDEX4                 = 0x8D47;
        public const int GL_STENCIL_INDEX8                 = 0x8D48;
        public const int GL_STENCIL_INDEX16                = 0x8D49;
        public const int GL_RENDERBUFFER_RED_SIZE          = 0x8D50;
        public const int GL_RENDERBUFFER_GREEN_SIZE        = 0x8D51;
        public const int GL_RENDERBUFFER_BLUE_SIZE         = 0x8D52;
        public const int GL_RENDERBUFFER_ALPHA_SIZE        = 0x8D53;
        public const int GL_RENDERBUFFER_DEPTH_SIZE        = 0x8D54;
        public const int GL_RENDERBUFFER_STENCIL_SIZE      = 0x8D55;
        public const int GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56;
        public const int GL_MAX_SAMPLES                    = 0x8D57;
        public const int GL_FRAMEBUFFER_SRGB               = 0x8DB9;
        public const int GL_HALF_FLOAT                     = 0x140B;
        public const int GL_MAP_READ_BIT                   = 0x0001;
        public const int GL_MAP_WRITE_BIT                  = 0x0002;
        public const int GL_MAP_INVALIDATE_RANGE_BIT       = 0x0004;
        public const int GL_MAP_INVALIDATE_BUFFER_BIT      = 0x0008;
        public const int GL_MAP_FLUSH_EXPLICIT_BIT         = 0x0010;
        public const int GL_MAP_UNSYNCHRONIZED_BIT         = 0x0020;
        public const int GL_COMPRESSED_RED_RGTC1           = 0x8DBB;
        public const int GL_COMPRESSED_SIGNED_RED_RGTC1    = 0x8DBC;
        public const int GL_COMPRESSED_RG_RGTC2            = 0x8DBD;
        public const int GL_COMPRESSED_SIGNED_RG_RGTC2     = 0x8DBE;
        public const int GL_RG                             = 0x8227;
        public const int GL_RG_INTEGER                     = 0x8228;
        public const int GL_R8                             = 0x8229;
        public const int GL_R16                            = 0x822A;
        public const int GL_RG8                            = 0x822B;
        public const int GL_RG16                           = 0x822C;
        public const int GL_R16F                           = 0x822D;
        public const int GL_R32F                           = 0x822E;
        public const int GL_RG16F                          = 0x822F;
        public const int GL_RG32F                          = 0x8230;
        public const int GL_R8I                            = 0x8231;
        public const int GL_R8UI                           = 0x8232;
        public const int GL_R16I                           = 0x8233;
        public const int GL_R16UI                          = 0x8234;
        public const int GL_R32I                           = 0x8235;
        public const int GL_R32UI                          = 0x8236;
        public const int GL_RG8I                           = 0x8237;
        public const int GL_RG8UI                          = 0x8238;
        public const int GL_RG16I                          = 0x8239;
        public const int GL_RG16UI                         = 0x823A;
        public const int GL_RG32I                          = 0x823B;
        public const int GL_RG32UI = 0x823C;
        public const int GL_VERTEX_ARRAY_BINDING           = 0x85B5;



        /// <summary>
        /// Calls glGetError and throws an exception if an error is returned.
        /// This method is only called if the DEBUG conditional is defined.
        /// Otherwise it is ignored.
        /// </summary>
        [Conditional("DEBUG")]
        protected void CheckForErrors()
        {
            var err = this.GetError();
            if (err != GL_NO_ERROR)
                throw new Exception("glGetError reported an error: " + err);
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GenerateMipmapDelegate(uint target);
        internal GenerateMipmapDelegate glGenerateMipmap;

        public void GenerateMipmap(int mipMapTarget)
        {
            glGenerateMipmap((uint)mipMapTarget);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteVertexArraysd(int n, uint* arrays);
        internal unsafe DeleteVertexArraysd glDeleteVertexArrays;

        public void DeleteVertexArrays(int[] arrays)
        {
            unsafe
            {
                fixed (int* arrays_ptr = arrays)
                {
                    glDeleteVertexArrays(arrays.Length, (uint*)arrays_ptr);
                    CheckForErrors();
                }
            }
        }

        public void DeleteVertexArray(int array)
        {
            int[] arr = { array };
            DeleteVertexArrays(arr);
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindVertexArrayd(uint array);
        internal BindVertexArrayd glBindVertexArray;

        public void BindVertexArray(int array)
        {
            glBindVertexArray((uint)array);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenVertexArraysd(int n, [OutAttribute] uint* arrays);
        internal unsafe GenVertexArraysd glGenVertexArrays;

        public void GenVertexArrays([OutAttribute] int[] arrays)
        {
            unsafe
            {
                fixed (int* arrays_ptr = arrays)
                {
                    glGenVertexArrays(arrays.Length, (uint*)arrays_ptr);
                    CheckForErrors();
                }
            }
        }

        public int GenVertexArray()
        {
            int[] arr = new int[1];
            GenVertexArrays(arr);
            return arr[0];
        }



        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenFramebuffersDelegate(int n, [OutAttribute] uint* framebuffers);
        internal unsafe GenFramebuffersDelegate glGenFramebuffers;

        public void GenFramebuffers([OutAttribute] int[] framebuffers)
        {
            unsafe
            {
                fixed (int* framebuffers_ptr = framebuffers)
                {
                    glGenFramebuffers(framebuffers.Length, (uint*)framebuffers_ptr);
                    CheckForErrors();
                }
            }
        }

        public int GenFramebuffer()
        {
            int[] reference = new int[1];
            GenFramebuffers(reference);
            return reference[0];
        }

        public int[] GenFramebuffers(int n)
        {
            int[] r = new int[n];
            GenFramebuffers(r);
            return r;
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindFramebufferDelegate(int target, uint framebuffer);
        internal BindFramebufferDelegate glBindFramebuffer;

        public void BindFramebuffer(int framebufferTarget, int framebuffer)
        {
            glBindFramebuffer(framebufferTarget, (uint)framebuffer);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteFramebuffersDelegate(int n, uint* framebuffers);
        internal unsafe DeleteFramebuffersDelegate glDeleteFramebuffers;

        public void DeleteFramebuffers(int[] framebuffers)
        {
            unsafe
            {
                fixed (int* framebuffers_ptr = framebuffers)
                {
                    glDeleteFramebuffers(framebuffers.Length, (uint*)framebuffers_ptr);
                    CheckForErrors();
                }
            }
        }

        public void DeleteFramebuffer(int n)
        {
            int[] r = 
            {
                n
            };

            DeleteFramebuffers(r);
        }

        internal delegate void FramebufferTexture2DDelegate(int framebufferTarget,
            int framebufferAttachment,
            int textureTarget,
            uint texture,
            int level);
        internal FramebufferTexture2DDelegate glFramebufferTexture2D;

        public void FramebufferTexture2D(int framebufferTarget,
            int framebufferAttachment,
            int textureTarget,
            int texture,
            int level)
        {
            glFramebufferTexture2D(framebufferTarget, framebufferAttachment, textureTarget, (uint)texture, level);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenRenderbuffersDelegate(int n, [OutAttribute] uint* renderbuffers);
        internal unsafe GenRenderbuffersDelegate glGenRenderbuffers;

        public void GenRenderbuffers([OutAttribute] int[] renderbuffers)
        {
            unsafe
            {
                fixed (int* renderbuffers_ptr = renderbuffers)
                {
                    glGenRenderbuffers(renderbuffers.Length, (uint*)renderbuffers_ptr);
                    CheckForErrors();
                }
            }
        }

        public int GenRenderbuffer()
        {
            int[] r = new int[1];
            GenRenderbuffers(r);
            return r[0];
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindRenderbufferDelegate(int target, uint renderbuffer);
        internal BindRenderbufferDelegate glBindRenderbuffer;

        public void BindRenderbuffer(int renderbuffer)
        {
            glBindRenderbuffer(((int)0x8D41), (uint)renderbuffer);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RenderbufferStorageDelegate(int target, int internalformat, int width, int height);
        internal RenderbufferStorageDelegate glRenderbufferStorage;

        public void RenderBufferStorage(int target, int internalFormat, int width, int height)
        {
            glRenderbufferStorage(target, internalFormat, width, height);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FlushMappedBufferRangeDelegate(int target, IntPtr offset, IntPtr length);
        internal FlushMappedBufferRangeDelegate glFlushMappedBufferRange;

        public void FlushMappedBufferRange(int bufferTarget, int offset, int length)
        {
            glFlushMappedBufferRange(bufferTarget, new IntPtr(offset), new IntPtr(length));
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate IntPtr MapBufferRangeDelegate(int target, IntPtr offset, IntPtr length, int access);
        internal unsafe MapBufferRangeDelegate glMapBufferRange;

        public IntPtr MapBufferRange(int bufferTarget, int offset, int length, int access)
        {
            IntPtr i = glMapBufferRange(bufferTarget, new IntPtr(offset), new IntPtr(length), access);
            CheckForErrors();
            return i;
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribIPointerDelegate(uint index, int size, int type, int stride, IntPtr pointer);
        internal VertexAttribIPointerDelegate glVertexAttribIPointer;

        public void VertexAttribIPointer<T4>(int index, int size, int type, int stride, [InAttribute, OutAttribute] T4[] pointer)
            where T4 : struct
        {
            GCHandle pointer_ptr = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                glVertexAttribIPointer((uint)index, (int)size, type, (int)stride, (IntPtr)pointer_ptr.AddrOfPinnedObject());
                CheckForErrors();
            }
            finally
            {
                pointer_ptr.Free();
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindBufferRangeDelegate(int bufferTarget, uint index, uint buffer, IntPtr offset, IntPtr size);
        internal BindBufferRangeDelegate glBindBufferRange;

        public void BindBufferRange(int bufferTarget, int index, int buffer, int offset, int size)
        {
            glBindBufferRange(bufferTarget, (uint)index, (uint)buffer, new IntPtr(offset), new IntPtr(size));
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindBufferBaseDelegate(int bufferTarget, uint index, uint buffer);
        internal BindBufferBaseDelegate glBindBufferBase;

        public void BindBufferBase(int bufferTarget, int index, int buffer)
        {
            glBindBufferBase(bufferTarget, (uint)index, (uint)buffer);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate bool IsVertexArrayDelegate(uint array);
        internal IsVertexArrayDelegate glIsVertexArray;

        public bool IsVertexArray(int array)
        {
            bool r = glIsVertexArray((uint)array);
            CheckForErrors();
            return r;
        }



        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClampColorDelegate(int target, int clamp);
        internal ClampColorDelegate glClampColor;

        public void ClampColor(int target, int clamp)
        {
            glClampColor(target, clamp);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BeginConditionalRenderDelegate(uint id, int mode);
        internal BeginConditionalRenderDelegate glBeginConditionalRender;

        public void BeginConditionalRender(int id, int mode)
        {
            glBeginConditionalRender((uint)id, mode);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EndConditionalRenderDelegate();
        internal EndConditionalRenderDelegate glEndConditionalRender;

        public void EndConditionalRender()
        {
            glEndConditionalRender();
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BeginTransformFeedbackDelegate(int primitiveMode);
        internal BeginTransformFeedbackDelegate glBeginTransformFeedback;

        public void BeginTransformFeedback(int primitiveMode)
        {
            glBeginTransformFeedback(primitiveMode);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EndTransformFeedbackDelegate();
        internal EndTransformFeedbackDelegate glEndTransformFeedback;

        public void EndTransformFeedback()
        {
            glEndTransformFeedback();
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4bvDelegate(uint index, sbyte* v);
        internal unsafe VertexAttrib4bvDelegate glVertexAttrib4bv;

        [System.CLSCompliant(false)]
        public void VertexAttrib4(int index, sbyte[] v)
        {
            unsafe
            {
                fixed (sbyte* v_ptr = v)
                {
                    glVertexAttrib4bv((uint)index, (sbyte*)v_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4ivDelegate(uint index, int* v);
        internal unsafe VertexAttrib4ivDelegate glVertexAttrib4iv;

        public void VertexAttrib4(int index, int[] v)
        {
            unsafe
            {
                fixed (int* v_ptr = v)
                {
                    glVertexAttrib4iv((uint)index, (int*)v_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI1idelegate(uint index, int x);
        internal VertexAttribI1idelegate glVertexAttribI1i;

        public void VertexAttribI(int index, int x)
        {
            glVertexAttribI1i((uint)index, x);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI2idelegate(uint index, int x, int y);
        internal VertexAttribI2idelegate glVertexAttribI2i;

        public void VertexAttribI(int index, int x, int y)
        {
            glVertexAttribI2i((uint)index, x, y);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI3idelegate(uint index, int x, int y, int z);
        internal VertexAttribI3idelegate glVertexAttribI3i;

        public void VertexAttribI(int index, int x, int y, int z)
        {
            glVertexAttribI3i((uint)index, x, y, z);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI4idelegate(uint index, int x, int y, int z, int w);
        internal VertexAttribI4idelegate glVertexAttribI4i;

        public void VertexAttribI(int index, int x, int y, int z, int w)
        {
            glVertexAttribI4i((uint)index, x, y, z, w);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI1uidelegate(uint index, uint x);
        internal VertexAttribI1uidelegate glVertexAttribI1ui;

        [System.CLSCompliant(false)]
        public void VertexAttribI(int index, uint x)
        {
            glVertexAttribI1ui((uint)index, x);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI2uidelegate(uint index, uint x, uint y);
        internal VertexAttribI2uidelegate glVertexAttribI2ui;

        [System.CLSCompliant(false)]
        public void VertexAttribI(int index, uint x, uint y)
        {
            glVertexAttribI2ui((uint)index, x, y);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI3uidelegate(uint index, uint x, uint y, uint z);
        internal VertexAttribI3uidelegate glVertexAttribI3ui;

        [System.CLSCompliant(false)]
        public void VertexAttribI(int index, uint x, uint y, uint z)
        {
            glVertexAttribI3ui((uint)index, x, y, z);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI4uidelegate(uint index, uint x, uint y, uint z, uint w);
        internal VertexAttribI4uidelegate glVertexAttribI4ui;

        [System.CLSCompliant(false)]
        public void VertexAttribI(int index, uint x, uint y, uint z, uint w)
        {
            glVertexAttribI4ui((uint)index, x, y, z, w);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TransformFeedbackVaryingsdelegate(uint program, int count, string[] varyings, int bufferMode);
        internal TransformFeedbackVaryingsdelegate glTransformFeedbackVaryings;

        public void TransformFeedbackVaryings(int program, int count, string[] varyings, int bufferMode)
        {
            glTransformFeedbackVaryings((uint)program, count, varyings, bufferMode);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTransformFeedbackVaryingdelegate(uint program, uint index, int bufSize, [OutAttribute] int* length, [OutAttribute] int* size, [OutAttribute] int * attribType, [OutAttribute] StringBuilder name);
        internal unsafe GetTransformFeedbackVaryingdelegate glGetTransformFeedbackVarying;

        public void GetTransformFeedbackVarying(int program, int index, int bufSize, [OutAttribute] out int length, [OutAttribute] out int size, [OutAttribute] out int attribType, [OutAttribute] StringBuilder name)
        {
            unsafe
            {
                fixed (int* length_ptr = &length)
                fixed (int* size_ptr = &size)
                fixed (int* type_ptr = &attribType)
                {
                    glGetTransformFeedbackVarying((uint)program, (uint)index, (int)bufSize, (int*)length_ptr, (int*)size_ptr, (int*)type_ptr, (StringBuilder)name);
                    CheckForErrors();
                    length = *length_ptr;
                    size = *size_ptr;
                    attribType = *type_ptr;
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindFragDataLocationdelegate(uint program, uint color, string name);
        internal BindFragDataLocationdelegate glBindFragDataLocation;

        public void BindFragDataLocation(int program, int color, string name)
        {
            glBindFragDataLocation((uint)program, (uint)color, (string)name);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int GetFragDataLocationdelegate(uint program, string name);
        internal GetFragDataLocationdelegate glGetFragDataLocation;

        public int GetFragDataLocation(int program, string name)
        {
            int r = glGetFragDataLocation((uint)program, (string)name);
            CheckForErrors();
            return r;
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform1uidelegate(int location, uint v0);
        internal Uniform1uidelegate glUniform1ui;

        [System.CLSCompliant(false)]
        public void Uniform(int location, uint value)
        {
            glUniform1ui(location, value);
            CheckForErrors();
        }



        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform2uidelegate(int location, uint v0, uint v1);
        internal Uniform2uidelegate glUniform2ui;

        [System.CLSCompliant(false)]
        public void Uniform(int location, uint v0, uint v1)
        {
            glUniform2ui(location, v0, v1);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform3uidelegate(int location, uint v0, uint v1, uint v2);
        internal Uniform3uidelegate glUniform3ui;

        [System.CLSCompliant(false)]
        public void Uniform(int location, uint v0, uint v1, uint v2)
        {
            glUniform3ui(location, v0, v1, v2);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform4uidelegate(int location, uint v0, uint v1, uint v2, uint v3);
        internal Uniform4uidelegate glUniform4ui;

        [System.CLSCompliant(false)]
        public void Uniform(int location, uint v0, uint v1, uint v2, uint v3)
        {
            glUniform4ui(location, v0, v1, v2, v3);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI1ivdelegate(uint index, int* v);
        internal unsafe VertexAttribI1ivdelegate glVertexAttribI1iv;

        public void VertexAttribI1(int index, int[] v)
        {
            unsafe
            {
                fixed (int* vptr = v)
                {
                    glVertexAttribI1iv((uint)index, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI1uivdelegate(uint index, uint* v);
        internal unsafe VertexAttribI1uivdelegate glVertexAttribI1uiv;

        [System.CLSCompliant(false)]
        public void VertexAttribI1(int index, uint[] v)
        {
            unsafe
            {
                fixed (uint* vptr = v)
                {
                    glVertexAttribI1uiv((uint)index, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI2ivdelegate(uint index, int* v);
        internal unsafe VertexAttribI2ivdelegate glVertexAttribI2iv;

        public void VertexAttribI2(int index, int[] v)
        {
            unsafe
            {
                fixed (int* vptr = v)
                {
                    glVertexAttribI2iv((uint)index, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI2uivdelegate(uint index, uint* v);
        internal unsafe VertexAttribI2uivdelegate glVertexAttribI2uiv;

        [System.CLSCompliant(false)]
        public void VertexAttribI2(int index, uint[] v)
        {
            unsafe
            {
                fixed (uint* vptr = v)
                {
                    glVertexAttribI2uiv((uint)index, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI3ivdelegate(uint index, int* v);
        internal unsafe VertexAttribI3ivdelegate glVertexAttribI3iv;

        public void VertexAttribI3(int index, int[] v)
        {
            unsafe
            {
                fixed (int* vptr = v)
                {
                    glVertexAttribI3iv((uint)index, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI3uivdelegate(uint index, uint* v);
        internal unsafe VertexAttribI3uivdelegate glVertexAttribI3uiv;

        [System.CLSCompliant(false)]
        public void VertexAttribI3(int index, uint[] v)
        {
            unsafe
            {
                fixed (uint* vptr = v)
                {
                    glVertexAttribI3uiv((uint)index, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI4ivdelegate(uint index, int* v);
        internal unsafe VertexAttribI4ivdelegate glVertexAttribI4iv;

        public void VertexAttribI4(int index, int[] v)
        {
            unsafe
            {
                fixed (int* vptr = v)
                {
                    glVertexAttribI4iv((uint)index, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI4uivdelegate(uint index, uint* v);
        internal unsafe VertexAttribI4uivdelegate glVertexAttribI4uiv;

        [System.CLSCompliant(false)]
        public void VertexAttribI4(int index, uint[] v)
        {
            unsafe
            {
                fixed (uint* vptr = v)
                {
                    glVertexAttribI4uiv((uint)index, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI4bvdelegate(uint index, sbyte* v);
        internal unsafe VertexAttribI4bvdelegate glVertexAttribI4bv;

        [System.CLSCompliant(false)]
        public void VertexAttribI4(int index, sbyte[] v)
        {
            unsafe
            {
                fixed (sbyte* vptr = v)
                {
                    glVertexAttribI4bv((uint)index, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI4svdelegate(uint index, short* v);
        internal unsafe VertexAttribI4svdelegate glVertexAttribI4sv;

        public void VertexAttribI4(int index, short[] v)
        {
            unsafe
            {
                fixed (short* vptr = v)
                {
                    glVertexAttribI4sv((uint)index, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI4ubvdelegate(uint index, byte* v);
        internal unsafe VertexAttribI4ubvdelegate glVertexAttribI4ubv;

        public void VertexAttribI4(int index, byte[] v)
        {
            unsafe
            {
                fixed (byte* vptr = v)
                {
                    glVertexAttribI4ubv((uint)index, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI4usvdelegate(uint index, ushort* v);
        internal unsafe VertexAttribI4usvdelegate glVertexAttribI4usv;

        [System.CLSCompliant(false)]
        public void VertexAttribI4(int index, ushort[] v)
        {
            unsafe
            {
                fixed (ushort* vptr = v)
                {
                    glVertexAttribI4usv((uint)index, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform1uivdelegate(int location, int count, uint* value);
        internal unsafe Uniform1uivdelegate glUniform1uiv;

        [System.CLSCompliant(false)]
        public void Uniform1(int location, int count, uint[] v)
        {
            unsafe
            {
                fixed (uint* vptr = v)
                {
                    glUniform1uiv(location, count, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform2uivdelegate(int location, int count, uint* value);
        internal unsafe Uniform2uivdelegate glUniform2uiv;

        [System.CLSCompliant(false)]
        public void Uniform2(int location, int count, uint[] v)
        {
            unsafe
            {
                fixed (uint* vptr = v)
                {
                    glUniform2uiv(location, count, vptr);
                    CheckForErrors();
                }
            }
        }


        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform3uivdelegate(int location, int count, uint* value);
        internal unsafe Uniform3uivdelegate glUniform3uiv;

        [System.CLSCompliant(false)]
        public void Uniform3(int location, int count, uint[] v)
        {
            unsafe
            {
                fixed (uint* vptr = v)
                {
                    glUniform3uiv(location, count, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform4uivdelegate(int location, int count, uint* value);
        internal unsafe Uniform4uivdelegate glUniform4uiv;

        [System.CLSCompliant(false)]
        public void Uniform4(int location, int count, uint[] v)
        {
            unsafe
            {
                fixed (uint* vptr = v)
                {
                    glUniform4uiv(location, count, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetUniformuivdelegate(uint program, int location, [OutAttribute] uint* @params);
        internal unsafe GetUniformuivdelegate glGetUniformuiv;

        [System.CLSCompliant(false)]
        public void GetUniform(int program, int location, [OutAttribute] uint[] @params)
        {
            unsafe
            {
                fixed (uint* @params_ptr = @params)
                {
                    glGetUniformuiv((uint)program, (int)location, @params_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribIivdelegate(uint index, int pname, [OutAttribute] int* @params);
        internal unsafe GetVertexAttribIivdelegate glGetVertexAttribIiv;

        public void GetVertexAttribI(int index, int vertexAttribPName, [OutAttribute] int[] @params)
        {
            unsafe
            {
                fixed (int* @params_ptr = @params)
                {
                    glGetVertexAttribIiv((uint)index, vertexAttribPName, @params_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribIuivdelegate(uint index, int pname, [OutAttribute] uint* @params);
        internal unsafe GetVertexAttribIuivdelegate glGetVertexAttribIuiv;

        [System.CLSCompliant(false)]
        public void GetVertexAttribI(int index, int vertexAttribPName, [OutAttribute] uint[] @params)
        {
            unsafe
            {
                fixed (uint* @params_ptr = @params)
                {
                    glGetVertexAttribIuiv((uint)index, vertexAttribPName, @params_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexParameterIivdelegate(int textureTarget, int pname, int* @params);
        internal unsafe TexParameterIivdelegate glTexParameterIiv;

        public void TexParameterI(int textureTarget, int texturePName, int[] @params)
        {
            unsafe
            {
                fixed (int* @params_ptr = @params)
                {
                    glTexParameterIiv(textureTarget, texturePName, (int*)@params_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexParameterIuivdelegate(int textureTarget, int pname, uint* @params);
        internal unsafe TexParameterIuivdelegate glTexParameterIuiv;

        [System.CLSCompliant(false)]
        public void TexParameterI(int textureTarget, int texturePName, uint[] @params)
        {
            unsafe
            {
                fixed (uint* @params_ptr = @params)
                {
                    glTexParameterIuiv(textureTarget, texturePName, @params_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexParameterIivdelegate(int textureTarget, int textureParameter, [OutAttribute] int* @params);
        internal unsafe GetTexParameterIivdelegate glGetTexParameterIiv;

        public void GetTexParameterI(int textureTarget, int texturePName, int[] @params)
        {
            unsafe
            {
                fixed (int* @ptr = @params)
                {
                    glGetTexParameterIiv(textureTarget, texturePName, ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexParameterIuivdelegate(int textureTarget, int textureParameter, [OutAttribute] uint* @params);
        internal unsafe GetTexParameterIuivdelegate glGetTexParameterIuiv;

        [System.CLSCompliant(false)]
        public void GetTexParameterI(int textureTarget, int texturePName, uint[] @params)
        {
            unsafe
            {
                fixed (uint* @ptr = @params)
                {
                    glGetTexParameterIuiv(textureTarget, texturePName, ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlitFramebufferdelegate(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, int mask, int filter);
        internal BlitFramebufferdelegate glBlitFramebuffer;

        public void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, int mask, int filter)
        {
            glBlitFramebuffer((int)srcX0, (int)srcY0, (int)srcX1, (int)srcY1, (int)dstX0, (int)dstY0, (int)dstX1, (int)dstY1, mask, filter);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Enableidelegate(int target, uint index);
        internal Enableidelegate glEnablei;

        public void Enable(int target, int index)
        {
            glEnablei(target, (uint)index);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Disableidelegate(int target, uint index);
        internal Disableidelegate glDisablei;

        public void Disable(int target, int index)
        {
            glDisablei(target, (uint)index);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearBufferfidelegate(int buffer, int drawbuffer, float depth, int stencil);
        internal ClearBufferfidelegate glClearBufferfi;

        public void Clearbuffer(int clearBufferMask, int drawbuffer, float depth, int stencil)
        {
            glClearBufferfi(clearBufferMask, drawbuffer, depth, stencil);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteRenderbuffersdelegate(int n, uint* renderbuffers);
        internal unsafe DeleteRenderbuffersdelegate glDeleteRenderbuffers;

        public void DeleteRenderbuffers(int[] renderbuffers)
        {
            unsafe
            {
                fixed (int* renderbuffers_ptr = renderbuffers)
                {
                    glDeleteRenderbuffers(renderbuffers.Length, (uint*)renderbuffers_ptr);
                }
            }
        }

        public void DeleteRenderbuffer(int renderbuffer)
        {
            int [] n = { renderbuffer };
            DeleteRenderbuffers(n);
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RenderbufferStorageMultisampledelegate(int target, int samples, int internalformat, int width, int height);
        internal RenderbufferStorageMultisampledelegate glRenderbufferStorageMultisample;

        public void RenderbufferStorageMultisample(int target, int samples, int internalformat, int width, int height)
        {
            glRenderbufferStorageMultisample(target, samples, internalformat, width, height);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FramebufferRenderbufferdelegate(int framebufferTarget, int framebufferAttachment, int renderbuffertarget, uint renderbuffer);
        internal FramebufferRenderbufferdelegate glFramebufferRenderbuffer;

        public void FramebufferRenderbuffer(int framebufferTarget, int framebufferAttachment, int renderbuffertarget, int renderbuffer)
        {
            glFramebufferRenderbuffer(framebufferTarget, framebufferAttachment, renderbuffertarget, (uint)renderbuffer);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FramebufferTexture1Ddelegate(int framebufferTarget, int framebufferAttachment, int textureTarget, uint texture, int level);
        internal FramebufferTexture1Ddelegate glFramebufferTexture1D;

        public void FramebufferTexture1D(int framebufferTarget, int framebufferAttachment, int textureTarget, int texture, int level)
        {
            glFramebufferTexture1D(framebufferTarget, framebufferAttachment, textureTarget, (uint)texture, level);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FramebufferTexture3Ddelegate(int framebufferTarget, int framebufferAttachment, int textureTarget, uint texture, int level, int zoffset);
        internal FramebufferTexture3Ddelegate glFramebufferTexture3D;

        public void FramebufferTexture3D(int framebufferTarget, int framebufferAttachment, int textureTarget, int texture, int level, int zoffset)
        {
            glFramebufferTexture3D(framebufferTarget, framebufferAttachment, textureTarget, (uint)texture, level, zoffset);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FramebufferTextureLayerdelegate(int framebufferTarget, int framebufferAttachment, uint texture, int level, int layer);
        internal FramebufferTextureLayerdelegate glFramebufferTextureLayer;

        public void FramebufferTextureLayer(int framebufferTarget, int framebufferAttachment, int texture, int level, int layer)
        {
            glFramebufferTextureLayer(framebufferTarget, framebufferAttachment, (uint)texture, level, layer);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int CheckFramebufferStatusdelegate(int framebufferTarget);
        internal CheckFramebufferStatusdelegate glCheckFramebufferStatus;

        public int CheckFramebufferStatus(int framebufferTarget)
        {
            var e = glCheckFramebufferStatus(framebufferTarget);
            CheckForErrors();
            return e;
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate bool IsFramebufferdelegate(uint framebuffer);
        internal IsFramebufferdelegate glIsFramebuffer;

        public bool IsFramebuffer(int framebuffer)
        {
            bool r = glIsFramebuffer((uint)framebuffer);
            CheckForErrors();
            return r;
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFramebufferAttachmentParameterivdelegate(int framebufferTarget, int framebufferAttachment, int pname, [OutAttribute] int* @params);
        internal unsafe GetFramebufferAttachmentParameterivdelegate glGetFramebufferAttachmentParameteriv;

        public void GetFramebufferAttachmentParameter(int framebufferTarget, int framebufferAttachment, int framebufferAttachmentPName, [OutAttribute] int[] @params)
        {
            unsafe
            {
                fixed (int* @params_ptr = @params)
                {
                    glGetFramebufferAttachmentParameteriv(framebufferTarget, framebufferAttachment, framebufferAttachmentPName, (int*)@params_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate bool IsRenderbufferdelegate(uint renderbuffer);
        internal IsRenderbufferdelegate glIsRenderbuffer;

        public bool IsRenderbuffer(int renderbuffer)
        {
            bool r = glIsRenderbuffer((uint)renderbuffer);
            CheckForErrors();
            return r;
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetRenderbufferParameterivdelegate(int target, int renderbufferPName, [OutAttribute] int* @params);
        internal unsafe GetRenderbufferParameterivdelegate glGetRenderbufferParameteriv;

        public void GetRenderbufferParameter(int target, int renderbufferPName, [OutAttribute] int[] @params)
        {
            unsafe
            {
                fixed (int* @params_ptr = @params)
                {
                    glGetRenderbufferParameteriv(target, renderbufferPName, (int*)@params_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate IntPtr GetStringiDelegate(int name, int i);
        internal GetStringiDelegate glGetStringi;

        public string GetString(int getStringPName, int i)
        {
            unsafe
            {
                string s = System.Runtime.InteropServices.Marshal.PtrToStringAnsi(glGetStringi((int)getStringPName, i));
                CheckForErrors();
                return s;
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ColorMaskIndexeddelegate(uint index, bool r, bool g, bool b, bool a);
        internal ColorMaskIndexeddelegate glColorMaskIndexedEXT;

        public void ColorMaskIndexed(int index, bool r, bool g, bool b, bool a)
        {
            glColorMaskIndexedEXT((uint)index, r, g, b, a);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetBooleanIndexedvEXTdelegate(uint target, uint index, [OutAttribute] bool* data);
        internal unsafe GetBooleanIndexedvEXTdelegate glGetBooleanIndexedvEXT;

        public void GetBooleanIndexed(int getPName, int index, [OutAttribute] bool[] data)
        {
            unsafe
            {
                fixed (bool* data_ptr = data)
                {
                    glGetBooleanIndexedvEXT((uint)getPName, (uint)index, (bool*)data_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetIntegerIndexedvEXTdelegate(uint target, uint index, [OutAttribute] int* data);
        internal unsafe GetIntegerIndexedvEXTdelegate glGetIntegerIndexedvEXT;

        public void GetBooleanIndexed(int getPName, int index, [OutAttribute] int[] data)
        {
            unsafe
            {
                fixed (int* data_ptr = data)
                {
                    glGetIntegerIndexedvEXT((uint)getPName, (uint)index, (int*)data_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetActiveUniformNameDelegate(UInt32 program, UInt32 uniformIndex, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder uniformName);
        internal unsafe GetActiveUniformNameDelegate glGetActiveUniformName;

        public void GetActiveUniformName(Int32 program, Int32 uniformIndex, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] StringBuilder uniformName)
        {
            unsafe
            {
                fixed (Int32* length_ptr = &length)
                {
                    glGetActiveUniformName((UInt32)program, (UInt32)uniformIndex, (Int32)bufSize, (Int32*)length_ptr, (StringBuilder)uniformName);
                    CheckForErrors();
                    length = *length_ptr;
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EnableIndexedEXTdelegate(int target, uint index);
        internal EnableIndexedEXTdelegate glEnableIndexedEXT;

        public void EnableIndexed(int target, int index)
        {
            glEnableIndexedEXT(target, (uint)index);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DisableIndexedEXTdelegate(int target, uint index);
        internal DisableIndexedEXTdelegate glDisableIndexedEXT;

        public void DisableIndexed(int target, int index)
        {
            glDisableIndexedEXT(target, (uint)index);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate bool IsEnabledIndexedEXTdelegate(int target, uint index);
        internal IsEnabledIndexedEXTdelegate glIsEnabledIndexedEXT;

        public bool IsEnabledIndexed(int target, int index)
        {
            bool r = glIsEnabledIndexedEXT(target, (uint)index);
            CheckForErrors();
            return r;
        }
    }
}
