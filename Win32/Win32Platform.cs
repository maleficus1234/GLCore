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
using System.Collections.Generic;

namespace GLCore.Win32
{
    // Provides non-OpenGL, platform specific services for Windows.
    public class Win32Platform
        : Platform
    {
        List<DisplayMode> displayModes = new List<DisplayMode>();

        public Win32Platform()
        {
            EnumerateDisplayModes();
        }

        // Wraps the platform specific implementation of memcpy.
        public override IntPtr CopyMemory(IntPtr destination, IntPtr source, int numBytes)
        {
            return Win32.memcpy(destination, source, numBytes);
        }

        // Returns a read-only collection of the display modes supported by the device.
        public override System.Collections.ObjectModel.ReadOnlyCollection<DisplayMode> DisplayModes
        {
            get { return this.displayModes.AsReadOnly(); }
        }

        // Retrieves supported display modes from windows and loads them into
        // the display mode collection.
        void EnumerateDisplayModes()
        {
            DeviceMode dm = Win32.CreateDeviceMode();

            int index = 0;
            while (0 != Win32.EnumDisplaySettings(null, index++, ref dm))
            {
                var newMode = new DisplayMode(dm.dmPelsWidth, dm.dmPelsHeight, dm.dmDisplayFrequency);
                if (!this.displayModes.Contains(newMode))
                    this.displayModes.Add(newMode);
            }
        }
    }
}
