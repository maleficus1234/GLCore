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
using System.Drawing;
using System.Windows.Forms;

namespace GLCore.Win32
{
    public class Win32Window
        : Window
    {
        internal Form form;

        public Win32Window(Form form)
        {
            this.form = form;
            this.form.Show();

            // Connect the Win32Window event handlers to the form.
            this.form.Resize += form_Resize;
            this.form.MouseDown += form_MouseDown;
            this.form.MouseUp += form_MouseUp;
            this.form.MouseMove += form_MouseMove;
            this.form.KeyDown += form_KeyDown;
            this.form.KeyUp += form_KeyUp;
            this.form.MouseWheel += form_MouseWheel;
            this.form.LostFocus += form_LostFocus;
            this.form.GotFocus += form_GotFocus;
        }

        public override void Dispose()
        {
            if (this.form != null)
            {
                this.form.Dispose();
                this.form = null;
            }
        }

        // All event handlers simply fire corresponding trigger function
        // in the base Window class.
        void form_GotFocus(object sender, EventArgs e)
        {
            TriggerGainedFocus();
        }

        void form_LostFocus(object sender, EventArgs e)
        {
            TriggerLostFocus();
        }

        void form_MouseWheel(object sender, MouseEventArgs e)
        {
            TriggerMouseWheel(e.Delta);
        }

        void form_KeyUp(object sender, KeyEventArgs e)
        {
            TriggerKeyUp(e.KeyCode);
        }

        void form_KeyDown(object sender, KeyEventArgs e)
        {
            TriggerKeyDown(e.KeyCode);
        }

        void form_MouseMove(object sender, MouseEventArgs e)
        {
            TriggerMouseMove(e.X, e.Y);
        }

        void form_MouseUp(object sender, MouseEventArgs e)
        {
            TriggerMouseUp(e.Button, e.X, e.Y);
        }

        void form_MouseDown(object sender, MouseEventArgs e)
        {
            TriggerMouseDown(e.Button, e.X, e.Y);
        }

        void form_Resize(object sender, EventArgs e)
        {
            TriggerResize();
        }

        // Use this to determine whether to continue the application loop.
        public override bool IsCreated
        {
            get
            {
                if (form == null) return false;
                return form.Created;
            }
        }

        // Fires the message pump
        public override void DoEvents()
        {
            // Replace this with something less terrible.
            Application.DoEvents();
        }

        public override string Text
        {
            get
            {
                return this.form.Text;
            }
            set
            {
                this.form.Text = value;
            }
        }

        // Returns the handle of the underlying form.
        // Cast from object to IntPtr.
        public override object Handle
        {
            get { return this.form.Handle; }
        }

        // Called from Win32Context: causes the window to make appropriate
        // changes upon a display mode change.
        internal void DoDisplayModeChange(DisplayMode mode, bool fullScreen)
        {
            this.form.Size = new Size(mode.Width, mode.Height);

            if (fullScreen)
            {
                this.form.FormBorderStyle = FormBorderStyle.None;
                form.Location = new System.Drawing.Point(0, 0);
                form.ClientSize = new System.Drawing.Size(mode.Width, mode.Height);
            }
            else
            {
                //this.form.FormBorderStyle = FormBorderStyle.FixedSingle;
                //this.form.WindowState = FormWindowState.Normal;
            }
        }
    }
}
