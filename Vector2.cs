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

namespace GLCore
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector2
    {
        public float X;
        public float Y;

        public Vector2(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        public Vector2(Vector3 v)
            : this(v.X, v.Y)
        {

        }

        public Vector2(Vector4 v)
            : this(v.X, v.Y)
        {

        }

        public static Vector2 CreateUnitX()
        {
            return new Vector2(1, 0);
        }

        public static Vector2 CreateUnitY()
        {
            return new Vector2(0, 1);
        }

        public static Vector2 CreateZero()
        {
            return new Vector2(0, 0);
        }

        public static Vector2 CreateOne()
        {
            return new Vector2(1, 1);
        }

        public static int SizeInBytes
        {
            get { return Marshal.SizeOf(new Vector2()); }
        }

        public static Vector2 operator +(Vector2 left, Vector2 right)
        {
            return new Vector2(left.X + right.X, left.Y + right.Y);
        }

        public static Vector2 Add(Vector2 left, Vector2 right)
        {
            return left + right;
        }

        public static Vector2 operator -(Vector2 left, Vector2 right)
        {
            return new Vector2(left.X - right.X, left.Y - right.Y);
        }

        public static Vector2 Subtract(Vector2 left, Vector2 right)
        {
            return left - right;
        }

        public static Vector2 operator *(Vector2 left, float right)
        {
            return new Vector2(left.X * right, left.Y * right);
        }

        public static Vector2 operator *(float left, Vector2 right)
        {
            return right * left;
        }

        public static Vector2 Multiply(Vector2 left, float right)
        {
            return left * right;
        }

        public static Vector2 operator /(Vector2 left, float right)
        {
            return new Vector2(left.X / right, left.Y / right);
        }

        public static Vector2 operator /(float left, Vector2 right)
        {
            return right / left;
        }

        public static Vector2 Divide(Vector2 left, float right)
        {
            return left / right;
        }

        public static Vector2 operator -(Vector2 v)
        {
            return new Vector2(-v.X, -v.Y);
        }

        public static Vector2 Negate(Vector2 v)
        {
            return -v;
        }

        public float GetLength()
        {
            return (float)Math.Sqrt(X * X + Y * Y);
        }

        public float GetLengthSquared()
        {
            return X * X + Y * Y;
        }
    }
}
