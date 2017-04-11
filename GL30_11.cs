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
    /* OpenGL 1.1 */
    public partial class GL30
    {
        public int GL_DEPTH_BUFFER_BIT { get { return 0x00000100; } }
        public int GL_STENCIL_BUFFER_BIT { get { return 0x00000400; } }
        public int GL_COLOR_BUFFER_BIT { get { return 0x00004000; } }
        public int GL_FALSE { get { return 0; } }
        public int GL_TRUE { get { return 1; } }
        public int GL_POINTS { get { return 0x0000; } }
        public int GL_LINES { get { return 0x0001; } }
        public int GL_LINE_LOOP { get { return 0x0002; } }
        public int GL_LINE_STRIP { get { return 0x0003; } }
        public int GL_TRIANGLES { get { return 0x0004; } }
        public int GL_TRIANGLE_STRIP { get { return 0x0005; } }
        public int GL_TRIANGLE_FAN { get { return 0x0006; } }
        public int GL_NEVER { get { return 0x0200; } }
        public int GL_LESS { get { return 0x0201; } }
        public int GL_EQUAL { get { return 0x0202; } }
        public int GL_LEQUAL { get { return 0x0203; } }
        public int GL_GREATER { get { return 0x0204; } }
        public int GL_NOTEQUAL { get { return 0x0205; } }
        public int GL_GEQUAL { get { return 0x0206; } }
        public int GL_ALWAYS { get { return 0x0207; } }
        public int GL_ZERO { get { return 0; } }
        public int GL_ONE { get { return 1; } }
        public int GL_SRC_COLOR { get { return 0x0300; } }
        public int GL_ONE_MINUS_SRC_COLOR { get { return 0x0301; } }
        public int GL_SRC_ALPHA { get { return 0x0302; } }
        public int GL_ONE_MINUS_SRC_ALPHA { get { return 0x0303; } }
        public int GL_DST_ALPHA { get { return 0x0304; } }
        public int GL_ONE_MINUS_DST_ALPHA { get { return 0x0305; } }
        public int GL_DST_COLOR { get { return 0x0306; } }
        public int GL_ONE_MINUS_DST_COLOR { get { return 0x0307; } }
        public int GL_SRC_ALPHA_SATURATE { get { return 0x0308; } }
        public int GL_NONE { get { return 0; } }
        public int GL_FRONT_LEFT { get { return 0x0400; } }
        public int GL_FRONT_RIGHT { get { return 0x0401; } }
        public int GL_BACK_LEFT { get { return 0x0402; } }
        public int GL_BACK_RIGHT { get { return 0x0403; } }
        public int GL_FRONT { get { return 0x0404; } }
        public int GL_BACK { get { return 0x0405; } }
        public int GL_LEFT { get { return 0x0406; } }
        public int GL_RIGHT { get { return 0x0407; } }
        public int GL_FRONT_AND_BACK { get { return 0x0408; } }
        public int GL_NO_ERROR { get { return 0; } }
        public int GL_INVALID_ENUM { get { return 0x0500; } }
        public int GL_INVALID_VALUE { get { return 0x0501; } }
        public int GL_INVALID_OPERATION { get { return 0x0502; } }
        public int GL_OUT_OF_MEMORY { get { return 0x0505; } }
        public int GL_CW { get { return 0x0900; } }
        public int GL_CCW { get { return 0x0901; } }
        public int GL_POINT_SIZE { get { return 0x0B11; } }
        public int GL_POINT_SIZE_RANGE { get { return 0x0B12; } }
        public int GL_POINT_SIZE_GRANULARITY { get { return 0x0B13; } }
        public int GL_LINE_SMOOTH { get { return 0x0B20; } }
        public int GL_LINE_WIDTH { get { return 0x0B21; } }
        public int GL_LINE_WIDTH_RANGE { get { return 0x0B22; } }
        public int GL_LINE_WIDTH_GRANULARITY { get { return 0x0B23; } }
        public int GL_POLYGON_MODE { get { return 0x0B40; } }
        public int GL_POLYGON_SMOOTH { get { return 0x0B41; } }
        public int GL_CULL_FACE { get { return 0x0B44; } }
        public int GL_CULL_FACE_MODE { get { return 0x0B45; } }
        public int GL_FRONT_FACE { get { return 0x0B46; } }
        public int GL_DEPTH_RANGE { get { return 0x0B70; } }
        public int GL_DEPTH_TEST { get { return 0x0B71; } }
        public int GL_DEPTH_WRITEMASK { get { return 0x0B72; } }
        public int GL_DEPTH_CLEAR_VALUE { get { return 0x0B73; } }
        public int GL_DEPTH_FUNC { get { return 0x0B74; } }
        public int GL_STENCIL_TEST { get { return 0x0B90; } }
        public int GL_STENCIL_CLEAR_VALUE { get { return 0x0B91; } }
        public int GL_STENCIL_FUNC { get { return 0x0B92; } }
        public int GL_STENCIL_VALUE_MASK { get { return 0x0B93; } }
        public int GL_STENCIL_FAIL { get { return 0x0B94; } }
        public int GL_STENCIL_PASS_DEPTH_FAIL { get { return 0x0B95; } }
        public int GL_STENCIL_PASS_DEPTH_PASS { get { return 0x0B96; } }
        public int GL_STENCIL_REF { get { return 0x0B97; } }
        public int GL_STENCIL_WRITEMASK { get { return 0x0B98; } }
        public int GL_VIEWPORT { get { return 0x0BA2; } }
        public int GL_DITHER { get { return 0x0BD0; } }
        public int GL_BLEND_DST { get { return 0x0BE0; } }
        public int GL_BLEND_SRC { get { return 0x0BE1; } }
        public int GL_BLEND { get { return 0x0BE2; } }
        public int GL_LOGIC_OP_MODE { get { return 0x0BF0; } }
        public int GL_COLOR_LOGIC_OP { get { return 0x0BF2; } }
        public int GL_DRAW_BUFFER { get { return 0x0C01; } }
        public int GL_READ_BUFFER { get { return 0x0C02; } }
        public int GL_SCISSOR_BOX { get { return 0x0C10; } }
        public int GL_SCISSOR_TEST { get { return 0x0C11; } }
        public int GL_COLOR_CLEAR_VALUE { get { return 0x0C22; } }
        public int GL_COLOR_WRITEMASK { get { return 0x0C23; } }
        public int GL_DOUBLEBUFFER { get { return 0x0C32; } }
        public int GL_STEREO { get { return 0x0C33; } }
        public int GL_LINE_SMOOTH_HINT { get { return 0x0C52; } }
        public int GL_POLYGON_SMOOTH_HINT { get { return 0x0C53; } }
        public int GL_UNPACK_SWAP_BYTES { get { return 0x0CF0; } }
        public int GL_UNPACK_LSB_FIRST { get { return 0x0CF1; } }
        public int GL_UNPACK_ROW_LENGTH { get { return 0x0CF2; } }
        public int GL_UNPACK_SKIP_ROWS { get { return 0x0CF3; } }
        public int GL_UNPACK_SKIP_PIXELS { get { return 0x0CF4; } }
        public int GL_UNPACK_ALIGNMENT { get { return 0x0CF5; } }
        public int GL_PACK_SWAP_BYTES { get { return 0x0D00; } }
        public int GL_PACK_LSB_FIRST { get { return 0x0D01; } }
        public int GL_PACK_ROW_LENGTH { get { return 0x0D02; } }
        public int GL_PACK_SKIP_ROWS { get { return 0x0D03; } }
        public int GL_PACK_SKIP_PIXELS { get { return 0x0D04; } }
        public int GL_PACK_ALIGNMENT { get { return 0x0D05; } }
        public int GL_MAX_TEXTURE_SIZE { get { return 0x0D33; } }
        public int GL_MAX_VIEWPORT_DIMS { get { return 0x0D3A; } }
        public int GL_SUBPIXEL_BITS { get { return 0x0D50; } }
        public int GL_TEXTURE_1D { get { return 0x0DE0; } }
        public int GL_TEXTURE_2D { get { return 0x0DE1; } }
        public int GL_POLYGON_OFFSET_UNITS { get { return 0x2A00; } }
        public int GL_POLYGON_OFFSET_POINT { get { return 0x2A01; } }
        public int GL_POLYGON_OFFSET_LINE { get { return 0x2A02; } }
        public int GL_POLYGON_OFFSET_FILL { get { return 0x8037; } }
        public int GL_POLYGON_OFFSET_FACTOR { get { return 0x8038; } }
        public int GL_TEXTURE_BINDING_1D { get { return 0x8068; } }
        public int GL_TEXTURE_BINDING_2D { get { return 0x8069; } }
        public int GL_TEXTURE_WIDTH { get { return 0x1000; } }
        public int GL_TEXTURE_HEIGHT { get { return 0x1001; } }
        public int GL_TEXTURE_INTERNAL_FORMAT { get { return 0x1003; } }
        public int GL_TEXTURE_BORDER_COLOR { get { return 0x1004; } }
        public int GL_TEXTURE_RED_SIZE { get { return 0x805C; } }
        public int GL_TEXTURE_GREEN_SIZE { get { return 0x805D; } }
        public int GL_TEXTURE_BLUE_SIZE { get { return 0x805E; } }
        public int GL_TEXTURE_ALPHA_SIZE { get { return 0x805F; } }
        public int GL_DONT_CARE { get { return 0x1100; } }
        public int GL_FASTEST { get { return 0x1101; } }
        public int GL_NICEST { get { return 0x1102; } }
        public int GL_BYTE { get { return 0x1400; } }
        public int GL_UNSIGNED_BYTE { get { return 0x1401; } }
        public int GL_SHORT { get { return 0x1402; } }
        public int GL_UNSIGNED_SHORT { get { return 0x1403; } }
        public int GL_INT { get { return 0x1404; } }
        public int GL_UNSIGNED_INT { get { return 0x1405; } }
        public int GL_FLOAT { get { return 0x1406; } }
        public int GL_DOUBLE { get { return 0x140A; } }
        public int GL_STACK_OVERFLOW { get { return 0x0503; } }
        public int GL_STACK_UNDERFLOW { get { return 0x0504; } }
        public int GL_CLEAR { get { return 0x1500; } }
        public int GL_AND { get { return 0x1501; } }
        public int GL_AND_REVERSE { get { return 0x1502; } }
        public int GL_COPY { get { return 0x1503; } }
        public int GL_AND_INVERTED { get { return 0x1504; } }
        public int GL_NOOP { get { return 0x1505; } }
        public int GL_XOR { get { return 0x1506; } }
        public int GL_OR { get { return 0x1507; } }
        public int GL_NOR { get { return 0x1508; } }
        public int GL_EQUIV { get { return 0x1509; } }
        public int GL_INVERT { get { return 0x150A; } }
        public int GL_OR_REVERSE { get { return 0x150B; } }
        public int GL_COPY_INVERTED { get { return 0x150C; } }
        public int GL_OR_INVERTED { get { return 0x150D; } }
        public int GL_NAND { get { return 0x150E; } }
        public int GL_SET { get { return 0x150F; } }
        public int GL_TEXTURE { get { return 0x1702; } }
        public int GL_COLOR { get { return 0x1800; } }
        public int GL_DEPTH { get { return 0x1801; } }
        public int GL_STENCIL { get { return 0x1802; } }
        public int GL_STENCIL_INDEX { get { return 0x1901; } }
        public int GL_DEPTH_COMPONENT { get { return 0x1902; } }
        public int GL_RED { get { return 0x1903; } }
        public int GL_GREEN { get { return 0x1904; } }
        public int GL_BLUE { get { return 0x1905; } }
        public int GL_ALPHA { get { return 0x1906; } }
        public int GL_RGB { get { return 0x1907; } }
        public int GL_RGBA { get { return 0x1908; } }
        public int GL_POINT { get { return 0x1B00; } }
        public int GL_LINE { get { return 0x1B01; } }
        public int GL_FILL { get { return 0x1B02; } }
        public int GL_KEEP { get { return 0x1E00; } }
        public int GL_REPLACE { get { return 0x1E01; } }
        public int GL_INCR { get { return 0x1E02; } }
        public int GL_DECR { get { return 0x1E03; } }
        public int GL_VENDOR { get { return 0x1F00; } }
        public int GL_RENDERER { get { return 0x1F01; } }
        public int GL_VERSION { get { return 0x1F02; } }
        public int GL_EXTENSIONS { get { return 0x1F03; } }
        public int GL_NEAREST { get { return 0x2600; } }
        public int GL_LINEAR { get { return 0x2601; } }
        public int GL_NEAREST_MIPMAP_NEAREST { get { return 0x2700; } }
        public int GL_LINEAR_MIPMAP_NEAREST { get { return 0x2701; } }
        public int GL_NEAREST_MIPMAP_LINEAR { get { return 0x2702; } }
        public int GL_LINEAR_MIPMAP_LINEAR { get { return 0x2703; } }
        public int GL_TEXTURE_MAG_FILTER { get { return 0x2800; } }
        public int GL_TEXTURE_MIN_FILTER { get { return 0x2801; } }
        public int GL_TEXTURE_WRAP_S { get { return 0x2802; } }
        public int GL_TEXTURE_WRAP_T { get { return 0x2803; } }
        public int GL_PROXY_TEXTURE_1D { get { return 0x8063; } }
        public int GL_PROXY_TEXTURE_2D { get { return 0x8064; } }
        public int GL_REPEAT { get { return 0x2901; } }
        public int GL_R3_G3_B2 { get { return 0x2A10; } }
        public int GL_RGB4 { get { return 0x804F; } }
        public int GL_RGB5 { get { return 0x8050; } }
        public int GL_RGB8 { get { return 0x8051; } }
        public int GL_RGB10 { get { return 0x8052; } }
        public int GL_RGB12 { get { return 0x8053; } }
        public int GL_RGB16 { get { return 0x8054; } }
        public int GL_RGBA2 { get { return 0x8055; } }
        public int GL_RGBA4 { get { return 0x8056; } }
        public int GL_RGB5_A1 { get { return 0x8057; } }
        public int GL_RGBA8 { get { return 0x8058; } }
        public int GL_RGB10_A2 { get { return 0x8059; } }
        public int GL_RGBA12 { get { return 0x805A; } }
        public int GL_RGBA16 { get { return 0x805B; } }
        public int GL_VERTEX_ARRAY { get { return 0x8074; } }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawArraysd(uint mode, int first, int count);
        internal DrawArraysd glDrawArrays;

        public void DrawArrays(int drawMode, int first, int count)
        {
            glDrawArrays((uint)drawMode, first, count);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawElementsDelegate(uint mode, int count, int type, IntPtr indices);
        internal DrawElementsDelegate glDrawElements;

        public void DrawElements<T3>(int drawMode, int count, int drawElementsType, [InAttribute, OutAttribute] T3[] indices)
            where T3 : struct
        {
            GCHandle indices_ptr = GCHandle.Alloc(indices, GCHandleType.Pinned);
            try
            {
                glDrawElements((uint)drawMode, (int)count, drawElementsType, (IntPtr)indices_ptr.AddrOfPinnedObject());
                CheckForErrors();
            }
            finally
            {
                indices_ptr.Free();
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PolygonOffsetDelegate(float factor, float units);
        internal PolygonOffsetDelegate glPolygonOffset;

        public void PolygonOffset(float factor, float units)
        {
            glPolygonOffset(factor, units);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexImage2Ddelegate(int textureTarget, int level, int internalformat, int x, int y, int width, int height, int border);
        internal CopyTexImage2Ddelegate glCopyTexImage2D;

        public void CopyTexImage2D(int textureTarget, int level, int internalformat, int x, int y, int width, int height, int border)
        {
            glCopyTexImage2D(textureTarget, (int)level, internalformat, (int)x, (int)y, (int)width, (int)height, (int)border);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexImage1Ddelegate(int textureTarget, int level, int internalformat, int x, int y, int width, int border);
        internal CopyTexImage1Ddelegate glCopyTexImage1D;

        public void CopyTexImage1D(int textureTarget, int level, int internalformat, int x, int y, int width, int border)
        {
            glCopyTexImage1D(textureTarget, (int)level, internalformat, (int)x, (int)y, (int)width, (int)border);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexSubImage2Ddelegate(int textureTarget, int level, int xoffset, int yoffset, int x, int y, int width, int height);
        internal CopyTexSubImage2Ddelegate glCopyTexSubImage2D;

        public void CopyTexSubImage2D(int textureTarget, int level, int xoffset, int yoffset, int x, int y, int width, int height)
        {
            glCopyTexSubImage2D(textureTarget, level, xoffset, yoffset, x, y, width, height);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexSubImage1Ddelegate(int textureTarget, int level, int xoffset, int x, int y, int width);
        internal CopyTexSubImage1Ddelegate glCopyTexSubImage1D;

        public void CopyTexSubImage1D(int textureTarget, int level, int xoffset, int x, int y, int width)
        {
            glCopyTexSubImage1D(textureTarget, level, xoffset, x, y, width);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexSubImage2Ddelegate(int textureTarget, int level, int xoffset, int yoffset, int zoffset, int width, int height, int pixelFormat, int pixelType, IntPtr pixels);
        internal TexSubImage2Ddelegate glTexSubImage2D;

        public void TexSubImage2D(int textureTarget, int level, int xoffset, int yoffset, int zoffset, int width, int height, int pixelFormat, int pixelType, IntPtr pixels)
        {
            glTexSubImage2D(textureTarget, (int)level, (int)xoffset, (int)yoffset, (int)zoffset, (int)width, (int)height, pixelFormat, pixelType, (IntPtr)pixels);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexSubImage1Ddelegate(int textureTarget, int level, int xoffset, int yoffset, int zoffset, int width, int pixelFormat, int pixelType, IntPtr pixels);
        internal TexSubImage1Ddelegate glTexSubImage1D;

        public void TexSubImage1D(int textureTarget, int level, int xoffset, int yoffset, int zoffset, int width, int pixelFormat, int pixelType, IntPtr pixels)
        {
            glTexSubImage1D(textureTarget, (int)level, (int)xoffset, (int)yoffset, (int)zoffset, (int)width, pixelFormat, pixelType, (IntPtr)pixels);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindTextured(uint unit, uint texture);
        internal BindTextured glBindTexture;

        public void BindTexture(int textureTarget, int texture)
        {
            glBindTexture((uint)textureTarget, (uint)texture);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate bool IsTextureDelegate(uint texture);
        internal IsTextureDelegate glIsTexture;

        public bool IsTexture(int texture)
        {
            bool r = glIsTexture((uint)texture);
            CheckForErrors();
            return r;
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenTexturesDelegate(int n, [OutAttribute] uint* textures);
        internal unsafe GenTexturesDelegate glGenTextures;

        public void GenTextures([OutAttribute] int[] textures)
        {
            unsafe
            {
                fixed (int* textures_ptr = textures)
                {
                    glGenTextures(textures.Length, (uint*)textures_ptr);
                    CheckForErrors();
                }
            }
        }

        public int GenTexture()
        {
            int[] arr = new int[1];
            GenTextures(arr);
            return arr[0];
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteTexturesd(int n, uint* textures);
        internal unsafe DeleteTexturesd glDeleteTextures;

        public void DeleteTextures(int[] textures)
        {
            unsafe
            {
                fixed (int* textures_ptr = textures)
                {
                    glDeleteTextures(textures.Length, (uint*)textures_ptr);
                    CheckForErrors();
                }
            }
        }

        public void DeleteTexture(int texture)
        {
            int[] arr = 
            {
                texture
            };
            DeleteTextures(arr);
        }
    }
}
