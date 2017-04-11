﻿// 
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

namespace GLCore
{
    public struct DisplayMode
    {
        int w;
        int h;
        int f;
        public int Width { get { return this.w; } }
        public int Height { get { return this.h; } }
        public int Frequency { get { return this.f; } }

        public DisplayMode(int width, int height, int frequency)
        {
            w = width;
            h = height;
            f = frequency;
        }

        public override string ToString()
        {
            return this.Width + "x" + this.Height + "x" + this.Frequency;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is DisplayMode)) return false;

            DisplayMode other = (DisplayMode)obj;
            return this.Width == other.Width && this.Height == other.Height && this.Frequency == other.Frequency;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}