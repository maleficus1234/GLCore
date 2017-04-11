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
using System.Reflection;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

// Ignore all the "will always have default value of null" warnings for the delegates: they
// do get values assigned through reflection.
#pragma warning disable 649

namespace GLCore
{
    /* OpenGL 2.0 */
    public partial class GL30
    {
        public int GL_BLEND_EQUATION_RGB { get { return 0x8009; } }
        public int GL_VERTEX_ATTRIB_ARRAY_ENABLED { get { return 0x8622; } }
        public int GL_VERTEX_ATTRIB_ARRAY_SIZE { get { return 0x8623; } }
        public int GL_VERTEX_ATTRIB_ARRAY_STRIDE { get { return 0x8624; } }
        public int GL_VERTEX_ATTRIB_ARRAY_TYPE { get { return 0x8625; } }
        public int GL_CURRENT_VERTEX_ATTRIB { get { return 0x8626; } }
        public int GL_VERTEX_PROGRAM_POINT_SIZE { get { return 0x8642; } }
        public int GL_VERTEX_ATTRIB_ARRAY_POINTER { get { return 0x8645; } }
        public int GL_STENCIL_BACK_FUNC { get { return 0x8800; } }
        public int GL_STENCIL_BACK_FAIL { get { return 0x8801; } }
        public int GL_STENCIL_BACK_PASS_DEPTH_FAIL { get { return 0x8802; } }
        public int GL_STENCIL_BACK_PASS_DEPTH_PASS { get { return 0x8803; } }
        public int GL_MAX_DRAW_BUFFERS { get { return 0x8824; } }
        public int GL_DRAW_BUFFER0 { get { return 0x8825; } }
        public int GL_DRAW_BUFFER1 { get { return 0x8826; } }
        public int GL_DRAW_BUFFER2 { get { return 0x8827; } }
        public int GL_DRAW_BUFFER3 { get { return 0x8828; } }
        public int GL_DRAW_BUFFER4 { get { return 0x8829; } }
        public int GL_DRAW_BUFFER5 { get { return 0x882A; } }
        public int GL_DRAW_BUFFER6 { get { return 0x882B; } }
        public int GL_DRAW_BUFFER7 { get { return 0x882C; } }
        public int GL_DRAW_BUFFER8 { get { return 0x882D; } }
        public int GL_DRAW_BUFFER9 { get { return 0x882E; } }
        public int GL_DRAW_BUFFER10 { get { return 0x882F; } }
        public int GL_DRAW_BUFFER11 { get { return 0x8830; } }
        public int GL_DRAW_BUFFER12 { get { return 0x8831; } }
        public int GL_DRAW_BUFFER13 { get { return 0x8832; } }
        public int GL_DRAW_BUFFER14 { get { return 0x8833; } }
        public int GL_DRAW_BUFFER15 { get { return 0x8834; } }
        public int GL_BLEND_EQUATION_ALPHA { get { return 0x883D; } }
        public int GL_MAX_VERTEX_ATTRIBS { get { return 0x8869; } }
        public int GL_VERTEX_ATTRIB_ARRAY_NORMALIZED { get { return 0x886A; } }
        public int GL_MAX_TEXTURE_IMAGE_UNITS { get { return 0x8872; } }
        public int GL_FRAGMENT_SHADER { get { return 0x8B30; } }
        public int GL_VERTEX_SHADER { get { return 0x8B31; } }
        public int GL_MAX_FRAGMENT_UNIFORM_COMPONENTS { get { return 0x8B49; } }
        public int GL_MAX_VERTEX_UNIFORM_COMPONENTS { get { return 0x8B4A; } }
        public int GL_MAX_VARYING_FLOATS { get { return 0x8B4B; } }
        public int GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS { get { return 0x8B4C; } }
        public int GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS { get { return 0x8B4D; } }
        public int GL_SHADER_TYPE { get { return 0x8B4F; } }
        public int GL_FLOAT_VEC2 { get { return 0x8B50; } }
        public int GL_FLOAT_VEC3 { get { return 0x8B51; } }
        public int GL_FLOAT_VEC4 { get { return 0x8B52; } }
        public int GL_INT_VEC2 { get { return 0x8B53; } }
        public int GL_INT_VEC3 { get { return 0x8B54; } }
        public int GL_INT_VEC4 { get { return 0x8B55; } }
        public int GL_BOOL { get { return 0x8B56; } }
        public int GL_BOOL_VEC2 { get { return 0x8B57; } }
        public int GL_BOOL_VEC3 { get { return 0x8B58; } }
        public int GL_BOOL_VEC4 { get { return 0x8B59; } }
        public int GL_FLOAT_MAT2 { get { return 0x8B5A; } }
        public int GL_FLOAT_MAT3 { get { return 0x8B5B; } }
        public int GL_FLOAT_MAT4 { get { return 0x8B5C; } }
        public int GL_SAMPLER_1D { get { return 0x8B5D; } }
        public int GL_SAMPLER_2D { get { return 0x8B5E; } }
        public int GL_SAMPLER_3D { get { return 0x8B5F; } }
        public int GL_SAMPLER_CUBE { get { return 0x8B60; } }
        public int GL_SAMPLER_1D_SHADOW { get { return 0x8B61; } }
        public int GL_SAMPLER_2D_SHADOW { get { return 0x8B62; } }
        public int GL_DELETE_STATUS { get { return 0x8B80; } }
        public int GL_COMPILE_STATUS { get { return 0x8B81; } }
        public int GL_LINK_STATUS { get { return 0x8B82; } }
        public int GL_VALIDATE_STATUS { get { return 0x8B83; } }
        public int GL_INFO_LOG_LENGTH { get { return 0x8B84; } }
        public int GL_ATTACHED_SHADERS { get { return 0x8B85; } }
        public int GL_ACTIVE_UNIFORMS { get { return 0x8B86; } }
        public int GL_ACTIVE_UNIFORM_MAX_LENGTH { get { return 0x8B87; } }
        public int GL_SHADER_SOURCE_LENGTH { get { return 0x8B88; } }
        public int GL_ACTIVE_ATTRIBUTES { get { return 0x8B89; } }
        public int GL_ACTIVE_ATTRIBUTE_MAX_LENGTH { get { return 0x8B8A; } }
        public int GL_FRAGMENT_SHADER_DERIVATIVE_HINT { get { return 0x8B8B; } }
        public int GL_SHADING_LANGUAGE_VERSION { get { return 0x8B8C; } }
        public int GL_CURRENT_PROGRAM { get { return 0x8B8D; } }
        public int GL_POINT_SPRITE_COORD_ORIGIN { get { return 0x8CA0; } }
        public int GL_LOWER_LEFT { get { return 0x8CA1; } }
        public int GL_UPPER_LEFT { get { return 0x8CA2; } }
        public int GL_STENCIL_BACK_REF { get { return 0x8CA3; } }
        public int GL_STENCIL_BACK_VALUE_MASK { get { return 0x8CA4; } }
        public int GL_STENCIL_BACK_WRITEMASK { get { return 0x8CA5; } }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendEquationSeparatedelegate(int modeRGB, int modeAlpha);
        internal BlendEquationSeparatedelegate glBlendEquationSeparate;

