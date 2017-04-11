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
    public class GL40
        : GL33
    {


        public GL40(Context context)
            : base(context)
        {

        }

        public int GL_SAMPLE_SHADING                  { get { return 0x8C36; } }
        public int GL_MIN_SAMPLE_SHADING_VALUE        { get { return 0x8C37; } }
        public int GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET  { get { return 0x8E5E; } }
        public int GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET  { get { return 0x8E5F; } }
        public int GL_TEXTURE_CUBE_MAP_ARRAY          { get { return 0x9009; } }
        public int GL_TEXTURE_BINDING_CUBE_MAP_ARRAY  { get { return 0x900A; } }
        public int GL_PROXY_TEXTURE_CUBE_MAP_ARRAY    { get { return 0x900B; } }
        public int GL_SAMPLER_CUBE_MAP_ARRAY          { get { return 0x900C; } }
        public int GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW   { get { return 0x900D; } }
        public int GL_INT_SAMPLER_CUBE_MAP_ARRAY      { get { return 0x900E; } }
        public int GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY  { get { return 0x900F; } }
        public int GL_DRAW_INDIRECT_BUFFER            { get { return 0x8F3F; } }
        public int GL_DRAW_INDIRECT_BUFFER_BINDING    { get { return 0x8F43; } }
        public int GL_GEOMETRY_SHADER_INVOCATIONS     { get { return 0x887F; } }
        public int GL_MAX_GEOMETRY_SHADER_INVOCATIONS  { get { return 0x8E5A; } }
        public int GL_MIN_FRAGMENT_INTERPOLATION_OFFSET  { get { return 0x8E5B; } }
        public int GL_MAX_FRAGMENT_INTERPOLATION_OFFSET  { get { return 0x8E5C; } }
        public int GL_FRAGMENT_INTERPOLATION_OFFSET_BITS  { get { return 0x8E5D; } }
        public int GL_MAX_VERTEX_STREAMS              { get { return 0x8E71; } }
        public int GL_DOUBLE_VEC2                     { get { return 0x8FFC; } }
        public int GL_DOUBLE_VEC3                     { get { return 0x8FFD; } }
        public int GL_DOUBLE_VEC4                     { get { return 0x8FFE; } }
        public int GL_DOUBLE_MAT2                     { get { return 0x8F46; } }
        public int GL_DOUBLE_MAT3                     { get { return 0x8F47; } }
        public int GL_DOUBLE_MAT4                     { get { return 0x8F48; } }
        public int GL_DOUBLE_MAT2x3                   { get { return 0x8F49; } }
        public int GL_DOUBLE_MAT2x4                   { get { return 0x8F4A; } }
        public int GL_DOUBLE_MAT3x2                   { get { return 0x8F4B; } }
        public int GL_DOUBLE_MAT3x4                   { get { return 0x8F4C; } }
        public int GL_DOUBLE_MAT4x2                   { get { return 0x8F4D; } }
        public int GL_DOUBLE_MAT4x3                   { get { return 0x8F4E; } }
        public int GL_ACTIVE_SUBROUTINES              { get { return 0x8DE5; } }
        public int GL_ACTIVE_SUBROUTINE_UNIFORMS      { get { return 0x8DE6; } }
        public int GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS  { get { return 0x8E47; } }
        public int GL_ACTIVE_SUBROUTINE_MAX_LENGTH    { get { return 0x8E48; } }
        public int GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH  { get { return 0x8E49; } }
        public int GL_MAX_SUBROUTINES                 { get { return 0x8DE7; } }
        public int GL_MAX_SUBROUTINE_UNIFORM_LOCATIONS  { get { return 0x8DE8; } }
        public int GL_NUM_COMPATIBLE_SUBROUTINES      { get { return 0x8E4A; } }
        public int GL_COMPATIBLE_SUBROUTINES          { get { return 0x8E4B; } }
        public int GL_PATCHES                         { get { return 0x000E; } }
        public int GL_PATCH_VERTICES                  { get { return 0x8E72; } }
        public int GL_PATCH_DEFAULT_INNER_LEVEL       { get { return 0x8E73; } }
        public int GL_PATCH_DEFAULT_OUTER_LEVEL       { get { return 0x8E74; } }
        public int GL_TESS_CONTROL_OUTPUT_VERTICES    { get { return 0x8E75; } }
        public int GL_TESS_GEN_MODE                   { get { return 0x8E76; } }
        public int GL_TESS_GEN_SPACING                { get { return 0x8E77; } }
        public int GL_TESS_GEN_VERTEX_ORDER           { get { return 0x8E78; } }
        public int GL_TESS_GEN_POINT_MODE             { get { return 0x8E79; } }
        public int GL_ISOLINES                        { get { return 0x8E7A; } }
        public int GL_FRACTIONAL_ODD                  { get { return 0x8E7B; } }
        public int GL_FRACTIONAL_EVEN                 { get { return 0x8E7C; } }
        public int GL_MAX_PATCH_VERTICES              { get { return 0x8E7D; } }
        public int GL_MAX_TESS_GEN_LEVEL              { get { return 0x8E7E; } }
        public int GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS  { get { return 0x8E7F; } }
        public int GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS  { get { return 0x8E80; } }
        public int GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS  { get { return 0x8E81; } }
        public int GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS  { get { return 0x8E82; } }
        public int GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS  { get { return 0x8E83; } }
        public int GL_MAX_TESS_PATCH_COMPONENTS       { get { return 0x8E84; } }
        public int GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS  { get { return 0x8E85; } }
        public int GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS  { get { return 0x8E86; } }
        public int GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS  { get { return 0x8E89; } }
        public int GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS  { get { return 0x8E8A; } }
        public int GL_MAX_TESS_CONTROL_INPUT_COMPONENTS  { get { return 0x886C; } }
        public int GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS  { get { return 0x886D; } }
        public int GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS  { get { return 0x8E1E; } }
        public int GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS  { get { return 0x8E1F; } }
        public int GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER  { get { return 0x84F0; } }
        public int GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER  { get { return 0x84F1; } }
        public int GL_TESS_EVALUATION_SHADER          { get { return 0x8E87; } }
        public int GL_TESS_CONTROL_SHADER             { get { return 0x8E88; } }
        public int GL_TRANSFORM_FEEDBACK              { get { return 0x8E22; } }
        public int GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED  { get { return 0x8E23; } }
        public int GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE  { get { return 0x8E24; } }
        public int GL_TRANSFORM_FEEDBACK_BINDING { get { return 0x8E25; } }
        public int GL_MAX_TRANSFORM_FEEDBACK_BUFFERS  { get { return 0x8E70; } }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawTransformFeedbackStreamDelegate(int beginMode, UInt32 id, UInt32 stream);
        internal DrawTransformFeedbackStreamDelegate glDrawTransformFeedbackStream;

        public void DrawTransformFeedbackStream(int beginMode, int id, int stream)
        {
            glDrawTransformFeedbackStream(beginMode, (uint)id, (uint)stream);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BeginQueryIndexedDelegate(int target, UInt32 index, UInt32 id);
        internal BeginQueryIndexedDelegate glBeginQueryIndexed;

        public void BeginQueryIndexed(int target, int index, int id)
        {
            glBeginQueryIndexed(target, (uint)index, (uint)id);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EndQueryIndexedDelegate(int target, UInt32 index);
        internal EndQueryIndexedDelegate glEndQueryIndexed;

        public void EndQueryIndexed(int target, int index)
        {
            glEndQueryIndexed(target, (uint)index);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetQueryIndexedivDelegate(int target, UInt32 index, int pname, [OutAttribute] Int32* @params);
        internal unsafe GetQueryIndexedivDelegate glGetQueryIndexediv;

        public void GetQueryIndexed(int target, Int32 index, int pname, [OutAttribute] Int32[] @params)
        {
            unsafe
            {
                fixed (Int32* @params_ptr = @params)
                {
                    glGetQueryIndexediv(target, (UInt32)index, pname, (Int32*)@params_ptr);
                    CheckForErrors();
                }
            }
        }

        public void GetQueryIndexed(int target, Int32 index, int pname, [OutAttribute] out Int32 @params)
        {
            unsafe
            {
                fixed (Int32* @params_ptr = &@params)
                {
                    glGetQueryIndexediv(target, (UInt32)index, pname, (Int32*)@params_ptr);
                    @params = *@params_ptr;
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PatchParameteriDelegate(int patchPName, Int32 value);
        internal PatchParameteriDelegate glPatchParameteri;

        public void PatchParameter(int patchPName, int value)
        {
            glPatchParameteri(patchPName, value);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PatchParameterfv(int pname, Single* values);
        internal unsafe PatchParameterfv glPatchParameterfv;

        public void PatchParameter(int patchPName, Single[] values)
        {
            unsafe
            {
                fixed (Single* values_ptr = values)
                {
                    glPatchParameterfv(patchPName, (Single*)values_ptr);
                    CheckForErrors();
                }
            }
        }

        public void PatchParameter(int patchPName, ref Single values)
        {
            unsafe
            {
                fixed (Single* values_ptr = &values)
                {
                    glPatchParameterfv(patchPName, (Single*)values_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawArraysIndirectDelegate(int drawMode, IntPtr indirect);
        internal DrawArraysIndirectDelegate glDrawArraysIndirect;

        public void DrawArraysIndirect(int drawMode, IntPtr indirect)
        {
            glDrawArraysIndirect(drawMode, indirect);
            CheckForErrors();
        }

        public void DrawArraysIndirect<T1>(int drawMode, [InAttribute, OutAttribute] T1[] indirect)
            where T1 : struct
        {
            GCHandle indirect_ptr = GCHandle.Alloc(indirect, GCHandleType.Pinned);
            try
            {
                glDrawArraysIndirect(drawMode, (IntPtr)indirect_ptr.AddrOfPinnedObject());
                CheckForErrors();
            }
            finally
            {
                indirect_ptr.Free();
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawElementsIndirectDelegate(int drawMode, int bufferTarget, IntPtr indirect);
        internal DrawElementsIndirectDelegate glDrawElementsIndirect;

        public void DrawElementsIndirect(int drawMode, int bufferTarget, IntPtr indirect)
        {
            glDrawElementsIndirect(drawMode, bufferTarget, indirect);
            CheckForErrors();
        }

        public void DrawElementsIndirect<T2>(int drawMode, int bufferTarget, [InAttribute, OutAttribute] T2[] indirect)
            where T2 : struct
        {
                GCHandle indirect_ptr = GCHandle.Alloc(indirect, GCHandleType.Pinned);
                try
                {
                    glDrawElementsIndirect(drawMode, bufferTarget, (IntPtr)indirect_ptr.AddrOfPinnedObject());
                    CheckForErrors();
                }
                finally
                {
                    indirect_ptr.Free();
                }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MinSampleShadingDelegate(Single value);
        internal MinSampleShadingDelegate glMinSampleShading;

        void MinSampleShading(float value)
        {
            glMinSampleShading(value);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GetSubroutineUniformLocationDelegate(UInt32 program, int shaderType, String name);
        internal GetSubroutineUniformLocationDelegate glGetSubroutineUniformLocation;

        public int GetSubroutineUniformLocation(int program, int shaderType, string name)
        {
            int r = glGetSubroutineUniformLocation((uint)program, shaderType, name);
            CheckForErrors();
            return r;
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GetSubroutineIndexDelegate(UInt32 program, int shaderType, String name);
        internal GetSubroutineIndexDelegate glGetSubroutineIndex;

        public int GetSubroutineIndex(int program, int shaderType, string name)
        {
            int r = glGetSubroutineIndex((uint)program, shaderType, name);
            CheckForErrors();
            return r;
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetActiveSubroutineUniformivDelegate(UInt32 program, int shaderType, UInt32 index, int activeSubroutineUniformPName, [OutAttribute] Int32* values);
        internal unsafe GetActiveSubroutineUniformivDelegate glGetActiveSubroutineUniformiv;

        public void GetActiveSubroutineUniform(Int32 program, int shaderType, Int32 index, int subroutineUniformPName, [OutAttribute] Int32[] values)
        {
            unsafe
            {
                fixed (Int32* values_ptr = values)
                {
                    glGetActiveSubroutineUniformiv((UInt32)program, shaderType, (UInt32)index, subroutineUniformPName, (Int32*)values_ptr);
                    CheckForErrors();
                }
            }
        }

        public void GetActiveSubroutineUniform(Int32 program, int shaderType, Int32 index, int subroutineUniformPName, [OutAttribute] out Int32 values)
        {
                unsafe
                {
                    fixed (Int32* values_ptr = &values)
                    {
                        glGetActiveSubroutineUniformiv((UInt32)program, shaderType, (UInt32)index, subroutineUniformPName, (Int32*)values_ptr);
                        values = *values_ptr;
                        CheckForErrors();
                    }
                }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetActiveSubroutineUniformNameDelegate(UInt32 program, int shaderType, UInt32 index, Int32 bufsize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder name);
        internal unsafe GetActiveSubroutineUniformNameDelegate glGetActiveSubroutineUniformName;

        public void GetActiveSubroutineUniformName(Int32 program, int shaderType, Int32 index, Int32 bufsize, [OutAttribute] out Int32 length, [OutAttribute] StringBuilder name)
        {
            unsafe
            {
                fixed (Int32* length_ptr = &length)
                {
                    glGetActiveSubroutineUniformName((UInt32)program, shaderType, (UInt32)index, (Int32)bufsize, (Int32*)length_ptr, (StringBuilder)name);
                    length = *length_ptr;
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetActiveSubroutineNameDelegate(UInt32 program, int shaderType, UInt32 index, Int32 bufsize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder name);
        internal unsafe GetActiveSubroutineNameDelegate glGetActiveSubroutineName;

        public void GetActiveSubroutineName(Int32 program, int shaderType, Int32 index, Int32 bufsize, [OutAttribute] out Int32 length, [OutAttribute] StringBuilder name)
        {
            unsafe
            {
                fixed (Int32* length_ptr = &length)
                {
                    glGetActiveSubroutineName((UInt32)program, shaderType, (UInt32)index, (Int32)bufsize, (Int32*)length_ptr, (StringBuilder)name);
                    length = *length_ptr;
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformSubroutinesuivDelegate(int shaderType, Int32 count, UInt32* indices);
        internal unsafe UniformSubroutinesuivDelegate glUniformSubroutinesuiv;

        public void UniformSubroutines(int shaderType, Int32 count, Int32[] indices)
        {
            unsafe
            {
                fixed (Int32* indices_ptr = indices)
                {
                    glUniformSubroutinesuiv(shaderType, (Int32)count, (UInt32*)indices_ptr);
                    CheckForErrors();
                }
            }
        }

        public void UniformSubroutines(int shaderType, Int32 count, ref Int32 indices)
        {
            unsafe
            {
                fixed (Int32* indices_ptr = &indices)
                {
                    glUniformSubroutinesuiv(shaderType, (Int32)count, (UInt32*)indices_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetUniformSubroutineuivDelegate(int shaderType, Int32 location, [OutAttribute] UInt32* @params);
        internal unsafe GetUniformSubroutineuivDelegate glGetUniformSubroutineuiv;

        public void GetUniformSubroutine(int shaderType, int location, [OutAttribute] int [] @params)
        {
            unsafe
            {
                fixed (Int32* @params_ptr = @params)
                {
                    glGetUniformSubroutineuiv(shaderType, (Int32)location, (UInt32*)@params_ptr);
                    CheckForErrors();
                }
            }
        }

        public void GetUniformSubroutine(int shaderType, Int32 location, [OutAttribute] out Int32 @params)
        {
            unsafe
            {
                fixed (Int32* @params_ptr = &@params)
                {
                    glGetUniformSubroutineuiv(shaderType, (Int32)location, (UInt32*)@params_ptr);
                    @params = *@params_ptr;
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramStageivDelegate(UInt32 program, int shaderType, int programStagePName, [OutAttribute] Int32* values);
        internal unsafe GetProgramStageivDelegate glGetProgramStageiv;

        public void GetProgramStage(Int32 program, int shaderType, int programStagePName, [OutAttribute] out Int32 values)
        {
            unsafe
            {
                fixed (Int32* values_ptr = &values)
                {
                    glGetProgramStageiv((UInt32)program, shaderType, programStagePName, (Int32*)values_ptr);
                    values = *values_ptr;
                    CheckForErrors();
                }
            }
        }

        public void GetProgramStage(Int32 program, int shaderType, int programStagePName, [OutAttribute] Int32 [] values)
        {
            unsafe
            {
                fixed (Int32* values_ptr = values)
                {
                    glGetProgramStageiv((UInt32)program, shaderType, programStagePName, (Int32*)values_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindTransformFeedbackDelegate(int target, UInt32 id);
        internal BindTransformFeedbackDelegate glBindTransformFeedback;

        public void BindTransformFeedback(int target, int id)
        {
            glBindTransformFeedback(target, (uint)id);
            CheckForErrors();
        }

        public void BindTransformFeedback(int id)
        {
            BindTransformFeedback(0x8E22, id);
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteTransformFeedbacksDelegate(Int32 n, UInt32* ids);
        internal unsafe DeleteTransformFeedbacksDelegate glDeleteTransformFeedbacks;

        public void DeleteTransformFeedback(Int32 n, Int32[] ids)
        {
                unsafe
                {
                    fixed (Int32* ids_ptr = ids)
                    {
                        glDeleteTransformFeedbacks((Int32)n, (UInt32*)ids_ptr);
                        CheckForErrors();
                    }
                }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenTransformFeedbacksDelegate(Int32 n, [OutAttribute] UInt32* ids);
        internal unsafe GenTransformFeedbacksDelegate glGenTransformFeedbacks;

        public void GenTransformFeedback(Int32 n, [OutAttribute] Int32[] ids)
        {
            unsafe
            {
                fixed (Int32* ids_ptr = ids)
                {
                    glGenTransformFeedbacks((Int32)n, (UInt32*)ids_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate bool IsTransformFeedbackDelegate(UInt32 id);
        internal IsTransformFeedbackDelegate glIsTransformFeedback;

        public bool IsTransformFeedback(int id)
        {
            bool r = glIsTransformFeedback((uint)id);
            CheckForErrors();
            return r;
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PauseTransformFeedbackDelegate();
        internal PauseTransformFeedbackDelegate glPauseTransformFeedback;

        public void PauseTransformFeedback()
        {
            glPauseTransformFeedback();
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ResumeTransformFeedbackDelegate();
        internal ResumeTransformFeedbackDelegate glResumeTransformFeedback;

        public void ResumeTransformFeedback()
        {
            glResumeTransformFeedback();
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawTransformFeedbackDelegate(int drawMode, UInt32 id);
        internal DrawTransformFeedbackDelegate glDrawTransformFeedback;

        public void DrawTransformFeedback(int drawMode, int id)
        {
            glDrawTransformFeedback(drawMode, (uint)id);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetUniformdvdelegate(uint program, int location, [OutAttribute] double* @params);
        internal unsafe GetUniformdvdelegate glGetUniformdv;

        public void GetUniform(int program, int location, [OutAttribute] double[] @params)
        {
            unsafe
            {
                fixed (double* @params_ptr = @params)
                {
                    glGetUniformdv((uint)program, (int)location, @params_ptr);
                    CheckForErrors();
                }
            }
        }





        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix4dvd(int location, int count, bool transpose, double* value);
        internal unsafe UniformMatrix4dvd glUniformMatrix4dv;

        public void UniformMatrix4(int location, bool transpose, double[] matrix)
        {
            unsafe
            {
                fixed (double* ptr = matrix)
                {
                    glUniformMatrix4dv(location, 1, transpose, ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix3dvd(int location, int count, bool transpose, double* value);
        internal unsafe UniformMatrix3dvd glUniformMatrix3dv;

        public void UniformMatrix3(int location, bool transpose, double[] matrix)
        {
            unsafe
            {
                fixed (double* ptr = matrix)
                {
                    glUniformMatrix3dv(location, 1, transpose, ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix2dvd(int location, int count, bool transpose, double* value);
        internal unsafe UniformMatrix2dvd glUniformMatrix2dv;

        public void UniformMatrix2(int location, bool transpose, double[] matrix)
        {
            unsafe
            {
                fixed (double* ptr = matrix)
                {
                    glUniformMatrix2dv(location, 1, transpose, ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix2x3dvd(int location, int count, bool transpose, double* value);
        internal unsafe UniformMatrix2x3dvd glUniformMatrix2x3dv;

        public void UniformMatrix2x3(int location, bool transpose, double[] matrix)
        {
            unsafe
            {
                fixed (double* ptr = matrix)
                {
                    glUniformMatrix2x3dv(location, 1, transpose, ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix3x2dvd(int location, int count, bool transpose, double* value);
        internal unsafe UniformMatrix3x2dvd glUniformMatrix3x2dv;

        public void UniformMatrix3x2(int location, bool transpose, double[] matrix)
        {
            unsafe
            {
                fixed (double* ptr = matrix)
                {
                    glUniformMatrix3x2dv(location, 1, transpose, ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix2x4dvd(int location, int count, bool transpose, double* value);
        internal unsafe UniformMatrix2x4dvd glUniformMatrix2x4dv;

        public void UniformMatrix2x4(int location, bool transpose, double[] matrix)
        {
            unsafe
            {
                fixed (double* ptr = matrix)
                {
                    glUniformMatrix2x4dv(location, 1, transpose, ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix4x2dvd(int location, int count, bool transpose, double* value);
        internal unsafe UniformMatrix4x2dvd glUniformMatrix4x2dv;

        public void UniformMatrix4x2(int location, bool transpose, double[] matrix)
        {
            unsafe
            {
                fixed (double* ptr = matrix)
                {
                    glUniformMatrix4x2dv(location, 1, transpose, ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix3x4dvd(int location, int count, bool transpose, double* value);
        internal unsafe UniformMatrix3x4dvd glUniformMatrix3x4dv;

        public void UniformMatrix3x4(int location, bool transpose, double[] matrix)
        {
            unsafe
            {
                fixed (double* ptr = matrix)
                {
                    glUniformMatrix3x4dv(location, 1, transpose, ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix4x3dvd(int location, int count, bool transpose, double* value);
        internal unsafe UniformMatrix4x3dvd glUniformMatrix4x3dv;

        public void UniformMatrix4x3(int location, bool transpose, double[] matrix)
        {
            unsafe
            {
                fixed (double* ptr = matrix)
                {
                    glUniformMatrix4x3dv(location, 1, transpose, ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform1ddelegate(int location, double v0);
        internal Uniform1ddelegate glUniform1d;

        public void Uniform(int location, double value)
        {
            glUniform1d(location, value);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform2ddelegate(int location, double v0, double v1);
        internal Uniform2ddelegate glUniform2d;

        public void Uniform(int location, double v0, double v1)
        {
            glUniform2d(location, v0, v1);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform3ddelegate(int location, double v0, double v1, double v2);
        internal Uniform3ddelegate glUniform3d;

        public void Uniform(int location, double v0, double v1, double v2)
        {
            glUniform3d(location, v0, v1, v2);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform4ddelegate(int location, double v0, double v1, double v2, double v3);
        internal Uniform4ddelegate glUniform4d;

        public void Uniform(int location, double v0, double v1, double v2, double v3)
        {
            glUniform4d(location, v0, v1, v2, v3);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform1dvdelegate(int location, int count, double* value);
        internal unsafe Uniform1dvdelegate glUniform1dv;

        public void Uniform1(int location, int count, double[] v)
        {
            unsafe
            {
                fixed (double* vptr = v)
                {
                    glUniform1dv(location, count, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform2dvdelegate(int location, int count, double* value);
        internal unsafe Uniform2dvdelegate glUniform2dv;

        public void Uniform2(int location, int count, double[] v)
        {
            unsafe
            {
                fixed (double* vptr = v)
                {
                    glUniform2dv(location, count, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform3dvdelegate(int location, int count, double* value);
        internal unsafe Uniform3dvdelegate glUniform3dv;

        public void Uniform3(int location, int count, double[] v)
        {
            unsafe
            {
                fixed (double* vptr = v)
                {
                    glUniform3dv(location, count, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform4dvdelegate(int location, int count, double* value);
        internal unsafe Uniform4dvdelegate glUniform4dv;

        public void Uniform4(int location, int count, double[] v)
        {
            unsafe
            {
                fixed (double* vptr = v)
                {
                    glUniform4dv(location, count, vptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendFuncSeparateiDelegate(UInt32 buf, int srcRGB, int dstRGB, int srcAlpha, int dstAlpha);
        internal BlendFuncSeparateiDelegate glBlendFuncSeparatei;

        public void BlendFuncSeparate(int buf, int srcRGB, int dstRGB, int srcAlpha, int dstAlpha)
        {
            glBlendFuncSeparatei((UInt32)buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendFunciDelegate(UInt32 buf, int src, int dst);
        internal BlendFunciDelegate glBlendFunci;

        public void BlendFunc(int buf, int src, int dst)
        {
            glBlendFunci((uint)buf, src, dst);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendEquationSeparateiDelegate(UInt32 buf, int modeRGB, int modeAlpha);
        internal BlendEquationSeparateiDelegate glBlendEquationSeparatei;

        public void BlendEquationSeparate(int buf, int modeRGB, int modeAlpha)
        {
            glBlendEquationSeparatei((uint)buf, modeRGB, modeAlpha);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendEquationiDelegate(UInt32 buf, int mode);
        internal BlendEquationiDelegate glBlendEquationi;

        public void BlendEquation(int buf, int mode)
        {
            glBlendEquationi((uint)buf, mode);
            CheckForErrors();
        }
    }
}
