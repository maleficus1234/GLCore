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
using System.Collections.ObjectModel;

namespace GLCore
{
    public abstract class Platform
    {
        /// <summary>
        /// Copies memory of size numBytes from the source address to the destination address.
        /// </summary>
        public abstract IntPtr CopyMemory(IntPtr destination, IntPtr source, int numBytes);

        /// <summary>
        /// Returns a list of display modes supported by the hardware.
        /// </summary>
        public abstract ReadOnlyCollection<DisplayMode> DisplayModes { get; }

        /// <summary>
        /// Returns a platform specific implementation of the Platform class.
        /// </summary>
        /// <returns></returns>
        public static Platform Create()
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                    return new GLCore.Win32.Win32Platform();
                //case PlatformID.Unix:
                   // return new GLCore.X11.X11Platform();
                case PlatformID.MacOSX:
                    throw new NotImplementedException();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