        public void BlendEquationSeparate(int blendingEquationRGB, int blendingEquationAlpha)
        {
            glBlendEquationSeparate(blendingEquationRGB, blendingEquationAlpha);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DrawBuffersDelegate(int n, int* bufs);
        internal unsafe DrawBuffersDelegate glDrawBuffers;

        public void DrawBuffers(int n, int[] colorBufferModes)
        {
            unsafe
            {
                fixed (int* bufs_ptr = colorBufferModes)
                {
                    glDrawBuffers((int)n, (int*)bufs_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilOpSeparatedelegate(int face, int sfail, int dpfail, int dppass);
        internal StencilOpSeparatedelegate glStencilOpSeparate;

        public void StencilOpSeparate(int face, int sfail, int dpfail, int dppass)
        {
            glStencilOpSeparate(face, sfail, dpfail, dppass);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilFuncSeparatedelegate(int face, int function, int @ref, uint mask);
        internal StencilFuncSeparatedelegate glStencilFuncSeparate;

        public void StencilFuncSeparate(int face, int function, int @ref, int mask)
        {
            glStencilFuncSeparate(face, function, @ref, (uint)mask);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilMaskSeparatedelegate(int face, uint mask);
        internal StencilMaskSeparatedelegate glStencilMaskSeparate;

        public void StencilMaskSeparate(int face, int mask)
        {
            glStencilMaskSeparate(face, (uint)mask);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void AttachShaderDelegate(uint program, uint shader);
        internal AttachShaderDelegate glAttachShader;

        public void AttachShader(int program, int shader)
        {
            glAttachShader((uint)program, (uint)shader);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindAttribLocationd(uint program, uint index, string name);
        internal BindAttribLocationd glBindAttribLocation;

        public void BindAttribLocation(int program, int index, string name)
        {
            glBindAttribLocation((uint)program, (uint)index, name);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CompileShaderDelegate(uint shader);
        internal CompileShaderDelegate glCompileShader;

        public void CompileShader(int shader)
        {
            glCompileShader((uint)shader);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int CreateShaderDelegate(int type);
        internal CreateShaderDelegate glCreateShader;

        public int CreateShader(int shaderType)
        {
            int s = glCreateShader(shaderType);
            CheckForErrors();
            return s;
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ShaderSourceDelegate(uint shader, int count, string[] @string, int* length);
        internal unsafe ShaderSourceDelegate glShaderSource;

        public void ShaderSource(int shader, int count, string[] @string, int[] length)
        {
            unsafe
            {
                fixed (int* length_ptr = length)
                {
                    glShaderSource((uint)shader, (int)count, @string, (int*)length_ptr);
                    CheckForErrors();
                }
            }
        }

        public void ShaderSource(int shader, string source)
        {
            string[] sourceArr = new string[1];
            sourceArr[0] = source;
            int[] lengthArr = 
            {
                source.Length
            };
            ShaderSource(shader, 1, sourceArr, lengthArr);
        }



        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DeleteShaderDelegate(uint shader);
        internal DeleteShaderDelegate glDeleteShader;

        public void DeleteShader(int shader)
        {
            glDeleteShader((uint)shader);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int CreateProgramDelegate();
        internal CreateProgramDelegate glCreateProgram;

        public int CreateProgram()
        {
            int p = glCreateProgram();
            CheckForErrors();
            return p;
        }



        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DetachShaderDelegate(uint program, uint shader);
        internal DetachShaderDelegate glDetachShader;

        public void DetachShader(int program, int shader)
        {
            glDetachShader((uint)program, (uint)shader);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LinkProgramDelegate(uint program);
        internal LinkProgramDelegate glLinkProgram;

        public void LinkProgram(int program)
        {
            glLinkProgram((uint)program);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DeleteProgramDelegate(uint program);
        internal DeleteProgramDelegate glDeleteProgram;

        public void DeleteProgram(int program)
        {
            glDeleteProgram((uint)program);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EnableVertexAttribArrayd(uint index);
        internal EnableVertexAttribArrayd glEnableVertexAttribArray;

        public void EnableVertexAttribArray(int index)
        {
            glEnableVertexAttribArray((uint)index);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DisableVertexAttribArrayd(uint index);
        internal DisableVertexAttribArrayd glDisableVertexAttribArray;

        public void DisableVertexAttribArray(int index)
        {
            glDisableVertexAttribArray((uint)index);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetActiveAttribdelegate(uint program, uint index, int bufSize, [OutAttribute] int* length, [OutAttribute] int* size, [OutAttribute] int* attribType, [OutAttribute] StringBuilder name);
        internal unsafe GetActiveAttribdelegate glGetActiveAttrib;

        public void GetActiveAttrib(int program, int index, int bufSize, [OutAttribute] out int length, [OutAttribute] out int size, [OutAttribute] out int attribType, [OutAttribute] StringBuilder name)
        {
            unsafe
            {
                fixed (int* length_ptr = &length)
                fixed (int* size_ptr = &size)
                fixed (int* type_ptr = &attribType)
                {
                    glGetActiveAttrib((uint)program, (uint)index, (int)bufSize, (int*)length_ptr, (int*)size_ptr, (int*)type_ptr, (StringBuilder)name);
                    CheckForErrors();
                    length = *length_ptr;
                    size = *size_ptr;
                    attribType = *type_ptr;
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetActiveUniformdelegate(uint program, uint index, int bufSize, [OutAttribute] int* length, [OutAttribute] int* size, [OutAttribute] int* type, [OutAttribute] StringBuilder name);
        internal unsafe GetActiveUniformdelegate glGetActiveUniform;

        public void GetActiveUniform(int program, int index, int bufSize, [OutAttribute] out int length, [OutAttribute] out int size, [OutAttribute] out int uniformType, [OutAttribute] StringBuilder name)
        {
            unsafe
            {
                fixed (int* length_ptr = &length)
                fixed (int* size_ptr = &size)
                fixed (int* type_ptr = &uniformType)
                {
                    glGetActiveUniform((uint)program, (uint)index, (int)bufSize, (int*)length_ptr, (int*)size_ptr, type_ptr, (StringBuilder)name);
                    CheckForErrors();
                    length = *length_ptr;
                    size = *size_ptr;
                    uniformType = *type_ptr;
                }
            }
        }


        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int GetAttribLocationdelegate(uint program, string name);
        internal GetAttribLocationdelegate glGetAttribLocation;

        public int GetAttribLocation(int program, string name)
        {
            int r = glGetAttribLocation((uint)program, name);
            CheckForErrors();
            return r;
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetAttachedShadersdelegate(uint program, int maxCount, [OutAttribute] int* count, [OutAttribute] uint* obj);
        internal unsafe GetAttachedShadersdelegate glGetAttachedShaders;
#warning add array support to GetAttachedShaders
        public void GetAttachedShaders(int program, int maxCount, [OutAttribute] out int count, [OutAttribute] out int obj)
        {
            unsafe
            {
                fixed (int* count_ptr = &count)
                fixed (int* obj_ptr = &obj)
                {
                    glGetAttachedShaders((uint)program, (int)maxCount, (int*)count_ptr, (uint*)obj_ptr);
                    CheckForErrors();
                    count = *count_ptr;
                    obj = *obj_ptr;
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ValidateProgramDelegate(uint program);
        internal ValidateProgramDelegate glValidateProgram;

        public void ValidateProgram(int program)
        {
            glValidateProgram((uint)program);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramInfoLogDelegate(uint program, int bufSize, [Out] int* length, [Out] System.Text.StringBuilder infoLog);
        internal unsafe GetProgramInfoLogDelegate glGetProgramInfoLog;

        public void GetProgramInfoLog(int program, int bufSize, [Out] out int length, [Out] System.Text.StringBuilder infoLog)
        {
            unsafe
            {
                fixed (int* length_ptr = &length)
                {
                    glGetProgramInfoLog((uint)program, (int)bufSize, (int*)length_ptr, (System.Text.StringBuilder)infoLog);
                    CheckForErrors();
                    length = *length_ptr;
                }
            }
        }

        public void GetProgramInfoLog(int program, out string info)
        {
            unsafe
            {
                int length;
                GetProgram(program, this.GL_INFO_LOG_LENGTH, out length); if (length == 0)
                {
                    info = string.Empty;
                    return;
                }
                StringBuilder sb = new StringBuilder(length * 2);
                GetProgramInfoLog(program, sb.Capacity, out length, sb);
                info = sb.ToString();
            }
        }

        public string GetProgramInfoLog(int program)
        {
            string s;
            GetProgramInfoLog(program, out s);
            return s;
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramivDelegate(uint program, uint pname, [OutAttribute] int* @params);
        internal unsafe GetProgramivDelegate glGetProgramiv;

        public void GetProgram(int program, int programPName, [OutAttribute] out int @params)
        {

            unsafe
            {
                fixed (int* @params_ptr = &@params)
                {
                    glGetProgramiv((uint)program, (uint)programPName, (int*)@params_ptr);
                    @params = *@params_ptr;
                    CheckForErrors();
                }
            }
        }

        public void GetProgram(int program, int programPName, int[] parameters)
        {
            unsafe
            {
                fixed (int* @params_ptr = parameters)
                {
                    glGetProgramiv((uint)program, (uint)programPName, (int*)@params_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetShaderInfoLogd(uint shader, int bufSize, [OutAttribute] int* length, [OutAttribute] StringBuilder infoLog);
        internal unsafe GetShaderInfoLogd glGetShaderInfoLog;

        public void GetShaderInfoLog(int shader, out string info)
        {
            unsafe
            {
                int length;
                GetShader(shader, this.GL_INFO_LOG_LENGTH, out length);
                if (length == 0)
                {
                    info = string.Empty;
                    return;
                }
                StringBuilder sb = new StringBuilder(length * 2);
                glGetShaderInfoLog((uint)shader, sb.Capacity, &length, sb);
                CheckForErrors();
                info = sb.ToString();
            }
        }

        public string GetShaderInfoLog(int shader)
        {
            string info;
            GetShaderInfoLog(shader, out info);
            return info;
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetShaderivd(uint shader, int pname, [OutAttribute] int* @params);
        internal unsafe GetShaderivd glGetShaderiv;

        public void GetShader(int shader, int pname, [OutAttribute] int[] @params)
        {
            unsafe
            {
                fixed (int* @params_ptr = @params)
                {
                    glGetShaderiv((uint)shader, pname, (int*)@params_ptr);
                    CheckForErrors();
                }
            }
        }

        void GetShader(int shader, int pname, [OutAttribute] out int @params)
        {
            unsafe
            {
                fixed (int* @params_ptr = &@params)
                {
                    glGetShaderiv((uint)shader, pname, (int*)@params_ptr);
                    CheckForErrors();
                    @params = *@params_ptr;
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetShaderSourcedelegate(uint shader, int bufSize, [OutAttribute] int* length, [OutAttribute] StringBuilder source);
        internal unsafe GetShaderSourcedelegate glGetShaderSource;

        public void GetShaderSource(int shader, int bufSize, [OutAttribute] out int length, [OutAttribute] StringBuilder source)
        {
            unsafe
            {
                fixed (int* length_ptr = &length)
                {
                    glGetShaderSource((uint)shader, (int)bufSize, (int*)length_ptr, (StringBuilder)source);
                    CheckForErrors();
                    length = *length_ptr;
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int GetUniformLocationd(uint program, string name);
        internal GetUniformLocationd glGetUniformLocation;

        public int GetUniformLocation(int program, string name)
        {
            int r = glGetUniformLocation((uint)program, name);
            CheckForErrors();
            return r;
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetUniformivdelegate(uint program, int location, [OutAttribute] int* @params);
        internal unsafe GetUniformivdelegate glGetUniformiv;

        public void GetUniform(int program, int location, [OutAttribute] int[] @params)
        {
            unsafe
            {
                fixed (int* @params_ptr = @params)
                {
                    glGetUniformiv((uint)program, (int)location, (int*)@params_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetUniformfvdelegate(uint program, int location, [OutAttribute] float* @params);
        internal unsafe GetUniformfvdelegate glGetUniformfv;

        public void GetUniform(int program, int location, [OutAttribute] float[] @params)
        {
            unsafe
            {
                fixed (float* @params_ptr = @params)
                {
                    glGetUniformfv((uint)program, (int)location, @params_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribdvdelegate(uint index, int pname, [OutAttribute] Double* @params);
        internal unsafe GetVertexAttribdvdelegate glGetVertexAttribdv;

        public void GetVertexAttrib(int index, int vertexAttribPName, [OutAttribute] Double[] @params)
        {
            unsafe
            {
                fixed (Double* @params_ptr = @params)
                {
                    glGetVertexAttribdv((uint)index, vertexAttribPName, (Double*)@params_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribfvdelegate(uint index, int pname, [OutAttribute] float* @params);
        internal unsafe GetVertexAttribfvdelegate glGetVertexAttribfv;

        public void GetVertexAttrib(int index, int vertexAttribPName, [OutAttribute] float[] @params)
        {
            unsafe
            {
                fixed (float* @params_ptr = @params)
                {
                    glGetVertexAttribfv((uint)index, vertexAttribPName, @params_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribivdelegate(uint index, int pname, [OutAttribute] int* @params);
        internal unsafe GetVertexAttribivdelegate glGetVertexAttribiv;

        public void GetVertexAttrib(int index, int vertexAttribPName, [OutAttribute] int[] @params)
        {
            unsafe
            {
                fixed (int* @params_ptr = @params)
                {
                    glGetVertexAttribiv((uint)index, vertexAttribPName, @params_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GetVertexAttribPointervdelegate(uint index, int pname, [OutAttribute] IntPtr pointer);
        internal GetVertexAttribPointervdelegate glGetVertexAttribPointerv;

        public void GetVertexAttribPointer<T2>(int index, int pname, [InAttribute, OutAttribute] T2[] pointer)
            where T2 : struct
        {
            GCHandle pointer_ptr = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                glGetVertexAttribPointerv((uint)index, pname, (IntPtr)pointer_ptr.AddrOfPinnedObject());
                CheckForErrors();
            }
            finally
            {
                pointer_ptr.Free();
            }
        }

        public void GetVertexAttribPointer<T2>(int index, int pname, [InAttribute, OutAttribute] T2[,] pointer)
            where T2 : struct
        {
            GCHandle pointer_ptr = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                glGetVertexAttribPointerv((uint)index, pname, (IntPtr)pointer_ptr.AddrOfPinnedObject());
                CheckForErrors();
            }
            finally
            {
                pointer_ptr.Free();
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate bool IsShaderdelegate(uint shader);
        internal IsShaderdelegate glIsShader;

        public bool IsShader(int shader)
        {
            bool r = glIsShader((uint)shader);
            CheckForErrors();
            return r;
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate bool IsProgramdelegate(uint program);
        internal IsProgramdelegate glIsProgram;

        public bool IsProgram(int program)
        {
            bool r = glIsProgram((uint)program);
            CheckForErrors();
            return r;
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void UseProgramd(uint program);
        internal UseProgramd glUseProgram;

        public void UseProgram(int program)
        {
            glUseProgram((uint)program);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix4fvd(int location, int count, bool transpose, float* value);
        internal unsafe UniformMatrix4fvd glUniformMatrix4fv;

        public void Uniform(int location, bool transpose, ref Matrix matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Column0.X)
                {
                    glUniformMatrix4fv(location, 1, transpose, matrix_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform1iddelegate(int location, int v0);
        internal Uniform1iddelegate glUniform1i;

        public void Uniform(int location, int value)
        {
            glUniform1i(location, value);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform1fdelegate(int location, float v0);
        internal Uniform1fdelegate glUniform1f;

        public void Uniform(int location, float value)
        {
            glUniform1f(location, value);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform2iddelegate(int location, int v0, int v1);
        internal Uniform2iddelegate glUniform2i;

        public void Uniform(int location, int v0, int v1)
        {
            glUniform2i(location, v0, v1);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform2fdelegate(int location, float v0, float v1);
        internal Uniform2fdelegate glUniform2f;

        public void Uniform(int location, float v0, float v1)
        {
            glUniform2f(location, v0, v1);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform3iddelegate(int location, int v0, int v1, int v2);
        internal Uniform3iddelegate glUniform3i;

        public void Uniform(int location, int v0, int v1, int v2)
        {
            glUniform3i(location, v0, v1, v2);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform3fdelegate(int location, float v0, float v1, float v2);
        internal Uniform3fdelegate glUniform3f;

        public void Uniform(int location, float v0, float v1, float v2)
        {
            glUniform3f(location, v0, v1, v2);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform4iddelegate(int location, int v0, int v1, int v2, int v3);
        internal Uniform4iddelegate glUniform4i;

        public void Uniform(int location, int v0, int v1, int v2, int v3)
        {
            glUniform4i(location, v0, v1, v2, v3);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform4fdelegate(int location, float v0, float v1, float v2, float v3);
        internal Uniform4fdelegate glUniform4f;

        public void Uniform(int location, float v0, float v1, float v2, float v3)
        {
            glUniform4f(location, v0, v1, v2, v3);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform1fvdelegate(int location, int count, float* value);
        internal unsafe Uniform1fvdelegate glUniform1fv;

        public void Uniform1(int location, int count, float[] v)
        {
            unsafe
            {
                fixed (float* vptr = v)
                {
                    glUniform1fv(location, count, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform1ivdelegate(int location, int count, int* value);
        internal unsafe Uniform1ivdelegate glUniform1iv;

        public void Uniform1(int location, int count, int[] v)
        {
            unsafe
            {
                fixed (int* vptr = v)
                {
                    glUniform1iv(location, count, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform2ivdelegate(int location, int count, int* value);
        internal unsafe Uniform2ivdelegate glUniform2iv;

        public void Uniform2(int location, int count, int[] v)
        {
            unsafe
            {
                fixed (int* vptr = v)
                {
                    glUniform2iv(location, count, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform2fvdelegate(int location, int count, float* value);
        internal unsafe Uniform2fvdelegate glUniform2fv;

        public void Uniform2(int location, int count, float[] v)
        {
            unsafe
            {
                fixed (float* vptr = v)
                {
                    glUniform2fv(location, count, vptr);
                    CheckForErrors();
                }
            }
        }


        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform3ivdelegate(int location, int count, int* value);
        internal unsafe Uniform3ivdelegate glUniform3iv;

        public void Uniform3(int location, int count, int[] v)
        {
            unsafe
            {
                fixed (int* vptr = v)
                {
                    glUniform3iv(location, count, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform3fvdelegate(int location, int count, float* value);
        internal unsafe Uniform3fvdelegate glUniform3fv;

        public void Uniform3(int location, int count, float[] v)
        {
            unsafe
            {
                fixed (float* vptr = v)
                {
                    glUniform3fv(location, count, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform4ivdelegate(int location, int count, int* value);
        internal unsafe Uniform4ivdelegate glUniform4iv;

        public void Uniform4(int location, int count, int[] v)
        {
            unsafe
            {
                fixed (int* vptr = v)
                {
                    glUniform4iv(location, count, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform4fvdelegate(int location, int count, float* value);
        internal unsafe Uniform4fvdelegate glUniform4fv;

        public void Uniform4(int location, int count, float[] v)
        {
            unsafe
            {
                fixed (float* vptr = v)
                {
                    glUniform4fv(location, count, vptr);
                    CheckForErrors();
                }
            }
        }

        public void UniformMatrix4(int location, bool transpose, float[] matrix)
        {
            unsafe
            {
                fixed (float* ptr = matrix)
                {
                    glUniformMatrix4fv(location, 1, transpose, ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix3fvd(int location, int count, bool transpose, float* value);
        internal unsafe UniformMatrix3fvd glUniformMatrix3fv;

        public void UniformMatrix3(int location, bool transpose, float[] matrix)
        {
            unsafe
            {
                fixed (float* ptr = matrix)
                {
                    glUniformMatrix3fv(location, 1, transpose, ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix2fvd(int location, int count, bool transpose, float* value);
        internal unsafe UniformMatrix2fvd glUniformMatrix2fv;

        public void UniformMatrix2(int location, bool transpose, float[] matrix)
        {
            unsafe
            {
                fixed (float* ptr = matrix)
                {
                    glUniformMatrix2fv(location, 1, transpose, ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1sd(uint index, short x);
        internal static VertexAttrib1sd glVertexAttrib1s;

        public void VertexAttrib(int index, short x)
        {
            glVertexAttrib1s((uint)index, x);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1fDelegate(uint index, float x);
        internal VertexAttrib1fDelegate glVertexAttrib1f;

        public void VertexAttrib(int index, float x)
        {
            glVertexAttrib1f((uint)index, x);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1dDelegate(uint index, double x);
        internal VertexAttrib1dDelegate glVertexAttrib1d;

        public void VertexAttrib(int index, double x)
        {
            glVertexAttrib1d((uint)index, x);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2sDelegate(uint index, short x, short y);
        internal VertexAttrib2sDelegate glVertexAttrib2s;

        public void VertexAttrib(int index, short x, short y)
        {
            glVertexAttrib2s((uint)index, x, y);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2fDelegate(uint index, float x, float y);
        internal VertexAttrib2fDelegate glVertexAttrib2f;

        public void VertexAttrib(int index, float x, float y)
        {
            glVertexAttrib2f((uint)index, x, y);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2dDelegate(uint index, double x, double y);
        internal VertexAttrib2dDelegate glVertexAttrib2d;

        public void VertexAttrib(int index, double x, double y)
        {
            glVertexAttrib2d((uint)index, x, y);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3sDelegate(uint index, short x, short y, short z);
        internal VertexAttrib3sDelegate glVertexAttrib3s;

        public void VertexAttrib(int index, short x, short y, short z)
        {
            glVertexAttrib3s((uint)index, x, y, z);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3fDelegate(uint index, float x, float y, float z);
        internal VertexAttrib3fDelegate glVertexAttrib3f;

        public void VertexAttrib(int index, float x, float y, float z)
        {
            glVertexAttrib3f((uint)index, x, y, z);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3dDelegate(uint index, double x, double y, double z);
        internal VertexAttrib3dDelegate glVertexAttrib3d;

        public void VertexAttrib(int index, double x, double y, double z)
        {
            glVertexAttrib3d((uint)index, x, y, z);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4sDelegate(uint index, short x, short y, short z, short w);
        internal VertexAttrib4sDelegate glVertexAttrib4s;

        public void VertexAttrib(int index, short x, short y, short z, short w)
        {
            glVertexAttrib4s((uint)index, x, y, z, w);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4fDelegate(uint index, float x, float y, float z, float w);
        internal VertexAttrib4fDelegate glVertexAttrib4f;

        public void VertexAttrib(int index, float x, float y, float z, float w)
        {
            glVertexAttrib4f((uint)index, x, y, z, w);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4dDelegate(uint index, double x, double y, double z, double w);
        internal VertexAttrib4dDelegate glVertexAttrib4d;

        public void VertexAttrib(int index, double x, double y, double z, double w)
        {
            glVertexAttrib4d((uint)index, x, y, z, w);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1svDelegate(uint index, IntPtr v);
        internal unsafe VertexAttrib1svDelegate glVertexAttrib1sv;

        public void VertexAttrib1(int index, short[] data)
        {
            GCHandle arr_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                glVertexAttrib1sv((uint)index, arr_ptr.AddrOfPinnedObject());
                CheckForErrors();
            }
            finally
            {
                arr_ptr.Free();
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1fvDelegate(uint index, IntPtr v);
        internal unsafe VertexAttrib1fvDelegate glVertexAttrib1fv;

        public void VertexAttrib1(int index, float[] data)
        {
            GCHandle arr_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                glVertexAttrib1fv((uint)index, arr_ptr.AddrOfPinnedObject());
                CheckForErrors();
            }
            finally
            {
                arr_ptr.Free();
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1dvDelegate(uint index, IntPtr v);
        internal unsafe VertexAttrib1dvDelegate glVertexAttrib1dv;

        public void VertexAttrib1(int index, double[] data)
        {
            GCHandle arr_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                glVertexAttrib1dv((uint)index, arr_ptr.AddrOfPinnedObject());
                CheckForErrors();
            }
            finally
            {
                arr_ptr.Free();
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2svDelegate(uint index, IntPtr v);
        internal unsafe VertexAttrib2svDelegate glVertexAttrib2sv;

        public void VertexAttrib2(int index, short[] data)
        {
            GCHandle arr_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                glVertexAttrib2sv((uint)index, arr_ptr.AddrOfPinnedObject());
                CheckForErrors();
            }
            finally
            {
                arr_ptr.Free();
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2fvDelegate(uint index, IntPtr v);
        internal unsafe VertexAttrib2fvDelegate glVertexAttrib2fv;

        public void VertexAttrib2(int index, float[] data)
        {
            GCHandle arr_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                glVertexAttrib2fv((uint)index, arr_ptr.AddrOfPinnedObject());
                CheckForErrors();
            }
            finally
            {
                arr_ptr.Free();
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2dvDelegate(uint index, IntPtr v);
        internal unsafe VertexAttrib2dvDelegate glVertexAttrib2dv;

        public void VertexAttrib2(int index, double[] data)
        {
            GCHandle arr_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                glVertexAttrib2dv((uint)index, arr_ptr.AddrOfPinnedObject());
                CheckForErrors();
            }
            finally
            {
                arr_ptr.Free();
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3svDelegate(uint index, IntPtr v);
        internal unsafe VertexAttrib3svDelegate glVertexAttrib3sv;

        public void VertexAttrib3(int index, short[] data)
        {
            GCHandle arr_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                glVertexAttrib3sv((uint)index, arr_ptr.AddrOfPinnedObject());
                CheckForErrors();
            }
            finally
            {
                arr_ptr.Free();
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3fvDelegate(uint index, IntPtr v);
        internal unsafe VertexAttrib3fvDelegate glVertexAttrib3fv;

        public void VertexAttrib3(int index, float[] data)
        {
            GCHandle arr_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                glVertexAttrib3fv((uint)index, arr_ptr.AddrOfPinnedObject());
                CheckForErrors();
            }
            finally
            {
                arr_ptr.Free();
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3dvDelegate(uint index, IntPtr v);
        internal unsafe VertexAttrib3dvDelegate glVertexAttrib3dv;

        public void VertexAttrib3(int index, double[] data)
        {
            GCHandle arr_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                glVertexAttrib3dv((uint)index, arr_ptr.AddrOfPinnedObject());
                CheckForErrors();
            }
            finally
            {
                arr_ptr.Free();
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4svDelegate(uint index, IntPtr v);
        internal unsafe VertexAttrib4svDelegate glVertexAttrib4sv;

        public void VertexAttrib4(int index, short[] data)
        {
            GCHandle arr_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                glVertexAttrib4sv((uint)index, arr_ptr.AddrOfPinnedObject());
                CheckForErrors();
            }
            finally
            {
                arr_ptr.Free();
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4fvDelegate(uint index, IntPtr v);
        internal unsafe VertexAttrib4fvDelegate glVertexAttrib4fv;

        public void VertexAttrib4(int index, float[] data)
        {
            GCHandle arr_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                glVertexAttrib4fv((uint)index, arr_ptr.AddrOfPinnedObject());
                CheckForErrors();
            }
            finally
            {
                arr_ptr.Free();
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4dvDelegate(uint index, IntPtr v);
        internal unsafe VertexAttrib4dvDelegate glVertexAttrib4dv;

        public void VertexAttrib4(int index, double[] data)
        {
            GCHandle arr_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                glVertexAttrib4dv((uint)index, arr_ptr.AddrOfPinnedObject());
                CheckForErrors();
            }
            finally
            {
                arr_ptr.Free();
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4NubDelegate(uint index, byte x, byte y, byte z, byte w);
        internal VertexAttrib4NubDelegate glVertexAttrib4Nub;

        public void VertexAttrib4N(int index, byte x, byte y, byte z, byte w)
        {
            glVertexAttrib4Nub((uint)index, x, y, z, w);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4Nbvdelegate(uint index, SByte* v);
        internal unsafe VertexAttrib4Nbvdelegate glVertexAttrib4Nbv;

        [System.CLSCompliant(false)]
        public void VertexAttrib4N(int index, SByte[] v)
        {
            unsafe
            {
                fixed (SByte* v_ptr = v)
                {
                    glVertexAttrib4Nbv((uint)index, (SByte*)v_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4Nuivdelegate(uint index, uint* v);
        internal unsafe VertexAttrib4Nuivdelegate glVertexAttrib4Nuiv;

        [System.CLSCompliant(false)]
        public void VertexAttrib4N(int index, uint[] v)
        {
            unsafe
            {
                fixed (uint* v_ptr = v)
                {
                    glVertexAttrib4Nuiv((uint)index, (uint*)v_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4Nusvdelegate(uint index, ushort* v);
        internal unsafe VertexAttrib4Nusvdelegate glVertexAttrib4Nusv;

        [System.CLSCompliant(false)]
        public void VertexAttrib4N(int index, ushort[] v)
        {
            unsafe
            {
                fixed (ushort* v_ptr = v)
                {
                    glVertexAttrib4Nusv((uint)index, (ushort*)v_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4Nubvdelegate(uint index, byte* v);
        internal unsafe VertexAttrib4Nubvdelegate glVertexAttrib4Nubv;

        public void VertexAttrib4N(int index, byte[] v)
        {
            unsafe
            {
                fixed (byte* v_ptr = v)
                {
                    glVertexAttrib4Nubv((uint)index, (byte*)v_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4Nsvdelegate(uint index, short* v);
        internal unsafe VertexAttrib4Nsvdelegate glVertexAttrib4Nsv;

        public void VertexAttrib4N(int index, short[] v)
        {
            unsafe
            {
                fixed (short* v_ptr = v)
                {
                    glVertexAttrib4Nsv((uint)index, (short*)v_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4Nivdelegate(uint index, int* v);
        internal unsafe VertexAttrib4Nivdelegate glVertexAttrib4Niv;

        public void VertexAttrib4N(int index, int[] v)
        {
            unsafe
            {
                fixed (int* v_ptr = v)
                {
                    glVertexAttrib4Niv((uint)index, (int*)v_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4usvDelegate(uint index, ushort* v);
        internal unsafe VertexAttrib4usvDelegate glVertexAttrib4usv;

        [System.CLSCompliant(false)]
        public void VertexAttrib4(int index, ushort[] v)
        {
            unsafe
            {
                fixed (ushort* v_ptr = v)
                {
                    glVertexAttrib4usv((uint)index, (ushort*)v_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4ubvDelegate(uint index, byte* v);
        internal unsafe VertexAttrib4ubvDelegate glVertexAttrib4ubv;

        public void VertexAttrib4(int index, byte[] v)
        {
            unsafe
            {
                fixed (byte* v_ptr = v)
                {
                    glVertexAttrib4ubv((uint)index, (byte*)v_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4uivDelegate(uint index, uint* v);
        internal unsafe VertexAttrib4uivDelegate glVertexAttrib4uiv;

        [System.CLSCompliant(false)]
        public void VertexAttrib4(int index, uint[] v)
        {
            unsafe
            {
                fixed (uint* v_ptr = v)
                {
                    glVertexAttrib4uiv((uint)index, (uint*)v_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribPointerd(uint index, int size, int vertexAttribType, bool normalized, int stride, IntPtr pointer);
        internal VertexAttribPointerd glVertexAttribPointer;

        public void VertexAttribPointer(int index, int size, int vertexAttribType, bool normalized, int stride, IntPtr pointer)
        {
            glVertexAttribPointer((uint)index, (int)size, vertexAttribType, (bool)normalized, (int)stride, (IntPtr)pointer);
            CheckForErrors();
        }

        public void VertexAttribPointer(int index, int size, int vertexAttribType, bool normalized, int stride, int pointer)
        {
            VertexAttribPointer(index, size, vertexAttribType, normalized, stride, new IntPtr(pointer));
            CheckForErrors();
        }
    }
}
