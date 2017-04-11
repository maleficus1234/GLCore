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
    public class GL33
        : GL32
    {

        public GL33(Context context)
            : base(context)
        {

        }

        public int  GL_VERTEX_ATTRIB_ARRAY_DIVISOR     { get { return 0x88FE; } }
        public int  GL_SRC1_COLOR                      { get { return 0x88F9; } }
        public int  GL_ONE_MINUS_SRC1_COLOR            { get { return 0x88FA; } }
        public int  GL_ONE_MINUS_SRC1_ALPHA            { get { return 0x88FB; } }
        public int  GL_MAX_DUAL_SOURCE_DRAW_BUFFERS    { get { return 0x88FC; } }
        public int  GL_ANY_SAMPLES_PASSED              { get { return 0x8C2F; } }
        public int  GL_SAMPLER_BINDING                 { get { return 0x8919; } }
        public int  GL_RGB10_A2UI                      { get { return 0x906F; } }
        public int  GL_TEXTURE_SWIZZLE_R               { get { return 0x8E42; } }
        public int  GL_TEXTURE_SWIZZLE_G               { get { return 0x8E43; } }
        public int  GL_TEXTURE_SWIZZLE_B               { get { return 0x8E44; } }
        public int  GL_TEXTURE_SWIZZLE_A               { get { return 0x8E45; } }
        public int  GL_TEXTURE_SWIZZLE_RGBA            { get { return 0x8E46; } }
        public int  GL_TIME_ELAPSED                    { get { return 0x88BF; } }
        public int  GL_TIMESTAMP                       { get { return 0x8E28; } }
        public int GL_INT_2_10_10_10_REV { get { return 0x8D9F; } }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindFragDataLocationIndexedDelegate(UInt32 program, UInt32 colorNumber, UInt32 index, String name);
        internal BindFragDataLocationIndexedDelegate glBindFragDataLocationIndexed;

        public void BindFragDataLocationIndexed(Int32 program, Int32 colorNumber, Int32 index, String name)
        {
            glBindFragDataLocationIndexed((UInt32)program, (UInt32)colorNumber, (UInt32)index, (String)name);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GetFragDataIndexDelegate(UInt32 program, String name);
        internal GetFragDataIndexDelegate glGetFragDataIndex;

        public Int32 GetFragDataIndex(Int32 program, String name)
        {
            int r = glGetFragDataIndex((UInt32)program, (String)name);
            CheckForErrors();
            return r;
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenSamplersDelegate(Int32 count, [OutAttribute] UInt32* samplers);
        internal unsafe GenSamplersDelegate glGenSamplers;

        public void GenSamplers(Int32 count, [OutAttribute] Int32[] samplers)
        {
            unsafe
            {
                fixed (Int32* samplers_ptr = samplers)
                {
                    glGenSamplers((Int32)count, (UInt32*)samplers_ptr);
                    CheckForErrors();
                }
            }
        }

        public void GenSamplers([OutAttribute] out Int32 samplers)
        {
            unsafe
            {
                fixed (Int32* samplers_ptr = &samplers)
                {
                    glGenSamplers(1, (UInt32*)samplers_ptr);
                    samplers = *samplers_ptr;
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteSamplersDelegate(Int32 count, UInt32* samplers);
        internal unsafe DeleteSamplersDelegate glDeleteSamplers;

        public void DeleteSamplers(Int32 count, Int32[] samplers)
        {
            unsafe
            {
                fixed (Int32* samplers_ptr = samplers)
                {
                    glDeleteSamplers((Int32)count, (UInt32*)samplers_ptr);
                    CheckForErrors();
                }
            }
        }

        public void DeleteSamplers(Int32 count, ref Int32 samplers)
        {
            unsafe
            {
                fixed (Int32* samplers_ptr = &samplers)
                {
                    glDeleteSamplers((Int32)count, (UInt32*)samplers_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate bool IsSamplerDelegate(UInt32 sampler);
        internal IsSamplerDelegate glIsSampler;

        public bool IsSampler(int sampler)
        {
            bool r = glIsSampler((uint)sampler);
            CheckForErrors();
            return r;
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindSamplerDelegate(UInt32 unit, UInt32 sampler);
        internal BindSamplerDelegate glBindSampler;

        public void BindSampler(int textureUnit, int sampler)
        {
            glBindSampler((uint)textureUnit, (uint)sampler);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SamplerParameteriDelegate(UInt32 sampler, uint pname, Int32 param);
        internal SamplerParameteriDelegate glSamplerParameteri;

        public void SamplerParameter(int sampler, int samplerPName, int param)
        {
            glSamplerParameteri((uint)sampler, (uint)samplerPName, param);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SamplerParameterfDelegate(UInt32 sampler, uint pname, float param);
        internal SamplerParameterfDelegate glSamplerParameterf;

        public void SamplerParameter(int sampler, int samplerPName, float param)
        {
            glSamplerParameterf((uint)sampler, (uint)samplerPName, param);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SamplerParameterivDelegate(UInt32 sampler, uint pname, Int32* param);
        internal unsafe SamplerParameterivDelegate glSamplerParameteriv;

        public void SamplerParameter(Int32 sampler, int samplerPName, Int32[] param)
        {
            unsafe
            {
                fixed (Int32* param_ptr = param)
                {
                    glSamplerParameteriv((UInt32)sampler, (uint)samplerPName, (Int32*)param_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SamplerParameterfvDelegate(UInt32 sampler, uint pname, float* param);
        internal unsafe SamplerParameterfvDelegate glSamplerParameterfv;

        public void SamplerParameter(Int32 sampler, int samplerPName, float[] param)
        {
            unsafe
            {
                fixed (float* param_ptr = param)
                {
                    glSamplerParameterfv((UInt32)sampler, (uint)samplerPName, (float*)param_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SamplerParameterIivDelegate(UInt32 sampler, uint pname, Int32* param);
        internal unsafe SamplerParameterIivDelegate glSamplerParameterIiv;

        public void SamplerParameterI(Int32 sampler, int samplerPName, Int32[] param)
        {
            unsafe
            {
                fixed (Int32* param_ptr = param)
                {
                    glSamplerParameterIiv((UInt32)sampler, (uint)samplerPName, (Int32*)param_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SamplerParameterIuivDelegate(UInt32 sampler, uint pname, uint* param);
        internal unsafe SamplerParameterIuivDelegate glSamplerParameterIuiv;

        [CLSCompliant(false)]
        public void SamplerParameterI(Int32 sampler, int samplerPName, uint[] param)
        {
            unsafe
            {
                fixed (uint* param_ptr = param)
                {
                    glSamplerParameterIuiv((UInt32)sampler, (uint)samplerPName, (uint*)param_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetSamplerParameterIivDelegate(UInt32 sampler, uint pname, [OutAttribute] Int32* @params);
        internal unsafe GetSamplerParameterIivDelegate glGetSamplerParameterIiv;

        public void GetSamplerParameterI(Int32 sampler, int samplerPName, [OutAttribute] Int32[] @params)
        {
            unsafe
            {
                fixed (Int32* @params_ptr = @params)
                {
                    glGetSamplerParameterIiv((UInt32)sampler, (uint)samplerPName, (Int32*)@params_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetSamplerParameterIuivDelegate(UInt32 sampler, uint pname, [OutAttribute] uint* @params);
        internal unsafe GetSamplerParameterIuivDelegate glGetSamplerParameterIuiv;

        [CLSCompliant(false)]
        public void GetSamplerParameterI(Int32 sampler, int samplerPName, [OutAttribute] uint[] @params)
        {
            unsafe
            {
                fixed (uint* @params_ptr = @params)
                {
                    glGetSamplerParameterIuiv((UInt32)sampler, (uint)samplerPName, (uint*)@params_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetSamplerParameteriv(UInt32 sampler, uint pname, [OutAttribute] Int32* @params);
        internal unsafe GetSamplerParameteriv glGetSamplerParameteriv;

        public void GetSamplerParameter(Int32 sampler, int samplerPName, [OutAttribute] Int32[] @params)
        {
            unsafe
            {
                fixed (Int32* @params_ptr = @params)
                {
                    glGetSamplerParameteriv((UInt32)sampler, (uint)samplerPName, (Int32*)@params_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetSamplerParameterfv(UInt32 sampler, uint pname, [OutAttribute] float* @params);
        internal unsafe GetSamplerParameterfv glGetSamplerParameterfv;

        public void GetSamplerParameter(Int32 sampler, int samplerPName, [OutAttribute] float[] @params)
        {
            unsafe
            {
                fixed (float* @params_ptr = @params)
                {
                    glGetSamplerParameterfv((UInt32)sampler, (uint)samplerPName, (float*)@params_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void QueryCounterDelegate(UInt32 id, int target);
        internal QueryCounterDelegate glQueryCounter;

        public void QueryCounter(int id, int target)
        {
            glQueryCounter((uint)id, target);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetQueryObjecti64vDelegate(UInt32 id, int pname, [OutAttribute] Int64* @params);
        internal unsafe GetQueryObjecti64vDelegate glGetQueryObjecti64v;

        public void GetQueryObject(Int32 id, int pname, [OutAttribute] Int64[] @params)
        {
            unsafe
            {
                fixed (Int64* @params_ptr = @params)
                {
                    glGetQueryObjecti64v((UInt32)id, pname, (Int64*)@params_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetQueryObjectui64vDelegate(UInt32 id, int pname, [OutAttribute] UInt64* @params);
        internal unsafe GetQueryObjectui64vDelegate glGetQueryObjectui64v;

        [CLSCompliant(false)]
        public void GetQueryObject(Int32 id, int pname, [OutAttribute] UInt64[] @params)
        {
            unsafe
            {
                fixed (UInt64* @params_ptr = @params)
                {
                    glGetQueryObjectui64v((UInt32)id, pname, (UInt64*)@params_ptr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribDivisorDelegate(UInt32 index, UInt32 divisor);
        internal VertexAttribDivisorDelegate glVertexAttribDivisor;

        public void VertexAttribDivisor(int index, int divisor)
        {
            glVertexAttribDivisor((uint)index, (uint)divisor);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribP1uiDelegate(UInt32 index, int type, bool normalized, UInt32 value);
        internal VertexAttribP1uiDelegate glVertexAttribP1ui;

        public void VertexAttribP1(Int32 index, int type, bool normalized, Int32 value)
        {
            glVertexAttribP1ui((UInt32)index, type, (bool)normalized, (UInt32)value);
            CheckForErrors();
        }

        [CLSCompliant(false)]
        public void VertexAttribP1(Int32 index, int type, bool normalized, UInt32 value)
        {
            glVertexAttribP1ui((UInt32)index, type, (bool)normalized, value);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribP1uivDelegate(UInt32 index, int type, bool normalized, UInt32* value);
        internal unsafe VertexAttribP1uivDelegate glVertexAttribP1uiv;

        public void VertexAttribP1(int index, int type, bool normalized, int[] values)
        {
            unsafe
            {
                fixed (int* valuesPtr = values)
                {
                    glVertexAttribP1uiv((uint)index, type, normalized, (uint*)valuesPtr);
                    CheckForErrors();
                }
            }
        }

        [CLSCompliant(false)]
        public void VertexAttribP1(int index, int type, bool normalized, uint[] values)
        {
            unsafe
            {
                fixed (uint* valuesPtr = values)
                {
                    glVertexAttribP1uiv((uint)index, type, normalized, (uint*)valuesPtr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribP2uiDelegate(UInt32 index, int type, bool normalized, UInt32 value);
        internal VertexAttribP2uiDelegate glVertexAttribP2ui;

        public void VertexAttribP2(Int32 index, int type, bool normalized, Int32 value)
        {
            glVertexAttribP2ui((UInt32)index, type, (bool)normalized, (UInt32)value);
            CheckForErrors();
        }

        [CLSCompliant(false)]
        public void VertexAttribP2(Int32 index, int type, bool normalized, UInt32 value)
        {
            glVertexAttribP2ui((UInt32)index, type, (bool)normalized, value);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribP2uivDelegate(UInt32 index, int type, bool normalized, UInt32* value);
        internal unsafe VertexAttribP2uivDelegate glVertexAttribP2uiv;

        public void VertexAttribP2(int index, int type, bool normalized, int[] values)
        {
            unsafe
            {
                fixed (int* valuesPtr = values)
                {
                    glVertexAttribP2uiv((uint)index, type, normalized, (uint*)valuesPtr);
                    CheckForErrors();
                }
            }
        }

        [CLSCompliant(false)]
        public void VertexAttribP2(int index, int type, bool normalized, uint[] values)
        {
            unsafe
            {
                fixed (uint* valuesPtr = values)
                {
                    glVertexAttribP2uiv((uint)index, type, normalized, (uint*)valuesPtr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribP3uiDelegate(UInt32 index, int type, bool normalized, UInt32 value);
        internal VertexAttribP3uiDelegate glVertexAttribP3ui;

        public void VertexAttribP3(Int32 index, int type, bool normalized, Int32 value)
        {
            glVertexAttribP3ui((UInt32)index, type, (bool)normalized, (UInt32)value);
            CheckForErrors();
        }

        [CLSCompliant(false)]
        public void VertexAttribP3(Int32 index, int type, bool normalized, UInt32 value)
        {
            glVertexAttribP3ui((UInt32)index, type, (bool)normalized, value);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribP3uivDelegate(UInt32 index, int type, bool normalized, UInt32* value);
        internal unsafe VertexAttribP3uivDelegate glVertexAttribP3uiv;

        public void VertexAttribP3(int index, int type, bool normalized, int[] values)
        {
            unsafe
            {
                fixed (int* valuesPtr = values)
                {
                    glVertexAttribP3uiv((uint)index, type, normalized, (uint*)valuesPtr);
                    CheckForErrors();
                }
            }
        }

        [CLSCompliant(false)]
        public void VertexAttribP3(int index, int type, bool normalized, uint[] values)
        {
            unsafe
            {
                fixed (uint* valuesPtr = values)
                {
                    glVertexAttribP3uiv((uint)index, type, normalized, (uint*)valuesPtr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribP4uiDelegate(UInt32 index, int type, bool normalized, UInt32 value);
        internal VertexAttribP4uiDelegate glVertexAttribP4ui;

        public void VertexAttribP4(Int32 index, int type, bool normalized, Int32 value)
        {
            glVertexAttribP4ui((UInt32)index, type, (bool)normalized, (UInt32)value);
            CheckForErrors();
        }

        [CLSCompliant(false)]
        public void VertexAttribP4(Int32 index, int type, bool normalized, UInt32 value)
        {
            glVertexAttribP4ui((UInt32)index, type, (bool)normalized, value);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribP4uivDelegate(UInt32 index, int type, bool normalized, UInt32* value);
        internal unsafe VertexAttribP4uivDelegate glVertexAttribP4uiv;

        public void VertexAttribP4(int index, int type, bool normalized, int[] values)
        {
            unsafe
            {
                fixed (int* valuesPtr = values)
                {
                    glVertexAttribP4uiv((uint)index, type, normalized, (uint*)valuesPtr);
                    CheckForErrors();
                }
            }
        }

        [CLSCompliant(false)]
        public void VertexAttribP4(int index, int type, bool normalized, uint[] values)
        {
            unsafe
            {
                fixed (uint* valuesPtr = values)
                {
                    glVertexAttribP4uiv((uint)index, type, normalized, (uint*)valuesPtr);
                    CheckForErrors();
                }
            }
        }
    }
}
