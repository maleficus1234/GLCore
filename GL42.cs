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
    public class GL42
        : GL41
    {

        public GL42(Context context)
            : base(context)
        {

        }

        public int GL_UNPACK_COMPRESSED_BLOCK_WIDTH   { get { return 0x9127; } }
        public int GL_UNPACK_COMPRESSED_BLOCK_HEIGHT  { get { return 0x9128; } }
        public int GL_UNPACK_COMPRESSED_BLOCK_DEPTH   { get { return 0x9129; } }
        public int GL_UNPACK_COMPRESSED_BLOCK_SIZE    { get { return 0x912A; } }
        public int GL_PACK_COMPRESSED_BLOCK_WIDTH     { get { return 0x912B; } }
        public int GL_PACK_COMPRESSED_BLOCK_HEIGHT    { get { return 0x912C; } }
        public int GL_PACK_COMPRESSED_BLOCK_DEPTH     { get { return 0x912D; } }
        public int GL_PACK_COMPRESSED_BLOCK_SIZE      { get { return 0x912E; } }
        public int GL_NUM_SAMPLE_COUNTS               { get { return 0x9380; } }
        public int GL_MIN_MAP_BUFFER_ALIGNMENT        { get { return 0x90BC; } }
        public int GL_ATOMIC_COUNTER_BUFFER           { get { return 0x92C0; } }
        public int GL_ATOMIC_COUNTER_BUFFER_BINDING   { get { return 0x92C1; } }
        public int GL_ATOMIC_COUNTER_BUFFER_START     { get { return 0x92C2; } }
        public int GL_ATOMIC_COUNTER_BUFFER_SIZE      { get { return 0x92C3; } }
        public int GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE  { get { return 0x92C4; } }
        public int GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS  { get { return 0x92C5; } }
        public int GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES  { get { return 0x92C6; } }
        public int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER  { get { return 0x92C7; } }
        public int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER  { get { return 0x92C8; } }
        public int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER  { get { return 0x92C9; } }
        public int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER  { get { return 0x92CA; } }
        public int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER  { get { return 0x92CB; } }
        public int GL_MAX_VERTEX_ATOMIC_COUNTER_BUFFERS  { get { return 0x92CC; } }
        public int GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS  { get { return 0x92CD; } }
        public int GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS  { get { return 0x92CE; } }
        public int GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS  { get { return 0x92CF; } }
        public int GL_MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS  { get { return 0x92D0; } }
        public int GL_MAX_COMBINED_ATOMIC_COUNTER_BUFFERS  { get { return 0x92D1; } }
        public int GL_MAX_VERTEX_ATOMIC_COUNTERS      { get { return 0x92D2; } }
        public int GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS  { get { return 0x92D3; } }
        public int GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS  { get { return 0x92D4; } }
        public int GL_MAX_GEOMETRY_ATOMIC_COUNTERS    { get { return 0x92D5; } }
        public int GL_MAX_FRAGMENT_ATOMIC_COUNTERS    { get { return 0x92D6; } }
        public int GL_MAX_COMBINED_ATOMIC_COUNTERS    { get { return 0x92D7; } }
        public int GL_MAX_ATOMIC_COUNTER_BUFFER_SIZE  { get { return 0x92D8; } }
        public int GL_MAX_ATOMIC_COUNTER_BUFFER_BINDINGS  { get { return 0x92DC; } }
        public int GL_ACTIVE_ATOMIC_COUNTER_BUFFERS   { get { return 0x92D9; } }
        public int GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX  { get { return 0x92DA; } }
        public int GL_UNSIGNED_INT_ATOMIC_COUNTER     { get { return 0x92DB; } }
        public int GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT  { get { return 0x00000001; } }
        public int GL_ELEMENT_ARRAY_BARRIER_BIT       { get { return 0x00000002; } }
        public int GL_UNIFORM_BARRIER_BIT             { get { return 0x00000004; } }
        public int GL_TEXTURE_FETCH_BARRIER_BIT       { get { return 0x00000008; } }
        public int GL_SHADER_IMAGE_ACCESS_BARRIER_BIT  { get { return 0x00000020; } }
        public int GL_COMMAND_BARRIER_BIT             { get { return 0x00000040; } }
        public int GL_PIXEL_BUFFER_BARRIER_BIT        { get { return 0x00000080; } }
        public int GL_TEXTURE_UPDATE_BARRIER_BIT      { get { return 0x00000100; } }
        public int GL_BUFFER_UPDATE_BARRIER_BIT       { get { return 0x00000200; } }
        public int GL_FRAMEBUFFER_BARRIER_BIT         { get { return 0x00000400; } }
        public int GL_TRANSFORM_FEEDBACK_BARRIER_BIT  { get { return 0x00000800; } }
        public int GL_ATOMIC_COUNTER_BARRIER_BIT      { get { return 0x00001000; } }
        public int GL_ALL_BARRIER_BITS                { get { return unchecked((int)0xFFFFFFFF); } }
        public int GL_MAX_IMAGE_UNITS                 { get { return 0x8F38; } }
        public int GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS  { get { return 0x8F39; } }
        public int GL_IMAGE_BINDING_NAME              { get { return 0x8F3A; } }
        public int GL_IMAGE_BINDING_LEVEL             { get { return 0x8F3B; } }
        public int GL_IMAGE_BINDING_LAYERED           { get { return 0x8F3C; } }
        public int GL_IMAGE_BINDING_LAYER             { get { return 0x8F3D; } }
        public int GL_IMAGE_BINDING_ACCESS            { get { return 0x8F3E; } }
        public int GL_IMAGE_1D                        { get { return 0x904C; } }
        public int GL_IMAGE_2D                        { get { return 0x904D; } }
        public int GL_IMAGE_3D                        { get { return 0x904E; } }
        public int GL_IMAGE_2D_RECT                   { get { return 0x904F; } }
        public int GL_IMAGE_CUBE                      { get { return 0x9050; } }
        public int GL_IMAGE_BUFFER                    { get { return 0x9051; } }
        public int GL_IMAGE_1D_ARRAY                  { get { return 0x9052; } }
        public int GL_IMAGE_2D_ARRAY                  { get { return 0x9053; } }
        public int GL_IMAGE_CUBE_MAP_ARRAY            { get { return 0x9054; } }
        public int GL_IMAGE_2D_MULTISAMPLE            { get { return 0x9055; } }
        public int GL_IMAGE_2D_MULTISAMPLE_ARRAY      { get { return 0x9056; } }
        public int GL_INT_IMAGE_1D                    { get { return 0x9057; } }
        public int GL_INT_IMAGE_2D                    { get { return 0x9058; } }
        public int GL_INT_IMAGE_3D                    { get { return 0x9059; } }
        public int GL_INT_IMAGE_2D_RECT               { get { return 0x905A; } }
        public int GL_INT_IMAGE_CUBE                  { get { return 0x905B; } }
        public int GL_INT_IMAGE_BUFFER                { get { return 0x905C; } }
        public int GL_INT_IMAGE_1D_ARRAY              { get { return 0x905D; } }
        public int GL_INT_IMAGE_2D_ARRAY              { get { return 0x905E; } }
        public int GL_INT_IMAGE_CUBE_MAP_ARRAY        { get { return 0x905F; } }
        public int GL_INT_IMAGE_2D_MULTISAMPLE        { get { return 0x9060; } }
        public int GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY  { get { return 0x9061; } }
        public int GL_UNSIGNED_INT_IMAGE_1D           { get { return 0x9062; } }
        public int GL_UNSIGNED_INT_IMAGE_2D           { get { return 0x9063; } }
        public int GL_UNSIGNED_INT_IMAGE_3D           { get { return 0x9064; } }
        public int GL_UNSIGNED_INT_IMAGE_2D_RECT      { get { return 0x9065; } }
        public int GL_UNSIGNED_INT_IMAGE_CUBE         { get { return 0x9066; } }
        public int GL_UNSIGNED_INT_IMAGE_BUFFER       { get { return 0x9067; } }
        public int GL_UNSIGNED_INT_IMAGE_1D_ARRAY     { get { return 0x9068; } }
        public int GL_UNSIGNED_INT_IMAGE_2D_ARRAY     { get { return 0x9069; } }
        public int GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY  { get { return 0x906A; } }
        public int GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE  { get { return 0x906B; } }
        public int GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY  { get { return 0x906C; } }
        public int GL_MAX_IMAGE_SAMPLES               { get { return 0x906D; } }
        public int GL_IMAGE_BINDING_FORMAT            { get { return 0x906E; } }
        public int GL_IMAGE_FORMAT_COMPATIBILITY_TYPE  { get { return 0x90C7; } }
        public int GL_IMAGE_FORMAT_COMPATIBILITY_BY_SIZE  { get { return 0x90C8; } }
        public int GL_IMAGE_FORMAT_COMPATIBILITY_BY_CLASS  { get { return 0x90C9; } }
        public int GL_MAX_VERTEX_IMAGE_UNIFORMS       { get { return 0x90CA; } }
        public int GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS  { get { return 0x90CB; } }
        public int GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS  { get { return 0x90CC; } }
        public int GL_MAX_GEOMETRY_IMAGE_UNIFORMS     { get { return 0x90CD; } }
        public int GL_MAX_FRAGMENT_IMAGE_UNIFORMS     { get { return 0x90CE; } }
        public int GL_MAX_COMBINED_IMAGE_UNIFORMS     { get { return 0x90CF; } }
        public int GL_TEXTURE_IMMUTABLE_FORMAT { get { return 0x912F; } }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawArraysInstancedBaseInstanceDelegate(int drawMode, int first, int count, int instancecount, int baseinstance);
        internal DrawArraysInstancedBaseInstanceDelegate glDrawArraysInstancedBaseInstance;

        public void DrawArraysInstancedBaseInstance(int drawMode, int first, int count, int instancecount, int baseinstance)
        {
            this.glDrawArraysInstancedBaseInstance(drawMode, first, count, instancecount, baseinstance);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawElementsInstancedBaseInstanceDelegate(int drawMode, int count, int type, IntPtr indices, int instancecount, int baseinstance);
        internal DrawElementsInstancedBaseInstanceDelegate glDrawElementsInstancedBaseInstance;

        public void DrawElementsInstancedBaseInstance<T3>(int drawMode, int count, int drawElementsType, [InAttribute, OutAttribute] T3[] indices, int instancecount, int baseinstance)
            where T3 : struct
        {
            GCHandle indices_ptr = GCHandle.Alloc(indices, GCHandleType.Pinned);
            try
            {
                glDrawElementsInstancedBaseInstance(drawMode, (int)count, drawElementsType, (IntPtr)indices_ptr.AddrOfPinnedObject(), instancecount, baseinstance);
                CheckForErrors();
            }
            finally
            {
                indices_ptr.Free();
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawElementsInstancedBaseVertexBaseInstanceDelegate(int drawMode, int count, int type, IntPtr indices, int instancecount, int basevertex, int baseinstance);
        internal DrawElementsInstancedBaseVertexBaseInstanceDelegate glDrawElementsInstancedBaseVertexBaseInstance;

        public void DrawElementsInstancedBaseVertexBaseInstance<T3>(int drawMode, int count, int drawElementsType, [InAttribute, OutAttribute] T3[] indices, int instancecount, int basevertex, int baseinstance)
            where T3 : struct
        {
            GCHandle indices_ptr = GCHandle.Alloc(indices, GCHandleType.Pinned);
            try
            {
                glDrawElementsInstancedBaseVertexBaseInstance(drawMode, (int)count, drawElementsType, (IntPtr)indices_ptr.AddrOfPinnedObject(), instancecount, basevertex, baseinstance);
                CheckForErrors();
            }
            finally
            {
                indices_ptr.Free();
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetInternalformativDelegate(int target, int internalFormat, int pname, int bufSize, int * parameters);
        internal GetInternalformativDelegate glGetInternalformativ;

        public void GetInternalFormat(int textureTarget, int internalFormat, int pname, int bufSize, int[] parameters)
        {
            unsafe
            {
                fixed (int* parametersPtr = parameters)
                {
                    this.glGetInternalformativ(textureTarget, internalFormat, pname, bufSize, parametersPtr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetActiveAtomicCounterBufferivDelegate(int program, int bufferIndex, int pname, int *parameters);
        internal GetActiveAtomicCounterBufferivDelegate glGetActiveAtomicCounterBufferiv;

        public void GetActiveAtomicCounterBuffer(int program, int bufferIndex, int pname, int[] parameters)
        {
            unsafe
            {
                fixed (int* parametersPtr = parameters)
                {
                    this.glGetActiveAtomicCounterBufferiv(program, bufferIndex, pname, parametersPtr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindImageTextureDelegate(int unit, int texture, int level, bool layered, int layer, int access, int format);
        internal BindImageTextureDelegate glBindImageTexture;

        public void BindImageTexture(int unit, int texture, int level, bool layered, int layer, int access, int format)
        {
            glBindImageTexture(unit, texture, level, layered, layer, access, format);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MemoryBarrierDelegate(int barriers);
        internal MemoryBarrierDelegate glMemoryBarrier;

        public void MemoryBarrier(int barriers)
        {
            glMemoryBarrier(barriers);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexStorage1DDelegate(int target, int levels, int internalformat, int width);
        internal TexStorage1DDelegate glTexStorage1D;

        public void TexStorage1D(int target, int levels, int internalformat, int width)
        {
            glTexStorage1D(target, levels, internalformat, width);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexStorage2DDelegate(int target, int levels, int internalformat, int width, int height);
        internal TexStorage2DDelegate glTexStorage2D;

        public void TexStorage2D(int target, int levels, int internalformat, int width, int height)
        {
            glTexStorage2D(target, levels, internalformat, width, height);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexStorage3DDelegate(int target, int levels, int internalformat, int width, int height, int depth);
        internal TexStorage3DDelegate glTexStorage3D;

        public void TexStorage3D(int target, int levels, int internalformat, int width, int height, int depth)
        {
            glTexStorage3D(target, levels, internalformat, width, height, depth);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawTransformFeedbackInstancedDelegate(int mode, int id, int instancecount);
        internal DrawTransformFeedbackInstancedDelegate glDrawTransformFeedbackInstanced;

        public void DrawTransformFeedbackInstanced(int mode, int id, int instancecount)
        {
            glDrawTransformFeedbackInstanced(mode, id, instancecount);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawTransformFeedbackStreamInstancedDelegate(int mode, int id, int stream, int instancecount);
        internal DrawTransformFeedbackStreamInstancedDelegate glDrawTransformFeedbackStreamInstanced;

        public void DrawTransformFeedbackStreamInstanced(int mode, int id, int stream, int instancecount)
        {
            glDrawTransformFeedbackStreamInstanced(mode, id, stream, instancecount);
            CheckForErrors();
        }
    }
}
