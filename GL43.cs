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
    public class GL43
        : GL42
    {

        public GL43(Context context)
            : base(context)
        {

        }

        public int GL_NUM_SHADING_LANGUAGE_VERSIONS  { get { return 0x82E9; } }
        public int GL_VERTEX_ATTRIB_ARRAY_LONG       { get { return 0x874E; } }
        public int GL_COMPRESSED_RGB8_ETC2           { get { return 0x9274; } }
        public int GL_COMPRESSED_SRGB8_ETC2          { get { return 0x9275; } }
        public int GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 { get { return 0x9276; } }
        public int GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 { get { return 0x9277; } }
        public int GL_COMPRESSED_RGBA8_ETC2_EAC      { get { return 0x9278; } }
        public int GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC { get { return 0x9279; } }
        public int GL_COMPRESSED_R11_EAC             { get { return 0x9270; } }
        public int GL_COMPRESSED_SIGNED_R11_EAC      { get { return 0x9271; } }
        public int GL_COMPRESSED_RG11_EAC            { get { return 0x9272; } }
        public int GL_COMPRESSED_SIGNED_RG11_EAC     { get { return 0x9273; } }
        public int GL_PRIMITIVE_RESTART_FIXED_INDEX  { get { return 0x8D69; } }
        public int GL_ANY_SAMPLES_PASSED_CONSERVATIVE { get { return 0x8D6A; } }
        public int GL_MAX_ELEMENT_INDEX              { get { return 0x8D6B; } }
        public int GL_COMPUTE_SHADER                 { get { return 0x91B9; } }
        public int GL_MAX_COMPUTE_UNIFORM_BLOCKS     { get { return 0x91BB; } }
        public int GL_MAX_COMPUTE_TEXTURE_IMAGE_UNITS { get { return 0x91BC; } }
        public int GL_MAX_COMPUTE_IMAGE_UNIFORMS     { get { return 0x91BD; } }
        public int GL_MAX_COMPUTE_SHARED_MEMORY_SIZE { get { return 0x8262; } }
        public int GL_MAX_COMPUTE_UNIFORM_COMPONENTS { get { return 0x8263; } }
        public int GL_MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS { get { return 0x8264; } }
        public int GL_MAX_COMPUTE_ATOMIC_COUNTERS    { get { return 0x8265; } }
        public int GL_MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS { get { return 0x8266; } }
        public int GL_MAX_COMPUTE_LOCAL_INVOCATIONS  { get { return 0x90EB; } }
        public int GL_MAX_COMPUTE_WORK_GROUP_COUNT   { get { return 0x91BE; } }
        public int GL_MAX_COMPUTE_WORK_GROUP_SIZE    { get { return 0x91BF; } }
        public int GL_COMPUTE_LOCAL_WORK_SIZE        { get { return 0x8267; } }
        public int GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER { get { return 0x90EC; } }
        public int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER { get { return 0x90ED; } }
        public int GL_DISPATCH_INDIRECT_BUFFER       { get { return 0x90EE; } }
        public int GL_DISPATCH_INDIRECT_BUFFER_BINDING { get { return 0x90EF; } }
        public int GL_DEBUG_OUTPUT_SYNCHRONOUS       { get { return 0x8242; } }
        public int GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH { get { return 0x8243; } }
        public int GL_DEBUG_CALLBACK_FUNCTION        { get { return 0x8244; } }
        public int GL_DEBUG_CALLBACK_USER_PARAM      { get { return 0x8245; } }
        public int GL_DEBUG_SOURCE_API               { get { return 0x8246; } }
        public int GL_DEBUG_SOURCE_WINDOW_SYSTEM     { get { return 0x8247; } }
        public int GL_DEBUG_SOURCE_SHADER_COMPILER   { get { return 0x8248; } }
        public int GL_DEBUG_SOURCE_THIRD_PARTY       { get { return 0x8249; } }
        public int GL_DEBUG_SOURCE_APPLICATION       { get { return 0x824A; } }
        public int GL_DEBUG_SOURCE_OTHER             { get { return 0x824B; } }
        public int GL_DEBUG_TYPE_ERROR               { get { return 0x824C; } }
        public int GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR { get { return 0x824D; } }
        public int GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR  { get { return 0x824E; } }
        public int GL_DEBUG_TYPE_PORTABILITY         { get { return 0x824F; } }
        public int GL_DEBUG_TYPE_PERFORMANCE         { get { return 0x8250; } }
        public int GL_DEBUG_TYPE_OTHER               { get { return 0x8251; } }
        public int GL_MAX_DEBUG_MESSAGE_LENGTH       { get { return 0x9143; } }
        public int GL_MAX_DEBUG_LOGGED_MESSAGES      { get { return 0x9144; } }
        public int GL_DEBUG_LOGGED_MESSAGES          { get { return 0x9145; } }
        public int GL_DEBUG_SEVERITY_HIGH            { get { return 0x9146; } }
        public int GL_DEBUG_SEVERITY_MEDIUM          { get { return 0x9147; } }
        public int GL_DEBUG_SEVERITY_LOW             { get { return 0x9148; } }
        public int GL_DEBUG_TYPE_MARKER              { get { return 0x8268; } }
        public int GL_DEBUG_TYPE_PUSH_GROUP          { get { return 0x8269; } }
        public int GL_DEBUG_TYPE_POP_GROUP           { get { return 0x826A; } }
        public int GL_DEBUG_SEVERITY_NOTIFICATION    { get { return 0x826B; } }
        public int GL_MAX_DEBUG_GROUP_STACK_DEPTH    { get { return 0x826C; } }
        public int GL_DEBUG_GROUP_STACK_DEPTH        { get { return 0x826D; } }
        public int GL_BUFFER                         { get { return 0x82E0; } }
        public int GL_SHADER                         { get { return 0x82E1; } }
        public int GL_PROGRAM                        { get { return 0x82E2; } }
        public int GL_QUERY                          { get { return 0x82E3; } }
        public int GL_PROGRAM_PIPELINE               { get { return 0x82E4; } }
        public int GL_SAMPLER                        { get { return 0x82E6; } }
        public int GL_MAX_LABEL_LENGTH               { get { return 0x82E8; } }
        public int GL_DEBUG_OUTPUT                   { get { return 0x92E0; } }
        public int GL_CONTEXT_FLAG_DEBUG_BIT         { get { return 0x00000002; } }
        public int GL_MAX_UNIFORM_LOCATIONS          { get { return 0x826E; } }
        public int GL_FRAMEBUFFER_DEFAULT_WIDTH      { get { return 0x9310; } }
        public int GL_FRAMEBUFFER_DEFAULT_HEIGHT     { get { return 0x9311; } }
        public int GL_FRAMEBUFFER_DEFAULT_LAYERS     { get { return 0x9312; } }
        public int GL_FRAMEBUFFER_DEFAULT_SAMPLES    { get { return 0x9313; } }
        public int GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS { get { return 0x9314; } }
        public int GL_MAX_FRAMEBUFFER_WIDTH          { get { return 0x9315; } }
        public int GL_MAX_FRAMEBUFFER_HEIGHT         { get { return 0x9316; } }
        public int GL_MAX_FRAMEBUFFER_LAYERS         { get { return 0x9317; } }
        public int GL_MAX_FRAMEBUFFER_SAMPLES        { get { return 0x9318; } }
        public int GL_INTERNALFORMAT_SUPPORTED       { get { return 0x826F; } }
        public int GL_INTERNALFORMAT_PREFERRED       { get { return 0x8270; } }
        public int GL_INTERNALFORMAT_RED_SIZE        { get { return 0x8271; } }
        public int GL_INTERNALFORMAT_GREEN_SIZE      { get { return 0x8272; } }
        public int GL_INTERNALFORMAT_BLUE_SIZE       { get { return 0x8273; } }
        public int GL_INTERNALFORMAT_ALPHA_SIZE      { get { return 0x8274; } }
        public int GL_INTERNALFORMAT_DEPTH_SIZE      { get { return 0x8275; } }
        public int GL_INTERNALFORMAT_STENCIL_SIZE    { get { return 0x8276; } }
        public int GL_INTERNALFORMAT_SHARED_SIZE     { get { return 0x8277; } }
        public int GL_INTERNALFORMAT_RED_TYPE        { get { return 0x8278; } }
        public int GL_INTERNALFORMAT_GREEN_TYPE      { get { return 0x8279; } }
        public int GL_INTERNALFORMAT_BLUE_TYPE       { get { return 0x827A; } }
        public int GL_INTERNALFORMAT_ALPHA_TYPE      { get { return 0x827B; } }
        public int GL_INTERNALFORMAT_DEPTH_TYPE      { get { return 0x827C; } }
        public int GL_INTERNALFORMAT_STENCIL_TYPE    { get { return 0x827D; } }
        public int GL_MAX_WIDTH                      { get { return 0x827E; } }
        public int GL_MAX_HEIGHT                     { get { return 0x827F; } }
        public int GL_MAX_DEPTH                      { get { return 0x8280; } }
        public int GL_MAX_LAYERS                     { get { return 0x8281; } }
        public int GL_MAX_COMBINED_DIMENSIONS        { get { return 0x8282; } }
        public int GL_COLOR_COMPONENTS               { get { return 0x8283; } }
        public int GL_DEPTH_COMPONENTS               { get { return 0x8284; } }
        public int GL_STENCIL_COMPONENTS             { get { return 0x8285; } }
        public int GL_COLOR_RENDERABLE               { get { return 0x8286; } }
        public int GL_DEPTH_RENDERABLE               { get { return 0x8287; } }
        public int GL_STENCIL_RENDERABLE             { get { return 0x8288; } }
        public int GL_FRAMEBUFFER_RENDERABLE         { get { return 0x8289; } }
        public int GL_FRAMEBUFFER_RENDERABLE_LAYERED { get { return 0x828A; } }
        public int GL_FRAMEBUFFER_BLEND              { get { return 0x828B; } }
        public int GL_READ_PIXELS                    { get { return 0x828C; } }
        public int GL_READ_PIXELS_FORMAT             { get { return 0x828D; } }
        public int GL_READ_PIXELS_TYPE               { get { return 0x828E; } }
        public int GL_TEXTURE_IMAGE_FORMAT           { get { return 0x828F; } }
        public int GL_TEXTURE_IMAGE_TYPE             { get { return 0x8290; } }
        public int GL_GET_TEXTURE_IMAGE_FORMAT       { get { return 0x8291; } }
        public int GL_GET_TEXTURE_IMAGE_TYPE         { get { return 0x8292; } }
        public int GL_MIPMAP                         { get { return 0x8293; } }
        public int GL_MANUAL_GENERATE_MIPMAP         { get { return 0x8294; } }
        public int GL_AUTO_GENERATE_MIPMAP           { get { return 0x8295; } }
        public int GL_COLOR_ENCODING                 { get { return 0x8296; } }
        public int GL_SRGB_READ                      { get { return 0x8297; } }
        public int GL_SRGB_WRITE                     { get { return 0x8298; } }
        public int GL_FILTER                         { get { return 0x829A; } }
        public int GL_VERTEX_TEXTURE                 { get { return 0x829B; } }
        public int GL_TESS_CONTROL_TEXTURE           { get { return 0x829C; } }
        public int GL_TESS_EVALUATION_TEXTURE        { get { return 0x829D; } }
        public int GL_GEOMETRY_TEXTURE               { get { return 0x829E; } }
        public int GL_FRAGMENT_TEXTURE               { get { return 0x829F; } }
        public int GL_COMPUTE_TEXTURE                { get { return 0x82A0; } }
        public int GL_TEXTURE_SHADOW                 { get { return 0x82A1; } }
        public int GL_TEXTURE_GATHER                 { get { return 0x82A2; } }
        public int GL_TEXTURE_GATHER_SHADOW          { get { return 0x82A3; } }
        public int GL_SHADER_IMAGE_LOAD              { get { return 0x82A4; } }
        public int GL_SHADER_IMAGE_STORE             { get { return 0x82A5; } }
        public int GL_SHADER_IMAGE_ATOMIC            { get { return 0x82A6; } }
        public int GL_IMAGE_TEXEL_SIZE               { get { return 0x82A7; } }
        public int GL_IMAGE_COMPATIBILITY_CLASS      { get { return 0x82A8; } }
        public int GL_IMAGE_PIXEL_FORMAT             { get { return 0x82A9; } }
        public int GL_IMAGE_PIXEL_TYPE               { get { return 0x82AA; } }
        public int GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST { get { return 0x82AC; } }
        public int GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST { get { return 0x82AD; } }
        public int GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE { get { return 0x82AE; } }
        public int GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE { get { return 0x82AF; } }
        public int GL_TEXTURE_COMPRESSED_BLOCK_WIDTH { get { return 0x82B1; } }
        public int GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT { get { return 0x82B2; } }
        public int GL_TEXTURE_COMPRESSED_BLOCK_SIZE  { get { return 0x82B3; } }
        public int GL_CLEAR_BUFFER                   { get { return 0x82B4; } }
        public int GL_TEXTURE_VIEW                   { get { return 0x82B5; } }
        public int GL_VIEW_COMPATIBILITY_CLASS       { get { return 0x82B6; } }
        public int GL_FULL_SUPPORT                   { get { return 0x82B7; } }
        public int GL_CAVEAT_SUPPORT                 { get { return 0x82B8; } }
        public int GL_IMAGE_CLASS_4_X_32             { get { return 0x82B9; } }
        public int GL_IMAGE_CLASS_2_X_32             { get { return 0x82BA; } }
        public int GL_IMAGE_CLASS_1_X_32             { get { return 0x82BB; } }
        public int GL_IMAGE_CLASS_4_X_16             { get { return 0x82BC; } }
        public int GL_IMAGE_CLASS_2_X_16             { get { return 0x82BD; } }
        public int GL_IMAGE_CLASS_1_X_16             { get { return 0x82BE; } }
        public int GL_IMAGE_CLASS_4_X_8              { get { return 0x82BF; } }
        public int GL_IMAGE_CLASS_2_X_8              { get { return 0x82C0; } }
        public int GL_IMAGE_CLASS_1_X_8              { get { return 0x82C1; } }
        public int GL_IMAGE_CLASS_11_11_10           { get { return 0x82C2; } }
        public int GL_IMAGE_CLASS_10_10_10_2         { get { return 0x82C3; } }
        public int GL_VIEW_CLASS_128_BITS            { get { return 0x82C4; } }
        public int GL_VIEW_CLASS_96_BITS             { get { return 0x82C5; } }
        public int GL_VIEW_CLASS_64_BITS             { get { return 0x82C6; } }
        public int GL_VIEW_CLASS_48_BITS             { get { return 0x82C7; } }
        public int GL_VIEW_CLASS_32_BITS             { get { return 0x82C8; } }
        public int GL_VIEW_CLASS_24_BITS             { get { return 0x82C9; } }
        public int GL_VIEW_CLASS_16_BITS             { get { return 0x82CA; } }
        public int GL_VIEW_CLASS_8_BITS              { get { return 0x82CB; } }
        public int GL_VIEW_CLASS_S3TC_DXT1_RGB       { get { return 0x82CC; } }
        public int GL_VIEW_CLASS_S3TC_DXT1_RGBA      { get { return 0x82CD; } }
        public int GL_VIEW_CLASS_S3TC_DXT3_RGBA      { get { return 0x82CE; } }
        public int GL_VIEW_CLASS_S3TC_DXT5_RGBA      { get { return 0x82CF; } }
        public int GL_VIEW_CLASS_RGTC1_RED           { get { return 0x82D0; } }
        public int GL_VIEW_CLASS_RGTC2_RG            { get { return 0x82D1; } }
        public int GL_VIEW_CLASS_BPTC_UNORM          { get { return 0x82D2; } }
        public int GL_VIEW_CLASS_BPTC_FLOAT          { get { return 0x82D3; } }
        public int GL_UNIFORM                        { get { return 0x92E1; } }
        public int GL_UNIFORM_BLOCK                  { get { return 0x92E2; } }
        public int GL_PROGRAM_INPUT                  { get { return 0x92E3; } }
        public int GL_PROGRAM_OUTPUT                 { get { return 0x92E4; } }
        public int GL_BUFFER_VARIABLE                { get { return 0x92E5; } }
        public int GL_SHADER_STORAGE_BLOCK           { get { return 0x92E6; } }
        public int GL_VERTEX_SUBROUTINE              { get { return 0x92E8; } }
        public int GL_TESS_CONTROL_SUBROUTINE        { get { return 0x92E9; } }
        public int GL_TESS_EVALUATION_SUBROUTINE     { get { return 0x92EA; } }
        public int GL_GEOMETRY_SUBROUTINE            { get { return 0x92EB; } }
        public int GL_FRAGMENT_SUBROUTINE            { get { return 0x92EC; } }
        public int GL_COMPUTE_SUBROUTINE             { get { return 0x92ED; } }
        public int GL_VERTEX_SUBROUTINE_UNIFORM      { get { return 0x92EE; } }
        public int GL_TESS_CONTROL_SUBROUTINE_UNIFORM { get { return 0x92EF; } }
        public int GL_TESS_EVALUATION_SUBROUTINE_UNIFORM { get { return 0x92F0; } }
        public int GL_GEOMETRY_SUBROUTINE_UNIFORM    { get { return 0x92F1; } }
        public int GL_FRAGMENT_SUBROUTINE_UNIFORM    { get { return 0x92F2; } }
        public int GL_COMPUTE_SUBROUTINE_UNIFORM     { get { return 0x92F3; } }
        public int GL_TRANSFORM_FEEDBACK_VARYING     { get { return 0x92F4; } }
        public int GL_ACTIVE_RESOURCES               { get { return 0x92F5; } }
        public int GL_MAX_NAME_LENGTH                { get { return 0x92F6; } }
        public int GL_MAX_NUM_ACTIVE_VARIABLES       { get { return 0x92F7; } }
        public int GL_MAX_NUM_COMPATIBLE_SUBROUTINES { get { return 0x92F8; } }
        public int GL_NAME_LENGTH                    { get { return 0x92F9; } }
        public int GL_TYPE                           { get { return 0x92FA; } }
        public int GL_ARRAY_SIZE                     { get { return 0x92FB; } }
        public int GL_OFFSET                         { get { return 0x92FC; } }
        public int GL_BLOCK_INDEX                    { get { return 0x92FD; } }
        public int GL_ARRAY_STRIDE                   { get { return 0x92FE; } }
        public int GL_MATRIX_STRIDE                  { get { return 0x92FF; } }
        public int GL_IS_ROW_MAJOR                   { get { return 0x9300; } }
        public int GL_ATOMIC_COUNTER_BUFFER_INDEX    { get { return 0x9301; } }
        public int GL_BUFFER_BINDING                 { get { return 0x9302; } }
        public int GL_BUFFER_DATA_SIZE               { get { return 0x9303; } }
        public int GL_NUM_ACTIVE_VARIABLES           { get { return 0x9304; } }
        public int GL_ACTIVE_VARIABLES               { get { return 0x9305; } }
        public int GL_REFERENCED_BY_VERTEX_SHADER    { get { return 0x9306; } }
        public int GL_REFERENCED_BY_TESS_CONTROL_SHADER { get { return 0x9307; } }
        public int GL_REFERENCED_BY_TESS_EVALUATION_SHADER { get { return 0x9308; } }
        public int GL_REFERENCED_BY_GEOMETRY_SHADER  { get { return 0x9309; } }
        public int GL_REFERENCED_BY_FRAGMENT_SHADER  { get { return 0x930A; } }
        public int GL_REFERENCED_BY_COMPUTE_SHADER   { get { return 0x930B; } }
        public int GL_TOP_LEVEL_ARRAY_SIZE           { get { return 0x930C; } }
        public int GL_TOP_LEVEL_ARRAY_STRIDE         { get { return 0x930D; } }
        public int GL_LOCATION                       { get { return 0x930E; } }
        public int GL_LOCATION_INDEX                 { get { return 0x930F; } }
        public int GL_IS_PER_PATCH                   { get { return 0x92E7; } }
        public int GL_SHADER_STORAGE_BUFFER          { get { return 0x90D2; } }
        public int GL_SHADER_STORAGE_BUFFER_BINDING  { get { return 0x90D3; } }
        public int GL_SHADER_STORAGE_BUFFER_START    { get { return 0x90D4; } }
        public int GL_SHADER_STORAGE_BUFFER_SIZE     { get { return 0x90D5; } }
        public int GL_MAX_VERTEX_SHADER_STORAGE_BLOCKS { get { return 0x90D6; } }
        public int GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS { get { return 0x90D7; } }
        public int GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS { get { return 0x90D8; } }
        public int GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS { get { return 0x90D9; } }
        public int GL_MAX_FRAGMENT_SHADER_STORAGE_BLOCKS { get { return 0x90DA; } }
        public int GL_MAX_COMPUTE_SHADER_STORAGE_BLOCKS { get { return 0x90DB; } }
        public int GL_MAX_COMBINED_SHADER_STORAGE_BLOCKS { get { return 0x90DC; } }
        public int GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS { get { return 0x90DD; } }
        public int GL_MAX_SHADER_STORAGE_BLOCK_SIZE  { get { return 0x90DE; } }
        public int GL_SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT { get { return 0x90DF; } }
        public int GL_SHADER_STORAGE_BARRIER_BIT     { get { return 0x00002000; } }
        public int GL_MAX_COMBINED_SHADER_OUTPUT_RESOURCES { get { return 0x8F39; } }
        public int GL_DEPTH_STENCIL_TEXTURE_MODE     { get { return 0x90EA; } }
        public int GL_TEXTURE_BUFFER_OFFSET          { get { return 0x919D; } }
        public int GL_TEXTURE_BUFFER_SIZE            { get { return 0x919E; } }
        public int GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT { get { return 0x919F; } }
        public int GL_TEXTURE_VIEW_MIN_LEVEL         { get { return 0x82DB; } }
        public int GL_TEXTURE_VIEW_NUM_LEVELS        { get { return 0x82DC; } }
        public int GL_TEXTURE_VIEW_MIN_LAYER         { get { return 0x82DD; } }
        public int GL_TEXTURE_VIEW_NUM_LAYERS        { get { return 0x82DE; } }
        public int GL_TEXTURE_IMMUTABLE_LEVELS       { get { return 0x82DF; } }
        public int GL_VERTEX_ATTRIB_BINDING          { get { return 0x82D4; } }
        public int GL_VERTEX_ATTRIB_RELATIVE_OFFSET  { get { return 0x82D5; } }
        public int GL_VERTEX_BINDING_DIVISOR         { get { return 0x82D6; } }
        public int GL_VERTEX_BINDING_OFFSET          { get { return 0x82D7; } }
        public int GL_VERTEX_BINDING_STRIDE          { get { return 0x82D8; } }
        public int GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET { get { return 0x82D9; } }
        public int GL_MAX_VERTEX_ATTRIB_BINDINGS { get { return 0x82DA; } }

        
        public delegate void GLDEBUGPROC(int source, int type, int id, int severity, int length, string message, IntPtr userParam);

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearBufferDataDelegate (int target, int internalformat, int format, int type, IntPtr data);
        internal ClearBufferDataDelegate glClearBufferData;

        public void ClearBufferData<T>(int target, int internalformat, int format, int type, T [] data)
            where T : struct
        {
            GCHandle data_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                glClearBufferData(target, internalformat, format, type, (IntPtr)data_ptr.AddrOfPinnedObject());
                CheckForErrors();
            }
            finally
            {
                data_ptr.Free();
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearBufferSubDataDelegate (int target, int internalformat, int offset, int size, int format, int type, IntPtr data);
        internal ClearBufferSubDataDelegate glClearBufferSubData;

        public void ClearBufferSubData<T>(int target, int internalformat, int offset, int size, int format, int type, T [] data)
            where T : struct
        {
            GCHandle data_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                glClearBufferSubData(target, internalformat, offset, size, format, type, (IntPtr)data_ptr.AddrOfPinnedObject());
                CheckForErrors();
            }
            finally
            {
                data_ptr.Free();
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DispatchComputeDelegate (int num_groups_x, int num_groups_y, int num_groups_z);
        internal DispatchComputeDelegate glDispatchCompute;

        public void DispatchCompute(int num_groups_x, int num_groups_y, int num_groups_z)
        {
            glDispatchCompute(num_groups_x, num_groups_y, num_groups_z);
            CheckForErrors();
        }


        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DispatchComputeIndirectDelegate (IntPtr indirect);
        internal DispatchComputeIndirectDelegate glDispatchComputeIndirect;

        public void DispatchComputeIndirect(IntPtr indirect)
        {
            glDispatchComputeIndirect(indirect);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyImageSubDataDelegate (int srcName, int srcTarget, int srcLevel, int srcX, int srcY, int srcZ, int dstName, int dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth);
        internal CopyImageSubDataDelegate glCopyImageSubData;

        public void CopyImageSubData(int srcName, int srcTarget, int srcLevel, int srcX, int srcY, int srcZ, int dstName, int dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth)
        {
            glCopyImageSubData(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
            CheckForErrors();
        }
        
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FramebufferParameteriDelegate (int target, int pname, int param);
        internal FramebufferParameteriDelegate glFramebufferParameteri;

        public void FramebufferParameter(int target, int pname, int param)
        {
            glFramebufferParameteri(target, pname, param);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFramebufferParameterivDelegate (int target, int pname, int *parameters);
        internal GetFramebufferParameterivDelegate glGetFramebufferParameteriv;

        public void GetFramebufferParamter(int target, int pname, int[] parameters)
        {
            unsafe
            {
                fixed (int* paramsPtr = parameters)
                {
                    glGetFramebufferParameteriv(target, pname, paramsPtr);
                    CheckForErrors();
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetInternalformati64vDelegate(int target, int internalformat, int pname, int bufSize, long* parameters);
        internal GetInternalformati64vDelegate glGetInternalformati64v;

        public void GetInternalformat(int target, int internalformat, int pname, int bufSize, long[] parameters)
        {
            unsafe
            {
                fixed (long* paramsPtr = parameters)
                {
                    glGetInternalformati64v(target, internalformat, pname, bufSize, paramsPtr);
                    CheckForErrors();
                }
            }
        }
        
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void InvalidateTexSubImageDelegate (int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth);
        internal InvalidateTexSubImageDelegate glInvalidateTexSubImage;

        public void InvalidateTexSubImage(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth)
        {
            glInvalidateTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth);
            CheckForErrors();
        }
        
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void InvalidateTexImageDelegate (int texture, int level);
        internal InvalidateTexImageDelegate glInvalidateTexImage;

        public void InvalidateTexImage(int texture, int level)
        {
            glInvalidateTexImage(texture, level);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void InvalidateBufferSubDataDelegate (int buffer, int offset, int length);
        internal InvalidateBufferSubDataDelegate glInvalidateBufferSubData;

        public void InvalidateBufferSubData(int buffer, int offset, int length)
        {
            glInvalidateBufferSubData(buffer, offset, length);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void InvalidateBufferDataDelegate (int buffer);
        internal InvalidateBufferDataDelegate glInvalidateBufferData;

        public void InvalidateBufferData(int buffer)
        {
            glInvalidateBufferData(buffer);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void InvalidateFramebufferDelegate(int target, int numAttachments, int* attachments);
        internal InvalidateFramebufferDelegate glInvalidateFramebuffer;

        public void InvalidateFramebuffer(int target, int numAttachments, int[] attachments)
        {
            unsafe
            {
                fixed (int* ptr = attachments)
                {
                    glInvalidateFramebuffer(target, numAttachments, ptr);
                    CheckForErrors();
                }
            }
        }


        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void InvalidateSubFramebufferDelegate(int target, int numAttachments, int* attachments, int x, int y, int width, int height);
        internal InvalidateSubFramebufferDelegate glInvalidateSubFramebuffer;

        public void InvalidateSubFramebuffer(int target, int numAttachments, int[] attachments, int x, int y, int width, int height)
        {
            unsafe
            {
                fixed (int* ptr = attachments)
                {
                    glInvalidateSubFramebuffer(target, numAttachments, ptr, x, y, width, height);
                    CheckForErrors();
                }
            }
        }
        
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiDrawArraysIndirectDelegate (int mode, IntPtr indirect, int drawcount, int stride);
        internal MultiDrawArraysIndirectDelegate glMultiDrawArraysIndirect;

        public void MultiDrawArraysIndirect(int mode, IntPtr indirect, int drawcount, int stride)
        {
            glMultiDrawArraysIndirect(mode, indirect, drawcount, stride);
            CheckForErrors();
        }


        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiDrawElementsIndirectDelegate (int mode, int type, IntPtr indirect, int drawcount, int stride);
        internal MultiDrawElementsIndirectDelegate glMultiDrawElementsIndirect;

        public void MultiDrawElementsIndirect(int mode, int type, IntPtr indirect, int drawcount, int stride)
        {
            glMultiDrawElementsIndirect(mode, type, indirect, drawcount, stride);
            CheckForErrors();
        }
        
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramInterfaceivDelegate(int program, int programInterface, int pname, int* parameters);
        internal GetProgramInterfaceivDelegate glGetProgramInterfaceiv;

        public void GetProgramInterface(int program, int programInterface, int pname, int [] parameters)
        {
            unsafe
            {
                fixed (int* ptr = parameters)
                {
                    glGetProgramInterfaceiv(program, programInterface, pname, ptr);
                    CheckForErrors();
                }
            }
        }
        
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int  GetProgramResourceIndexDelegate (int program, int programInterface, string name);
        internal GetProgramResourceIndexDelegate glGetProgramResourceIndex;

        public int GetProgramResourceIndex(int program, int programInterface, string name)
        {
            int r = glGetProgramResourceIndex(program, programInterface, name);
            CheckForErrors();
            return r;
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramResourceNameDelegate(int program, int programInterface, int index, int bufSize, int length, string name);
        internal GetProgramResourceNameDelegate glGetProgramResourceName;

        public void GetProgramResourceName(int program, int programInterface, int index, int bufSize, int length, string name)
        {
            glGetProgramResourceName(program, programInterface, index, bufSize, length, name);
            CheckForErrors();
        }
        
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramResourceivDelegate(int program, int programInterface, int index, int propCount, int* props, int bufSize, int* length, int* parameters);
        internal GetProgramResourceivDelegate glGetProgramResourceiv;

        public void GetProgramResource(int program, int programInterface, int index, int propCount, int [] props, int bufSize, int[] length, int [] parameters)
        {
            unsafe
            {
                fixed (int* propsPtr = props)
                {
                    fixed (int* lengthPtr = length)
                    {
                        fixed (int* paramsPtr = parameters)
                        {
                            glGetProgramResourceiv(program, programInterface, index, propCount, propsPtr, bufSize, lengthPtr, paramsPtr);
                            CheckForErrors();
                        }
                    }
                }
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int  GetProgramResourceLocationDelegate (int program, int programInterface, string name);
        internal GetProgramResourceLocationDelegate glGetProgramResourceLocation;

        public int GetProgramResourceLocation(int program, int programInterface, string name)
        {
            int r = glGetProgramResourceLocation(program, programInterface, name);
            CheckForErrors();
            return r;
        }
        
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate int  GetProgramResourceLocationIndexDelegate (int program, int programInterface, string name);
        internal GetProgramResourceLocationIndexDelegate glGetProgramResourceLocationIndex;

        public int GetProgramResourceLocationIndex(int program, int programInterface, string name)
        {
            int r = glGetProgramResourceIndex(program, programInterface, name);
            CheckForErrors();
            return r;
        }
        
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ShaderStorageBlockBindingDelegate (int program, int storageBlockIndex, int storageBlockBinding);
        internal ShaderStorageBlockBindingDelegate glShaderStorageBlockBinding;

        public void ShaderStorageBlockBinding(int program, int storageBlockIndex, int storageBlockBinding)
        {
            glShaderStorageBlockBinding(program, storageBlockIndex, storageBlockBinding);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexBufferRangeDelegate (int target, int internalformat, int buffer, int offset, int size);
        internal TexBufferRangeDelegate glTexBufferRange;

        public void TexBufferRange(int target, int internalformat, int buffer, int offset, int size)
        {
            glTexBufferRange(target, internalformat, buffer, offset, size);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexStorage2DMultisampleDelegate (int target, int samples, int internalformat, int width, int height, bool fixedsamplelocations);
        internal TexStorage2DMultisampleDelegate glTexStorage2DMultisample;

        public void TexStorage2DMultisample(int target, int samples, int internalformat, int width, int height, bool fixedsamplelocations)
        {
            glTexStorage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexStorage3DMultisampleDelegate (int target, int samples, int internalformat, int width, int height, int depth, bool fixedsamplelocations);
        internal TexStorage3DMultisampleDelegate glTexStorage3DMultisample;

        public void TexStorage3DMultisample(int target, int samples, int internalformat, int width, int height, int depth, bool fixedsamplelocations)
        {
            glTexStorage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TextureViewDelegate (int texture, int target, int origtexture, int internalformat, int minlevel, int numlevels, int minlayer, int numlayers);
        internal TextureViewDelegate glTextureView;

        public void TextureView(int texture, int target, int origtexture, int internalformat, int minlevel, int numlevels, int minlayer, int numlayers)
        {
            glTextureView(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindVertexBufferDelegate (int bindingindex, int buffer, int offset, int stride);
        internal BindVertexBufferDelegate glBindVertexBuffer;

        public void BindVertexBuffer(int bindingindex, int buffer, int offset, int stride)
        {
            glBindVertexBuffer(bindingindex, buffer, offset, stride);
            CheckForErrors();
        }
        
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribFormatDelegate (int attribindex, int size, int type, bool normalized, int relativeoffset);
        internal VertexAttribFormatDelegate glVertexAttribFormat;

        public void VertexAttribFormat(int attribindex, int size, int type, bool normalized, int relativeoffset)
        {
            glVertexAttribFormat(attribindex, size, type, normalized, relativeoffset);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribIFormatDelegate (int attribindex, int size, int type, int relativeoffset);
        internal VertexAttribIFormatDelegate glVertexAttribIFormat;

        public void VertexAttribIFormat(int attribindex, int size, int type, int relativeoffset)
        {
            glVertexAttribIFormat(attribindex, size, type, relativeoffset);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribLFormatDelegate (int attribindex, int size, int type, int relativeoffset);
        internal VertexAttribLFormatDelegate glVertexAttribLFormat;

        public void VertexAttribLFormat(int attribindex, int size, int type, int relativeoffset)
        {
            glVertexAttribLFormat(attribindex, size, type, relativeoffset);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribBindingDelegate (int attribindex, int bindingindex);
        internal VertexAttribBindingDelegate glVertexAttribBinding;

        public void VertexAttribBinding(int attribindex, int bindingindex)
        {
            glVertexAttribBinding(attribindex, bindingindex);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexBindingDivisorDelegate (int bindingindex, int divisor);
        internal VertexBindingDivisorDelegate glVertexBindingDivisor;

        public void VertexBindingDivisor(int bindingindex, int divisor)
        {
            glVertexBindingDivisor(bindingindex, divisor);
            CheckForErrors();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DebugMessageControlDelegate(int source, int type, int severity, int count, int* ids, bool enabled);
        internal DebugMessageControlDelegate glDebugMessageControl;

        public void DebugMessageControl(int source, int type, int severity, int count, int[] ids, bool enabled)
        {
            unsafe
            {
                fixed (int* ptr = ids)
                {
                    glDebugMessageControl(source, type, severity, count, ptr, enabled);
                    CheckForErrors();
                }
            }
        }
        
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DebugMessageInsertDelegate (int source, int type, int id, int severity, int length, string buf);
        internal DebugMessageInsertDelegate glDebugMessageInsert;

        public void DebugMessageInsert(int source, int type, int id, int severity, int length, string buf)
        {
            glDebugMessageInsert(source, type, id, severity, length, buf);
            CheckForErrors();
        }
        
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DebugMessageCallbackDelegate (GLDEBUGPROC callback, IntPtr userParam);
        internal DebugMessageCallbackDelegate glDebugMessageCallback;

        public void DebugMessageCallback(GLDEBUGPROC callback, IntPtr userParam)
        {
            glDebugMessageCallback(callback, userParam);
            CheckForErrors();
        }
        
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate int GetDebugMessageLogDelegate(int count, int bufSize, int* sources, int* types, int* ids, int* severities, int* lengths, string messageLog);
        internal GetDebugMessageLogDelegate glGetDebugMessageLog;

        public int GetDebugMessageLog(int count, int bufSize, int[] sources, int[] types, int[] ids, int[] severities, int[] lengths, string messageLog)
        {
            unsafe
            {
                fixed (int* sourcePtr = sources)
                {
                    fixed (int* typesPtr = types)
                    {
                        fixed (int* idsPtr = ids)
                        {
                            fixed (int* severPtr = severities)
                            {
                                fixed (int* lengthsPtr = lengths)
                                {
                                    int r = glGetDebugMessageLog(count, bufSize, sourcePtr, typesPtr, idsPtr, severPtr, lengthsPtr, messageLog);
                                    CheckForErrors();
                                    return r;
                                }
                            }
                        }
                    }
                }
            }
        }
        
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PushDebugGroupDelegate (int source, int id, int length, string message);
        internal PushDebugGroupDelegate glPushDebugGroup;

        public void PushDebugGroup(int source, int id, int length, string message)
        {
            glPushDebugGroup(source, id, length, message);
            CheckForErrors();
        }
        
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PopDebugGroupDelegate ();
        internal PopDebugGroupDelegate glPopDebugGroup;

        public void PopDebugGroup()
        {
            glPopDebugGroup();
            CheckForErrors();
        }
        
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ObjectLabelDelegate (int identifier, int name, int length, string label);
        internal ObjectLabelDelegate glObjectLabel;

        public void ObjectLabel(int identifier, int name, int length, string label)
        {
            glObjectLabel(identifier, name, length, label);
            CheckForErrors();
        }
        
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetObjectLabelDelegate(int identifier, int name, int bufSize, int length, string label);
        internal GetObjectLabelDelegate glGetObjectLabel;

        public void GetObjectLabel(int identifier, int name, int bufSize, int length, string label)
        {
            glGetObjectLabel(identifier, name, bufSize, length, label);
            CheckForErrors();
        }
        
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ObjectPtrLabelDelegate (IntPtr ptr, int length, string label);
        internal ObjectPtrLabelDelegate glObjectPtrLabel;

        public void ObjectPtrLabel(IntPtr ptr, int length, string label)
        {
            glObjectPtrLabel(ptr, length, label);
            CheckForErrors();
        }
        
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetObjectPtrLabelDelegate(IntPtr ptr, int bufSize, int length, string label);
        internal GetObjectPtrLabelDelegate glGetObjectPtrLabel;

        public void GetObjectPtrLabel(IntPtr ptr, int bufSize, int length, string label)
        {
            glGetObjectPtrLabel(ptr, bufSize, length, label);
            CheckForErrors();
        }
    }
}
