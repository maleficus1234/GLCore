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
    public class GLES30
        : GLES20
    {
        protected GL32 gl32;
        protected GL33 gl33;

        public GLES30(Context context)
            : base(context)
        {
            try
            {
                gl32 = new GL32(context);
            }
            catch (Exception e)
            {

            }

            try
            {
                gl33 = new GL33(context);
            }
            catch (Exception e)
            {

            }
        }

        public int GL_READ_BUFFER                                    { get { return 0x0C02; } }
        public int GL_UNPACK_ROW_LENGTH                              { get { return 0x0CF2; } }
        public int GL_UNPACK_SKIP_ROWS                               { get { return 0x0CF3; } }
        public int GL_UNPACK_SKIP_PIXELS                             { get { return 0x0CF4; } }
        public int GL_PACK_ROW_LENGTH                                { get { return 0x0D02; } }
        public int GL_PACK_SKIP_ROWS                                 { get { return 0x0D03; } }
        public int GL_PACK_SKIP_PIXELS                               { get { return 0x0D04; } }
        public int GL_COLOR                                          { get { return 0x1800; } }
        public int GL_DEPTH                                          { get { return 0x1801; } }
        public int GL_STENCIL                                        { get { return 0x1802; } }
        public int GL_RED                                            { get { return 0x1903; } }
        public int GL_RGB8                                           { get { return 0x8051; } }
        public int GL_RGBA8                                          { get { return 0x8058; } }
        public int GL_RGB10_A2                                       { get { return 0x8059; } }
        public int GL_TEXTURE_BINDING_3D                             { get { return 0x806A; } }
        public int GL_UNPACK_SKIP_IMAGES                             { get { return 0x806D; } }
        public int GL_UNPACK_IMAGE_HEIGHT                            { get { return 0x806E; } }
        public int GL_TEXTURE_3D                                     { get { return 0x806F; } }
        public int GL_TEXTURE_WRAP_R                                 { get { return 0x8072; } }
        public int GL_MAX_3D_TEXTURE_SIZE                            { get { return 0x8073; } }
        public int GL_UNSIGNED_INT_2_10_10_10_REV                    { get { return 0x8368; } }
        public int GL_MAX_ELEMENTS_VERTICES                          { get { return 0x80E8; } }
        public int GL_MAX_ELEMENTS_INDICES                           { get { return 0x80E9; } }
        public int GL_TEXTURE_MIN_LOD                                { get { return 0x813A; } }
        public int GL_TEXTURE_MAX_LOD                                { get { return 0x813B; } }
        public int GL_TEXTURE_BASE_LEVEL                             { get { return 0x813C; } }
        public int GL_TEXTURE_MAX_LEVEL                              { get { return 0x813D; } }
        public int GL_MIN                                            { get { return 0x8007; } }
        public int GL_MAX                                            { get { return 0x8008; } }
        public int GL_DEPTH_COMPONENT24                              { get { return 0x81A6; } }
        public int GL_MAX_TEXTURE_LOD_BIAS                           { get { return 0x84FD; } }
        public int GL_TEXTURE_COMPARE_MODE                           { get { return 0x884C; } }
        public int GL_TEXTURE_COMPARE_FUNC                           { get { return 0x884D; } }
        public int GL_CURRENT_QUERY                                  { get { return 0x8865; } }
        public int GL_QUERY_RESULT                                   { get { return 0x8866; } }
        public int GL_QUERY_RESULT_AVAILABLE                         { get { return 0x8867; } }
        public int GL_BUFFER_MAPPED                                  { get { return 0x88BC; } }
        public int GL_BUFFER_MAP_POINTER                             { get { return 0x88BD; } }
        public int GL_STREAM_READ                                    { get { return 0x88E1; } }
        public int GL_STREAM_COPY                                    { get { return 0x88E2; } }
        public int GL_STATIC_READ                                    { get { return 0x88E5; } }
        public int GL_STATIC_COPY                                    { get { return 0x88E6; } }
        public int GL_DYNAMIC_READ                                   { get { return 0x88E9; } }
        public int GL_DYNAMIC_COPY                                   { get { return 0x88EA; } }
        public int GL_MAX_DRAW_BUFFERS                               { get { return 0x8824; } }
        public int GL_DRAW_BUFFER0                                   { get { return 0x8825; } }
        public int GL_DRAW_BUFFER1                                   { get { return 0x8826; } }
        public int GL_DRAW_BUFFER2                                   { get { return 0x8827; } }
        public int GL_DRAW_BUFFER3                                   { get { return 0x8828; } }
        public int GL_DRAW_BUFFER4                                   { get { return 0x8829; } }
        public int GL_DRAW_BUFFER5                                   { get { return 0x882A; } }
        public int GL_DRAW_BUFFER6                                   { get { return 0x882B; } }
        public int GL_DRAW_BUFFER7                                   { get { return 0x882C; } }
        public int GL_DRAW_BUFFER8                                   { get { return 0x882D; } }
        public int GL_DRAW_BUFFER9                                   { get { return 0x882E; } }
        public int GL_DRAW_BUFFER10                                  { get { return 0x882F; } }
        public int GL_DRAW_BUFFER11                                  { get { return 0x8830; } }
        public int GL_DRAW_BUFFER12                                  { get { return 0x8831; } }
        public int GL_DRAW_BUFFER13                                  { get { return 0x8832; } }
        public int GL_DRAW_BUFFER14                                  { get { return 0x8833; } }
        public int GL_DRAW_BUFFER15                                  { get { return 0x8834; } }
        public int GL_MAX_FRAGMENT_UNIFORM_COMPONENTS                { get { return 0x8B49; } }
        public int GL_MAX_VERTEX_UNIFORM_COMPONENTS                  { get { return 0x8B4A; } }
        public int GL_SAMPLER_3D                                     { get { return 0x8B5F; } }
        public int GL_SAMPLER_2D_SHADOW                              { get { return 0x8B62; } }
        public int GL_FRAGMENT_SHADER_DERIVATIVE_HINT                { get { return 0x8B8B; } }
        public int GL_PIXEL_PACK_BUFFER                              { get { return 0x88EB; } }
        public int GL_PIXEL_UNPACK_BUFFER                            { get { return 0x88EC; } }
        public int GL_PIXEL_PACK_BUFFER_BINDING                      { get { return 0x88ED; } }
        public int GL_PIXEL_UNPACK_BUFFER_BINDING                    { get { return 0x88EF; } }
        public int GL_FLOAT_MAT2x3                                   { get { return 0x8B65; } }
        public int GL_FLOAT_MAT2x4                                   { get { return 0x8B66; } }
        public int GL_FLOAT_MAT3x2                                   { get { return 0x8B67; } }
        public int GL_FLOAT_MAT3x4                                   { get { return 0x8B68; } }
        public int GL_FLOAT_MAT4x2                                   { get { return 0x8B69; } }
        public int GL_FLOAT_MAT4x3                                   { get { return 0x8B6A; } }
        public int GL_SRGB                                           { get { return 0x8C40; } }
        public int GL_SRGB8                                          { get { return 0x8C41; } }
        public int GL_SRGB8_ALPHA8                                   { get { return 0x8C43; } }
        public int GL_COMPARE_REF_TO_TEXTURE                         { get { return 0x884E; } }
        public int GL_MAJOR_VERSION                                  { get { return 0x821B; } }
        public int GL_MINOR_VERSION                                  { get { return 0x821C; } }
        public int GL_NUM_EXTENSIONS                                 { get { return 0x821D; } }
        public int GL_RGBA32F                                        { get { return 0x8814; } }
        public int GL_RGB32F                                         { get { return 0x8815; } }
        public int GL_RGBA16F                                        { get { return 0x881A; } }
        public int GL_RGB16F                                         { get { return 0x881B; } }
        public int GL_VERTEX_ATTRIB_ARRAY_INTEGER                    { get { return 0x88FD; } }
        public int GL_MAX_ARRAY_TEXTURE_LAYERS                       { get { return 0x88FF; } }
        public int GL_MIN_PROGRAM_TEXEL_OFFSET                       { get { return 0x8904; } }
        public int GL_MAX_PROGRAM_TEXEL_OFFSET                       { get { return 0x8905; } }
        public int GL_MAX_VARYING_COMPONENTS                         { get { return 0x8B4B; } }
        public int GL_TEXTURE_2D_ARRAY                               { get { return 0x8C1A; } }
        public int GL_TEXTURE_BINDING_2D_ARRAY                       { get { return 0x8C1D; } }
        public int GL_R11F_G11F_B10F                                 { get { return 0x8C3A; } }
        public int GL_UNSIGNED_INT_10F_11F_11F_REV                   { get { return 0x8C3B; } }
        public int GL_RGB9_E5                                        { get { return 0x8C3D; } }
        public int GL_UNSIGNED_INT_5_9_9_9_REV                       { get { return 0x8C3E; } }
        public int GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH          { get { return 0x8C76; } }
        public int GL_TRANSFORM_FEEDBACK_BUFFER_MODE                 { get { return 0x8C7F; } }
        public int GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS     { get { return 0x8C80; } }
        public int GL_TRANSFORM_FEEDBACK_VARYINGS                    { get { return 0x8C83; } }
        public int GL_TRANSFORM_FEEDBACK_BUFFER_START                { get { return 0x8C84; } }
        public int GL_TRANSFORM_FEEDBACK_BUFFER_SIZE                 { get { return 0x8C85; } }
        public int GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN          { get { return 0x8C88; } }
        public int GL_RASTERIZER_DISCARD                             { get { return 0x8C89; } }
        public int GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS  { get { return 0x8C8A; } }
        public int GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS        { get { return 0x8C8B; } }
        public int GL_INTERLEAVED_ATTRIBS                            { get { return 0x8C8C; } }
        public int GL_SEPARATE_ATTRIBS                               { get { return 0x8C8D; } }
        public int GL_TRANSFORM_FEEDBACK_BUFFER                      { get { return 0x8C8E; } }
        public int GL_TRANSFORM_FEEDBACK_BUFFER_BINDING              { get { return 0x8C8F; } }
        public int GL_RGBA32UI                                       { get { return 0x8D70; } }
        public int GL_RGB32UI                                        { get { return 0x8D71; } }
        public int GL_RGBA16UI                                       { get { return 0x8D76; } }
        public int GL_RGB16UI                                        { get { return 0x8D77; } }
        public int GL_RGBA8UI                                        { get { return 0x8D7C; } }
        public int GL_RGB8UI                                         { get { return 0x8D7D; } }
        public int GL_RGBA32I                                        { get { return 0x8D82; } }
        public int GL_RGB32I                                         { get { return 0x8D83; } }
        public int GL_RGBA16I                                        { get { return 0x8D88; } }
        public int GL_RGB16I                                         { get { return 0x8D89; } }
        public int GL_RGBA8I                                         { get { return 0x8D8E; } }
        public int GL_RGB8I                                          { get { return 0x8D8F; } }
        public int GL_RED_INTEGER                                    { get { return 0x8D94; } }
        public int GL_RGB_INTEGER                                    { get { return 0x8D98; } }
        public int GL_RGBA_INTEGER                                   { get { return 0x8D99; } }
        public int GL_SAMPLER_2D_ARRAY                               { get { return 0x8DC1; } }
        public int GL_SAMPLER_2D_ARRAY_SHADOW                        { get { return 0x8DC4; } }
        public int GL_SAMPLER_CUBE_SHADOW                            { get { return 0x8DC5; } }
        public int GL_UNSIGNED_INT_VEC2                              { get { return 0x8DC6; } }
        public int GL_UNSIGNED_INT_VEC3                              { get { return 0x8DC7; } }
        public int GL_UNSIGNED_INT_VEC4                              { get { return 0x8DC8; } }
        public int GL_INT_SAMPLER_2D                                 { get { return 0x8DCA; } }
        public int GL_INT_SAMPLER_3D                                 { get { return 0x8DCB; } }
        public int GL_INT_SAMPLER_CUBE                               { get { return 0x8DCC; } }
        public int GL_INT_SAMPLER_2D_ARRAY                           { get { return 0x8DCF; } }
        public int GL_UNSIGNED_INT_SAMPLER_2D                        { get { return 0x8DD2; } }
        public int GL_UNSIGNED_INT_SAMPLER_3D                        { get { return 0x8DD3; } }
        public int GL_UNSIGNED_INT_SAMPLER_CUBE                      { get { return 0x8DD4; } }
        public int GL_UNSIGNED_INT_SAMPLER_2D_ARRAY                  { get { return 0x8DD7; } }
        public int GL_BUFFER_ACCESS_FLAGS                            { get { return 0x911F; } }
        public int GL_BUFFER_MAP_LENGTH                              { get { return 0x9120; } }
        public int GL_BUFFER_MAP_OFFSET                              { get { return 0x9121; } }
        public int GL_DEPTH_COMPONENT32F                             { get { return 0x8CAC; } }
        public int GL_DEPTH32F_STENCIL8                              { get { return 0x8CAD; } }
        public int GL_FLOAT_32_UNSIGNED_INT_24_8_REV                 { get { return 0x8DAD; } }
        public int GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING          { get { return 0x8210; } }
        public int GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE          { get { return 0x8211; } }
        public int GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE                { get { return 0x8212; } }
        public int GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE              { get { return 0x8213; } }
        public int GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE               { get { return 0x8214; } }
        public int GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE              { get { return 0x8215; } }
        public int GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE              { get { return 0x8216; } }
        public int GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE            { get { return 0x8217; } }
        public int GL_FRAMEBUFFER_DEFAULT                            { get { return 0x8218; } }
        public int GL_FRAMEBUFFER_UNDEFINED                          { get { return 0x8219; } }
        public int GL_DEPTH_STENCIL_ATTACHMENT                       { get { return 0x821A; } }
        public int GL_DEPTH_STENCIL                                  { get { return 0x84F9; } }
        public int GL_UNSIGNED_INT_24_8                              { get { return 0x84FA; } }
        public int GL_DEPTH24_STENCIL8                               { get { return 0x88F0; } }
        public int GL_UNSIGNED_NORMALIZED                            { get { return 0x8C17; } }
        public int GL_DRAW_FRAMEBUFFER_BINDING                       { get { return 0x8CA6; } }
        public int GL_READ_FRAMEBUFFER                               { get { return 0x8CA8; } }
        public int GL_DRAW_FRAMEBUFFER                               { get { return 0x8CA9; } }
        public int GL_READ_FRAMEBUFFER_BINDING                       { get { return 0x8CAA; } }
        public int GL_RENDERBUFFER_SAMPLES                           { get { return 0x8CAB; } }
        public int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER           { get { return 0x8CD4; } }
        public int GL_MAX_COLOR_ATTACHMENTS                          { get { return 0x8CDF; } }
        public int GL_COLOR_ATTACHMENT1                              { get { return 0x8CE1; } }
        public int GL_COLOR_ATTACHMENT2                              { get { return 0x8CE2; } }
        public int GL_COLOR_ATTACHMENT3                              { get { return 0x8CE3; } }
        public int GL_COLOR_ATTACHMENT4                              { get { return 0x8CE4; } }
        public int GL_COLOR_ATTACHMENT5                              { get { return 0x8CE5; } }
        public int GL_COLOR_ATTACHMENT6                              { get { return 0x8CE6; } }
        public int GL_COLOR_ATTACHMENT7                              { get { return 0x8CE7; } }
        public int GL_COLOR_ATTACHMENT8                              { get { return 0x8CE8; } }
        public int GL_COLOR_ATTACHMENT9                              { get { return 0x8CE9; } }
        public int GL_COLOR_ATTACHMENT10                             { get { return 0x8CEA; } }
        public int GL_COLOR_ATTACHMENT11                             { get { return 0x8CEB; } }
        public int GL_COLOR_ATTACHMENT12                             { get { return 0x8CEC; } }
        public int GL_COLOR_ATTACHMENT13                             { get { return 0x8CED; } }
        public int GL_COLOR_ATTACHMENT14                             { get { return 0x8CEE; } }
        public int GL_COLOR_ATTACHMENT15                             { get { return 0x8CEF; } }
        public int GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE             { get { return 0x8D56; } }
        public int GL_MAX_SAMPLES                                    { get { return 0x8D57; } }
        public int GL_HALF_FLOAT                                     { get { return 0x140B; } }
        public int GL_MAP_READ_BIT                                   { get { return 0x0001; } }
        public int GL_MAP_WRITE_BIT                                  { get { return 0x0002; } }
        public int GL_MAP_INVALIDATE_RANGE_BIT                       { get { return 0x0004; } }
        public int GL_MAP_INVALIDATE_BUFFER_BIT                      { get { return 0x0008; } }
        public int GL_MAP_FLUSH_EXPLICIT_BIT                         { get { return 0x0010; } }
        public int GL_MAP_UNSYNCHRONIZED_BIT                         { get { return 0x0020; } }
        public int GL_RG                                             { get { return 0x8227; } }
        public int GL_RG_INTEGER                                     { get { return 0x8228; } }
        public int GL_R8                                             { get { return 0x8229; } }
        public int GL_RG8                                            { get { return 0x822B; } }
        public int GL_R16F                                           { get { return 0x822D; } }
        public int GL_R32F                                           { get { return 0x822E; } }
        public int GL_RG16F                                          { get { return 0x822F; } }
        public int GL_RG32F                                          { get { return 0x8230; } }
        public int GL_R8I                                            { get { return 0x8231; } }
        public int GL_R8UI                                           { get { return 0x8232; } }
        public int GL_R16I                                           { get { return 0x8233; } }
        public int GL_R16UI                                          { get { return 0x8234; } }
        public int GL_R32I                                           { get { return 0x8235; } }
        public int GL_R32UI                                          { get { return 0x8236; } }
        public int GL_RG8I                                           { get { return 0x8237; } }
        public int GL_RG8UI                                          { get { return 0x8238; } }
        public int GL_RG16I                                          { get { return 0x8239; } }
        public int GL_RG16UI                                         { get { return 0x823A; } }
        public int GL_RG32I                                          { get { return 0x823B; } }
        public int GL_RG32UI                                         { get { return 0x823C; } }
        public int GL_VERTEX_ARRAY_BINDING                           { get { return 0x85B5; } }
        public int GL_R8_SNORM                                       { get { return 0x8F94; } }
        public int GL_RG8_SNORM                                      { get { return 0x8F95; } }
        public int GL_RGB8_SNORM                                     { get { return 0x8F96; } }
        public int GL_RGBA8_SNORM                                    { get { return 0x8F97; } }
        public int GL_SIGNED_NORMALIZED                              { get { return 0x8F9C; } }
        public int GL_PRIMITIVE_RESTART_FIXED_INDEX                  { get { return 0x8D69; } }
        public int GL_COPY_READ_BUFFER                               { get { return 0x8F36; } }
        public int GL_COPY_WRITE_BUFFER                              { get { return 0x8F37; } }
        public int GL_COPY_READ_BUFFER_BINDING                       { get { return 0x8F36; } }
        public int GL_COPY_WRITE_BUFFER_BINDING                      { get { return 0x8F37; } }
        public int GL_UNIFORM_BUFFER                                 { get { return 0x8A11; } }
        public int GL_UNIFORM_BUFFER_BINDING                         { get { return 0x8A28; } }
        public int GL_UNIFORM_BUFFER_START                           { get { return 0x8A29; } }
        public int GL_UNIFORM_BUFFER_SIZE                            { get { return 0x8A2A; } }
        public int GL_MAX_VERTEX_UNIFORM_BLOCKS                      { get { return 0x8A2B; } }
        public int GL_MAX_FRAGMENT_UNIFORM_BLOCKS                    { get { return 0x8A2D; } }
        public int GL_MAX_COMBINED_UNIFORM_BLOCKS                    { get { return 0x8A2E; } }
        public int GL_MAX_UNIFORM_BUFFER_BINDINGS                    { get { return 0x8A2F; } }
        public int GL_MAX_UNIFORM_BLOCK_SIZE                         { get { return 0x8A30; } }
        public int GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS         { get { return 0x8A31; } }
        public int GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS       { get { return 0x8A33; } }
        public int GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT                { get { return 0x8A34; } }
        public int GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH           { get { return 0x8A35; } }
        public int GL_ACTIVE_UNIFORM_BLOCKS                          { get { return 0x8A36; } }
        public int GL_UNIFORM_TYPE                                   { get { return 0x8A37; } }
        public int GL_UNIFORM_SIZE                                   { get { return 0x8A38; } }
        public int GL_UNIFORM_NAME_LENGTH                            { get { return 0x8A39; } }
        public int GL_UNIFORM_BLOCK_INDEX                            { get { return 0x8A3A; } }
        public int GL_UNIFORM_OFFSET                                 { get { return 0x8A3B; } }
        public int GL_UNIFORM_ARRAY_STRIDE                           { get { return 0x8A3C; } }
        public int GL_UNIFORM_MATRIX_STRIDE                          { get { return 0x8A3D; } }
        public int GL_UNIFORM_IS_ROW_MAJOR                           { get { return 0x8A3E; } }
        public int GL_UNIFORM_BLOCK_BINDING                          { get { return 0x8A3F; } }
        public int GL_UNIFORM_BLOCK_DATA_SIZE                        { get { return 0x8A40; } }
        public int GL_UNIFORM_BLOCK_NAME_LENGTH                      { get { return 0x8A41; } }
        public int GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS                  { get { return 0x8A42; } }
        public int GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES           { get { return 0x8A43; } }
        public int GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER      { get { return 0x8A44; } }
        public int GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER    { get { return 0x8A46; } }
        public int GL_INVALID_INDEX                                  { get { return unchecked((int)0xFFFFFFFF); } }
        public int GL_MAX_VERTEX_OUTPUT_COMPONENTS                   { get { return 0x9122; } }
        public int GL_MAX_FRAGMENT_INPUT_COMPONENTS                  { get { return 0x9125; } }
        public int GL_MAX_SERVER_WAIT_TIMEOUT                        { get { return 0x9111; } }
        public int GL_OBJECT_TYPE                                    { get { return 0x9112; } }
        public int GL_SYNC_CONDITION                                 { get { return 0x9113; } }
        public int GL_SYNC_STATUS                                    { get { return 0x9114; } }
        public int GL_SYNC_FLAGS                                     { get { return 0x9115; } }
        public int GL_SYNC_FENCE                                     { get { return 0x9116; } }
        public int GL_SYNC_GPU_COMMANDS_COMPLETE                     { get { return 0x9117; } }
        public int GL_UNSIGNALED                                     { get { return 0x9118; } }
        public int GL_SIGNALED                                       { get { return 0x9119; } }
        public int GL_ALREADY_SIGNALED                               { get { return 0x911A; } }
        public int GL_TIMEOUT_EXPIRED                                { get { return 0x911B; } }
        public int GL_CONDITION_SATISFIED                            { get { return 0x911C; } }
        public int GL_WAIT_FAILED                                    { get { return 0x911D; } }
        public int GL_SYNC_FLUSH_COMMANDS_BIT                        { get { return 0x00000001; } }
        public int GL_TIMEOUT_IGNORED                                { get { return unchecked((int)0xFFFFFFFFFFFFFFFF); } }
        public int GL_VERTEX_ATTRIB_ARRAY_DIVISOR                    { get { return 0x88FE; } }
        public int GL_ANY_SAMPLES_PASSED                             { get { return 0x8C2F; } }
        public int GL_ANY_SAMPLES_PASSED_CONSERVATIVE                { get { return 0x8D6A; } }
        public int GL_SAMPLER_BINDING                                { get { return 0x8919; } }
        public int GL_RGB10_A2UI                                     { get { return 0x906F; } }
        public int GL_TEXTURE_SWIZZLE_R                              { get { return 0x8E42; } }
        public int GL_TEXTURE_SWIZZLE_G                              { get { return 0x8E43; } }
        public int GL_TEXTURE_SWIZZLE_B                              { get { return 0x8E44; } }
        public int GL_TEXTURE_SWIZZLE_A                              { get { return 0x8E45; } }
        public int GL_GREEN                                          { get { return 0x1904; } }
        public int GL_BLUE                                           { get { return 0x1905; } }
        public int GL_INT_2_10_10_10_REV                             { get { return 0x8D9F; } }
        public int GL_TRANSFORM_FEEDBACK                             { get { return 0x8E22; } }
        public int GL_TRANSFORM_FEEDBACK_PAUSED                      { get { return 0x8E23; } }
        public int GL_TRANSFORM_FEEDBACK_ACTIVE                      { get { return 0x8E24; } }
        public int GL_TRANSFORM_FEEDBACK_BINDING                     { get { return 0x8E25; } }
        public int GL_PROGRAM_BINARY_RETRIEVABLE_HINT                { get { return 0x8257; } }
        public int GL_PROGRAM_BINARY_LENGTH                          { get { return 0x8741; } }
        public int GL_NUM_PROGRAM_BINARY_FORMATS                     { get { return 0x87FE; } }
        public int GL_PROGRAM_BINARY_FORMATS                         { get { return 0x87FF; } }
        public int GL_COMPRESSED_R11_EAC                             { get { return 0x9270; } }
        public int GL_COMPRESSED_SIGNED_R11_EAC                      { get { return 0x9271; } }
        public int GL_COMPRESSED_RG11_EAC                            { get { return 0x9272; } }
        public int GL_COMPRESSED_SIGNED_RG11_EAC                     { get { return 0x9273; } }
        public int GL_COMPRESSED_RGB8_ETC2                           { get { return 0x9274; } }
        public int GL_COMPRESSED_SRGB8_ETC2                          { get { return 0x9275; } }
        public int GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2       { get { return 0x9276; } }
        public int GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2      { get { return 0x9277; } }
        public int GL_COMPRESSED_RGBA8_ETC2_EAC                      { get { return 0x9278; } }
        public int GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC               { get { return 0x9279; } }
        public int GL_TEXTURE_IMMUTABLE_FORMAT                       { get { return 0x912F; } }
        public int GL_MAX_ELEMENT_INDEX                              { get { return 0x8D6B; } }
        public int GL_NUM_SAMPLE_COUNTS                              { get { return 0x9380; } }
        public int GL_TEXTURE_IMMUTABLE_LEVELS { get { return 0x82DF; } }

        public void ReadBuffer (int mode)
        {
            gl30.ReadBuffer(mode);
        }

        public void DrawRangeElements<T> (int mode, int start, int end, int count, int type, T[]indices)
            where T: struct
        {
            gl30.DrawRangeElements<T>(mode, start, end, count, type, indices);
        }

        public void TexImage3D (int target, int level, int internalformat, int width, int height, int depth, int border, int format, int type, IntPtr pixels)
        {
            gl30.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
        }
        
        public void TexSubImage3D (int target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int format, int type, IntPtr pixels)
        {
            gl30.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        }
        
        public void CopyTexSubImage3D (int target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
        {
            gl30.CopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);
        }

        public void CompressedTexImage3D(int target, int level, int internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data)
        {
            gl30.CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
        }

        public void CompressedTexSubImage3D(int target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int format, int imageSize, IntPtr data)
        {
            gl30.CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
        }

        public void GenQueries(int n, int[] ids)
        {
            gl30.GenQueries(n, ids);
        }

        public void DeleteQueries(int n, int[] ids)
        {
            gl30.DeleteQueries(n, ids);
        }

        public bool IsQuery(int id)
        {
            return gl30.IsQuery(id);
        }

        public void BeginQuery(int target, int id)
        {
            gl30.BeginQuery(target, id);
        }

        public void EndQuery(int target)
        {
            gl30.EndQuery(target);
        }

        public void GetQuery(int target, int pname, int[] parameters)
        {
            gl30.GetQuery(target, pname, parameters);
        }

        public void GetQueryObject(int id, int pname, int[] parameters)
        {
            gl30.GetQueryObject(id, pname, parameters);
        }

        public bool UnmapBuffer(int target)
        {
            return gl30.UnmapBuffer(target);
        }

        public void GetBufferPointer<T>(int target, int pname, T[] parameters)
            where T: struct
        {
            gl30.GetBufferPointer<T>(target, pname, parameters);
        }

        public void DrawBuffers(int n, int[] bufs)
        {
            gl30.DrawBuffers(n, bufs);
        }

        public void UniformMatrix2x3(int location, int count, bool transpose, float[] value)
        {
            gl30.UniformMatrix2x3(location, count, transpose, value);
        }

        public void UniformMatrix3x2(int location, int count, bool transpose, float[] value)
        {
            gl30.UniformMatrix3x2(location, count, transpose, value);
        }

        public void UniformMatrix2x4(int location, int count, bool transpose, float[] value)
        {
            gl30.UniformMatrix2x4(location, count, transpose, value);
        }

        public void UniformMatrix4x2(int location, int count, bool transpose, float[] value)
        {
            gl30.UniformMatrix4x2(location, count, transpose, value);
        }

        public void UniformMatrix3x4(int location, int count, bool transpose, float[] value)
        {
            gl30.UniformMatrix3x4(location, count, transpose, value);
        }

        public void UniformMatrix4x3(int location, int count, bool transpose, float[] value)
        {
            gl30.UniformMatrix4x3(location, count, transpose, value);
        }

        public void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, int mask, int filter)
        {
            gl30.BlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
        }

        public void RenderbufferStorageMultisample(int target, int samples, int internalformat, int width, int height)
        {
            gl30.RenderbufferStorageMultisample(target, samples, internalformat, width, height);
        }

        public void FramebufferTextureLayer(int target, int attachment, int texture, int level, int layer)
        {
            gl30.FramebufferTextureLayer(target, attachment, texture, level, layer);
        }

        public IntPtr MapBufferRange(int target, int offset, int length, int access)
        {
            return gl30.MapBufferRange(target, offset, length, access);
        }

        public void FlushMappedBufferRange(int target, int offset, int length)
        {
            gl30.FlushMappedBufferRange(target, offset, length);
        }

        public void BindVertexArray(int array)
        {
            gl30.BindVertexArray(array);
        }

        /*public void DeleteVertexArrays (int n, int [] arrays);
        public void GenVertexArrays (int n, int [] arrays);
        public void IsVertexArray (int array);
        public void GetIntegeri_v (int target, int index, int [] data);
        public void BeginTransformFeedback (int primitiveMode);
        public void EndTransformFeedback ();
        public void BindBufferRange (int target, int index, int buffer, IntPtr offset, IntPtr size);
        public void BindBufferBase (int target, int index, int buffer);
        public void TransformFeedbackVaryings (int program, int count, string varyings, int bufferMode);
        public void GetTransformFeedbackVarying (int program, int index, int bufSize, int [] length, int [] size, int [] type, string name);
        public void VertexAttribIPointer (int index, int size, int type, int stride, IntPtr pointer);
        public void GetVertexAttribIiv (int index, int pname, int [] parameters);
        public void GetVertexAttribIuiv (int index, int pname, int [] parameters);
        public void VertexAttribI4i (int index, int x, int y, int z, int w);
        public void VertexAttribI4ui (int index, int x, int y, int z, int w);
        public void VertexAttribI4iv (int index, int [] v);
        public void VertexAttribI4uiv (int index, int [] v);
        public void GetUniformuiv (int program, int location, int [] parameters);
        public int glGetFragDataLocation (int program, string name);
        public void Uniform1ui (int location, int v0);
        public void Uniform2ui (int location, int v0, int v1);
        public void Uniform3ui (int location, int v0, int v1, int v2);
        public void Uniform4ui (int location, int v0, int v1, int v2, int v3);
        public void Uniform1uiv (int location, int count, int [] value);
        public void Uniform2uiv (int location, int count, int [] value);
        public void Uniform3uiv (int location, int count, int [] value);
        public void Uniform4uiv (int location, int count, int [] value);
        public void ClearBufferiv (int buffer, int drawbuffer, int [] value);
        public void ClearBufferuiv (int buffer, int drawbuffer, int [] value);
        public void ClearBufferfv (int buffer, int drawbuffer, float [] value);
        public void ClearBufferfi (int buffer, int drawbuffer, float depth, int stencil);*/

        public string GetString(int name, int index)
        {
            return gl30.GetString(name, index);
        }

       /* public void CopyBufferSubData (int readTarget, int writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
        public void GetUniformIndices (int program, int uniformCount, string [] uniformNames, int [] uniformIndices);
        public void GetActiveUniformsiv (int program, int uniformCount, int [] uniformIndices, int pname, int [] parameters);
        public int glGetUniformBlockIndex (int program, string uniformBlockName);
        public void GetActiveUniformBlockiv (int program, int uniformBlockIndex, int pname, int [] parameters);
        public void GetActiveUniformBlockName (int program, int uniformBlockIndex, int bufSize, int [] length, string uniformBlockName);
        public void UniformBlockBinding (int program, int uniformBlockIndex, int uniformBlockBinding);
        public void DrawArraysInstanced (int mode, int first, int count, int instancecount);
        public void DrawElementsInstanced (int mode, int count, int type, IntPtr indices, int instancecount);
        public int glFenceSync (int condition, int flags);*/
        
        public bool IsSync(IntPtr sync)
        {
            if (gl32 == null)
                throw new NotSupportedException("IsSync requires an OpenGL 3.2 capable device.");
            return gl32.IsSync(sync);
        }

        public void DeleteSync(IntPtr sync)
        {
            if (gl32 == null)
                throw new NotSupportedException("DeleteSync requires an OpenGL 3.2 capable device.");
            gl32.DeleteSync(sync);
        }

       /* public int  ClientWaitSync (int sync, int flags, long timeout);
        public void WaitSync (int sync, int flags, long timeout);
        public void GetInteger64v (int pname, long [] parameters);
        public void GetSynciv (int sync, int pname, int bufSize, int [] length, int [] values);
        public void GetInteger64i_v (int target, int index, long [] data);
        public void GetBufferParameteri64v (int target, int pname, long [] parameters);
        public void GenSamplers (int count, int [] samplers);
        public void DeleteSamplers (int count, int [] samplers);*/

        public bool IsSampler(int sampler)
        {
            if (gl33 == null)
                throw new NotSupportedException("IsSampler requires an OpenGL 3.3 capable device.");
            return gl33.IsSampler(sampler);
        }

      /*  public void BindSampler (int unit, int sampler);
        public void SamplerParameteri (int sampler, int pname, int param);
        public void SamplerParameteriv (int sampler, int pname, int [] param);
        public void SamplerParameterf (int sampler, int pname, float param);
        public void SamplerParameterfv (int sampler, int pname, float [] param);
        public void GetSamplerParameteriv (int sampler, int pname, int [] parameters);
        public void GetSamplerParameterfv (int sampler, int pname, float [] parameters);
        public void VertexAttribDivisor (int index, int divisor);
        public void BindTransformFeedback (int target, int id);
        public void DeleteTransformFeedbacks (int n, int [] ids);
        public void GenTransformFeedbacks (int n, int [] ids);
        public void IsTransformFeedback (int id);
        public void PauseTransformFeedback ();
        public void ResumeTransformFeedback ();
        public void GetProgramBinary (int program, int bufSize, int [] length, int [] binaryFormat, IntPtr binary);
        public void ProgramBinary (int program, int binaryFormat, IntPtr binary, int length);
        public void ProgramParameteri (int program, int pname, int value);
        public void InvalidateFramebuffer (int target, int numAttachments, int [] attachments);
        public void InvalidateSubFramebuffer (int target, int numAttachments, int [] attachments, int x, int y, int width, int height);
        public void TexStorage2D (int target, int levels, int internalformat, int width, int height);
        public void TexStorage3D (int target, int levels, int internalformat, int width, int height, int depth);
        public void GetInternalformativ (int target, int internalformat, int pname, int bufSize, int [] parameters);*/
    }
}
