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
using System.Security;

namespace GLCore.Win32
{
    sealed class Win32
    {
        [DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true), SuppressUnmanagedCodeSecurity]
        public static extern IntPtr GetProcAddress(IntPtr module, string processName);

        [DllImport("gdi32.dll", SetLastError = true), SuppressUnmanagedCodeSecurity]
        public static extern int ChoosePixelFormat(IntPtr deviceContext, ref PixelFormatDescriptor pixelFormatDescriptor);

        [DllImport("gdi32.dll", EntryPoint = "SetPixelFormat", SetLastError = true), SuppressUnmanagedCodeSecurity]
        private static extern bool _SetPixelFormat(IntPtr deviceContext,
            int pixelFormat,
            ref PixelFormatDescriptor pixelFormatDescriptor);

        public static bool SetPixelFormat(IntPtr deviceContext,
            int pixelFormat,
            ref PixelFormatDescriptor pixelFormatDescriptor)
        {
            LoadLibrary("opengl32.dll");
            return _SetPixelFormat(deviceContext, pixelFormat, ref pixelFormatDescriptor);
        }


        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true), SuppressUnmanagedCodeSecurity]
        public static extern IntPtr GetDC(IntPtr windowHandle);

        [DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true), SuppressUnmanagedCodeSecurity]
        public static extern IntPtr LoadLibrary(string fileName);

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        public static extern int EnumDisplaySettings(
             string lpszDeviceName,
             int iModeNum,
             ref DeviceMode lpDevMode);

        [DllImport("user32.dll", SetLastError = true)]
        internal unsafe static extern int ChangeDisplaySettings(ref DeviceMode device_mode, ChangeDisplaySettingsEnum flags);

        [DllImport("user32.dll", SetLastError = true)]
        internal unsafe static extern int ChangeDisplaySettings(IntPtr device_mode, ChangeDisplaySettingsEnum flags);

        [DllImport("msvcrt.dll", SetLastError = false)]
        public static extern IntPtr memcpy(IntPtr dest, IntPtr src, int count);

        // Creates a properly initialised DeviceMode object.
        public static DeviceMode CreateDeviceMode()
        {
            var dm = new DeviceMode();
            dm.dmDeviceName = new String(new char[32]);
            dm.dmFormName = new String(new char[32]);
            dm.dmSize = (short)Marshal.SizeOf(dm);
            return dm;
        }

        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern long SetWindowLong(IntPtr hWnd, GetWindowLongOffsets nIndex, long dwNewLong);
    }
}
