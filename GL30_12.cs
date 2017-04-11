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
    /* OpenGL 1.2 */
    public partial class GL30
    {
        public int GL_UNSIGNED_BYTE_3_3_2 { get { return 0x8032; } }
        public int GL_UNSIGNED_SHORT_4_4_4_4 { get { return 0x8033; } }
        public int GL_UNSIGNED_SHORT_5_5_5_1 { get { return 0x8034; } }
        public int GL_UNSIGNED_INT_8_8_8_8 { get { return 0x8035; } }
        public int GL_UNSIGNED_INT_10_10_10_2 { get { return 0x8036; } }
        public int GL_TEXTURE_BINDING_3D { get { return 0x806A; } }
        public int GL_PACK_SKIP_IMAGES { get { return 0x806B; } }
        public int GL_PACK_IMAGE_HEIGHT { get { return 0x806C; } }
        public int GL_UNPACK_SKIP_IMAGES { get { return 0x806D; } }
        public int GL_UNPACK_IMAGE_HEIGHT { get { return 0x806E; } }
        public int GL_TEXTURE_3D { get { return 0x806F; } }
        public int GL_PROXY_TEXTURE_3D { get { return 0x8070; } }
        public int GL_TEXTURE_DEPTH { get { return 0x8071; } }
        public int GL_TEXTURE_WRAP_R { get { return 0x8072; } }
        public int GL_MAX_3D_TEXTURE_SIZE { get { return 0x8073; } }
        public int GL_UNSIGNED_BYTE_2_3_3_REV { get { return 0x8362; } }
        public int GL_UNSIGNED_SHORT_5_6_5 { get { return 0x8363; } }
        public int GL_UNSIGNED_SHORT_5_6_5_REV { get { return 0x8364; } }
        public int GL_UNSIGNED_SHORT_4_4_4_4_REV { get { return 0x8365; } }
        public int GL_UNSIGNED_SHORT_1_5_5_5_REV { get { return 0x8366; } }
        public int GL_UNSIGNED_INT_8_8_8_8_REV { get { return 0x8367; } }
        public int GL_UNSIGNED_INT_2_10_10_10_REV { get { return 0x8368; } }
        public int GL_BGR { get { return 0x80E0; } }
        public int GL_BGRA { get { return 0x80E1; } }
        public int GL_MAX_ELEMENTS_VERTICES { get { return 0x80E8; } }
        public int GL_MAX_ELEMENTS_INDICES { get { return 0x80E9; } }
        public int GL_CLAMP_TO_EDGE { get { return 0x812F; } }
        public int GL_TEXTURE_MIN_LOD { get { return 0x813A; } }
        public int GL_TEXTURE_MAX_LOD { get { return 0x813B; } }
        public int GL_TEXTURE_BASE_LEVEL { get { return 0x813C; } }
        public int GL_TEXTURE_MAX_LEVEL { get { return 0x813D; } }
        public int GL_SMOOTH_POINT_SIZE_RANGE { get { return 0x0B12; } }
        public int GL_SMOOTH_POINT_SIZE_GRANULARITY { get { return 0x0B13; } }
        public int GL_SMOOTH_LINE_WIDTH_RANGE { get { return 0x0B22; } }
        public int GL_SMOOTH_LINE_WIDTH_GRANULARITY { get { return 0x0B23; } }
        public int GL_ALIASED_LINE_WIDTH_RANGE { get { return 0x846E; } }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawRangeElementsDelegate(uint mode, uint start, uint end, int count, int type, IntPtr indices);
        internal DrawRangeElementsDelegate glDrawRangeElements;

        public void DrawRangeElements<T5>(int drawMode, int start, int end, int count, int drawElementsType, [InAttribute, OutAttribute] T5[] indices)
            where T5 : struct
        {
            GCHandle indices_ptr = GCHandle.Alloc(indices, GCHandleType.Pinned);
            try
            {
                glDrawRangeElements((uint)drawMode, (uint)start, (uint)end, (int)count, drawElementsType, (IntPtr)indices_ptr.AddrOfPinnedObject());
                CheckForErrors();
            }
            finally
            {
                indices_ptr.Free();
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexImage3Ddelegate(int textureTarget,
            int level,
            int internalformat,
            int width,
            int height,
            int depth,
            int border,
            int pixelFormat,
            int pixelType,
            IntPtr pixels);
        internal TexImage3Ddelegate glTexImage3D;

        public void TexImage3D(int textureTarget, int level, int internalformat, int width, int height, int depth, int border, int pixelFormat, int pixelType, IntPtr pixels)
        {
            glTexImage3D(textureTarget, level, internalformat, width, height, depth, border, pixelFormat, pixelType, pixels);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexSubImage3Ddelegate(int textureTarget, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int pixelFormat, int pixelType, IntPtr pixels);
        internal TexSubImage3Ddelegate glTexSubImage3D;

        public void TexSubImage3D(int textureTarget, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int pixelFormat, int pixelType, IntPtr pixels)
        {
            glTexSubImage3D(textureTarget, (int)level, (int)xoffset, (int)yoffset, (int)zoffset, (int)width, (int)height, (int)depth, pixelFormat, pixelType, (IntPtr)pixels);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexSubImage3Ddelegate(int textureTarget, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
        internal CopyTexSubImage3Ddelegate glCopyTexSubImage3D;

        public void CopyTexSubImage3D(int textureTarget, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
        {
            glCopyTexSubImage3D(textureTarget, level, xoffset, yoffset, zoffset, x, y, width, height);
            CheckForErrors();
        }
    }
}
