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
    /* OpenGL 2.1 */
    public partial class GL30
    {
        public int  GL_PIXEL_PACK_BUFFER              { get { return 0x88EB; } }
        public int  GL_PIXEL_UNPACK_BUFFER            { get { return 0x88EC; } }
        public int  GL_PIXEL_PACK_BUFFER_BINDING      { get { return 0x88ED; } }
        public int  GL_PIXEL_UNPACK_BUFFER_BINDING    { get { return 0x88EF; } }
        public int  GL_FLOAT_MAT2x3                   { get { return 0x8B65; } }
        public int  GL_FLOAT_MAT2x4                   { get { return 0x8B66; } }
        public int  GL_FLOAT_MAT3x2                   { get { return 0x8B67; } }
        public int  GL_FLOAT_MAT3x4                   { get { return 0x8B68; } }
        public int  GL_FLOAT_MAT4x2                   { get { return 0x8B69; } }
        public int  GL_FLOAT_MAT4x3                   { get { return 0x8B6A; } }
        public int  GL_SRGB                           { get { return 0x8C40; } }
        public int  GL_SRGB8                          { get { return 0x8C41; } }
        public int  GL_SRGB_ALPHA                     { get { return 0x8C42; } }
        public int  GL_SRGB8_ALPHA8                   { get { return 0x8C43; } }
        public int  GL_COMPRESSED_SRGB                { get { return 0x8C48; } }
        public int  GL_COMPRESSED_SRGB_ALPHA { get { return 0x8C49; } }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix2x3fvd(int location, int count, bool transpose, float* value);
        internal unsafe UniformMatrix2x3fvd glUniformMatrix2x3fv;

        public void UniformMatrix2x3(int location, int count, bool transpose, float[] matrix)
        {
            unsafe
            {
                fixed (float* ptr = matrix)
                {
                    glUniformMatrix2x3fv(location, count, transpose, ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix3x2fvd(int location, int count, bool transpose, float* value);
        internal unsafe UniformMatrix3x2fvd glUniformMatrix3x2fv;

        public void UniformMatrix3x2(int location, int count, bool transpose, float[] matrix)
        {
            unsafe
            {
                fixed (float* ptr = matrix)
                {
                    glUniformMatrix3x2fv(location, count, transpose, ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix2x4fvd(int location, int count, bool transpose, float* value);
        internal unsafe UniformMatrix2x4fvd glUniformMatrix2x4fv;

        public void UniformMatrix2x4(int location, int count, bool transpose, float[] matrix)
        {
            unsafe
            {
                fixed (float* ptr = matrix)
                {
                    glUniformMatrix2x4fv(location, count, transpose, ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix4x2fvd(int location, int count, bool transpose, float* value);
        internal unsafe UniformMatrix4x2fvd glUniformMatrix4x2fv;

        public void UniformMatrix4x2(int location, int count, bool transpose, float[] matrix)
        {
            unsafe
            {
                fixed (float* ptr = matrix)
                {
                    glUniformMatrix4x2fv(location, count, transpose, ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix3x4fvd(int location, int count, bool transpose, float* value);
        internal unsafe UniformMatrix3x4fvd glUniformMatrix3x4fv;

        public void UniformMatrix3x4(int location, int count, bool transpose, float[] matrix)
        {
            unsafe
            {
                fixed (float* ptr = matrix)
                {
                    glUniformMatrix3x4fv(location, count, transpose, ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix4x3fvd(int location, int count, bool transpose, float* value);
        internal unsafe UniformMatrix4x3fvd glUniformMatrix4x3fv;

        public void UniformMatrix4x3(int location, int count, bool transpose, float[] matrix)
        {
            unsafe
            {
                fixed (float* ptr = matrix)
                {
                    glUniformMatrix4x3fv(location, count, transpose, ptr);
                    CheckForErrors();
                }
            }
        }
    }
}
