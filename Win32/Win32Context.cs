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
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GLCore.Win32
{
    public class Win32Context<T>
        : GLContext<T>
        where T : GLBase
    {
        IntPtr deviceContext = IntPtr.Zero;
        IntPtr renderingContext = IntPtr.Zero;
        Win32Window window;

        internal bool fullScreen = false;
        internal DisplayMode displayMode;

        public Win32Context(FormBorderStyle borderStyle = FormBorderStyle.Sizable)
            : base(new Win32Platform())
        {

            /*displayMode = new DisplayMode(640, 480, 60);

            // Determine the desired version from the type of this generic.
            Version desiredVersion;
            if (this is GLContext<GL30>)
                desiredVersion = new Version(3, 0);
            else if (this is GLContext<GL31>)
                desiredVersion = new Version(3, 1);
            else if (this is GLContext<GL32>)
                desiredVersion = new Version(3, 2);
            else if (this is GLContext<GL33>)
                desiredVersion = new Version(3, 3);
            else if (this is GLContext<GL40>)
                desiredVersion = new Version(4, 0);
            else if (this is GLContext<GL41>)
                desiredVersion = new Version(4, 1);
            else if (this is GLContext<GL42>)
                desiredVersion = new Version(4, 2);
            else if (this is GLContext<GL43>)
                desiredVersion = new Version(4, 3);
            else if (this is GLContext<GLES20>)
                desiredVersion = new Version(3, 0);
            else if (this is GLContext<GLES30>)
                desiredVersion = new Version(3, 0);
            else
                throw new InitialisationFailedException("OpenGL version is not supported by this library.");

            // Create the form and setup event handlers needed by the context.
            var form = new Form();
            form.FormBorderStyle = borderStyle;
            form.ClientSize = new System.Drawing.Size(displayMode.Width, displayMode.Height);
            // Handling LostFocus and GotFocus allows us to properly handle
            // tabbing in and out of full screen.
            form.LostFocus += form_LostFocus;
            form.GotFocus += form_GotFocus;
            // Changing the window size while in windowed mode will update the
            // current display mode.
            form.SizeChanged += form_SizeChanged;
            form.Show();
            
            // Set properties that can't be set through the Form class.
            // Popup window, clip children, clip siblings.
            Win32.SetWindowLong(form.Handle, GetWindowLongOffsets.STYLE, 0x80000000L | 0x02000000L | 0x04000000L);
            // Ensure that the window covers the task bar when full screen.
            Win32.SetWindowLong(form.Handle, GetWindowLongOffsets.EXSTYLE, 0x00040000L);

            // Create the Win32Window container class for this form.
            this.window = new Win32Window(form);

            // Create the pixel format to use
            PixelFormatDescriptor pfd = new PixelFormatDescriptor();
            pfd.nSize = (short)System.Runtime.InteropServices.Marshal.SizeOf(pfd);
            pfd.nVersion = 1;
            pfd.dwFlags = PixelFormatFlags.DoubleBuffer 
                | PixelFormatFlags.DrawToWindow 
                | PixelFormatFlags.SupportOpenGL;
            pfd.iPixelType = 0;
            pfd.cColorBits = 32;
            pfd.cRedBits = 0;
            pfd.cRedShift = 0;
            pfd.cGreenBits = 0;
            pfd.cGreenShift = 0;
            pfd.cBlueBits = 0;
            pfd.cBlueShift = 0;
            pfd.cAlphaBits = 0;
            pfd.cAlphaShift = 0;
            pfd.cAccumBits = 0;
            pfd.cAccumRedBits = 0;
            pfd.cAccumGreenBits = 0;
            pfd.cAccumBlueBits = 0;
            pfd.cAccumAlphaBits = 0;
            pfd.cDepthBits = 32;
            pfd.cStencilBits = 0;
            pfd.cAuxBuffers = 0;
            pfd.iLayerType = 0;
            pfd.bReserved = 0;
            pfd.dwLayerMask = 0;
            pfd.dwDamageMask = 0;
            pfd.dwVisibleMask = 0;

            // Create the device context, ensure that the requested pixel format
            // is supported by that device context, and then set the pixel format.
            deviceContext = Win32.GetDC((IntPtr)this.Window.Handle);
            if (deviceContext == IntPtr.Zero)
                throw new InitialisationFailedException("Could not obtain device context.");

            int pixelFormat = Win32.ChoosePixelFormat(deviceContext, ref pfd);
            if (pixelFormat == 0)
                throw new InitialisationFailedException("Pixel format is invalid.");

            if (!Win32.SetPixelFormat(deviceContext, pixelFormat, ref pfd))
                throw new InitialisationFailedException("Could not set pixel format.");*/

            // Load the core wgl functions.
            wgl.LoadInitialDelegates();

            // Create a temporary context to get function pointers. We must do this to get the function
            // pointers we need to create an OpenGL 3.2+ context.
            /*IntPtr tempRC = wgl.CreateContext(deviceContext);
            if (tempRC == IntPtr.Zero)
                throw new InitialisationFailedException("Unable to create the temporary OpenGL context.");

            wgl.MakeCurrent(deviceContext, tempRC);

            // Create a temporary GL30 object so that we have access to the
            // functions necessary to get the gl extension list.
            GL30 tempGL = new GL30(this);*/

            //wgl.LoadExtensions(deviceContext);
            // If wgl.CreateContextAttribs is null, then the extension needed to create
            // and OpenGL 3.2 or higher context is not available. If the requested version
            // is greater than or equal to 3.2, throw and error.
            //if (wgl.CreateContextAttribs == null && desiredVersion >= new Version(3, 2))
              //  throw new InitialisationFailedException("OpenGL 3.2 and up is not supported by the hardware.");
            // If the extension is not available, but the requested version is 3.0 or 3.1,
            // use the temporary rendering context.
            //else if (wgl.CreateContextAttribs == null && this.Version >= new Version(3,0))
              //  renderingContext = tempRC;
            //else // Context is available, >= 3.2 is requested
            //{

                // Specifying a profile  mask causes CreateContextAttribs to fail with invalid profile on my geforce 560?
               /* int[] glAttribs =
                    {
                        (int)Attrib.ContextMajorVersion, desiredVersion.Major,
                        (int)Attrib.ContextMinorVersion, desiredVersion.Minor,
                        (int)Attrib.ContextFlags, 0,
                        0
                    };

                // Create a 3.2+ context with the requested context flags.
                renderingContext = wgl.CreateContextAttribs(deviceContext, IntPtr.Zero, glAttribs);
                if (renderingContext == IntPtr.Zero)
                    throw new InitialisationFailedException("Unable to create an OpenGL " + desiredVersion + " context.");

                // Replace the temporary rendering context with the new one.
                wgl.MakeCurrent(IntPtr.Zero, IntPtr.Zero);
                wgl.DeleteContext(tempRC);
                wgl.MakeCurrent(deviceContext, renderingContext);*/
           // }

            // Create a GL object for the chosen version.
            if (this is GLContext<GL30>)
                this.GL = (T)((GLBase)new GL30(this));
            if (this is GLContext<GL31>)
                this.GL = (T)((GLBase)new GL31(this));
            if (this is GLContext<GL32>)
                this.GL = (T)((GLBase)new GL32(this));
            if (this is GLContext<GL33>)
                this.GL = (T)((GLBase)new GL33(this));
            if (this is GLContext<GL40>)
                this.GL = (T)((GLBase)new GL40(this));
            if (this is GLContext<GL41>)
                this.GL = (T)((GLBase)new GL41(this));
            if (this is GLContext<GL42>)
                this.GL = (T)((GLBase)new GL42(this));
            if (this is GLContext<GL43>)
                this.GL = (T)((GLBase)new GL43(this));
            if (this is GLContext<GLES20>)
                this.GL = (T)((GLBase)new GLES20(this));
            if (this is GLContext<GLES30>)
                this.GL = (T)((GLBase)new GLES30(this));
        }

        void form_SizeChanged(object sender, EventArgs e)
        {
            if (!fullScreen && this.Window != null)
            {
                var form = ((Win32Window)this.Window).form;
                this.DisplayMode = new DisplayMode(form.ClientSize.Width, form.ClientSize.Height, this.DisplayMode.Frequency);
            }
        }

        void form_GotFocus(object sender, EventArgs e)
        {
            if (fullScreen)
            {
                

                DeviceMode dm = Win32.CreateDeviceMode();
                dm.dmPelsWidth = this.displayMode.Width;
                dm.dmPelsHeight = this.displayMode.Height;
                dm.dmBitsPerPel = 32;
                dm.dmFields = 0x00080000 | 0x00100000 | 0x00040000;
                Win32.ChangeDisplaySettings(ref dm, ChangeDisplaySettingsEnum.Fullscreen);

                ((Win32Window)this.Window).form.Location = new System.Drawing.Point(0, 0);
                ((Win32Window)this.Window).form.ClientSize = new System.Drawing.Size(this.displayMode.Width, this.displayMode.Height);
            }
        }

        void form_LostFocus(object sender, EventArgs e)
        {
            if (fullScreen)
            {
                Win32.ChangeDisplaySettings(IntPtr.Zero, (ChangeDisplaySettingsEnum)0);
                ((Win32Window)this.Window).form.WindowState = FormWindowState.Minimized;
            }
        }

        private void ChangeDisplayMode(DeviceMode dm, bool fullScreen)
        {
            this.fullScreen = fullScreen;
            this.displayMode = new DisplayMode(dm.dmPelsWidth, dm.dmPelsHeight, dm.dmDisplayFrequency);

            if (fullScreen)
                Console.WriteLine("rawr " + Win32.ChangeDisplaySettings(ref dm, ChangeDisplaySettingsEnum.Fullscreen));
            else
                Console.WriteLine("rawr " + Win32.ChangeDisplaySettings(IntPtr.Zero, (ChangeDisplaySettingsEnum)0));

            ((Win32Window)this.Window).DoDisplayModeChange(new DisplayMode(dm.dmPelsWidth, dm.dmPelsHeight, dm.dmDisplayFrequency), fullScreen);
        }

        public override void ChangeDisplayMode(DisplayMode mode, bool fullScreen)
        {
            DeviceMode dm = Win32.CreateDeviceMode();
            dm.dmPelsWidth = mode.Width;
            dm.dmPelsHeight = mode.Height;
            dm.dmBitsPerPel = 32;
            dm.dmFields = 0x00080000 | 0x00100000 | 0x00040000;

            ChangeDisplayMode(dm, fullScreen);
        }

        public override void Dispose()
        {
            if (this.renderingContext != IntPtr.Zero)
            {
                wgl.MakeCurrent(IntPtr.Zero, IntPtr.Zero);
                wgl.DeleteContext(this.renderingContext);
                this.renderingContext = IntPtr.Zero;
            }

            this.Window.Dispose();
        }

        public override void SwapBuffers()
        {
            wgl.SwapBuffers(deviceContext);
        }

        public override IntPtr GetGLProcAddress(string name)
        {
            var ptr = wgl.GetProcAddress(name);
            if (ptr == IntPtr.Zero)
                ptr = Win32.GetProcAddress(wgl.Module, name);
            return ptr;
        }

        public override void MakeCurrent()
        {
            wgl.MakeCurrent(this.deviceContext, this.renderingContext);
        }

     /*   public override ReadOnlyCollection<string> Extensions
        {
            get { return this.extensions.AsReadOnly(); }
        }*/

        public override Window Window
        {
            get { return this.window; }
        }

        public override DisplayMode DisplayMode
        {
            get
            {
                return this.displayMode;
            }
            protected set
            {
                this.displayMode = value;
            }
        }

        public override bool IsFullscreen
        {
            get
            {
                return this.fullScreen;
            }
            protected set
            {
                this.fullScreen = value;
            }
        }

        
    }
}
