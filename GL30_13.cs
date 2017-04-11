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
    /* OpenGL 1.3 */
    public partial class GL30
    {
        public int GL_TEXTURE0 { get { return 0x84C0; } }
        public int GL_TEXTURE1 { get { return 0x84C1; } }
        public int GL_TEXTURE2 { get { return 0x84C2; } }
        public int GL_TEXTURE3 { get { return 0x84C3; } }
        public int GL_TEXTURE4 { get { return 0x84C4; } }
        public int GL_TEXTURE5 { get { return 0x84C5; } }
        public int GL_TEXTURE6 { get { return 0x84C6; } }
        public int GL_TEXTURE7 { get { return 0x84C7; } }
        public int GL_TEXTURE8 { get { return 0x84C8; } }
        public int GL_TEXTURE9 { get { return 0x84C9; } }
        public int GL_TEXTURE10 { get { return 0x84CA; } }
        public int GL_TEXTURE11 { get { return 0x84CB; } }
        public int GL_TEXTURE12 { get { return 0x84CC; } }
        public int GL_TEXTURE13 { get { return 0x84CD; } }
        public int GL_TEXTURE14 { get { return 0x84CE; } }
        public int GL_TEXTURE15 { get { return 0x84CF; } }
        public int GL_TEXTURE16 { get { return 0x84D0; } }
        public int GL_TEXTURE17 { get { return 0x84D1; } }
        public int GL_TEXTURE18 { get { return 0x84D2; } }
        public int GL_TEXTURE19 { get { return 0x84D3; } }
        public int GL_TEXTURE20 { get { return 0x84D4; } }
        public int GL_TEXTURE21 { get { return 0x84D5; } }
        public int GL_TEXTURE22 { get { return 0x84D6; } }
        public int GL_TEXTURE23 { get { return 0x84D7; } }
        public int GL_TEXTURE24 { get { return 0x84D8; } }
        public int GL_TEXTURE25 { get { return 0x84D9; } }
        public int GL_TEXTURE26 { get { return 0x84DA; } }
        public int GL_TEXTURE27 { get { return 0x84DB; } }
        public int GL_TEXTURE28 { get { return 0x84DC; } }
        public int GL_TEXTURE29 { get { return 0x84DD; } }
        public int GL_TEXTURE30 { get { return 0x84DE; } }
        public int GL_TEXTURE31 { get { return 0x84DF; } }
        public int GL_ACTIVE_TEXTURE { get { return 0x84E0; } }
        public int GL_MULTISAMPLE { get { return 0x809D; } }
        public int GL_SAMPLE_ALPHA_TO_COVERAGE { get { return 0x809E; } }
        public int GL_SAMPLE_ALPHA_TO_ONE { get { return 0x809F; } }
        public int GL_SAMPLE_COVERAGE { get { return 0x80A0; } }
        public int GL_SAMPLE_BUFFERS { get { return 0x80A8; } }
        public int GL_SAMPLES { get { return 0x80A9; } }
        public int GL_SAMPLE_COVERAGE_VALUE { get { return 0x80AA; } }
        public int GL_SAMPLE_COVERAGE_INVERT { get { return 0x80AB; } }
        public int GL_TEXTURE_CUBE_MAP { get { return 0x8513; } }
        public int GL_TEXTURE_BINDING_CUBE_MAP { get { return 0x8514; } }
        public int GL_TEXTURE_CUBE_MAP_POSITIVE_X { get { return 0x8515; } }
        public int GL_TEXTURE_CUBE_MAP_NEGATIVE_X { get { return 0x8516; } }
        public int GL_TEXTURE_CUBE_MAP_POSITIVE_Y { get { return 0x8517; } }
        public int GL_TEXTURE_CUBE_MAP_NEGATIVE_Y { get { return 0x8518; } }
        public int GL_TEXTURE_CUBE_MAP_POSITIVE_Z { get { return 0x8519; } }
        public int GL_TEXTURE_CUBE_MAP_NEGATIVE_Z { get { return 0x851A; } }
        public int GL_PROXY_TEXTURE_CUBE_MAP { get { return 0x851B; } }
        public int GL_MAX_CUBE_MAP_TEXTURE_SIZE { get { return 0x851C; } }
        public int GL_COMPRESSED_RGB { get { return 0x84ED; } }
        public int GL_COMPRESSED_RGBA { get { return 0x84EE; } }
        public int GL_TEXTURE_COMPRESSION_HINT { get { return 0x84EF; } }
        public int GL_TEXTURE_COMPRESSED_IMAGE_SIZE { get { return 0x86A0; } }
        public int GL_TEXTURE_COMPRESSED { get { return 0x86A1; } }
        public int GL_NUM_COMPRESSED_TEXTURE_FORMATS { get { return 0x86A2; } }
        public int GL_COMPRESSED_TEXTURE_FORMATS { get { return 0x86A3; } }
        public int GL_CLAMP_TO_BORDER { get { return 0x812D; } }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ActiveTextured(int unit);
        internal ActiveTextured glActiveTexture;

        public void ActiveTexture(int textureUnit)
        {
            glActiveTexture(textureUnit);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SampleCoverageDelegate(Single value, bool invert);
        internal SampleCoverageDelegate glSampleCoverage;

        public void SampleCoverage(float value, bool invert)
        {
            glSampleCoverage(value, invert);
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CompressedTexImage3Ddelegate(int textureTarget, int level, int internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data);
        internal CompressedTexImage3Ddelegate glCompressedTexImage3D;

        public void CompressedTexImage3D(int textureTarget, int level, int internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data)
        {
            glCompressedTexImage3D(textureTarget, (int)level, internalformat, (int)width, (int)height, (int)depth, (int)border, (int)imageSize, (IntPtr)data);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CompressedTexImage2Ddelegate(int textureTarget, int level, int internalformat, int width, int height, int border, int imageSize, IntPtr data);
        internal CompressedTexImage2Ddelegate glCompressedTexImage2D;

        public void CompressedTexImage2D(int textureTarget, int level, int internalformat, int width, int height, int border, int imageSize, IntPtr data)
        {
            glCompressedTexImage2D(textureTarget, (int)level, internalformat, (int)width, (int)height, border, (int)imageSize, (IntPtr)data);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CompressedTexImage1Ddelegate(int textureTarget, int level, int internalformat, int width, int border, int imageSize, IntPtr data);
        internal CompressedTexImage1Ddelegate glCompressedTexImage1D;

        public void CompressedTexImage1D(int textureTarget, int level, int internalformat, int width, int border, int imageSize, IntPtr data)
        {
            glCompressedTexImage1D(textureTarget, (int)level, internalformat, (int)width, border, (int)imageSize, (IntPtr)data);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CompressedTexSubImage3Ddelegate(int textureTarget, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int pixelFormat, int imageSize, IntPtr data);
        internal CompressedTexSubImage3Ddelegate glCompressedTexSubImage3D;

        public void CompressedTexSubImage3D(int textureTarget, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int pixelFormat, int imageSize, IntPtr data)
        {
            glCompressedTexSubImage3D(textureTarget, (int)level, (int)xoffset, (int)yoffset, (int)zoffset, (int)width, (int)height, (int)depth, pixelFormat, (int)imageSize, (IntPtr)data);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CompressedTexSubImage2Ddelegate(int textureTarget, int level, int xoffset, int yoffset, int width, int height, int pixelFormat, int imageSize, IntPtr data);
        internal CompressedTexSubImage2Ddelegate glCompressedTexSubImage2D;

        public void CompressedTexSubImage2D(int textureTarget, int level, int xoffset, int yoffset, int width, int height, int pixelFormat, int imageSize, IntPtr data)
        {
            glCompressedTexSubImage2D(textureTarget, (int)level, (int)xoffset, (int)yoffset, width, (int)height, pixelFormat, (int)imageSize, (IntPtr)data);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CompressedTexSubImage1Ddelegate(int textureTarget, int level, int xoffset, int width, int pixelFormat, int imageSize, IntPtr data);
        internal CompressedTexSubImage1Ddelegate glCompressedTexSubImage1D;

        public void CompressedTexSubImage1D(int textureTarget, int level, int xoffset, int width, int pixelFormat, int imageSize, IntPtr data)
        {
            glCompressedTexSubImage1D(textureTarget, (int)level, (int)xoffset, width, pixelFormat, (int)imageSize, (IntPtr)data);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GetCompressedTexImagedelegate(int textureTarget, int level, [OutAttribute] IntPtr img);
        internal GetCompressedTexImagedelegate glGetCompressedTexImage;

        public void GetCompressedTexImage(int textureTarget, int level, [OutAttribute] IntPtr img)
        {
            glGetCompressedTexImage(textureTarget, (int)level, (IntPtr)img);
            CheckForErrors();
        }
    }
}
