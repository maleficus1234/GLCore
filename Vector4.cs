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
    public struct Vector4
        : IEquatable<Vector4>
    {
        public float X;
        public float Y;
        public float Z;
        public float W;

        public Vector4(float x, float y, float z, float w)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.W = w;
        }

        public Vector4(Vector3 v, float w = 0)
            : this(v.X, v.Y, v.Z, w)
        {

        }

        public Vector4(Vector2 v, float z = 0, float w = 0)
            : this(v.X, v.Y, z, w)
        {

        }

        public static Vector4 CreateUnitX() 
        { 
            return new Vector4(1, 0, 0, 0);
        }

        public static Vector4 CreateUnitY() 
        { 
            return new Vector4(0, 1, 0, 0);
        }

        public static Vector4 CreateUnitZ() 
        { 
            return new Vector4(0, 0, 1, 0);
        }

        public static Vector4 CreateUnitW()
        {
            return new Vector4(0, 0, 0, 1);
        }

        public static Vector4 CreateZero()
        {
            return new Vector4(0, 0, 0, 0);
        }

        public static Vector4 CreateOne()
        {
            return new Vector4(1, 1, 1, 1);
        }

        public static Vector4 operator -(Vector4 v)
        {
            return new Vector4(-v.X, -v.Y, -v.Z, -v.W);
        }

        public static Vector4 Negate(Vector4 v)
        {
            return -v;
        }

        public static int SizeInBytes
        {
            get 
            { 
                return Marshal.SizeOf(new Vector4()); 
            }
        }

        // Tested against GLM
        public static float Dot(Vector4 left, Vector4 right)
        {
            return (left.X * right.X) + (left.Y * right.Y) + (left.Z * right.Z) + (left.W * right.W);
        }

        // Tested against GLM
        public static Vector4 operator *(Vector4 left, float right)
        {
            return new Vector4(left.X * right, left.Y * right, left.Z * right, left.W * right);
        }

        public static Vector4 Multiply(Vector4 left, float right)
        {
            return left * right;
        }

        public static Vector4 operator *(Vector4 left, Vector4 right)
        {
            return new Vector4(left.X * right.X,
                left.Y * right.Y,
                left.Z * right.Z,
                left.W * right.W);
        }

        public static Vector4 Multiply(Vector4 left, Vector4 right)
        {
            return left * right;
        }

        // Tested against GLM
        public static Vector4 operator *(Matrix left, Vector4 right)
        {
            Vector4 v = new Vector4();
            v.X = Vector4.Dot(left.Row0, right);
            v.Y = Vector4.Dot(left.Row1, right);
            v.Z = Vector4.Dot(left.Row2, right);
            v.W = Vector4.Dot(left.Row3, right);
            return v;
        }

        public static Vector4 operator +(Vector4 left, float right)
        {
            return new Vector4(left.X + right, left.Y + right, left.Z + right, left.W + right);
        }

        public static Vector4 operator -(Vector4 left, float right)
        {
            return new Vector4(left.X - right, left.Y - right, left.Z - right, left.W - right);
        }

        public static Vector4 Multiply(Matrix left, Vector4 right)
        {
            return left * right;
        }

        // Tested against GLM
        public static Vector4 operator /(Vector4 left, float right)
        {
            return new Vector4(left.X / right, left.Y / right, left.Z / right, left.W / right);
        }

      /*  public static Vector4 operator /(float left, Vector4 right)
        {
            return right / left;
        }*/

        public static Vector4 Divide(Vector4 left, float right)
        {
            return left / right;
        }

        public static Vector4 operator /(Vector4 left, Vector4 right)
        {
            return new Vector4(left.X / right.X,
                left.Y / right.Y,
                left.Z / right.Z,
                left.W / right.W);
        }

        public static Vector4 Divide(Vector4 left, Vector4 right)
        {
            return left / right;
        }

        public static Vector4 Add(Vector4 left, Vector4 right)
        {
            return left + right;
        }

        public static Vector4 operator +(Vector4 left, Vector4 right)
        {
            return new Vector4(left.X + right.X,
                left.Y + right.Y,
                left.Z + right.Z,
                left.W + right.W);
        }

        public static Vector4 Subtract(Vector4 left, Vector4 right)
        {
            return left - right;
        }

        public static Vector4 operator -(Vector4 left, Vector4 right)
        {
            return new Vector4(left.X - right.X,
                left.Y - right.Y,
                left.Z - right.Z,
                left.W - right.W);
        }

        public static Vector4 Minimize(Vector4 left, Vector4 right)
        {
            Vector4 r = new Vector4();

            if (left.X < right.X)
                r.X = left.X;
            else
                r.X = right.X;

            if (left.Y < right.Y)
                r.Y = left.Y;
            else
                r.Y = right.Y;

            if (left.Z < right.Z)
                r.Z = left.Z;
            else
                r.Z = right.Z;

            if (left.W < right.W)
                r.W = left.W;
            else
                r.W = right.W;

            return r;
        }

        public static Vector4 Maximize(Vector4 left, Vector4 right)
        {
            Vector4 r = new Vector4();

            if (left.X > right.X)
                r.X = left.X;
            else
                r.X = right.X;

            if (left.Y > right.Y)
                r.Y = left.Y;
            else
                r.Y = right.Y;

            if (left.Z > right.Z)
                r.Z = left.Z;
            else
                r.Z = right.Z;

            if (left.W > right.W)
                r.W = left.W;
            else
                r.W = right.W;

            return r;
        }

        public static Vector4 Clamp(Vector4 min, Vector4 max)
        {
            Vector4 vec = new Vector4();
            vec.X = vec.X < min.X ? min.X : vec.X > max.X ? max.X : vec.X;
            vec.Y = vec.Y < min.Y ? min.Y : vec.Y > max.Y ? max.Y : vec.Y;
            vec.Z = vec.X < min.Z ? min.Z : vec.Z > max.Z ? max.Z : vec.Z;
            vec.W = vec.Y < min.W ? min.W : vec.W > max.W ? max.W : vec.W;
            return vec;
        }

        public bool Equals(Vector4 other)
        {
            return this.X == other.X &&
                this.Y == other.Y &&
                this.Z == other.Z &&
                this.W == other.W;
        }

        public override bool Equals(Object o)
        {
            if (o is Vector4)
                return this.Equals((Vector4)o);
            return false;
        }

        public static bool operator ==(Vector4 right, Vector4 left)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Vector4 right, Vector4 left)
        {
            return !left.Equals(right);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public float GetLength()
        {
            return (float)Math.Sqrt(X * X + Y * Y + Z * Z + W * W);
        }

        public float GetLengthSquared()
        {
            return X * X + Y * Y + Z * Z + W * W;
        }

        public void Normalize()
        {
            float scale = 1.0f / this.GetLength();
            this = Vector4.Multiply(this, scale);
        }

        public static Vector4 Normalize(Vector4 v)
        {
            v.Normalize();
            return v;
        }

        public static Vector4 Lerp(Vector4 a, Vector4 b, float blend)
        {
            Vector4 r = new Vector4();
            r.X = blend * (b.X - a.X) + a.X;
            r.Y = blend * (b.Y - a.Y) + a.Y;
            r.Z = blend * (b.Z - a.Z) + a.Z;
            r.W = blend * (b.W - a.W) + a.W;
            return r;
        }

        public static Vector4 CreateBarycentric(Vector4 a,
            Vector4 b,
            Vector4 c,
            float u,
            float v)
        {
            return a + (b - a) * u + (c - a) * v;
        }

        public Vector3 ToVector3()
        {
            return new Vector3(X, Y, Z);
        }

        public Vector2 ToVector2()
        {
            return new Vector2(X, Y);
        }

        public override string ToString()
        {
            return X + ", " + Y + ", " + Z + ", " + W;
        }
    }
}
