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
using System.Runtime.InteropServices;

namespace GLCore.Win32
{
    sealed class wgl
    {
        // Pointer to the OpenGL DLL
        public static IntPtr Module { get; private set; }

        internal static void LoadInitialDelegates()
        {
            // Load the OpenGL dll into memory prior to setting up wgl and
            // gl delegates.
            Module = Win32.LoadLibrary("opengl32.dll");
            if (Module == IntPtr.Zero)
                throw new Exception("Unable to load opengl32.dll.");

            // Initialise the core wgl functions.

            wgl.CreateContext = (wgl.CreateContextDelegate)Marshal.GetDelegateForFunctionPointer(Win32.GetProcAddress(Module, "wglCreateContext"),
                typeof(wgl.CreateContextDelegate));

            wgl.MakeCurrent = (wgl.MakeCurrentDelegate)Marshal.GetDelegateForFunctionPointer(Win32.GetProcAddress(Module, "wglMakeCurrent"),
                typeof(wgl.MakeCurrentDelegate));

            wgl.GetProcAddress = (wgl.GetProcAddressDelegate)Marshal.GetDelegateForFunctionPointer(Win32.GetProcAddress(Module, "wglGetProcAddress"),
                typeof(wgl.GetProcAddressDelegate));

            wgl.DeleteContext = (wgl.DeleteContextDelegate)Marshal.GetDelegateForFunctionPointer(Win32.GetProcAddress(Module, "wglDeleteContext"),
                typeof(wgl.DeleteContextDelegate));

            wgl.SwapBuffers = (wgl.SwapBuffersDelegate)Marshal.GetDelegateForFunctionPointer(Win32.GetProcAddress(Module, "wglSwapBuffers"),
                typeof(wgl.SwapBuffersDelegate));
        }

        // Load needed wgl extension functions.
        public static void LoadExtensions(IntPtr hdc)
        {
            // Setup the function to obtain the wgl extension string
            wgl.wglGetExtensionsStringARB = (wgl.GetExtensionsStringARBDelegate)Marshal.GetDelegateForFunctionPointer(wgl.GetProcAddress("wglGetExtensionsStringARB"),
                typeof(wgl.GetExtensionsStringARBDelegate));

            // Load the extension strings and make it lower case to ensure
            // accurate checking for extension names.
            string extensions = wgl.GetExtensionsString(hdc).ToLower();

            // Load the extension method needed for OpenGL 3.2+ initialisation.
            if(extensions.Contains("wgl_arb_create_context"))
                wgl.CreateContextAttribs = (wgl.CreateContextAttribsARBDelegate)Marshal.GetDelegateForFunctionPointer(wgl.GetProcAddress("wglCreateContextAttribsARB"),
                    typeof(wgl.CreateContextAttribsARBDelegate));
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        public delegate IntPtr CreateContextDelegate(IntPtr hDc);
        public static CreateContextDelegate CreateContext { get; private set; }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        public delegate Boolean MakeCurrentDelegate(IntPtr hDc, IntPtr newContext);
        public static MakeCurrentDelegate MakeCurrent { get; private set; }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        public delegate IntPtr GetProcAddressDelegate(String lpszProc);
        public static GetProcAddressDelegate GetProcAddress { get; private set; }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        public delegate IntPtr CreateContextAttribsARBDelegate(IntPtr hDC, IntPtr shareHGLRC, int[] attribs);
        public static CreateContextAttribsARBDelegate CreateContextAttribs { get; private set; }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate IntPtr GetExtensionsStringARBDelegate(IntPtr hdc);
        internal static GetExtensionsStringARBDelegate wglGetExtensionsStringARB;

        public static string GetExtensionsString(IntPtr hdc)
        {
            unsafe
            {
                return System.Runtime.InteropServices.Marshal.PtrToStringAnsi(wglGetExtensionsStringARB((IntPtr)hdc));
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        public delegate Boolean DeleteContextDelegate(IntPtr oldContext);
        public static DeleteContextDelegate DeleteContext { get; private set; }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        public delegate Boolean SwapBuffersDelegate(IntPtr hdc);
        public static SwapBuffersDelegate SwapBuffers { get; private set; }
    }
}
