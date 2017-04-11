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

namespace GLCore
{
    /// <summary>
    /// Provides a base class upon which window implementations are built.
    /// </summary>
    public abstract class Window
        : IDisposable
    {
        public abstract void Dispose();

        // Delegates for window event handling
        public delegate void ResizeDelegate(Window sender);
        public delegate void FocusDelegate(Window sender);
        public delegate void MouseButtonDelegate(Window sender, MouseButtons button, int x, int y);
        public delegate void MouseMoveDelegate(Window sender, int x, int y);
        public delegate void KeyDelegate(Window window, Keys key);
        public delegate void MouseWheelDelegate(Window window, int delta);

        /// <summary>
        /// Returns true if the underlying window has been created, false if not.
        /// </summary>
        public abstract bool IsCreated { get; }

        /// <summary>
        /// Process window events.
        /// </summary>
        public abstract void DoEvents();

        /// <summary>
        /// Returns the width of the client area of the window.
        /// </summary>
       // public abstract int Width { get; set; }

        /// <summary>
        /// Returns the height of the client area of the window.
        /// </summary>
      //  public abstract int Height { get; set; }

        /// <summary>
        /// Gets or sets the text of the window caption.
        /// </summary>
        public abstract String Text { get; set; }

        /// <summary>
        /// Returns the handle of the underlying window. What is returned
        /// is implementation dependent.
        /// </summary>
        public abstract object Handle { get; }

        /// <summary>
        /// Triggered when the size of the window changes.
        /// </summary>
        public event ResizeDelegate Resize;

        /// <summary>
        /// Triggers the Resize event.
        /// </summary>
        public void TriggerResize()
        {
            if (this.Resize != null)
                Resize(this);
        }

        /// <summary>
        /// Triggered when the window loses focus.
        /// </summary>
        public event FocusDelegate LostFocus;

        /// <summary>
        /// Triggers the lost focus event.
        /// </summary>
        public void TriggerLostFocus()
        {
            if (this.LostFocus != null)
                LostFocus(this);
        }

        /// <summary>
        /// Triggered when the widnow gains focus.
        /// </summary>
        public event FocusDelegate GainedFocus;

        /// <summary>
        /// Triggers the gained focus event.
        /// </summary>
        public void TriggerGainedFocus()
        {
            if (this.GainedFocus != null)
                GainedFocus(this);
        }

        /// <summary>
        /// Triggered when a mouse button is pressed in the client area of the window.
        /// </summary>
        public event MouseButtonDelegate MouseDown;

        /// <summary>
        /// Triggers the MouseDown event.
        /// </summary>
        /// <param name="button">The button that was pressed.</param>
        /// <param name="x">x position of the mouse.</param>
        /// <param name="y">y position of the mouse.</param>
        public void TriggerMouseDown(MouseButtons button, int x, int y)
        {
            if (this.MouseDown != null)
                MouseDown(this, button, x, y);
        }

        /// <summary>
        /// Triggered when a mouse button is released in the client area of the window.
        /// </summary>
        public event MouseButtonDelegate MouseUp;

        /// <summary>
        /// Triggers the MouseUp event.
        /// </summary>
        /// <param name="button">The button that was released.</param>
        /// <param name="x">x position of the mouse.</param>
        /// <param name="y">y position of the mouse.</param>
        public void TriggerMouseUp(MouseButtons button, int x, int y)
        {
            if (this.MouseUp != null)
                MouseUp(this, button, x, y);
        }

        /// <summary>
        /// Triggered when the mouse is moved within the client area of the window.
        /// </summary>
        public event MouseMoveDelegate MouseMove;

        /// <summary>
        /// Triggers the MouseMove event.
        /// </summary>
        /// <param name="x">x position of the mouse.</param>
        /// <param name="y">y position of the mouse.</param>
        public void TriggerMouseMove(int x, int y)
        {
            if (this.MouseMove != null)
                MouseMove(this, x, y);
        }

        /// <summary>
        /// Triggered when a key is pressed while the window has focus.
        /// </summary>
        public event KeyDelegate KeyDown;

        /// <summary>
        /// Triggers the KeyDown event.
        /// </summary>
        /// <param name="key">The key that was pressed.</param>
        public void TriggerKeyDown(Keys key)
        {
            if (this.KeyDown != null)
                KeyDown(this, key);
        }

        /// <summary>
        /// Triggered when a key is released while the window has focus.
        /// </summary>
        public event KeyDelegate KeyUp;

        /// <summary>
        /// Triggers the KeyUp event.
        /// </summary>
        /// <param name="key">The key that was released.</param>
        public void TriggerKeyUp(Keys key)
        {
            if (this.KeyUp != null)
                KeyUp(this, key);
        }

        /// <summary>
        /// Triggered when the mouse wheel is turned while the window has focus.
        /// </summary>
        public event MouseWheelDelegate MouseWheel;

        /// <summary>
        /// Triggers the MouseWheel event.
        /// </summary>
        /// <param name="delta">The amount the wheel was turned.</param>
        public void TriggerMouseWheel(int delta)
        {
            if (this.MouseWheel != null)
                MouseWheel(this, delta);
        }
    }
}
