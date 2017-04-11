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
    /* OpenGL 1.0 */
    public partial class GL30
    {
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CullFaceDelegate(int mode);
        internal CullFaceDelegate glCullFace;

        public void CullFace(int mode)
        {
            glCullFace(mode);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FrontFaceDelegate(int mode);
        internal FrontFaceDelegate glFrontFace;

        public void FrontFace(int mode)
        {
            glFrontFace(mode);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Hintdelegate(int target, int mode);
        internal Hintdelegate glHint;

        public void Hint(int hintTarget, int mode)
        {
            glHint(hintTarget, mode);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LineWidthdelegate(float width);
        internal LineWidthdelegate glLineWidth;

        public void LineWidth(float width)
        {
            glLineWidth(width);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PointSizedelegate(float size);
        internal PointSizedelegate glPointSize;

        public void PointSize(float size)
        {
            glPointSize(size);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PolygonModeDelegate(int face, int mode);
        internal PolygonModeDelegate glPolygonMode;

        public void PolygonMode(int face, int mode)
        {
            glPolygonMode(face, mode);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ScissorDelegate(int x, int y, int width, int height);
        internal ScissorDelegate glScissor;

        public void Scissor(int x, int y, int width, int height)
        {
            glScissor(x, y, width, height);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexParameterid(int textureTarget, int pname, int param);
        internal TexParameterid glTexParameteri;

        public void TexParameter(int textureTarget, int texturePName, int param)
        {
            glTexParameteri(textureTarget, texturePName, param);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexParameterfd(int textureTarget, int texturePName, float param);
        internal TexParameterfd glTexParameterf;

        public void TexParameter(int textureTarget, int texturePName, float param)
        {
            glTexParameterf(textureTarget, texturePName, param);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexParameterfvdelegate(int textureTarget, int pname, float* @params);
        internal unsafe TexParameterfvdelegate glTexParameterfv;

        public void TexParameter(int textureTarget, int texturePName, float[] @params)
        {
            unsafe
            {
                fixed (float* @params_ptr = @params)
                {
                    glTexParameterfv(textureTarget, texturePName, (float*)@params_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexParameterivdelegate(int textureTarget, int pname, int* @params);
        internal unsafe TexParameterivdelegate glTexParameteriv;

        public void TexParameter(int textureTarget, int texturePName, int[] @params)
        {
            unsafe
            {
                fixed (int* @params_ptr = @params)
                {
                    glTexParameteriv(textureTarget, texturePName, (int*)@params_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexImage1Ddelegate(int textureTarget, int level, int internalformat, int width, int border, int pixelFormat, int pixelType, IntPtr pixels);
        internal TexImage1Ddelegate glTexImage1D;

        public void TexImage1D(int textureTarget, int level, int internalformat, int width, int height, int depth, int border, int pixelFormat, int pixelType, IntPtr pixels)
        {
            glTexImage1D(textureTarget, level, internalformat, width, border, pixelFormat, pixelType, pixels);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexImage2Dd(int textureTarget,
            int level,
            int internalformat,
            int width, int height, int border,
            int pixelFormat,
            int pixelType,
            IntPtr pixels);
        internal TexImage2Dd glTexImage2D;

        public void TexImage2D(int textureTarget,
            int level,
            int internalformat,
            int width, int height, int border,
            int pixelFormat,
            int pixelType,
            IntPtr pixels)
        {
            glTexImage2D(textureTarget,
                level,
                internalformat,
                width,
                height,
                border,
                pixelFormat,
                pixelType,
                pixels);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawBufferDelegate(int mode);
        internal DrawBufferDelegate glDrawBuffer;

        public void DrawBuffer(int colorBufferMode)
        {
            glDrawBuffer(colorBufferMode);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearColorDelegate(float red, float green, float blue, float alpha);
        internal ClearColorDelegate glClearColor;

        public void ClearColor(float red, float green, float blue, float alpha)
        {
            glClearColor((float)red, (float)green, (float)blue, (float)alpha);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearDelegate(int mask);
        internal ClearDelegate glClear;

        public void Clear(int clearBufferMask)
        {
            glClear(clearBufferMask);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearDepthdelegate(Double depth);
        internal ClearDepthdelegate glClearDepth;

        public void ClearDepth(Double depth)
        {
            glClearDepth(depth);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearStencildelegate(int s);
        internal ClearStencildelegate glClearStencil;

        public void ClearStencil(int s)
        {
            glClearStencil(s);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ColorMaskdelegate(bool red, bool green, bool blue, bool alpha);
        internal ColorMaskdelegate glColorMask;

        public void ColorMask(bool red, bool green, bool blue, bool alpha)
        {
            glColorMask(red, green, blue, alpha);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ColorMaskidelegate(uint index, bool red, bool green, bool blue, bool alpha);
        internal ColorMaskidelegate glColorMaski;

        public void ColorMask(int index, bool red, bool green, bool blue, bool alpha)
        {
            glColorMaski((uint)index, red, green, blue, alpha);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DepthMaskdelegate(bool flag);
        internal DepthMaskdelegate glDepthMask;

        public void DepthMask(bool flag)
        {
            glDepthMask(flag);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilMaskdelegate(uint mask);
        internal StencilMaskdelegate glStencilMask;

        public void StencilMask(int mask)
        {
            glStencilMask((uint)mask);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Flushdelegate();
        internal Flushdelegate glFlush;

        public void Flush()
        {
            glFlush();
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Finishdelegate();
        internal Finishdelegate glFinish;

        public void Finish()
        {
            glFinish();
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EnableDelegate(uint cap);
        internal EnableDelegate glEnable;

        public void Enable(int capability)
        {
            glEnable((uint)capability);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Disabled(uint cap);
        internal Disabled glDisable;

        public void Disable(int capability)
        {
            glDisable((uint)capability);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendFuncd(int sBlendingFactor, int dBlendingFactor);
        internal BlendFuncd glBlendFunc;

        public void BlendFunc(int sBlendingFactor, int dBlendingFactor)
        {
            glBlendFunc(sBlendingFactor, dBlendingFactor);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LogicOpdelegate(int opcode);
        internal LogicOpdelegate glLogicOp;

        public void LogicOp(int operation)
        {
            glLogicOp(operation);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilFuncdelegate(int func, int @ref, uint mask);
        internal StencilFuncdelegate glStencilFunc;

        public void StencilFunc(int function, int @ref, int mask)
        {
            glStencilFunc(function, @ref, (uint)mask);
            CheckForErrors();
        }



        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilOpdelegate(int fail, int zfail, int zpass);
        internal StencilOpdelegate glStencilOp;

        public void StencilOp(int failOperation, int zfailOperation, int zpassOperation)
        {
            glStencilOp(failOperation, zfailOperation, zpassOperation);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DepthFuncdelegate(int func);
        internal DepthFuncdelegate glDepthFunc;

        public void DepthFunc(int function)
        {
            glDepthFunc(function);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelStorefdelegate(int pname, float param);
        internal PixelStorefdelegate glPixelStoref;

        public void PixelStore(int pixelStorePName, float param)
        {
            glPixelStoref(pixelStorePName, param);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelStoreidelegate(int pixelStorePName, int param);
        internal PixelStoreidelegate glPixelStorei;

        public void PixelStore(int pixelStorePName, int param)
        {
            glPixelStorei(pixelStorePName, param);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReadBufferdelegate(int mode);
        internal ReadBufferdelegate glReadBuffer;

        public void ReadBuffer(int colorBufferMode)
        {
            glReadBuffer(colorBufferMode);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReadPixelsdelegate(int x, int y, int width, int height, int pixelFormat, int pixelType, [OutAttribute] IntPtr pixels);
        internal ReadPixelsdelegate glReadPixels;

        public void ReadPixels(int x, int y, int width, int height, int pixelFormat, int pixelType, [OutAttribute] IntPtr pixels)
        {
            glReadPixels((int)x, (int)y, (int)width, (int)height, pixelFormat, pixelType, (IntPtr)pixels);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetDoublevDelegate(int pname, [Out] double* @params);
        internal unsafe GetDoublevDelegate glGetDoublev;

        public void Get(int getPName, [Out] double[] @params)
        {
            unsafe
            {
                fixed (double* @params_ptr = @params)
                {
                    glGetDoublev((int)getPName, @params_ptr);
                    CheckForErrors();
                }
            }
        }

        public void Get(int getPName, [Out] out double @params)
        {
            unsafe
            {
                fixed (double* @params_ptr = &@params)
                {
                    glGetDoublev((int)getPName, @params_ptr);
                    CheckForErrors();
                    @params = *@params_ptr;
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFloatvDelegate(int pname, [Out] float* @params);
        internal unsafe GetFloatvDelegate glGetFloatv;

        public void Get(int getPName, [Out] float[] @params)
        {
            unsafe
            {
                fixed (float* @params_ptr = @params)
                {
                    glGetFloatv((int)getPName, @params_ptr);
                    CheckForErrors();
                }
            }
        }

        public void Get(int getPName, [Out] out float @params)
        {
            unsafe
            {
                fixed (float* @params_ptr = &@params)
                {
                    glGetFloatv((int)getPName, @params_ptr);
                    CheckForErrors();
                    @params = *@params_ptr;
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetBooleanvDelegate(int pname, [Out] bool* @params);
        internal unsafe GetBooleanvDelegate glGetBooleanv;

        public void Get(int getPName, [Out] bool[] @params)
        {
            unsafe
            {
                fixed (bool* @params_ptr = @params)
                {
                    glGetBooleanv((int)getPName, @params_ptr);
                    CheckForErrors();
                }
            }
        }

        public void Get(int getPName, [Out] out bool @params)
        {
            unsafe
            {
                fixed (bool* @params_ptr = &@params)
                {
                    glGetBooleanv((int)getPName, @params_ptr);
                    CheckForErrors();
                    @params = *@params_ptr;
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetIntegervDelegate(int pname, [Out] int* @params);
        internal unsafe GetIntegervDelegate glGetIntegerv;

        public void Get(int getPName, [Out] out int @params)
        {
            unsafe
            {
                fixed (int* @params_ptr = &@params)
                {
                    glGetIntegerv((int)getPName, (int*)@params_ptr);
                    CheckForErrors();
                    @params = *@params_ptr;
                }
            }
        }

        public void Get(int getPName, [Out] int[] @params)
        {
            unsafe
            {
                fixed (int* @params_ptr = @params)
                {
                    glGetIntegerv((int)getPName, (int*)@params_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int GetErrorDelegate();
        internal GetErrorDelegate glGetError;

        public int GetError()
        {
            return glGetError();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate IntPtr GetStringDelegate(int name);
        internal GetStringDelegate glGetString;

        public string GetString(int getStringPName)
        {
            unsafe
            {
                string s = System.Runtime.InteropServices.Marshal.PtrToStringAnsi(glGetString((int)getStringPName));
                CheckForErrors();
                return s;
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GetTexImageDelegate(int textureTarget,
            int level,
            int pixelFormat,
            int pixelType,
            [OutAttribute] IntPtr pixels);
        internal GetTexImageDelegate glGetTexImage;

        public void GetTexImage(int textureTarget,
            int level,
            int pixelFormat,
            int pixelType,
            [OutAttribute] IntPtr pixels)
        {
            glGetTexImage(textureTarget, level, pixelFormat, pixelType, pixels);
            CheckForErrors();
        }

        public void GetTexImage<T4>(int textureTarget,
            int level,
            int pixelFormat,
            int pixelType,
            [InAttribute, OutAttribute] T4[,] pixels)
            where T4 : struct
        {
            GCHandle pixels_ptr = GCHandle.Alloc(pixels, GCHandleType.Pinned);
            try
            {
                glGetTexImage(textureTarget, (int)level, pixelFormat, pixelType, (IntPtr)pixels_ptr.AddrOfPinnedObject());
                CheckForErrors();
            }
            finally
            {
                pixels_ptr.Free();
            }
        }

        public void GetTexImage<T4>(int textureTarget,
            int level,
            int pixelFormat,
            int pixelType,
            [InAttribute, OutAttribute] T4[] pixels)
            where T4 : struct
        {
            GCHandle pixels_ptr = GCHandle.Alloc(pixels, GCHandleType.Pinned);
            try
            {
                glGetTexImage(textureTarget, (int)level, pixelFormat, pixelType, pixels_ptr.AddrOfPinnedObject());
                CheckForErrors();
            }
            finally
            {
                pixels_ptr.Free();
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexParameterfvdelegate(int textureTarget, int textureParameter, [OutAttribute] float* @params);
        internal unsafe GetTexParameterfvdelegate glGetTexParameterfv;

        public void GetTexParameter(int textureTarget, int texturePName, float[] @params)
        {
            unsafe
            {
                fixed (float* @ptr = @params)
                {
                    glGetTexParameterfv(textureTarget, texturePName, ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexParameterivdelegate(int textureTarget, int textureParameter, [OutAttribute] int* @params);
        internal unsafe GetTexParameterivdelegate glGetTexParameteriv;

        public void GetTexParameter(int textureTarget, int texturePName, int[] @params)
        {
            unsafe
            {
                fixed (int* @ptr = @params)
                {
                    glGetTexParameteriv(textureTarget, texturePName, ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexLevelParameterfvdelegate(int textureTarget, int level, int textureLevelParameter, [OutAttribute] float* @params);
        internal unsafe GetTexLevelParameterfvdelegate glGetTexLevelParameterfv;

        public void GetTexLevelParameter(int textureTarget, int level, int textureLevelPName, float[] @params)
        {
            unsafe
            {
                fixed (float* @ptr = @params)
                {
                    glGetTexLevelParameterfv(textureTarget, level, textureLevelPName, ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexLevelParameterivdelegate(int textureTarget, int level, int textureLevelParameter, [OutAttribute] int* @params);
        internal unsafe GetTexLevelParameterivdelegate glGetTexLevelParameteriv;

        public void GetTexLevelParameter(int textureTarget, int level, int textureLevelPName, int[] @params)
        {
            unsafe
            {
                fixed (int* @ptr = @params)
                {
                    glGetTexLevelParameteriv(textureTarget, level, textureLevelPName, ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate bool IsEnableddelegate(int cap);
        internal IsEnableddelegate glIsEnabled;

        public bool IsEnabled(int capability)
        {
            bool r = glIsEnabled(capability);
            CheckForErrors();
            return r;
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DepthRangeDelegate(Double near, Double far);
        internal DepthRangeDelegate glDepthRange;

        public void DepthRange(double near, double far)
        {
            glDepthRange(near, far);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ViewportDelegate(int x, int y, int width, int height);
        internal ViewportDelegate glViewport;

        public void Viewport(int x, int y, int width, int height)
        {
            glViewport(x, y, width, height);
            CheckForErrors();
        }
    }
}
