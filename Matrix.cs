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
    public struct Matrix
        : IEquatable<Matrix>
    {
        public Vector4 Column0;
        public Vector4 Column1;
        public Vector4 Column2;
        public Vector4 Column3;

        public Matrix(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3)
        {
            this.Column0 = column0;
            this.Column1 = column1;
            this.Column2 = column2;
            this.Column3 = column3;
        }

        public Matrix(
            float m11, float m12, float m13, float m14,
            float m21, float m22, float m23, float m24,
            float m31, float m32, float m33, float m34,
            float m41, float m42, float m43, float m44)
        {
            Column0 = new Vector4(m11, m12, m13, m14);
            Column1 = new Vector4(m21, m22, m23, m24);
            Column2 = new Vector4(m31, m32, m33, m34);
            Column3 = new Vector4(m41, m42, m43, m44);
        }

        public float M00 { get { return Column0.X; } set { Column0.X = value; } }

        public float M01 { get { return Column0.Y; } set { Column0.Y = value; } }

        public float M02 { get { return Column0.Z; } set { Column0.Z = value; } }

        public float M03 { get { return Column0.W; } set { Column0.W = value; } }

        public float M10 { get { return Column1.X; } set { Column1.X = value; } }

        public float M11 { get { return Column1.Y; } set { Column1.Y = value; } }

        public float M12 { get { return Column1.Z; } set { Column1.Z = value; } }

        public float M13 { get { return Column1.W; } set { Column1.W = value; } }

        public float M20 { get { return Column2.X; } set { Column2.X = value; } }

        public float M21 { get { return Column2.Y; } set { Column2.Y = value; } }

        public float M22 { get { return Column2.Z; } set { Column2.Z = value; } }

        public float M23 { get { return Column2.W; } set { Column2.W = value; } }

        public float M30 { get { return Column3.X; } set { Column3.X = value; } }

        public float M31 { get { return Column3.Y; } set { Column3.Y = value; } }

        public float M32 { get { return Column3.Z; } set { Column3.Z = value; } }

        public float M33 { get { return Column3.W; } set { Column3.W = value; } }

        public float this[int entry]
        {
            get
            {
                unsafe
                {
                    fixed(float* ptr = &this.Column0.X)
                    {
                        return ptr[entry];
                    }
                }
            }
            set
            {
                unsafe
                {
                    fixed (float* ptr = &this.Column0.X)
                    {
                        ptr[entry] = value;
                    }
                }
            }
        }

        public Vector4 Row0
        {
            get
            {
                return new Vector4(M00, M10, M20, M30);
            }
            set
            {
                M00 = value.X;
                M10 = value.Y;
                M20 = value.Z;
                M30 = value.W;
            }
        }

        public Vector4 Row1
        {
            get
            {
                return new Vector4(M01, M11, M21, M31);
            }
            set
            {
                M01 = value.X;
                M11 = value.Y;
                M21 = value.Z;
                M31 = value.W;
            }
        }

        public Vector4 Row2
        {
            get
            {
                return new Vector4(M02, M12, M22, M32);
            }
            set
            {
                M02 = value.X;
                M12 = value.Y;
                M22 = value.Z;
                M32 = value.W;
            }
        }

        public Vector4 Row3
        {
            get
            {
                return new Vector4(M03, M13, M23, M33);
            }
            set
            {
                M03 = value.X;
                M13 = value.Y;
                M23 = value.Z;
                M33 = value.W;
            }
        }

        public Vector4 GetColumn(int column)
        {
            switch (column)
            {
                case 0:
                    return Column0;
                case 1:
                    return Column1;
                case 2:
                    return Column2;
                case 3:
                    return Column3;
                default:
                    throw new IndexOutOfRangeException();
            }
        }

        public Vector4 GetRow(int row)
        {
            switch (row)
            {
                case 0:
                    return Row0;
                case 1:
                    return Row1;
                case 2:
                    return Row2;
                case 3:
                    return Row3;
                default:
                    throw new IndexOutOfRangeException();
            }
        }

        public static Matrix Multiply(Matrix left, Matrix right)
        {
            return left * right;
        }

        // Tested against GLM.
        public static Matrix operator *(Matrix left, Matrix right)
        {
            Matrix r = new Matrix();
            r.Column0 = left.Column0 * right.Column0.X + left.Column1 * right.Column0.Y + left.Column2 * right.Column0.Z + left.Column3 * right.Column0.W;
            r.Column1 = left.Column0 * right.Column1.X + left.Column1 * right.Column1.Y + left.Column2 * right.Column1.Z + left.Column3 * right.Column1.W;
            r.Column2 = left.Column0 * right.Column2.X + left.Column1 * right.Column2.Y + left.Column2 * right.Column2.Z + left.Column3 * right.Column2.W;
            r.Column3 = left.Column0 * right.Column3.X + left.Column1 * right.Column3.Y + left.Column2 * right.Column3.Z + left.Column3 * right.Column3.W;
            return r;
        }

        public static Matrix operator /(Matrix left, float right)
        {
            return new Matrix(left.Column0 / right,
                left.Column1 / right,
                left.Column2 / right,
                left.Column3 / right);
        }

        public static Matrix Add(Matrix left, Matrix right)
        {
            return left + right;
        }

        public static Matrix operator +(Matrix left, Matrix right)
        {
            return new Matrix(left.Column0 + right.Column0,
                left.Column1 + right.Column1,
                left.Column2 + right.Column2,
                left.Column3 + right.Column3);
        }

        public static Matrix Subtract(Matrix left, Matrix right)
        {
            return left - right;
        }

        public static Matrix operator -(Matrix left, Matrix right)
        {
            return new Matrix(left.Column0 - right.Column0,
                left.Column1 - right.Column1,
                left.Column2 - right.Column2,
                left.Column3 - right.Column3);
        }

        // Tested against GLM
        public float CalculateDeterminant()
        {
            return
                Row0.X * Row1.Y * Row2.Z * Row3.W - Row0.X * Row1.Y * Row2.W * Row3.Z + Row0.X * Row1.Z * Row2.W * Row3.Y - Row0.X * Row1.Z * Row2.Y * Row3.W
                + Row0.X * Row1.W * Row2.Y * Row3.Z - Row0.X * Row1.W * Row2.Z * Row3.Y - Row0.Y * Row1.Z * Row2.W * Row3.X + Row0.Y * Row1.Z * Row2.X * Row3.W
                - Row0.Y * Row1.W * Row2.X * Row3.Z + Row0.Y * Row1.W * Row2.Z * Row3.X - Row0.Y * Row1.X * Row2.Z * Row3.W + Row0.Y * Row1.X * Row2.W * Row3.Z
                + Row0.Z * Row1.W * Row2.X * Row3.Y - Row0.Z * Row1.W * Row2.Y * Row3.X + Row0.Z * Row1.X * Row2.Y * Row3.W - Row0.Z * Row1.X * Row2.W * Row3.Y
                + Row0.Z * Row1.Y * Row2.W * Row3.X - Row0.Z * Row1.Y * Row2.X * Row3.W - Row0.W * Row1.X * Row2.Y * Row3.Z + Row0.W * Row1.X * Row2.Z * Row3.Y
                - Row0.W * Row1.Y * Row2.Z * Row3.X + Row0.W * Row1.Y * Row2.X * Row3.Z - Row0.W * Row1.Z * Row2.X * Row3.Y + Row0.W * Row1.Z * Row2.Y * Row3.X;
        }

        // Tested against GLM.
        public static Matrix CreateRotation(float angle, Vector3 axis)
        {
            float c = (float)Math.Cos(angle);
            float s = (float)Math.Sin(angle);

            axis.Normalize();

            Vector3 temp = (1 - c) * axis;

            Matrix rotate = new Matrix();

            rotate.M00 = c + temp.X * axis.X;
		    rotate.M01 = 0 + temp.X * axis.Y + s * axis.Z;
		    rotate.M02 = 0 + temp.X * axis.Z - s * axis.Y;

		    rotate.M10 = 0 + temp.Y * axis.X - s * axis.Z;
		    rotate.M11 = c + temp.Y * axis.Y;
		    rotate.M12 = 0 + temp.Y * axis.Z + s * axis.X;

		    rotate.M20 = 0 + temp.Z * axis.X + s * axis.Y;
		    rotate.M21 = 0 + temp.Z * axis.Y - s * axis.X;
		    rotate.M22 = c + temp.Z * axis.Z;


            Matrix result = new Matrix();
            Matrix m = Matrix.CreateIdentity();
		    result.Column0 = m.Column0 * rotate.M00 + m.Column1 * rotate.M01 + m.Column2 * rotate.M02;
		    result.Column1 = m.Column0 * rotate.M10 + m.Column1 * rotate.M11 + m.Column2 * rotate.M12;
		    result.Column2 = m.Column0 * rotate.M20 + m.Column1 * rotate.M21 + m.Column2 * rotate.M22;
		    result.Column3 = m.Column3;
		    return result;
        }

        public static Matrix CreateIdentity()
        {
            Matrix r = new Matrix();
            r.Row0 = Vector4.CreateUnitX();
            r.Row1 = Vector4.CreateUnitY();
            r.Row2 = Vector4.CreateUnitZ();
            r.Row3 = Vector4.CreateUnitW();
            return r;
        }

        // Tested against GLM
        public static Matrix CreateTranslation(Vector3 v)
        {
            Matrix identity = Matrix.CreateIdentity();
            Matrix result = Matrix.CreateIdentity();
            result.Column3 = identity.Column0 * v.X
                + identity.Column1 * v.Y
                + identity.Column2 * v.Z
                + identity.Column3;
            return result;
        }

        public static Matrix CreateTranslation(float x, float y, float z)
        {
            return CreateTranslation(new Vector3(x, y, z));
        }

        // Tested against GLM
        public static Matrix CreateOrthographic(float left, float right, float bottom, float top)
        {
            Matrix result = Matrix.CreateIdentity();
		    result.M00 = 2.0f / (right - left);
		    result.M11 = 2.0f / (top - bottom);
		    result.M22 = - 1.0f;
		    result.M30 = - (right + left) / (right - left);
		    result.M31 = - (top + bottom) / (top - bottom);
		    return result;
        }

        // Tested against GLM
        public static Matrix CreateOrthographic(float left, float right, float bottom, float top, float zNear, float zFar)
        {
            Matrix result = Matrix.CreateIdentity();
            result.M00 = 2.0f / (right - left);
            result.M11 = 2.0f / (top - bottom);
            result.M22 = -2.0f / (zFar - zNear);
            result.M30 = -(right + left) / (right - left);
            result.M31 = -(top + bottom) / (top - bottom);
            result.M32 = -(zFar + zNear) / (zFar - zNear);
            return result;
        }

        // Tested against GLM
        public static Matrix CreateFrustum(float left, float right, float bottom, float top, float zNear, float zFar)
        {
            Matrix result = new Matrix();
		    result.M00 = (2.0f * zNear) / (right - left);
		    result.M11 = (2.0f * zNear) / (top - bottom);
		    result.M20 = (right + left) / (right - left);
		    result.M21 = (top + bottom) / (top - bottom);
		    result.M22 = -(zFar + zNear) / (zFar - zNear);
            result.M23 = -1;
		    result.M32 = -(2.0f * zFar * zNear) / (zFar - zNear);
		    return result;
        }

        // Tested against GLM
        public static Matrix CreatePerspective(float fovy, float aspect, float zNear, float zFar)
        {
            Matrix r = new Matrix();

            float tanHalfFovy = (float)Math.Tan(fovy / 2.0f);

            r.M00 = 1.0f / (aspect * tanHalfFovy);
            r.M11 = 1.0f / (tanHalfFovy);
            r.M22 = -(zFar + zNear) / (zFar - zNear);
            r.M23 = -1;
            r.M32 = -(2.0f * zFar * zNear) / (zFar - zNear);

            return r;
        }

        // Tested against GLM
        public static Matrix CreatePerspectiveFov(float fov, float width, float height, float zNear, float zFar)
        {
            float h = (float)Math.Cos(0.5f * fov) / (float)Math.Sin(0.5f * fov);
		    float w = h * height / width;

		    Matrix result = new Matrix();
		    result.M00 = w;
		    result.M11 = h;
		    result.M22 = - (zFar + zNear) / (zFar - zNear);
            result.M23 = -1.0f;
		    result.M32 = - (2.0f * zFar * zNear) / (zFar - zNear);
		    return result;
        }

        // Tested against GLM.
        public static Matrix CreatePerspectiveInfinite(float fovy, float aspect, float zNear)
        {
            float range = (float)Math.Tan(fovy / 2.0f) * zNear;

            float left = -range * aspect;
		    float right = range * aspect;
		    float bottom = -range;
		    float top = range;

            Matrix Result = new Matrix();
		    Result.M00 = (2.0f * zNear) / (right - left);
		    Result.M11 = (2.0f * zNear) / (top - bottom);
            Result.M22 = -1.0f;
		    Result.M23 = - 1.0f;
		    Result.M32 = - 2.0f * zNear;
		    return Result;
        }

        // Tested against GLM
        public static Matrix CreateScale(Vector3 v)
        {
            Matrix result = Matrix.CreateIdentity();
		    result.Column0 *= v.X;
		    result.Column1 *= v.Y;
		    result.Column2 *= v.Z;
		    return result;
        }

        // Tested against GLM
        public static Matrix CreateLookAt(Vector3 eye, Vector3 target, Vector3 up)
        {
            var f = target - eye;
            f.Normalize();
            var u = up;
            u.Normalize();
            var s = Vector3.Cross(f, u);
            s.Normalize();
            u = Vector3.Cross(s, f);

            Matrix Result = Matrix.CreateIdentity();

            Result.M00 = s.X;
            Result.M10 = s.Y;
            Result.M20 = s.Z;
            Result.M01 = u.X;
            Result.M11 = u.Y;
            Result.M21 = u.Z;
            Result.M02 = -f.X;
            Result.M12 = -f.Y;
            Result.M22 = -f.Z;
            Result.M30 = -(Vector3.Dot(s, eye));
            Result.M31 = -(Vector3.Dot(u, eye));
            Result.M32 = Vector3.Dot(f, eye);
            return Result;
        }

        // Tested against GLM.
        public static Matrix CreatePick(Vector2 center, Vector2 delta, Vector4 viewport)
        {
		    Matrix Result = Matrix.CreateIdentity();

		    if(!(delta.X > 0 && delta.Y > 0)) 
			    return Result; // Error

		    Vector3 Temp = new Vector3((viewport.Z - 2.0f * (center.X - viewport.X)) / delta.X,
			    (viewport.W - 2.0f * (center.Y - viewport.Y)) / delta.Y,
			    0.0f);

		    // Translate and scale the picked region to the entire window
		    Result = Result * Matrix.CreateTranslation(Temp);
            Matrix scale = Matrix.CreateScale(new Vector3(viewport.Z/delta.X, viewport.W/delta.Y, 1.0f));
		    return Result * scale;
        }

        // Tested against GLM.
        public static Matrix Transpose(Matrix m)
        {
            return new Matrix(m.Row0, m.Row1, m.Row2, m.Row3);
        }

        public void Invert()
        {
            this = Matrix.Inverse(this);
        }

        public void Transpose()
        {
            this = Matrix.Transpose(this);
        }

        // Tested against GLM.
        public static Matrix Inverse(Matrix m)
        {
            float Coef00 = m.M22 * m.M33 - m.M32 * m.M23;
		    float Coef02 = m.M12 * m.M33 - m.M32 * m.M13;
		    float Coef03 = m.M12 * m.M23 - m.M22 * m.M13;

		    float Coef04 = m.M21 * m.M33 - m.M31 * m.M23;
		    float Coef06 = m.M11 * m.M33 - m.M31 * m.M13;
		    float Coef07 = m.M11 * m.M23 - m.M21 * m.M13;

		    float Coef08 = m.M21 * m.M32 - m.M31 * m.M22;
		    float Coef10 = m.M11 * m.M32 - m.M31 * m.M12;
		    float Coef11 = m.M11 * m.M22 - m.M21 * m.M12;

		    float Coef12 = m.M20 * m.M33 - m.M30 * m.M23;
		    float Coef14 = m.M10 * m.M33 - m.M30 * m.M13;
		    float Coef15 = m.M10 * m.M23 - m.M20 * m.M13;

		    float Coef16 = m.M20 * m.M32 - m.M30 * m.M22;
		    float Coef18 = m.M10 * m.M32 - m.M30 * m.M12;
		    float Coef19 = m.M10 * m.M22 - m.M20 * m.M12;

		    float Coef20 = m.M20 * m.M31 - m.M30 * m.M21;
		    float Coef22 = m.M10 * m.M31 - m.M30 * m.M11;
		    float Coef23 = m.M10 * m.M21 - m.M20 * m.M11;

		    Vector4 SignA = new Vector4(+1, -1, +1, -1);
		    Vector4 SignB = new Vector4(-1, +1, -1, +1);

		    Vector4 Fac0 = new Vector4(Coef00, Coef00, Coef02, Coef03);
		    Vector4 Fac1 = new Vector4(Coef04, Coef04, Coef06, Coef07);
		    Vector4 Fac2 = new Vector4(Coef08, Coef08, Coef10, Coef11);
		    Vector4 Fac3 = new Vector4(Coef12, Coef12, Coef14, Coef15);
		    Vector4 Fac4 = new Vector4(Coef16, Coef16, Coef18, Coef19);
		    Vector4 Fac5 = new Vector4(Coef20, Coef20, Coef22, Coef23);

		    Vector4 Vec0 = new Vector4(m.M10, m.M00, m.M00, m.M00);
		    Vector4 Vec1 = new Vector4(m.M11, m.M01, m.M01, m.M01);
		    Vector4 Vec2 = new Vector4(m.M12, m.M02, m.M02, m.M02);
		    Vector4 Vec3 = new Vector4(m.M13, m.M03, m.M03, m.M03);

		    Vector4 Inv0 = SignA * (Vec1 * Fac0 - Vec2 * Fac1 + Vec3 * Fac2);
		    Vector4 Inv1 = SignB * (Vec0 * Fac0 - Vec2 * Fac3 + Vec3 * Fac4);
		    Vector4 Inv2 = SignA * (Vec0 * Fac1 - Vec1 * Fac3 + Vec3 * Fac5);
		    Vector4 Inv3 = SignB * (Vec0 * Fac2 - Vec1 * Fac4 + Vec2 * Fac5);

		    Matrix Inverse = new Matrix(Inv0, Inv1, Inv2, Inv3);

		    Vector4 Row0 = new Vector4(Inverse.M00, Inverse.M10, Inverse.M20, Inverse.M30);

		    float Determinant = Vector4.Dot(m.Column0, Row0);

		    Inverse /= Determinant;

		    return Inverse;
        }

        public bool Equals(Matrix other)
        {
            return this.Row0 == other.Row0 &&
                this.Row1 == other.Row1 &&
                this.Row2 == other.Row2 &&
                this.Row3 == other.Row3;
        }

        public override bool Equals(Object o)
        {
            if (o is Matrix)
                return this.Equals((Matrix)o);
            return false;
        }

        public static bool operator ==(Matrix left, Matrix right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Matrix left, Matrix right)
        {
            return !left.Equals(right);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return Row0.ToString() + "\n" + Row1.ToString() + "\n" + Row2.ToString() + "\n" + Row3.ToString();
        }
    }
}
