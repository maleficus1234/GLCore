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
    public class GL31
        : GL30
    {

        public GL31(Context context)
            : base(context)
        {

        }

        public int GL_SAMPLER_2D_RECT                 { get { return 0x8B63; } }
        public int GL_SAMPLER_2D_RECT_SHADOW          { get { return 0x8B64; } }
        public int GL_SAMPLER_BUFFER                  { get { return 0x8DC2; } }
        public int GL_INT_SAMPLER_2D_RECT             { get { return 0x8DCD; } }
        public int GL_INT_SAMPLER_BUFFER              { get { return 0x8DD0; } }
        public int GL_UNSIGNED_INT_SAMPLER_2D_RECT    { get { return 0x8DD5; } }
        public int GL_UNSIGNED_INT_SAMPLER_BUFFER     { get { return 0x8DD8; } }
        public int GL_TEXTURE_BUFFER                  { get { return 0x8C2A; } }
        public int GL_MAX_TEXTURE_BUFFER_SIZE         { get { return 0x8C2B; } }
        public int GL_TEXTURE_BINDING_BUFFER          { get { return 0x8C2C; } }
        public int GL_TEXTURE_BUFFER_DATA_STORE_BINDING  { get { return 0x8C2D; } }
        public int GL_TEXTURE_RECTANGLE               { get { return 0x84F5; } }
        public int GL_TEXTURE_BINDING_RECTANGLE       { get { return 0x84F6; } }
        public int GL_PROXY_TEXTURE_RECTANGLE         { get { return 0x84F7; } }
        public int GL_MAX_RECTANGLE_TEXTURE_SIZE      { get { return 0x84F8; } }
        public int GL_R8_SNORM                        { get { return 0x8F94; } }
        public int GL_RG8_SNORM                       { get { return 0x8F95; } }
        public int GL_RGB8_SNORM                      { get { return 0x8F96; } }
        public int GL_RGBA8_SNORM                     { get { return 0x8F97; } }
        public int GL_R16_SNORM                       { get { return 0x8F98; } }
        public int GL_RG16_SNORM                      { get { return 0x8F99; } }
        public int GL_RGB16_SNORM                     { get { return 0x8F9A; } }
        public int GL_RGBA16_SNORM                    { get { return 0x8F9B; } }
        public int GL_SIGNED_NORMALIZED               { get { return 0x8F9C; } }
        public int GL_PRIMITIVE_RESTART               { get { return 0x8F9D; } }
        public int GL_PRIMITIVE_RESTART_INDEX         { get { return 0x8F9E; } }
        public int GL_COPY_READ_BUFFER                { get { return 0x8F36; } }
        public int GL_COPY_WRITE_BUFFER               { get { return 0x8F37; } }
        public int GL_UNIFORM_BUFFER                  { get { return 0x8A11; } }
        public int GL_UNIFORM_BUFFER_BINDING          { get { return 0x8A28; } }
        public int GL_UNIFORM_BUFFER_START            { get { return 0x8A29; } }
        public int GL_UNIFORM_BUFFER_SIZE             { get { return 0x8A2A; } }
        public int GL_MAX_VERTEX_UNIFORM_BLOCKS       { get { return 0x8A2B; } }
        public int GL_MAX_FRAGMENT_UNIFORM_BLOCKS     { get { return 0x8A2D; } }
        public int GL_MAX_COMBINED_UNIFORM_BLOCKS     { get { return 0x8A2E; } }
        public int GL_MAX_UNIFORM_BUFFER_BINDINGS     { get { return 0x8A2F; } }
        public int GL_MAX_UNIFORM_BLOCK_SIZE          { get { return 0x8A30; } }
        public int GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS  { get { return 0x8A31; } }
        public int GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS  { get { return 0x8A33; } }
        public int GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT  { get { return 0x8A34; } }
        public int GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH  { get { return 0x8A35; } }
        public int GL_ACTIVE_UNIFORM_BLOCKS           { get { return 0x8A36; } }
        public int GL_UNIFORM_TYPE                    { get { return 0x8A37; } }
        public int GL_UNIFORM_SIZE                    { get { return 0x8A38; } }
        public int GL_UNIFORM_NAME_LENGTH             { get { return 0x8A39; } }
        public int GL_UNIFORM_BLOCK_INDEX             { get { return 0x8A3A; } }
        public int GL_UNIFORM_OFFSET                  { get { return 0x8A3B; } }
        public int GL_UNIFORM_ARRAY_STRIDE            { get { return 0x8A3C; } }
        public int GL_UNIFORM_MATRIX_STRIDE           { get { return 0x8A3D; } }
        public int GL_UNIFORM_IS_ROW_MAJOR            { get { return 0x8A3E; } }
        public int GL_UNIFORM_BLOCK_BINDING           { get { return 0x8A3F; } }
        public int GL_UNIFORM_BLOCK_DATA_SIZE         { get { return 0x8A40; } }
        public int GL_UNIFORM_BLOCK_NAME_LENGTH       { get { return 0x8A41; } }
        public int GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS   { get { return 0x8A42; } }
        public int GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES  { get { return 0x8A43; } }
        public int GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER  { get { return 0x8A44; } }
        public int GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER { get { return 0x8A46; } }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawArraysInstancedDelegate(int drawMode, int first, int count, int primcount);
        internal DrawArraysInstancedDelegate glDrawArraysInstanced;

        public void DrawArraysInstanced(int drawMode, int first, int count, int primcount)
        {
            glDrawArraysInstanced(drawMode, first, count, primcount);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawElementsInstancedDelegate(int drawMode, int count, int type, IntPtr indices, int primcount);
        internal DrawElementsInstancedDelegate glDrawElementsInstanced;

        public void DrawElementsInstanced(int drawMode, int count, int drawElementsType, int indices, int primcount)
        {
            glDrawElementsInstanced(drawMode, count, drawElementsType, new IntPtr(indices), primcount);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexBufferd(uint target, uint internalformat, uint buffer);
        internal TexBufferd glTexBuffer;

        public void TexBuffer(int internalFormat, int buffer)
        {
            glTexBuffer((uint)this.GL_TEXTURE_BUFFER, (uint)internalFormat, (uint)buffer);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyBufferSubDataDelegate(int readTarget, int writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
        internal CopyBufferSubDataDelegate glCopyBufferSubData;

        public void CopyBufferSubData(int readTarget, int writeTarget, int readOffset, int writeOffset, int size)
        {
            glCopyBufferSubData(readTarget, writeTarget, new IntPtr(readOffset), new IntPtr(writeOffset), new IntPtr(size));
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GetUniformBlockIndexDelegate(UInt32 program, String uniformBlockName);
        internal GetUniformBlockIndexDelegate glGetUniformBlockIndex;

        public void GetUniformBlockIndex(int program, string uniformBlockName)
        {
            glGetUniformBlockIndex((uint)program, uniformBlockName);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetActiveUniformBlockNameDelegate(UInt32 program, UInt32 uniformBlockIndex, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder uniformBlockName);
        internal unsafe GetActiveUniformBlockNameDelegate glGetActiveUniformBlockName;

        public string GetActiveUniformBlockName(int program, int uniformIndex)
        {
            unsafe
            {
                int length;
                GetProgram(program, this.GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH, out length);
                StringBuilder sb = new StringBuilder(length == 0 ? 1 : length * 2);

                int length2 = 0;
                glGetActiveUniformBlockName((uint)program, (uint)uniformIndex, sb.Capacity, &length2, sb);
                CheckForErrors();
                return sb.ToString();
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetActiveUniformBlockivDelegate(UInt32 program, UInt32 uniformBlockIndex, int pname, [OutAttribute] Int32* @params);
        internal unsafe GetActiveUniformBlockivDelegate glGetActiveUniformBlockiv;

        public void GetActiveUniformBlock(Int32 program, Int32 uniformBlockIndex, int uniformBlockPName, [OutAttribute] Int32[] @params)
        {
            unsafe
            {
                fixed (Int32* @params_ptr = @params)
                {
                    glGetActiveUniformBlockiv((UInt32)program, (UInt32)uniformBlockIndex, uniformBlockPName, (Int32*)@params_ptr);
                    CheckForErrors();
                }
            }
        }

        public void GetActiveUniformBlock(Int32 program, Int32 uniformBlockIndex, int uniformBlockPName, [OutAttribute] out Int32 @params)
        {
            unsafe
            {
                fixed (Int32* @params_ptr = &@params)
                {
                    glGetActiveUniformBlockiv((UInt32)program, (UInt32)uniformBlockIndex, uniformBlockPName, (Int32*)@params_ptr);
                    CheckForErrors();
                    @params = *@params_ptr;
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetUniformIndicesDelegate(UInt32 program, Int32 uniformCount, String[] uniformNames, [OutAttribute] UInt32* uniformIndices);
        internal unsafe GetUniformIndicesDelegate glGetUniformIndices;

        public void GetUniformIndices(Int32 program, Int32 uniformCount, String[] uniformNames, [OutAttribute] Int32[] uniformIndices)
        {
            unsafe
            {
                fixed (Int32* uniformIndices_ptr = uniformIndices)
                {
                    glGetUniformIndices((UInt32)program, (Int32)uniformCount, (String[])uniformNames, (UInt32*)uniformIndices_ptr);
                    CheckForErrors();
                }
            }
        }

        public void GetUniformIndices(Int32 program, Int32 uniformCount, String[] uniformNames, [OutAttribute] out Int32 uniformIndices)
        {
            unsafe
            {
                fixed (Int32* uniformIndices_ptr = &uniformIndices)
                {
                    glGetUniformIndices((UInt32)program, (Int32)uniformCount, (String[])uniformNames, (UInt32*)uniformIndices_ptr);
                    CheckForErrors();
                    uniformIndices = *uniformIndices_ptr;
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetActiveUniformsivDelegate(UInt32 program, Int32 uniformCount, UInt32* uniformIndices, uint pname, [OutAttribute] Int32* @params);
        internal unsafe GetActiveUniformsivDelegate glGetActiveUniformsiv;

        public void GetActiveUniforms(Int32 program, Int32 uniformCount, Int32[] uniformIndices, int uniformPName, [OutAttribute] Int32[] @params)
        {
            unsafe
            {
                fixed (Int32* uniformIndices_ptr = uniformIndices)
                fixed (Int32* @params_ptr = @params)
                {
                    glGetActiveUniformsiv((UInt32)program, (Int32)uniformCount, (UInt32*)uniformIndices_ptr, (uint)uniformPName, (Int32*)@params_ptr);
                    CheckForErrors();               
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void UniformBlockBindingDelegate(UInt32 program, UInt32 uniformBlockIndex, UInt32 uniformBlockBinding);
        internal UniformBlockBindingDelegate glUniformBlockBinding;

        public void UniformBlockBinding(int program, int uniformblockIndex, int uniformBlockBinding)
        {
            glUniformBlockBinding((uint)program, (uint)uniformblockIndex, (uint)uniformBlockBinding);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PrimitiveRestartIndexDelegate(UInt32 index);
        internal PrimitiveRestartIndexDelegate glPrimitiveRestartIndex;

        public void PrimitiveRestartIndex(int index)
        {
            glPrimitiveRestartIndex((uint)index);
            CheckForErrors();
        }
    }
}
