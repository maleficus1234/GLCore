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
    /* OpenGL 1.4 */
    public partial class GL30
    {
        public int GL_BLEND_DST_RGB { get { return 0x80C8; } }
        public int GL_BLEND_SRC_RGB { get { return 0x80C9; } }
        public int GL_BLEND_DST_ALPHA { get { return 0x80CA; } }
        public int GL_BLEND_SRC_ALPHA { get { return 0x80CB; } }
        public int GL_POINT_FADE_THRESHOLD_SIZE { get { return 0x8128; } }
        public int GL_DEPTH_COMPONENT16 { get { return 0x81A5; } }
        public int GL_DEPTH_COMPONENT24 { get { return 0x81A6; } }
        public int GL_DEPTH_COMPONENT32 { get { return 0x81A7; } }
        public int GL_MIRRORED_REPEAT { get { return 0x8370; } }
        public int GL_MAX_TEXTURE_LOD_BIAS { get { return 0x84FD; } }
        public int GL_TEXTURE_LOD_BIAS { get { return 0x8501; } }
        public int GL_INCR_WRAP { get { return 0x8507; } }
        public int GL_DECR_WRAP { get { return 0x8508; } }
        public int GL_TEXTURE_DEPTH_SIZE { get { return 0x884A; } }
        public int GL_TEXTURE_COMPARE_MODE { get { return 0x884C; } }
        public int GL_TEXTURE_COMPARE_FUNC { get { return 0x884D; } }
        public int GL_FUNC_ADD { get { return 0x8006; } }
        public int GL_FUNC_SUBTRACT { get { return 0x800A; } }
        public int GL_FUNC_REVERSE_SUBTRACT { get { return 0x800B; } }
        public int GL_MIN { get { return 0x8007; } }
        public int GL_MAX { get { return 0x8008; } }
        public int GL_CONSTANT_COLOR { get { return 0x8001; } }
        public int GL_ONE_MINUS_CONSTANT_COLOR { get { return 0x8002; } }
        public int GL_CONSTANT_ALPHA { get { return 0x8003; } }
        public int GL_ONE_MINUS_CONSTANT_ALPHA { get { return 0x8004; } }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendFuncSeparatedelegate(int sfactorRGB, int dfactorRGB, int sfactorAlpha, int dfactorAlpha);
        internal BlendFuncSeparatedelegate glBlendFuncSeparate;

        public void BlendFuncSeparate(int sRgbBlendingFactor, int dRgbBlendingFactor, int sAlphaBlendingFactor, int dAlphaBlendingFactor)
        {
            glBlendFuncSeparate(sRgbBlendingFactor, dRgbBlendingFactor, sAlphaBlendingFactor, dAlphaBlendingFactor);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiDrawArraysDelegate(uint mode, int* first, int* count, int primcount);
        internal unsafe MultiDrawArraysDelegate glMultiDrawArrays;

        public void MultiDrawArrays(int drawMode, int[] first, int[] count, int primcount)
        {
            unsafe
            {
                fixed (int* first_ptr = first)
                fixed (int* count_ptr = count)
                {
                    glMultiDrawArrays((uint)drawMode, (int*)first_ptr, (int*)count_ptr, (int)primcount);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiDrawElementsDelegate(uint mode, int* count, int type, IntPtr indices, int primcount);
        internal unsafe MultiDrawElementsDelegate glMultiDrawElements;

        public void MultiDrawElements<T3>(int drawMode, int[] count, int drawElementsType, [InAttribute, OutAttribute] T3[] indices, int primcount)
            where T3 : struct
        {
            unsafe
            {
                fixed (int* count_ptr = count)
                {
                    GCHandle indices_ptr = GCHandle.Alloc(indices, GCHandleType.Pinned);
                    try
                    {
                        glMultiDrawElements((uint)drawMode, (int*)count_ptr, drawElementsType, (IntPtr)indices_ptr.AddrOfPinnedObject(), (int)primcount);
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
        internal delegate void PointParameterfdelegate(int pname, float param);
        internal PointParameterfdelegate glPointParameterf;

        public void PointParameter(int name, float param)
        {
            glPointParameterf(name, param);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PointParameteridelegate(int pname, int param);
        internal PointParameteridelegate glPointParameteri;

        public void PointParameter(int name, int param)
        {
            glPointParameteri(name, param);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PointParameterfvdelegate(int pname, float* @params);
        internal unsafe PointParameterfvdelegate glPointParameterfv;

        public void PointParameter(int pname, float[] @params)
        {
            unsafe
            {
                fixed (float* @params_ptr = @params)
                {
                    glPointParameterfv(pname, @params_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PointParameterivdelegate(int pname, int* @params);
        internal unsafe PointParameterivdelegate glPointParameteriv;

        public void PointParameter(int pname, int[] @params)
        {
            unsafe
            {
                fixed (int* @params_ptr = @params)
                {
                    glPointParameteriv(pname, @params_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendColordelegate(float red, float green, float blue, float alpha);
        internal BlendColordelegate glBlendColor;

        public void BlendColor(float red, float green, float blue, float alpha)
        {
            glBlendColor(red, green, blue, alpha);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendEquationdelegate(int mode);
        internal BlendEquationdelegate glBlendEquation;

        public void BlendEquation(int blendingEquation)
        {
            glBlendEquation(blendingEquation);
            CheckForErrors();
        }

    }
}
