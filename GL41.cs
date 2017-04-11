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
    public class GL41
        : GL40
    {

        public GL41(Context context)
            : base(context)
        {

        }

        public int GL_FIXED                           { get { return 0x140C; } }
        public int GL_IMPLEMENTATION_COLOR_READ_TYPE  { get { return 0x8B9A; } }
        public int GL_IMPLEMENTATION_COLOR_READ_FORMAT  { get { return 0x8B9B; } }
        public int GL_LOW_FLOAT                       { get { return 0x8DF0; } }
        public int GL_MEDIUM_FLOAT                    { get { return 0x8DF1; } }
        public int GL_HIGH_FLOAT                      { get { return 0x8DF2; } }
        public int GL_LOW_INT                         { get { return 0x8DF3; } }
        public int GL_MEDIUM_INT                      { get { return 0x8DF4; } }
        public int GL_HIGH_INT                        { get { return 0x8DF5; } }
        public int GL_SHADER_COMPILER                 { get { return 0x8DFA; } }
        public int GL_SHADER_BINARY_FORMATS           { get { return 0x8DF8; } }
        public int GL_NUM_SHADER_BINARY_FORMATS       { get { return 0x8DF9; } }
        public int GL_MAX_VERTEX_UNIFORM_VECTORS      { get { return 0x8DFB; } }
        public int GL_MAX_VARYING_VECTORS             { get { return 0x8DFC; } }
        public int GL_MAX_FRAGMENT_UNIFORM_VECTORS    { get { return 0x8DFD; } }
        public int GL_RGB565                          { get { return 0x8D62; } }
        public int GL_PROGRAM_BINARY_RETRIEVABLE_HINT  { get { return 0x8257; } }
        public int GL_PROGRAM_BINARY_LENGTH           { get { return 0x8741; } }
        public int GL_NUM_PROGRAM_BINARY_FORMATS      { get { return 0x87FE; } }
        public int GL_PROGRAM_BINARY_FORMATS          { get { return 0x87FF; } }
        public int GL_VERTEX_SHADER_BIT               { get { return 0x00000001; } }
        public int GL_FRAGMENT_SHADER_BIT             { get { return 0x00000002; } }
        public int GL_GEOMETRY_SHADER_BIT             { get { return 0x00000004; } }
        public int GL_TESS_CONTROL_SHADER_BIT         { get { return 0x00000008; } }
        public int GL_TESS_EVALUATION_SHADER_BIT      { get { return 0x00000010; } }
        public int GL_ALL_SHADER_BITS                 { get { return unchecked((int)0xFFFFFFFF); } }
        public int GL_PROGRAM_SEPARABLE               { get { return 0x8258; } }
        public int GL_ACTIVE_PROGRAM                  { get { return 0x8259; } }
        public int GL_PROGRAM_PIPELINE_BINDING        { get { return 0x825A; } }
        public int GL_MAX_VIEWPORTS                   { get { return 0x825B; } }
        public int GL_VIEWPORT_SUBPIXEL_BITS          { get { return 0x825C; } }
        public int GL_VIEWPORT_BOUNDS_RANGE           { get { return 0x825D; } }
        public int GL_LAYER_PROVOKING_VERTEX          { get { return 0x825E; } }
        public int GL_VIEWPORT_INDEX_PROVOKING_VERTEX  { get { return 0x825F; } }
        public int GL_UNDEFINED_VERTEX { get { return 0x8260; } }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReleaseShaderCompilerDelegate();
        internal ReleaseShaderCompilerDelegate glReleaseShaderCompiler;

        public void ReleaseShaderCompiler()
        {
            this.glReleaseShaderCompiler();
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ShaderBinaryDelegate(Int32 count, UInt32* shaders, int binaryformat, IntPtr binary, Int32 length);
        internal unsafe ShaderBinaryDelegate glShaderBinary;

        public void ShaderBinary(Int32 count, Int32[] shaders, int binaryformat, IntPtr binary, Int32 length)
        {
            unsafe
            {
                fixed (Int32* shaders_ptr = shaders)
                {
                    glShaderBinary((Int32)count, (UInt32*)shaders_ptr, binaryformat, (IntPtr)binary, (Int32)length);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetShaderPrecisionFormatDelegate(int shadertype, int precisionType, [OutAttribute] Int32* range, [OutAttribute] Int32* precision);
        internal unsafe GetShaderPrecisionFormatDelegate glGetShaderPrecisionFormat;

        public void GetShaderPrecisionFormat(int shadertype, int precisionType, [OutAttribute] Int32[] range, [OutAttribute] Int32[] precision)
        {
            unsafe
            {
                fixed (Int32* range_ptr = range)
                fixed (Int32* precision_ptr = precision)
                {
                    glGetShaderPrecisionFormat(shadertype, precisionType, (Int32*)range_ptr, (Int32*)precision_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DepthRangefDelegate(Single n, Single f);
        internal DepthRangefDelegate glDepthRangef;

        public void DepthRange(float n, float f)
        {
            this.glDepthRangef(n, f);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearDepthfDelegate(Single d);
        internal ClearDepthfDelegate glClearDepthf;

        public void ClearDepth(float d)
        {
            this.glClearDepthf(d);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramBinaryDelegate(UInt32 program, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] int* binaryFormat, [OutAttribute] IntPtr binary);
        internal unsafe GetProgramBinaryDelegate glGetProgramBinary;

        public void GetProgramBinary(Int32 program, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] out int binaryFormat, [OutAttribute] IntPtr binary)
        {
            unsafe
            {
                fixed (Int32* length_ptr = &length)
                fixed (int* binaryFormat_ptr = &binaryFormat)
                {
                    glGetProgramBinary((UInt32)program, (Int32)bufSize, (Int32*)length_ptr, (int*)binaryFormat_ptr, (IntPtr)binary);
                    CheckForErrors();
                    length = *length_ptr;
                    binaryFormat = *binaryFormat_ptr;
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramBinaryDelegate(UInt32 program, int binaryFormat, IntPtr binary, Int32 length);
        internal ProgramBinaryDelegate glProgramBinary;

        void ProgramBinary(Int32 program, int binaryFormat, IntPtr binary, Int32 length)
        {
            glProgramBinary((UInt32)program, binaryFormat, (IntPtr)binary, (Int32)length);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramParameteriDelegate(UInt32 program, int programPName, Int32 value);
        internal ProgramParameteriDelegate glProgramParameteri;

        public void ProgramParameter(int program, int programPName, int value)
        {
            this.glProgramParameteri((uint)program, programPName, value);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void UseProgramStagesDelegate(UInt32 pipeline, int stages, UInt32 program);
        internal UseProgramStagesDelegate glUseProgramStages;

        public void UseProgramStages(int pipeline, int programStageMask, int program)
        {
            this.glUseProgramStages((uint)pipeline, programStageMask, (uint)program);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ActiveShaderProgramDelegate(UInt32 pipeline, UInt32 program);
        internal ActiveShaderProgramDelegate glActiveShaderProgram;

        public void ActiveShaderProgram(int pipeline, int program)
        {
            this.glActiveShaderProgram((uint)pipeline, (uint)program);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 CreateShaderProgramvDelegate(int shaderType, Int32 count, String[] strings);
        internal CreateShaderProgramvDelegate glCreateShaderProgramv;

        public int CreateShaderProgram(int shaderType, int count, string[] strings)
        {
            int r = this.glCreateShaderProgramv(shaderType, count, strings);
            CheckForErrors();
            return r;
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindProgramPipelineDelegate(UInt32 pipeline);
        internal BindProgramPipelineDelegate glBindProgramPipeline;

        public void BindProgramPipeline(int pipeline)
        {
            glBindProgramPipeline((uint)pipeline);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteProgramPipelinesDelegate(Int32 n, int* pipelines);
        internal unsafe DeleteProgramPipelinesDelegate glDeleteProgramPipelines;

        public void DeleteProgramPipelines(int n, int[] pipelines)
        {
            unsafe
            {
                fixed (int* pipelinesPtr = pipelines)
                {
                    this.glDeleteProgramPipelines(n, pipelinesPtr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenProgramPipelinesDelegate(Int32 n, [OutAttribute] int* pipelines);
        internal unsafe GenProgramPipelinesDelegate glGenProgramPipelines;

        public void GenProgramPipelines(int n, [OutAttribute] int[] pipelines)
        {
            unsafe
            {
                fixed (int* pipelinesPtr = pipelines)
                {
                    this.glGenProgramPipelines(n, pipelinesPtr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate bool IsProgramPipelineDelegate(int pipeline);
        internal IsProgramPipelineDelegate glIsProgramPipeline;

        public bool IsProgramPipeline(int pipeline)
        {
            bool r = glIsProgramPipeline(pipeline);
            CheckForErrors();
            return r;
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramPipelineivDelegate(int pipeline, int pname, [OutAttribute] Int32* @params);
        internal unsafe GetProgramPipelineivDelegate glGetProgramPipelineiv;

        public void GetProgramPipeline(Int32 pipeline, int pname, [OutAttribute] Int32[] @params)
        {

            unsafe
            {
                fixed (Int32* @params_ptr = @params)
                {
                    glGetProgramPipelineiv(pipeline, pname, (Int32*)@params_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramUniform1iDelegate(int program, Int32 location, Int32 v0);
        internal ProgramUniform1iDelegate glProgramUniform1i;

        public void ProgramUniform(int program, int location, int v0)
        {
            glProgramUniform1i(program, location, v0);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniform1ivDelegate(int program, Int32 location, Int32 count, Int32* value);
        internal unsafe ProgramUniform1ivDelegate glProgramUniform1iv;

        public void ProgramUniform1(int program, Int32 location, Int32 count, Int32[] value)
        {
            unsafe
            {
                fixed (Int32* value_ptr = value)
                {
                    glProgramUniform1iv(program, (Int32)location, (Int32)count, (Int32*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramUniform2iDelegate(int program, Int32 location, Int32 v0, int v1);
        internal ProgramUniform2iDelegate glProgramUniform2i;

        public void ProgramUniform(int program, int location, int v0, int v1)
        {
            glProgramUniform2i(program, location, v0, v1);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniform2ivDelegate(int program, Int32 location, Int32 count, Int32* value);
        internal unsafe ProgramUniform2ivDelegate glProgramUniform2iv;

        public void ProgramUniform2(int program, Int32 location, Int32 count, Int32[] value)
        {
            unsafe
            {
                fixed (Int32* value_ptr = value)
                {
                    glProgramUniform2iv(program, (Int32)location, (Int32)count, (Int32*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramUniform3iDelegate(int program, Int32 location, Int32 v0, int v1, int v2);
        internal ProgramUniform3iDelegate glProgramUniform3i;

        public void ProgramUniform(int program, int location, int v0, int v1, int v2)
        {
            glProgramUniform3i(program, location, v0, v1, v2);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniform3ivDelegate(int program, Int32 location, Int32 count, Int32* value);
        internal unsafe ProgramUniform3ivDelegate glProgramUniform3iv;

        public void ProgramUniform3(int program, Int32 location, Int32 count, Int32[] value)
        {
            unsafe
            {
                fixed (Int32* value_ptr = value)
                {
                    glProgramUniform3iv(program, (Int32)location, (Int32)count, (Int32*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramUniform4iDelegate(int program, Int32 location, Int32 v0, int v1, int v2, int v3);
        internal ProgramUniform4iDelegate glProgramUniform4i;

        public void ProgramUniform(int program, int location, int v0, int v1, int v2, int v3)
        {
            glProgramUniform4i(program, location, v0, v1, v2, v3);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniform4ivDelegate(int program, Int32 location, Int32 count, Int32* value);
        internal unsafe ProgramUniform4ivDelegate glProgramUniform4iv;

        public void ProgramUniform4(int program, Int32 location, Int32 count, Int32[] value)
        {
            unsafe
            {
                fixed (Int32* value_ptr = value)
                {
                    glProgramUniform4iv(program, (Int32)location, (Int32)count, (Int32*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramUniform1fDelegate(int program, Int32 location, float v0);
        internal ProgramUniform1fDelegate glProgramUniform1f;

        public void ProgramUniform(int program, int location, float v0)
        {
            glProgramUniform1f(program, location, v0);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniform1fvDelegate(int program, Int32 location, Int32 count, float* value);
        internal unsafe ProgramUniform1fvDelegate glProgramUniform1fv;

        public void ProgramUniform1(int program, Int32 location, Int32 count, float[] value)
        {
            unsafe
            {
                fixed (float* value_ptr = value)
                {
                    glProgramUniform1fv(program, (Int32)location, (Int32)count, (float*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramUniform2fDelegate(int program, Int32 location, float v0, float v1);
        internal ProgramUniform2fDelegate glProgramUniform2f;

        public void ProgramUniform(int program, int location, float v0, float v1)
        {
            glProgramUniform2f(program, location, v0, v1);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniform2fvDelegate(int program, Int32 location, Int32 count, float* value);
        internal unsafe ProgramUniform2fvDelegate glProgramUniform2fv;

        public void ProgramUniform2(int program, Int32 location, Int32 count, float[] value)
        {
            unsafe
            {
                fixed (float* value_ptr = value)
                {
                    glProgramUniform2fv(program, (Int32)location, (Int32)count, (float*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramUniform3fDelegate(int program, Int32 location, float v0, float v1, float v2);
        internal ProgramUniform3fDelegate glProgramUniform3f;

        public void ProgramUniform(int program, int location, float v0, float v1, float v2)
        {
            glProgramUniform3f(program, location, v0, v1, v2);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniform3fvDelegate(int program, Int32 location, Int32 count, float* value);
        internal unsafe ProgramUniform3fvDelegate glProgramUniform3fv;

        public void ProgramUniform3(int program, Int32 location, Int32 count, float[] value)
        {
            unsafe
            {
                fixed (float* value_ptr = value)
                {
                    glProgramUniform3fv(program, (Int32)location, (Int32)count, (float*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramUniform4fDelegate(int program, Int32 location, float v0, float v1, float v2, float v3);
        internal ProgramUniform4fDelegate glProgramUniform4f;

        public void ProgramUniform(int program, int location, float v0, float v1, float v2, float v3)
        {
            glProgramUniform4f(program, location, v0, v1, v2, v3);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniform4fvDelegate(int program, Int32 location, Int32 count, float* value);
        internal unsafe ProgramUniform4fvDelegate glProgramUniform4fv;

        public void ProgramUniform4(int program, Int32 location, Int32 count, float[] value)
        {
            unsafe
            {
                fixed (float* value_ptr = value)
                {
                    glProgramUniform4fv(program, (Int32)location, (Int32)count, (float*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramUniform1uiDelegate(int program, Int32 location, uint v0);
        internal ProgramUniform1uiDelegate glProgramUniform1ui;

        [CLSCompliant(false)]
        public void ProgramUniform(int program, int location, uint v0)
        {
            glProgramUniform1ui(program, location, v0);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniform1uivDelegate(int program, Int32 location, Int32 count, uint* value);
        internal unsafe ProgramUniform1uivDelegate glProgramUniform1uiv;

        [CLSCompliant(false)]
        public void ProgramUniform1(int program, Int32 location, Int32 count, uint[] value)
        {
            unsafe
            {
                fixed (uint* value_ptr = value)
                {
                    glProgramUniform1uiv(program, (Int32)location, (Int32)count, (uint*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramUniform2uiDelegate(int program, Int32 location, uint v0, uint v1);
        internal ProgramUniform2uiDelegate glProgramUniform2ui;

        [CLSCompliant(false)]
        public void ProgramUniform(int program, int location, uint v0, uint v1)
        {
            glProgramUniform2ui(program, location, v0, v1);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniform2uivDelegate(int program, Int32 location, Int32 count, uint* value);
        internal unsafe ProgramUniform2uivDelegate glProgramUniform2uiv;

        [CLSCompliant(false)]
        public void ProgramUniform2(int program, Int32 location, Int32 count, uint[] value)
        {
            unsafe
            {
                fixed (uint* value_ptr = value)
                {
                    glProgramUniform2uiv(program, (Int32)location, (Int32)count, (uint*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramUniform3uiDelegate(int program, Int32 location, uint v0, uint v1, uint v2);
        internal ProgramUniform3uiDelegate glProgramUniform3ui;

        [CLSCompliant(false)]
        public void ProgramUniform(int program, int location, uint v0, uint v1, uint v2)
        {
            glProgramUniform3ui(program, location, v0, v1, v2);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniform3uivDelegate(int program, Int32 location, Int32 count, uint* value);
        internal unsafe ProgramUniform3uivDelegate glProgramUniform3uiv;

        [CLSCompliant(false)]
        public void ProgramUniform3(int program, Int32 location, Int32 count, uint[] value)
        {
            unsafe
            {
                fixed (uint* value_ptr = value)
                {
                    glProgramUniform3uiv(program, (Int32)location, (Int32)count, (uint*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramUniform4uiDelegate(int program, Int32 location, uint v0, uint v1, uint v2, uint v3);
        internal ProgramUniform4uiDelegate glProgramUniform4ui;

        [CLSCompliant(false)]
        public void ProgramUniform(int program, int location, uint v0, uint v1, uint v2, uint v3)
        {
            glProgramUniform4ui(program, location, v0, v1, v2, v3);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniform4uivDelegate(int program, Int32 location, Int32 count, uint* value);
        internal unsafe ProgramUniform4uivDelegate glProgramUniform4uiv;

        [CLSCompliant(false)]
        public void ProgramUniform4(int program, Int32 location, Int32 count, uint[] value)
        {
            unsafe
            {
                fixed (uint* value_ptr = value)
                {
                    glProgramUniform4uiv(program, (Int32)location, (Int32)count, (uint*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramUniform1dDelegate(int program, Int32 location, double v0);
        internal ProgramUniform1dDelegate glProgramUniform1d;

        public void ProgramUniform(int program, int location, double v0)
        {
            glProgramUniform1d(program, location, v0);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniform1dvDelegate(int program, Int32 location, Int32 count, double* value);
        internal unsafe ProgramUniform1dvDelegate glProgramUniform1dv;

        public void ProgramUniform1(int program, Int32 location, Int32 count, double[] value)
        {
            unsafe
            {
                fixed (double* value_ptr = value)
                {
                    glProgramUniform1dv(program, (Int32)location, (Int32)count, (double*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramUniform2dDelegate(int program, Int32 location, double v0, double v1);
        internal ProgramUniform2dDelegate glProgramUniform2d;

        public void ProgramUniform(int program, int location, double v0, double v1)
        {
            glProgramUniform2d(program, location, v0, v1);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniform2dvDelegate(int program, Int32 location, Int32 count, double* value);
        internal unsafe ProgramUniform2dvDelegate glProgramUniform2dv;

        public void ProgramUniform2(int program, Int32 location, Int32 count, double[] value)
        {
            unsafe
            {
                fixed (double* value_ptr = value)
                {
                    glProgramUniform2dv(program, (Int32)location, (Int32)count, (double*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramUniform3dDelegate(int program, Int32 location, double v0, double v1, double v2);
        internal ProgramUniform3dDelegate glProgramUniform3d;

        public void ProgramUniform(int program, int location, double v0, double v1, double v2)
        {
            glProgramUniform3d(program, location, v0, v1, v2);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniform3dvDelegate(int program, Int32 location, Int32 count, double* value);
        internal unsafe ProgramUniform3dvDelegate glProgramUniform3dv;

        public void ProgramUniform3(int program, Int32 location, Int32 count, double[] value)
        {
            unsafe
            {
                fixed (double* value_ptr = value)
                {
                    glProgramUniform3dv(program, (Int32)location, (Int32)count, (double*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramUniform4dDelegate(int program, Int32 location, double v0, double v1, double v2, double v3);
        internal ProgramUniform4dDelegate glProgramUniform4d;

        public void ProgramUniform(int program, int location, double v0, double v1, double v2, double v3)
        {
            glProgramUniform4d(program, location, v0, v1, v2, v3);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniform4dvDelegate(int program, Int32 location, Int32 count, double* value);
        internal unsafe ProgramUniform4dvDelegate glProgramUniform4dv;

        public void ProgramUniform4(int program, Int32 location, Int32 count, double[] value)
        {
            unsafe
            {
                fixed (double* value_ptr = value)
                {
                    glProgramUniform4dv(program, (Int32)location, (Int32)count, (double*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniformMatrix2fvDelegate(int program, Int32 location, Int32 count, bool transpose, Single* value);
        internal unsafe ProgramUniformMatrix2fvDelegate glProgramUniformMatrix2fv;

        public void ProgramUniformMatrix2(Int32 program, Int32 location, Int32 count, bool transpose, Single[] value)
        {
            unsafe
            {
                fixed (Single* value_ptr = value)
                {
                    glProgramUniformMatrix2fv(program, (Int32)location, (Int32)count, (bool)transpose, (Single*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniformMatrix3fvDelegate(int program, Int32 location, Int32 count, bool transpose, Single* value);
        internal unsafe ProgramUniformMatrix3fvDelegate glProgramUniformMatrix3fv;

        public void ProgramUniformMatrix3(Int32 program, Int32 location, Int32 count, bool transpose, Single[] value)
        {
            unsafe
            {
                fixed (Single* value_ptr = value)
                {
                    glProgramUniformMatrix3fv(program, (Int32)location, (Int32)count, (bool)transpose, (Single*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniformMatrix4fvDelegate(int program, Int32 location, Int32 count, bool transpose, Single* value);
        internal unsafe ProgramUniformMatrix4fvDelegate glProgramUniformMatrix4fv;

        public void ProgramUniformMatrix4(Int32 program, Int32 location, Int32 count, bool transpose, Single[] value)
        {
            unsafe
            {
                fixed (Single* value_ptr = value)
                {
                    glProgramUniformMatrix4fv(program, (Int32)location, (Int32)count, (bool)transpose, (Single*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniformMatrix2dvDelegate(int program, Int32 location, Int32 count, bool transpose, double* value);
        internal unsafe ProgramUniformMatrix2dvDelegate glProgramUniformMatrix2dv;

        public void ProgramUniformMatrix2(Int32 program, Int32 location, Int32 count, bool transpose, double[] value)
        {
            unsafe
            {
                fixed (double* value_ptr = value)
                {
                    glProgramUniformMatrix2dv(program, (Int32)location, (Int32)count, (bool)transpose, (double*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniformMatrix3dvDelegate(int program, Int32 location, Int32 count, bool transpose, double* value);
        internal unsafe ProgramUniformMatrix3dvDelegate glProgramUniformMatrix3dv;

        public void ProgramUniformMatrix3(Int32 program, Int32 location, Int32 count, bool transpose, double[] value)
        {
            unsafe
            {
                fixed (double* value_ptr = value)
                {
                    glProgramUniformMatrix3dv(program, (Int32)location, (Int32)count, (bool)transpose, (double*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniformMatrix4dvDelegate(int program, Int32 location, Int32 count, bool transpose, double* value);
        internal unsafe ProgramUniformMatrix4dvDelegate glProgramUniformMatrix4dv;

        public void ProgramUniformMatrix4(Int32 program, Int32 location, Int32 count, bool transpose, double[] value)
        {
            unsafe
            {
                fixed (double* value_ptr = value)
                {
                    glProgramUniformMatrix4dv(program, (Int32)location, (Int32)count, (bool)transpose, (double*)value_ptr);
                    CheckForErrors();
                }
            }
        }






        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniformMatrix2x3fvDelegate(int program, Int32 location, Int32 count, bool transpose, Single* value);
        internal unsafe ProgramUniformMatrix2x3fvDelegate glProgramUniformMatrix2x3fv;

        public void ProgramUniformMatrix2x3(Int32 program, Int32 location, Int32 count, bool transpose, Single[] value)
        {
            unsafe
            {
                fixed (Single* value_ptr = value)
                {
                    glProgramUniformMatrix2x3fv(program, (Int32)location, (Int32)count, (bool)transpose, (Single*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniformMatrix3x2fvDelegate(int program, Int32 location, Int32 count, bool transpose, Single* value);
        internal unsafe ProgramUniformMatrix3x2fvDelegate glProgramUniformMatrix3x2fv;

        public void ProgramUniformMatrix3x2(Int32 program, Int32 location, Int32 count, bool transpose, Single[] value)
        {
            unsafe
            {
                fixed (Single* value_ptr = value)
                {
                    glProgramUniformMatrix3x2fv(program, (Int32)location, (Int32)count, (bool)transpose, (Single*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniformMatrix4x2fvDelegate(int program, Int32 location, Int32 count, bool transpose, Single* value);
        internal unsafe ProgramUniformMatrix4x2fvDelegate glProgramUniformMatrix4x2fv;

        public void ProgramUniformMatrix4x2(Int32 program, Int32 location, Int32 count, bool transpose, Single[] value)
        {
            unsafe
            {
                fixed (Single* value_ptr = value)
                {
                    glProgramUniformMatrix4x2fv(program, (Int32)location, (Int32)count, (bool)transpose, (Single*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniformMatrix2x4fvDelegate(int program, Int32 location, Int32 count, bool transpose, Single* value);
        internal unsafe ProgramUniformMatrix2x4fvDelegate glProgramUniformMatrix2x4fv;

        public void ProgramUniformMatrix2x4(Int32 program, Int32 location, Int32 count, bool transpose, Single[] value)
        {
            unsafe
            {
                fixed (Single* value_ptr = value)
                {
                    glProgramUniformMatrix2x4fv(program, (Int32)location, (Int32)count, (bool)transpose, (Single*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniformMatrix4x3fvDelegate(int program, Int32 location, Int32 count, bool transpose, Single* value);
        internal unsafe ProgramUniformMatrix4x3fvDelegate glProgramUniformMatrix4x3fv;

        public void ProgramUniformMatrix4x3(Int32 program, Int32 location, Int32 count, bool transpose, Single[] value)
        {
            unsafe
            {
                fixed (Single* value_ptr = value)
                {
                    glProgramUniformMatrix4x3fv(program, (Int32)location, (Int32)count, (bool)transpose, (Single*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniformMatrix3x4fvDelegate(int program, Int32 location, Int32 count, bool transpose, Single* value);
        internal unsafe ProgramUniformMatrix3x4fvDelegate glProgramUniformMatrix3x4fv;

        public void ProgramUniformMatrix3x4(Int32 program, Int32 location, Int32 count, bool transpose, Single[] value)
        {
            unsafe
            {
                fixed (Single* value_ptr = value)
                {
                    glProgramUniformMatrix3x4fv(program, (Int32)location, (Int32)count, (bool)transpose, (Single*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniformMatrix2x3dvDelegate(int program, Int32 location, Int32 count, bool transpose, double* value);
        internal unsafe ProgramUniformMatrix2x3dvDelegate glProgramUniformMatrix2x3dv;

        public void ProgramUniformMatrix2x3(Int32 program, Int32 location, Int32 count, bool transpose, double[] value)
        {
            unsafe
            {
                fixed (double* value_ptr = value)
                {
                    glProgramUniformMatrix2x3dv(program, (Int32)location, (Int32)count, (bool)transpose, (double*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniformMatrix3x2dvDelegate(int program, Int32 location, Int32 count, bool transpose, double* value);
        internal unsafe ProgramUniformMatrix3x2dvDelegate glProgramUniformMatrix3x2dv;

        public void ProgramUniformMatrix3x2(Int32 program, Int32 location, Int32 count, bool transpose, double[] value)
        {
            unsafe
            {
                fixed (double* value_ptr = value)
                {
                    glProgramUniformMatrix3x2dv(program, (Int32)location, (Int32)count, (bool)transpose, (double*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniformMatrix4x2dvDelegate(int program, Int32 location, Int32 count, bool transpose, double* value);
        internal unsafe ProgramUniformMatrix4x2dvDelegate glProgramUniformMatrix4x2dv;

        public void ProgramUniformMatrix4x2(Int32 program, Int32 location, Int32 count, bool transpose, double[] value)
        {
            unsafe
            {
                fixed (double* value_ptr = value)
                {
                    glProgramUniformMatrix4x2dv(program, (Int32)location, (Int32)count, (bool)transpose, (double*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniformMatrix2x4dvDelegate(int program, Int32 location, Int32 count, bool transpose, double* value);
        internal unsafe ProgramUniformMatrix2x4dvDelegate glProgramUniformMatrix2x4dv;

        public void ProgramUniformMatrix2x4(Int32 program, Int32 location, Int32 count, bool transpose, double[] value)
        {
            unsafe
            {
                fixed (double* value_ptr = value)
                {
                    glProgramUniformMatrix2x4dv(program, (Int32)location, (Int32)count, (bool)transpose, (double*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniformMatrix4x3dvDelegate(int program, Int32 location, Int32 count, bool transpose, double* value);
        internal unsafe ProgramUniformMatrix4x3dvDelegate glProgramUniformMatrix4x3dv;

        public void ProgramUniformMatrix4x3(Int32 program, Int32 location, Int32 count, bool transpose, double[] value)
        {
            unsafe
            {
                fixed (double* value_ptr = value)
                {
                    glProgramUniformMatrix4x3dv(program, (Int32)location, (Int32)count, (bool)transpose, (double*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramUniformMatrix3x4dvDelegate(int program, Int32 location, Int32 count, bool transpose, double* value);
        internal unsafe ProgramUniformMatrix3x4dvDelegate glProgramUniformMatrix3x4dv;

        public void ProgramUniformMatrix3x4(Int32 program, Int32 location, Int32 count, bool transpose, double[] value)
        {
            unsafe
            {
                fixed (double* value_ptr = value)
                {
                    glProgramUniformMatrix3x4dv(program, (Int32)location, (Int32)count, (bool)transpose, (double*)value_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ValidateProgramPipelineDelegate(int pipeline);
        internal ValidateProgramPipelineDelegate glValidateProgramPipeline;

        public void ValidateProgramPipeline(int pipeline)
        {
            this.glValidateProgramPipeline(pipeline);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramPipelineInfoLogDelegate(int pipeline, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
        internal unsafe GetProgramPipelineInfoLogDelegate glGetProgramPipelineInfoLog;

        public void GetProgramPipelineInfoLog(Int32 pipeline, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] StringBuilder infoLog)
        {
            unsafe
            {
                fixed (Int32* length_ptr = &length)
                {
                    glGetProgramPipelineInfoLog(pipeline, (Int32)bufSize, (Int32*)length_ptr, (StringBuilder)infoLog);
                    length = *length_ptr;
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribL1dDelegate(int index, Double x);
        internal VertexAttribL1dDelegate glVertexAttribL1d;

        public void VertexAttribL(int index, double x)
        {
            glVertexAttribL1d(index, x);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribL2dDelegate(int index, Double x, double y);
        internal VertexAttribL2dDelegate glVertexAttribL2d;

        public void VertexAttribL(int index, double x, double y)
        {
            glVertexAttribL2d(index, x, y);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribL3dDelegate(int index, Double x, double y, double z);
        internal VertexAttribL3dDelegate glVertexAttribL3d;

        public void VertexAttribL(int index, double x, double y, double z)
        {
            glVertexAttribL3d(index, x, y, z);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribL4dDelegate(int index, Double x, double y, double z, double w);
        internal VertexAttribL4dDelegate glVertexAttribL4d;

        public void VertexAttribL(int index, double x, double y, double z, double w)
        {
            glVertexAttribL4d(index, x, y, z, w);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribL1dvDelegate(int index, Double* v);
        internal unsafe VertexAttribL1dvDelegate glVertexAttribL1dv;

        public void VertexAttribL1(int index, double[] v)
        {
            unsafe
            {
                fixed (double* vptr = v)
                {
                    this.glVertexAttribL1dv(index, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribL2dvDelegate(int index, Double* v);
        internal unsafe VertexAttribL2dvDelegate glVertexAttribL2dv;

        public void VertexAttribL2(int index, double[] v)
        {
            unsafe
            {
                fixed (double* vptr = v)
                {
                    this.glVertexAttribL2dv(index, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribL3dvDelegate(int index, Double* v);
        internal unsafe VertexAttribL3dvDelegate glVertexAttribL3dv;

        public void VertexAttribL3(int index, double[] v)
        {
            unsafe
            {
                fixed (double* vptr = v)
                {
                    this.glVertexAttribL3dv(index, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribL4dvDelegate(int index, Double* v);
        internal unsafe VertexAttribL4dvDelegate glVertexAttribL4dv;

        public void VertexAttribL4(int index, double[] v)
        {
            unsafe
            {
                fixed (double* vptr = v)
                {
                    this.glVertexAttribL4dv(index, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribLPointerDelegate(UInt32 index, Int32 size, int type, Int32 stride, IntPtr pointer);
        internal VertexAttribLPointerDelegate glVertexAttribLPointer;

        public void VertexAttribL(Int32 index, Int32 size, int type, Int32 stride, IntPtr pointer)
        {
            this.glVertexAttribLPointer((UInt32)index, (Int32)size, type, (Int32)stride, (IntPtr)pointer);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribLdvDelegate(int index, int pname, [OutAttribute] Double* @params);
        internal unsafe GetVertexAttribLdvDelegate glGetVertexAttribLdv;

        public void GetVertexAttribL(Int32 index, int vertexAttribPName, [OutAttribute] Double[] @params)
        {
            unsafe
            {
                fixed (Double* @params_ptr = @params)
                {
                    this.glGetVertexAttribLdv(index, vertexAttribPName, (Double*)@params_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ViewportArrayvDelegate(int first, Int32 count, Single* v);
        internal unsafe ViewportArrayvDelegate glViewportArrayv;

        public void ViewportArray(int first, int count, float[] v)
        {
            unsafe
            {
                fixed (float* vptr = v)
                {
                    this.glViewportArrayv(first, count, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ViewportIndexedfDelegate(int index, Single x, Single y, Single w, Single h);
        internal ViewportIndexedfDelegate glViewportIndexedf;

        public void ViewportIndexed(int index, float x, float y, float w, float h)
        {
            this.glViewportIndexedf(index, x, y, w, h);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ViewportIndexedfvDelegate(int index, Single* v);
        internal unsafe ViewportIndexedfvDelegate glViewportIndexedfv;

        public void ViewportIndexed(int index, float[] v)
        {
            unsafe
            {
                fixed (float* vptr = v)
                {
                    this.glViewportIndexedfv(index, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ScissorArrayvDelegate(int first, Int32 count, Single* v);
        internal unsafe ScissorArrayvDelegate glScissorArrayv;

        public void ScissorArray(int first, int count, float[] v)
        {
            unsafe
            {
                fixed (float* vptr = v)
                {
                    this.glScissorArrayv(first, count, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ScissorIndexedDelegate(int index, float left, float bottom, Single w, Single h);
        internal ScissorIndexedDelegate glScissorIndexed;

        public void ScissorIndexed(int index, float left, float bottom, float w, float h)
        {
            this.glScissorIndexed(index, left, bottom, w, h);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ScissorIndexedvDelegate(int index, Single* v);
        internal unsafe ScissorIndexedvDelegate glScissorIndexedv;

        public void ScissorIndexed(int index, float[] v)
        {
            unsafe
            {
                fixed (float* vptr = v)
                {
                    this.glScissorIndexedv(index, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DepthRangeArrayvDelegate(int first, Int32 count, Double* v);
        internal unsafe DepthRangeArrayvDelegate glDepthRangeArrayv;

        public void DepthRangeArray(int first, int count, double[] v)
        {
            unsafe
            {
                fixed (double* vptr = v)
                {
                    this.glDepthRangeArrayv(first, count, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DepthRangeIndexedDelegate(int index, Double n, Double f);
        internal DepthRangeIndexedDelegate glDepthRangeIndexed;

        public void DepthRangeIndexed(int index, double n, double f)
        {
            this.glDepthRangeIndexed(index, n, f);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFloati_vDelegate(int target, int index, [OutAttribute] Single* data);
        internal unsafe GetFloati_vDelegate glGetFloati_v;

        public void GetFloat(int target, Int32 index, [OutAttribute] Single[] data)
        {
            unsafe
            {
                fixed (Single* data_ptr = data)
                {
                    this.glGetFloati_v(target, index, (Single*)data_ptr);
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetDoublei_vDelegate(int target, int index, [OutAttribute] double* data);
        internal unsafe GetDoublei_vDelegate glGetDoublei_v;

        public void GetDouble(int target, Int32 index, [OutAttribute] double[] data)
        {
            unsafe
            {
                fixed (double* data_ptr = data)
                {
                    this.glGetDoublei_v(target, index, (double*)data_ptr);
                }
            }
        }
    }
}
