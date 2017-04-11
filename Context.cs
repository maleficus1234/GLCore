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
using System.Collections.ObjectModel;

namespace GLCore
{
    /// <summary>
    /// Provides a base class upon which OpenGL contexts are implemented.
    /// Provides basic services such as context information (version, supported
    /// extensions), buffer swapping, the window with which the context
    /// is associated, and function pointer retrieval.
    /// </summary>
    public abstract class Context
        : IDisposable
    {
        /// <summary>
        ///  Disposes of unmanaged resources used by this object.
        /// </summary>
        public abstract void Dispose();

        /// <summary>
        /// Returns the version of this OpenGL context.
        /// </summary>
        public abstract Version Version { get; }

        /// <summary>
        /// Swaps the back buffer to the window.
        /// </summary>
        public abstract void SwapBuffers();

        /// <summary>
        /// Returns a pointer to the named OpenGL function.
        /// </summary>
        public abstract IntPtr GetGLProcAddress(string name);

        /// <summary>
        /// Makes this context the current one.
        /// </summary>
        public abstract void MakeCurrent();

        /// <summary>
        /// Returns the window with which this context is associated.
        /// </summary>
        public abstract Window Window { get; }

        /// <summary>
        /// Changes the display mode, including full screen toggle.
        /// </summary>
        public abstract void ChangeDisplayMode(DisplayMode mode, bool fullscreen);

        /// <summary>
        /// Gets the current display mode.
        /// </summary>
        public abstract DisplayMode DisplayMode { get; protected set; }

        /// <summary>
        /// Gets the current full screen state.
        /// </summary>
        public abstract bool IsFullscreen { get; protected set; }
    }
}
