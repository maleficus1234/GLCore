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
    public struct Vector3
        : IEquatable<Vector3>
    {
        public float X;
        public float Y;
        public float Z;

        public Vector3(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public Vector3(Vector4 v)
            : this(v.X, v.Y, v.Z)
        {

        }

        public Vector3(Vector2 v, float z = 0)
            : this(v.X, v.Y, z)
        {

        }

        public static Vector3 CreateUnitX()
        {
            return new Vector3(1, 0, 0);
        }

        public static Vector3 CreateUnitY()
        {
            return new Vector3(0, 1, 0);
        }

        public static Vector3 CreateUnitZ()
        {
            return new Vector3(0, 0, 1);
        }

        public static Vector3 CreateZero()
        {
            return new Vector3(0, 0, 0);
        }

        public static Vector3 CreateOne()
        {
            return new Vector3(1, 1, 1);
        }

        public static int SizeInBytes
        {
            get { return Marshal.SizeOf(new Vector3()); }
        }

        // Tested against GLM
        public void Normalize()
        {
            float scale = 1.0f / this.GetLength();
            X *= scale;
            Y *= scale;
            Z *= scale;
        }

        // Tested against GLM
        public static Vector3 Normalize(Vector3 v)
        {
            v.Normalize();
            return v;
        }

        // Tested against GLM
        public float GetLength()
        {
            return (float)System.Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public float GetLengthSquared()
        {
            return X * X + Y * Y + Z * Z;
        }

        public static Vector3 operator +(Vector3 left, Vector3 right)
        {
            return new Vector3(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
        }

        public static Vector3 Add(Vector3 left, Vector3 right)
        {
            return left + right;
        }

        public static Vector3 operator -(Vector3 left, Vector3 right)
        {
            return left + (-right);
        }

        public static Vector3 Subtract(Vector3 left, Vector3 right)
        {
            return left - right;
        }

        public static Vector3 operator -(Vector3 v)
        {
            return new Vector3(-v.X, -v.Y, -v.Z);
        }

        public static bool operator == (Vector3 v1, Vector3 v2)
        {
            return (v1.X == v2.X && v1.Y == v2.Y && v1.Z == v2.Z);
        }

        public static bool operator !=(Vector3 v1, Vector3 v2)
        {
            return !(v1 == v2);
        }

        // Tested against GLM
        public static void Cross(ref Vector3 left, ref Vector3 right, out Vector3 result)
        {
            result = new Vector3(left.Y * right.Z - left.Z * right.Y,
                left.Z * right.X - left.X * right.Z,
                left.X * right.Y - left.Y * right.X);
        }

        // Tested against GLM
        public static Vector3 Cross(Vector3 left, Vector3 right)
        {
            Vector3 result;
            Cross(ref left, ref right, out result);
            return result;
        }

        // Tested against GLM
        public static float Dot(Vector3 left, Vector3 right)
        {
            return (left.X * right.X) + (left.Y * right.Y) + (left.Z * right.Z);
        }

        // Tested against GLM
        public static Vector3 operator *(Vector3 left, float right)
        {
            return new Vector3(left.X * right, left.Y * right, left.Z * right);
        }

        public static Vector3 operator *(float left, Vector3 right)
        {
            return right * left;
        }

        public static Vector3 Multiply(Vector3 left, float right)
        {
            return left * right;
        }

        public static Vector3 operator *(Vector3 left, Vector3 right)
        {
            return new Vector3(left.X * right.X,
                left.Y * right.Y,
                left.Z * right.Z);
        }

        public static Vector3 Multiply(Vector3 left, Vector3 right)
        {
            return left * right;
        }

        public static Vector3 operator *(Matrix left, Vector3 right)
        {
            Vector4 v = new Vector4();
            Vector4 r = new Vector4(right, 1);
            v.X = Vector4.Dot(left.Column0, r);
            v.Y = Vector4.Dot(left.Column1, r);
            v.Z = Vector4.Dot(left.Column2, r);
            v.W = Vector4.Dot(left.Column3, r);
            return new Vector3(v);
        }

        public static Vector3 Multiply(Matrix left, Vector3 right)
        {
            return left * right;
        }

        public static Vector3 operator /(Vector3 left, float right)
        {
            return new Vector3(left.X / right, left.Y / right, left.Z / right);
        }

        public static Vector3 operator /(float left, Vector3 right)
        {
            return right / left;
        }

        public static Vector3 Divide(Vector3 left, float right)
        {
            return left / right;
        }

        public static Vector3 operator /(Vector3 left, Vector3 right)
        {
            return new Vector3(left.X / right.X,
                left.Y / right.Y,
                left.Z / right.Z);
        }

        public static Vector3 Divide(Vector3 left, Vector3 right)
        {
            return left / right;
        }

        public static Vector3 Minimize(Vector3 left, Vector3 right)
        {
            Vector3 r = new Vector3();

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

            return r;
        }

        public static Vector3 Maximize(Vector3 left, Vector3 right)
        {
            Vector3 r = new Vector3();

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

            return r;
        }

        public static Vector3 Clamp(Vector3 min, Vector3 max)
        {
            Vector3 vec = new Vector3();
            vec.X = vec.X < min.X ? min.X : vec.X > max.X ? max.X : vec.X;
            vec.Y = vec.Y < min.Y ? min.Y : vec.Y > max.Y ? max.Y : vec.Y;
            vec.Z = vec.Z < min.Z ? min.Z : vec.Z > max.Z ? max.Z : vec.Z;
            return vec;
        }

        public bool Equals(Vector3 v)
        {
            return X == v.X && Y == v.Y && Z == v.Z;
        }

        public override bool Equals(object obj)
        {
            if (obj is Vector3)
                return this.Equals((Vector3)obj);
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static Vector3 Lerp(Vector3 a, Vector3 b, float blend)
        {
            Vector3 r = new Vector3();
            r.X = blend * (b.X - a.X) + a.X;
            r.Y = blend * (b.Y - a.Y) + a.Y;
            r.Z = blend * (b.Z - a.Z) + a.Z;
            return r;
        }

        public static Vector3 CreateBarycentric(Vector3 a, Vector3 b, Vector3 c, float u, float v)
        {
            return a + u * (b - a) + v * (c - a);
        }

        public static Vector3 TransformVector(Matrix m, Vector3 v)
        {
            m.Row3 = Vector4.CreateUnitW();
            return m * v;
        }

        public static Vector3 TransformNormalInverse(Matrix invertedMatrix, Vector3 v)
        {
            Vector3 n = new Vector3();
            n.X = Vector3.Dot(v, invertedMatrix.Row0.ToVector3());
            n.X = Vector3.Dot(v, invertedMatrix.Row1.ToVector3());
            n.X = Vector3.Dot(v, invertedMatrix.Row2.ToVector3());
            return n;
        }

        public static Vector3 TransformNormal(Matrix m, Vector3 v)
        {
            m.Invert();
            return TransformNormalInverse(m, v);
        }

        // Tested against GLM.
        public static Vector3 Project(Vector3 v, Matrix modelView, Matrix projection, Vector4 viewport)
        {

            Vector4 tmp = new Vector4(v, 1);
		    tmp = modelView * tmp; // tested
		    tmp = projection * tmp; // tested

		    tmp /= tmp.W; // tested
		    tmp = tmp * 0.5f + 0.5f; // Tested
		    tmp.X = tmp.X * viewport.Z + viewport.X;
		    tmp.Y = tmp.Y * viewport.W + viewport.Y;

            return tmp.ToVector3();
        }

        // Tested against GLM.
        public static Vector3 Unproject(Vector3 win, Matrix modelView, Matrix projection, Vector4 viewport)
        {
            Matrix inverse = Matrix.Inverse(projection * modelView);

            Vector4 tmp = new Vector4(win, 1);
            tmp.X = (tmp.X - viewport.X) / viewport.Z;
		    tmp.Y = (tmp.Y - viewport.Y) / viewport.W;
		    tmp = tmp * 2.0f - 1.0f;

		    Vector4 obj = inverse * tmp;
		    obj /= obj.W;

		    return obj.ToVector3();
        }

        public override string ToString()
        {
            return X + ", " + Y + ", " + Z;
        }
    }
}
