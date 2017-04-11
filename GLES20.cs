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
    public class GLES20
        : GLBase
    {
        protected GL30 gl30;
        protected GL41 gl41;


        public GLES20(Context context)
            : base(context)
        {
            this.gl30 = new GL30(context);

            try
            {
                gl41 = new GL41(context);
            }
            catch (Exception e)
            {

            }
        }

        /* ClearBufferMask */
        public int  GL_DEPTH_BUFFER_BIT                               { get { return 0x00000100; } }
        public int  GL_STENCIL_BUFFER_BIT                             { get { return 0x00000400; } }
        public int  GL_COLOR_BUFFER_BIT                               { get { return 0x00004000; } }

        /* Boolean */
        public int  GL_FALSE                                         { get { return 0; } }
        public int  GL_TRUE                                          { get { return 1; } }

        /* BeginMode */
        public int  GL_POINTS                                         { get { return 0x0000; } }
        public int  GL_LINES                                          { get { return 0x0001; } }
        public int  GL_LINE_LOOP                                      { get { return 0x0002; } }
        public int  GL_LINE_STRIP                                     { get { return 0x0003; } }
        public int  GL_TRIANGLES                                      { get { return 0x0004; } }
        public int  GL_TRIANGLE_STRIP                                 { get { return 0x0005; } }
        public int  GL_TRIANGLE_FAN                                   { get { return 0x0006; } }

        /* BlendingFactorDest */
        public int  GL_ZERO                                          { get { return 0; } }
        public int  GL_ONE                                           { get { return 1; } }
        public int  GL_SRC_COLOR                                      { get { return 0x0300; } }
        public int  GL_ONE_MINUS_SRC_COLOR                            { get { return 0x0301; } }
        public int  GL_SRC_ALPHA                                      { get { return 0x0302; } }
        public int  GL_ONE_MINUS_SRC_ALPHA                            { get { return 0x0303; } }
        public int  GL_DST_ALPHA                                      { get { return 0x0304; } }
        public int  GL_ONE_MINUS_DST_ALPHA                            { get { return 0x0305; } }

        /* BlendingFactorSrc */
        /*      GL_ZERO */
        /*      GL_ONE */
        public int  GL_DST_COLOR                                      { get { return 0x0306; } }
        public int  GL_ONE_MINUS_DST_COLOR                            { get { return 0x0307; } }
        public int  GL_SRC_ALPHA_SATURATE                             { get { return 0x0308; } }
        /*      GL_SRC_ALPHA */
        /*      GL_ONE_MINUS_SRC_ALPHA */
        /*      GL_DST_ALPHA */
        /*      GL_ONE_MINUS_DST_ALPHA */

        /* BlendEquationSeparate */
        public int  GL_FUNC_ADD                                       { get { return 0x8006; } }
        public int  GL_BLEND_EQUATION                                 { get { return 0x8009; } }
        public int  GL_BLEND_EQUATION_RGB                             { get { return 0x8009; } }    /* same as BLEND_EQUATION */
        public int  GL_BLEND_EQUATION_ALPHA                           { get { return 0x883D; } }

        /* BlendSubtract */
        public int  GL_FUNC_SUBTRACT                                  { get { return 0x800A; } }
        public int  GL_FUNC_REVERSE_SUBTRACT                          { get { return 0x800B; } }

        /* Separate Blend Functions */
        public int  GL_BLEND_DST_RGB                                  { get { return 0x80C8; } }
        public int  GL_BLEND_SRC_RGB                                  { get { return 0x80C9; } }
        public int  GL_BLEND_DST_ALPHA                                { get { return 0x80CA; } }
        public int  GL_BLEND_SRC_ALPHA                                { get { return 0x80CB; } }
        public int  GL_CONSTANT_COLOR                                 { get { return 0x8001; } }
        public int  GL_ONE_MINUS_CONSTANT_COLOR                       { get { return 0x8002; } }
        public int  GL_CONSTANT_ALPHA                                 { get { return 0x8003; } }
        public int  GL_ONE_MINUS_CONSTANT_ALPHA                       { get { return 0x8004; } }
        public int  GL_BLEND_COLOR                                    { get { return 0x8005; } }

        /* Buffer Objects */
        public int  GL_ARRAY_BUFFER                                   { get { return 0x8892; } }
        public int  GL_ELEMENT_ARRAY_BUFFER                           { get { return 0x8893; } }
        public int  GL_ARRAY_BUFFER_BINDING                           { get { return 0x8894; } }
        public int  GL_ELEMENT_ARRAY_BUFFER_BINDING                   { get { return 0x8895; } }

        public int  GL_STREAM_DRAW                                    { get { return 0x88E0; } }
        public int  GL_STATIC_DRAW                                    { get { return 0x88E4; } }
        public int  GL_DYNAMIC_DRAW                                   { get { return 0x88E8; } }

        public int  GL_BUFFER_SIZE                                    { get { return 0x8764; } }
        public int  GL_BUFFER_USAGE                                   { get { return 0x8765; } }

        public int  GL_CURRENT_VERTEX_ATTRIB                          { get { return 0x8626; } }

        /* CullFaceMode */
        public int  GL_FRONT                                          { get { return 0x0404; } }
        public int  GL_BACK                                           { get { return 0x0405; } }
        public int  GL_FRONT_AND_BACK                                 { get { return 0x0408; } }

        /* DepthFunction */
        /*      GL_NEVER */
        /*      GL_LESS */
        /*      GL_EQUAL */
        /*      GL_LEQUAL */
        /*      GL_GREATER */
        /*      GL_NOTEQUAL */
        /*      GL_GEQUAL */
        /*      GL_ALWAYS */

        /* EnableCap */
        public int  GL_TEXTURE_2D                                     { get { return 0x0DE1; } }
        public int  GL_CULL_FACE                                      { get { return 0x0B44; } }
        public int  GL_BLEND                                          { get { return 0x0BE2; } }
        public int  GL_DITHER                                         { get { return 0x0BD0; } }
        public int  GL_STENCIL_TEST                                   { get { return 0x0B90; } }
        public int  GL_DEPTH_TEST                                     { get { return 0x0B71; } }
        public int  GL_SCISSOR_TEST                                   { get { return 0x0C11; } }
        public int  GL_POLYGON_OFFSET_FILL                            { get { return 0x8037; } }
        public int  GL_SAMPLE_ALPHA_TO_COVERAGE                       { get { return 0x809E; } }
        public int  GL_SAMPLE_COVERAGE                                { get { return 0x80A0; } }

        /* ErrorCode */
        public int GL_NO_ERROR { get { return 0; } }
        public int  GL_INVALID_ENUM                                   { get { return 0x0500; } }
        public int  GL_INVALID_VALUE                                  { get { return 0x0501; } }
        public int  GL_INVALID_OPERATION                              { get { return 0x0502; } }
        public int  GL_OUT_OF_MEMORY                                  { get { return 0x0505; } }

        /* FrontFaceDirection */
        public int  GL_CW                                             { get { return 0x0900; } }
        public int  GL_CCW                                            { get { return 0x0901; } }

        /* GetPName */
        public int  GL_LINE_WIDTH                                     { get { return 0x0B21; } }
        public int  GL_ALIASED_POINT_SIZE_RANGE                       { get { return 0x846D; } }
        public int  GL_ALIASED_LINE_WIDTH_RANGE                       { get { return 0x846E; } }
        public int  GL_CULL_FACE_MODE                                 { get { return 0x0B45; } }
        public int  GL_FRONT_FACE                                     { get { return 0x0B46; } }
        public int  GL_DEPTH_RANGE                                    { get { return 0x0B70; } }
        public int  GL_DEPTH_WRITEMASK                                { get { return 0x0B72; } }
        public int  GL_DEPTH_CLEAR_VALUE                              { get { return 0x0B73; } }
        public int  GL_DEPTH_FUNC                                     { get { return 0x0B74; } }
        public int  GL_STENCIL_CLEAR_VALUE                            { get { return 0x0B91; } }
        public int  GL_STENCIL_FUNC                                   { get { return 0x0B92; } }
        public int  GL_STENCIL_FAIL                                   { get { return 0x0B94; } }
        public int  GL_STENCIL_PASS_DEPTH_FAIL                        { get { return 0x0B95; } }
        public int  GL_STENCIL_PASS_DEPTH_PASS                        { get { return 0x0B96; } }
        public int  GL_STENCIL_REF                                    { get { return 0x0B97; } }
        public int  GL_STENCIL_VALUE_MASK                             { get { return 0x0B93; } }
        public int  GL_STENCIL_WRITEMASK                              { get { return 0x0B98; } }
        public int  GL_STENCIL_BACK_FUNC                              { get { return 0x8800; } }
        public int  GL_STENCIL_BACK_FAIL                              { get { return 0x8801; } }
        public int  GL_STENCIL_BACK_PASS_DEPTH_FAIL                   { get { return 0x8802; } }
        public int  GL_STENCIL_BACK_PASS_DEPTH_PASS                   { get { return 0x8803; } }
        public int  GL_STENCIL_BACK_REF                               { get { return 0x8CA3; } }
        public int  GL_STENCIL_BACK_VALUE_MASK                        { get { return 0x8CA4; } }
        public int  GL_STENCIL_BACK_WRITEMASK                         { get { return 0x8CA5; } }
        public int  GL_VIEWPORT                                       { get { return 0x0BA2; } }
        public int  GL_SCISSOR_BOX                                    { get { return 0x0C10; } }
        /*      GL_SCISSOR_TEST */
        public int  GL_COLOR_CLEAR_VALUE                              { get { return 0x0C22; } }
        public int  GL_COLOR_WRITEMASK                                { get { return 0x0C23; } }
        public int  GL_UNPACK_ALIGNMENT                               { get { return 0x0CF5; } }
        public int  GL_PACK_ALIGNMENT                                 { get { return 0x0D05; } }
        public int  GL_MAX_TEXTURE_SIZE                               { get { return 0x0D33; } }
        public int  GL_MAX_VIEWPORT_DIMS                              { get { return 0x0D3A; } }
        public int  GL_SUBPIXEL_BITS                                  { get { return 0x0D50; } }
        public int  GL_RED_BITS                                       { get { return 0x0D52; } }
        public int  GL_GREEN_BITS                                     { get { return 0x0D53; } }
        public int  GL_BLUE_BITS                                      { get { return 0x0D54; } }
        public int  GL_ALPHA_BITS                                     { get { return 0x0D55; } }
        public int  GL_DEPTH_BITS                                     { get { return 0x0D56; } }
        public int  GL_STENCIL_BITS                                   { get { return 0x0D57; } }
        public int  GL_POLYGON_OFFSET_UNITS                           { get { return 0x2A00; } }
        /*      GL_POLYGON_OFFSET_FILL */
        public int  GL_POLYGON_OFFSET_FACTOR                          { get { return 0x8038; } }
        public int  GL_TEXTURE_BINDING_2D                             { get { return 0x8069; } }
        public int  GL_SAMPLE_BUFFERS                                 { get { return 0x80A8; } }
        public int  GL_SAMPLES                                        { get { return 0x80A9; } }
        public int  GL_SAMPLE_COVERAGE_VALUE                          { get { return 0x80AA; } }
        public int  GL_SAMPLE_COVERAGE_INVERT                         { get { return 0x80AB; } }

        /* GetTextureParameter */
        /*      GL_TEXTURE_MAG_FILTER */
        /*      GL_TEXTURE_MIN_FILTER */
        /*      GL_TEXTURE_WRAP_S */
        /*      GL_TEXTURE_WRAP_T */

        public int  GL_NUM_COMPRESSED_TEXTURE_FORMATS                 { get { return 0x86A2; } }
        public int  GL_COMPRESSED_TEXTURE_FORMATS                     { get { return 0x86A3; } }

        /* HintMode */
        public int  GL_DONT_CARE                                      { get { return 0x1100; } }
        public int  GL_FASTEST                                        { get { return 0x1101; } }
        public int  GL_NICEST                                         { get { return 0x1102; } }

        /* HintTarget */
        public int  GL_GENERATE_MIPMAP_HINT                           { get { return 0x8192; } }

        /* DataType */
        public int  GL_BYTE                                           { get { return 0x1400; } }
        public int  GL_UNSIGNED_BYTE                                  { get { return 0x1401; } }
        public int  GL_SHORT                                          { get { return 0x1402; } }
        public int  GL_UNSIGNED_SHORT                                 { get { return 0x1403; } }
        public int  GL_INT                                            { get { return 0x1404; } }
        public int  GL_UNSIGNED_INT                                   { get { return 0x1405; } }
        public int  GL_FLOAT                                          { get { return 0x1406; } }
        public int  GL_FIXED                                          { get { return 0x140C; } }

        /* PixelFormat */
        public int  GL_DEPTH_COMPONENT                                { get { return 0x1902; } }
        public int  GL_ALPHA                                          { get { return 0x1906; } }
        public int  GL_RGB                                            { get { return 0x1907; } }
        public int  GL_RGBA                                           { get { return 0x1908; } }
        public int  GL_LUMINANCE                                      { get { return 0x1909; } }
        public int  GL_LUMINANCE_ALPHA                                { get { return 0x190A; } }

        /* PixelType */
        /*      GL_UNSIGNED_BYTE */
        public int  GL_UNSIGNED_SHORT_4_4_4_4                         { get { return 0x8033; } }
        public int  GL_UNSIGNED_SHORT_5_5_5_1                         { get { return 0x8034; } }
        public int  GL_UNSIGNED_SHORT_5_6_5                           { get { return 0x8363; } }

        /* Shaders */
        public int  GL_FRAGMENT_SHADER                                { get { return 0x8B30; } }
        public int  GL_VERTEX_SHADER                                  { get { return 0x8B31; } }
        public int  GL_MAX_VERTEX_ATTRIBS                             { get { return 0x8869; } }
        public int  GL_MAX_VERTEX_UNIFORM_VECTORS                     { get { return 0x8DFB; } }
        public int  GL_MAX_VARYING_VECTORS                            { get { return 0x8DFC; } }
        public int  GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS               { get { return 0x8B4D; } }
        public int  GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS                 { get { return 0x8B4C; } }
        public int  GL_MAX_TEXTURE_IMAGE_UNITS                        { get { return 0x8872; } }
        public int  GL_MAX_FRAGMENT_UNIFORM_VECTORS                   { get { return 0x8DFD; } }
        public int  GL_SHADER_TYPE                                    { get { return 0x8B4F; } }
        public int  GL_DELETE_STATUS                                  { get { return 0x8B80; } }
        public int  GL_LINK_STATUS                                    { get { return 0x8B82; } }
        public int  GL_VALIDATE_STATUS                                { get { return 0x8B83; } }
        public int  GL_ATTACHED_SHADERS                               { get { return 0x8B85; } }
        public int  GL_ACTIVE_UNIFORMS                                { get { return 0x8B86; } }
        public int  GL_ACTIVE_UNIFORM_MAX_LENGTH                      { get { return 0x8B87; } }
        public int  GL_ACTIVE_ATTRIBUTES                              { get { return 0x8B89; } }
        public int  GL_ACTIVE_ATTRIBUTE_MAX_LENGTH                    { get { return 0x8B8A; } }
        public int  GL_SHADING_LANGUAGE_VERSION                       { get { return 0x8B8C; } }
        public int  GL_CURRENT_PROGRAM                                { get { return 0x8B8D; } }

        /* StencilFunction */
        public int  GL_NEVER                                          { get { return 0x0200; } }
        public int  GL_LESS                                           { get { return 0x0201; } }
        public int  GL_EQUAL                                          { get { return 0x0202; } }
        public int  GL_LEQUAL                                         { get { return 0x0203; } }
        public int  GL_GREATER                                        { get { return 0x0204; } }
        public int  GL_NOTEQUAL                                       { get { return 0x0205; } }
        public int  GL_GEQUAL                                         { get { return 0x0206; } }
        public int  GL_ALWAYS                                         { get { return 0x0207; } }

        /* StencilOp */
        /*      GL_ZERO */
        public int  GL_KEEP                                           { get { return 0x1E00; } }
        public int  GL_REPLACE                                        { get { return 0x1E01; } }
        public int  GL_INCR                                           { get { return 0x1E02; } }
        public int  GL_DECR                                           { get { return 0x1E03; } }
        public int  GL_INVERT                                         { get { return 0x150A; } }
        public int  GL_INCR_WRAP                                      { get { return 0x8507; } }
        public int  GL_DECR_WRAP                                      { get { return 0x8508; } }

        /* StringName */
        public int  GL_VENDOR                                         { get { return 0x1F00; } }
        public int  GL_RENDERER                                       { get { return 0x1F01; } }
        public int  GL_VERSION                                        { get { return 0x1F02; } }
        public int  GL_EXTENSIONS                                     { get { return 0x1F03; } }

        /* TextureMagFilter */
        public int  GL_NEAREST                                        { get { return 0x2600; } }
        public int  GL_LINEAR                                         { get { return 0x2601; } }

        /* TextureMinFilter */
        /*      GL_NEAREST */
        /*      GL_LINEAR */
        public int  GL_NEAREST_MIPMAP_NEAREST                         { get { return 0x2700; } }
        public int  GL_LINEAR_MIPMAP_NEAREST                          { get { return 0x2701; } }
        public int  GL_NEAREST_MIPMAP_LINEAR                          { get { return 0x2702; } }
        public int  GL_LINEAR_MIPMAP_LINEAR                           { get { return 0x2703; } }

        /* TextureParameterName */
        public int  GL_TEXTURE_MAG_FILTER                             { get { return 0x2800; } }
        public int  GL_TEXTURE_MIN_FILTER                             { get { return 0x2801; } }
        public int  GL_TEXTURE_WRAP_S                                 { get { return 0x2802; } }
        public int  GL_TEXTURE_WRAP_T                                 { get { return 0x2803; } }

        /* TextureTarget */
        /*      GL_TEXTURE_2D */
        public int  GL_TEXTURE                                        { get { return 0x1702; } }

        public int  GL_TEXTURE_CUBE_MAP                               { get { return 0x8513; } }
        public int  GL_TEXTURE_BINDING_CUBE_MAP                       { get { return 0x8514; } }
        public int  GL_TEXTURE_CUBE_MAP_POSITIVE_X                    { get { return 0x8515; } }
        public int  GL_TEXTURE_CUBE_MAP_NEGATIVE_X                    { get { return 0x8516; } }
        public int  GL_TEXTURE_CUBE_MAP_POSITIVE_Y                    { get { return 0x8517; } }
        public int  GL_TEXTURE_CUBE_MAP_NEGATIVE_Y                    { get { return 0x8518; } }
        public int  GL_TEXTURE_CUBE_MAP_POSITIVE_Z                    { get { return 0x8519; } }
        public int  GL_TEXTURE_CUBE_MAP_NEGATIVE_Z                    { get { return 0x851A; } }
        public int  GL_MAX_CUBE_MAP_TEXTURE_SIZE                      { get { return 0x851C; } }

        /* TextureUnit */
        public int  GL_TEXTURE0                                       { get { return 0x84C0; } }
        public int  GL_TEXTURE1                                       { get { return 0x84C1; } }
        public int  GL_TEXTURE2                                       { get { return 0x84C2; } }
        public int  GL_TEXTURE3                                       { get { return 0x84C3; } }
        public int  GL_TEXTURE4                                       { get { return 0x84C4; } }
        public int  GL_TEXTURE5                                       { get { return 0x84C5; } }
        public int  GL_TEXTURE6                                       { get { return 0x84C6; } }
        public int  GL_TEXTURE7                                       { get { return 0x84C7; } }
        public int  GL_TEXTURE8                                       { get { return 0x84C8; } }
        public int  GL_TEXTURE9                                       { get { return 0x84C9; } }
        public int  GL_TEXTURE10                                      { get { return 0x84CA; } }
        public int  GL_TEXTURE11                                      { get { return 0x84CB; } }
        public int  GL_TEXTURE12                                      { get { return 0x84CC; } }
        public int  GL_TEXTURE13                                      { get { return 0x84CD; } }
        public int  GL_TEXTURE14                                      { get { return 0x84CE; } }
        public int  GL_TEXTURE15                                      { get { return 0x84CF; } }
        public int  GL_TEXTURE16                                      { get { return 0x84D0; } }
        public int  GL_TEXTURE17                                      { get { return 0x84D1; } }
        public int  GL_TEXTURE18                                      { get { return 0x84D2; } }
        public int  GL_TEXTURE19                                      { get { return 0x84D3; } }
        public int  GL_TEXTURE20                                      { get { return 0x84D4; } }
        public int  GL_TEXTURE21                                      { get { return 0x84D5; } }
        public int  GL_TEXTURE22                                      { get { return 0x84D6; } }
        public int  GL_TEXTURE23                                      { get { return 0x84D7; } }
        public int  GL_TEXTURE24                                      { get { return 0x84D8; } }
        public int  GL_TEXTURE25                                      { get { return 0x84D9; } }
        public int  GL_TEXTURE26                                      { get { return 0x84DA; } }
        public int  GL_TEXTURE27                                      { get { return 0x84DB; } }
        public int  GL_TEXTURE28                                      { get { return 0x84DC; } }
        public int  GL_TEXTURE29                                      { get { return 0x84DD; } }
        public int  GL_TEXTURE30                                      { get { return 0x84DE; } }
        public int  GL_TEXTURE31                                      { get { return 0x84DF; } }
        public int  GL_ACTIVE_TEXTURE                                 { get { return 0x84E0; } }

        /* TextureWrapMode */
        public int  GL_REPEAT                                         { get { return 0x2901; } }
        public int  GL_CLAMP_TO_EDGE                                  { get { return 0x812F; } }
        public int  GL_MIRRORED_REPEAT                                { get { return 0x8370; } }

        /* Uniform Types */
        public int  GL_FLOAT_VEC2                                     { get { return 0x8B50; } }
        public int  GL_FLOAT_VEC3                                     { get { return 0x8B51; } }
        public int  GL_FLOAT_VEC4                                     { get { return 0x8B52; } }
        public int  GL_INT_VEC2                                       { get { return 0x8B53; } }
        public int  GL_INT_VEC3                                       { get { return 0x8B54; } }
        public int  GL_INT_VEC4                                       { get { return 0x8B55; } }
        public int  GL_BOOL                                           { get { return 0x8B56; } }
        public int  GL_BOOL_VEC2                                      { get { return 0x8B57; } }
        public int  GL_BOOL_VEC3                                      { get { return 0x8B58; } }
        public int  GL_BOOL_VEC4                                      { get { return 0x8B59; } }
        public int  GL_FLOAT_MAT2                                     { get { return 0x8B5A; } }
        public int  GL_FLOAT_MAT3                                     { get { return 0x8B5B; } }
        public int  GL_FLOAT_MAT4                                     { get { return 0x8B5C; } }
        public int  GL_SAMPLER_2D                                     { get { return 0x8B5E; } }
        public int  GL_SAMPLER_CUBE                                   { get { return 0x8B60; } }

        /* Vertex Arrays */
        public int  GL_VERTEX_ATTRIB_ARRAY_ENABLED                    { get { return 0x8622; } }
        public int  GL_VERTEX_ATTRIB_ARRAY_SIZE                       { get { return 0x8623; } }
        public int  GL_VERTEX_ATTRIB_ARRAY_STRIDE                     { get { return 0x8624; } }
        public int  GL_VERTEX_ATTRIB_ARRAY_TYPE                       { get { return 0x8625; } }
        public int  GL_VERTEX_ATTRIB_ARRAY_NORMALIZED                 { get { return 0x886A; } }
        public int  GL_VERTEX_ATTRIB_ARRAY_POINTER                    { get { return 0x8645; } }
        public int  GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING             { get { return 0x889F; } }

        /* Read Format */
        public int  GL_IMPLEMENTATION_COLOR_READ_TYPE                 { get { return 0x8B9A; } }
        public int  GL_IMPLEMENTATION_COLOR_READ_FORMAT               { get { return 0x8B9B; } }

        /* Shader Source */
        public int  GL_COMPILE_STATUS                                 { get { return 0x8B81; } }
        public int  GL_INFO_LOG_LENGTH                                { get { return 0x8B84; } }
        public int  GL_SHADER_SOURCE_LENGTH                           { get { return 0x8B88; } }
        public int  GL_SHADER_COMPILER                                { get { return 0x8DFA; } }

        /* Shader Binary */
        public int  GL_SHADER_BINARY_FORMATS                          { get { return 0x8DF8; } }
        public int  GL_NUM_SHADER_BINARY_FORMATS                      { get { return 0x8DF9; } }

        /* Shader Precision-Specified Types */
        public int  GL_LOW_FLOAT                                      { get { return 0x8DF0; } }
        public int  GL_MEDIUM_FLOAT                                   { get { return 0x8DF1; } }
        public int  GL_HIGH_FLOAT                                     { get { return 0x8DF2; } }
        public int  GL_LOW_INT                                        { get { return 0x8DF3; } }
        public int  GL_MEDIUM_INT                                     { get { return 0x8DF4; } }
        public int  GL_HIGH_INT                                       { get { return 0x8DF5; } }

        /* Framebuffer Object. */
        public int  GL_FRAMEBUFFER                                    { get { return 0x8D40; } }
        public int  GL_RENDERBUFFER                                   { get { return 0x8D41; } }

        public int  GL_RGBA4                                          { get { return 0x8056; } }
        public int  GL_RGB5_A1                                        { get { return 0x8057; } }
        public int  GL_RGB565                                         { get { return 0x8D62; } }
        public int  GL_DEPTH_COMPONENT16                              { get { return 0x81A5; } }
        public int  GL_STENCIL_INDEX8                                 { get { return 0x8D48; } }

        public int  GL_RENDERBUFFER_WIDTH                             { get { return 0x8D42; } }
        public int  GL_RENDERBUFFER_HEIGHT                            { get { return 0x8D43; } }
        public int  GL_RENDERBUFFER_INTERNAL_FORMAT                   { get { return 0x8D44; } }
        public int  GL_RENDERBUFFER_RED_SIZE                          { get { return 0x8D50; } }
        public int  GL_RENDERBUFFER_GREEN_SIZE                        { get { return 0x8D51; } }
        public int  GL_RENDERBUFFER_BLUE_SIZE                         { get { return 0x8D52; } }
        public int  GL_RENDERBUFFER_ALPHA_SIZE                        { get { return 0x8D53; } }
        public int  GL_RENDERBUFFER_DEPTH_SIZE                        { get { return 0x8D54; } }
        public int  GL_RENDERBUFFER_STENCIL_SIZE                      { get { return 0x8D55; } }

        public int  GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE             { get { return 0x8CD0; } }
        public int  GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME             { get { return 0x8CD1; } }
        public int  GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL           { get { return 0x8CD2; } }
        public int  GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE   { get { return 0x8CD3; } }

        public int  GL_COLOR_ATTACHMENT0                              { get { return 0x8CE0; } }
        public int  GL_DEPTH_ATTACHMENT                               { get { return 0x8D00; } }
        public int  GL_STENCIL_ATTACHMENT                             { get { return 0x8D20; } }

        public int  GL_NONE                                           { get { return 0; } }

        public int  GL_FRAMEBUFFER_COMPLETE                           { get { return 0x8CD5; } }
        public int  GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT              { get { return 0x8CD6; } }
        public int  GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT      { get { return 0x8CD7; } }
        public int  GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS              { get { return 0x8CD9; } }
        public int  GL_FRAMEBUFFER_UNSUPPORTED                        { get { return 0x8CDD; } }

        public int  GL_FRAMEBUFFER_BINDING                            { get { return 0x8CA6; } }
        public int  GL_RENDERBUFFER_BINDING                           { get { return 0x8CA7; } }
        public int  GL_MAX_RENDERBUFFER_SIZE                          { get { return 0x84E8; } }

        public int  GL_INVALID_FRAMEBUFFER_OPERATION                  { get { return 0x0506; } }

        public void ActiveTexture(int textureUnit)
        {
            gl30.ActiveTexture(textureUnit);
        }

        public void AttachShader(int program, int shader)
        {
            gl30.AttachShader(program, shader);
        }

        public void BindAttribLocation(int program, int index, string name)
        {
            gl30.BindAttribLocation(program, index, name);
        }

        public void BindBuffer(int bufferTarget, int buffer)
        {
            gl30.BindBuffer(bufferTarget, buffer);
        }

        public void BindFramebuffer(int frameBufferTarget, int framebuffer)
        {
            gl30.BindFramebuffer(frameBufferTarget, framebuffer);
        }

        public void BindRenderbuffer(int renderbuffer)
        {
            gl30.BindRenderbuffer(renderbuffer);
        }
        
        public void BindTexture(int textureTarget, int texture)
        {
            gl30.BindTexture(textureTarget, texture);
        }

        public void BlendColor(float red, float green, float blue, float alpha)
        {
            gl30.BlendColor(red, green, blue, alpha);
        }
        
        public void BlendEquation(int blendingEquation)
        {
            gl30.BlendEquation(blendingEquation);
        }

        public void BlendEquationSeparate(int blendingEquationRGB, int blendingEquationAlpha)
        {
            gl30.BlendEquationSeparate(blendingEquationRGB, blendingEquationAlpha);
        }
        
        public void BlendFunc(int sBlendingFactor, int dBlendingFactor)
        {
            gl30.BlendFunc(sBlendingFactor, dBlendingFactor);
        }

        public void BlendFuncSeparate(int sRgbBlendingFactor, int dRgbBlendingFactor, int sAlphaBlendingFactor, int dAlphaBlendingFactor)
        {
            gl30.BlendFuncSeparate(sRgbBlendingFactor, dRgbBlendingFactor, sAlphaBlendingFactor, dAlphaBlendingFactor);
        }
        
        public void BufferData<T>(int bufferTarget, int size, T[] data, int bufferUsage)
            where T:struct
        {
            gl30.BufferData<T>(bufferTarget, size, data, bufferUsage);
        }

        public void BufferSubData<T>(int bufferTarget, int offset, int size, T [] data)
            where T: struct
        {
            gl30.BufferSubData<T>(bufferTarget, offset, size, data);
        }

        public int CheckFramebufferStatus(int framebufferTarget)
        {
            return gl30.CheckFramebufferStatus(framebufferTarget);
        }

        public void Clear(int clearBufferMask)
        {
            gl30.Clear(clearBufferMask);
        }

        public void ClearColor(float red, float green, float blue, float alpha)
        {
            gl30.ClearColor(red, green, blue, alpha);
        }

        public void ClearDepth(float depth)
        {
            gl30.ClearDepth(depth);
        }

        public void ClearStencil(int s)
        {
            gl30.ClearStencil(s);
        }

        public void ColorMask(bool red, bool green, bool blue, bool alpha)
        {
            gl30.ColorMask(red, green, blue, alpha);
        }

        public void CompileShader(int shader)
        {
            gl30.CompileShader(shader);
        }
        
        public void CompressedTexImage2D(int textureTarget,
            int level,
            int internalformat,
            int width, int height,
            int border,
            int imageSize,
            IntPtr data)
        {
            gl30.CompressedTexImage2D(textureTarget,
                level,
                internalformat,
                width, height,
                border,
                imageSize,
                data);
        }

        public void CompressedTexSubImage2D(int textureTarget,
            int level,
            int xoffset, int yoffset,
            int width, int height,
            int pixelFormat,
            int imageSize,
            IntPtr data)
        {
            gl30.CompressedTexSubImage2D(textureTarget,
                level,
                xoffset, yoffset,
                width, height,
                pixelFormat,
                imageSize,
                data);
        }

        public void CopyTexImage2D(int textureTarget,
            int level,
            int internalformat,
            int x, int y,
            int width, int height,
            int border)
        {
            gl30.CopyTexImage2D(textureTarget,
                level,
                internalformat,
                x, y,
                width, height,
                border);
        }

        public void CopyTexSubImage2D(int textureTarget,
            int level,
            int xoffset, int yoffset,
            int x, int y,
            int width, int height)
        {
            gl30.CopyTexSubImage2D(textureTarget,
                level,
                xoffset, yoffset,
                x, y,
                width, height);
        }

        public int CreateProgram()
        {
            return gl30.CreateProgram();
        }

        public int CreateShader(int shaderType)
        {
            return gl30.CreateShader(shaderType);
        }

        public void CullFace(int mode)
        {
            gl30.CullFace(mode);
        }

        public void DeleteBuffers(int[]buffers)
        {
            gl30.DeleteBuffers(buffers);
        }

        public void DeleteBuffer(int buffer)
        {
            gl30.DeleteBuffer(buffer);
        }

        public void DeleteFramebuffers(int[] framebuffers)
        {
            gl30.DeleteFramebuffers(framebuffers);
        }

        public void DeleteFramebuffer(int framebuffer)
        {
            gl30.DeleteFramebuffer(framebuffer);
        }

        public void DeleteProgram(int program)
        {
            gl30.DeleteProgram(program);
        }

        public void DeleteRenderbuffers(int[] renderbuffers)
        {
            gl30.DeleteRenderbuffers(renderbuffers);
        }

        public void DeleteRenderBuffer(int renderbuffer)
        {
            gl30.DeleteRenderbuffer(renderbuffer);
        }

        public void DeleteShader(int shader)
        {
            gl30.DeleteShader(shader);
        }

        public void DeleteTextures(int[] textures)
        {
            gl30.DeleteTextures(textures);
        }

        public void DeleteTexture(int texture)
        {
            gl30.DeleteTexture(texture);
        }
        
        public void DepthFunc(int function)
        {
            gl30.DepthFunc(function);
        }

        public void DepthMask(bool flag)
        {
            gl30.DepthMask(flag);
        }

        public void DepthRange(float znear, float zfar)
        {
            gl30.DepthRange(znear, zfar);
        }

        public void DetachShader(int program, int shader)
        {
            gl30.DetachShader(program, shader);
        }
        
        public void Disable(int capability)
        {
            gl30.Disable(capability);
        }

        public void DisableVertexAttribArray(int index)
        {
            gl30.DisableVertexAttribArray(index);
        }
        
        public void DrawArrays(int drawMode, int first, int count)
        {
            gl30.DrawArrays(drawMode, first, count);
        }

        public void DrawElements<T>(int drawMode, int count, int drawElementsType, T[]indices)
             where T: struct
        {
            gl30.DrawElements<T>(drawMode, count, drawElementsType, indices);
        }

        public void Enable(int capability)
        {
            gl30.Enable(capability);
        }

        public void EnableVertexAttribArray(int index)
        {
            gl30.EnableVertexAttribArray(index);
        }

        public void Finish()
        {
            gl30.Finish();
        }

        public void Flush()
        {
            gl30.Flush();
        }
        
        public void FramebufferRenderbuffer(int framebufferTarget, 
            int framebufferAttachment,
            int renderbuffertarget,
            int renderbuffer)
        {
            gl30.FramebufferRenderbuffer(framebufferTarget, framebufferAttachment, renderbuffertarget, renderbuffer);
        }
        
        public void FramebufferTexture2D(int framebufferTarget,
            int framebufferAttachment,
            int textureTarget,
            int texture,
            int level)
        {
            gl30.FramebufferTexture2D(framebufferTarget, framebufferAttachment, textureTarget, texture, level);
        }

        public void FrontFace(int mode)
        {
            gl30.FrontFace(mode);
        }

        public void GenBuffers(int[] buffers)
        {
            gl30.GenBuffers(buffers);
        }

        public int GenBuffer()
        {
            return gl30.GenBuffer();
        }
        
        public void GenerateMipmap(int mipMapTarget)
        {
            gl30.GenerateMipmap(mipMapTarget);
        }

        public void GenFramebuffers(int[] buffers)
        {
            gl30.GenFramebuffers(buffers);
        }

        public int GenFramebuffer()
        {
            return gl30.GenFramebuffer();
        }

        public void GenRenderbuffers(int[] buffers)
        {
            gl30.GenRenderbuffers(buffers);
        }

        public int GenRenderbuffer()
        {
            return gl30.GenRenderbuffer();
        }

        public void GenTextures(int[] textures)
        {
            gl30.GenTextures(textures);
        }

        public int GenTexture()
        {
            return gl30.GenTexture();
        }

        public void GetActiveAttrib(int program, int index, int bufSize, out int length, out int size, out int attribType, StringBuilder name)
        {
            gl30.GetActiveAttrib(program, index, bufSize, out length, out size, out attribType, name);
        }
        
        public void GetActiveUniform(int program, int index, int bufSize, out int length, out int size, out int uniformType, StringBuilder name)
        {
            gl30.GetActiveUniform(program, index, bufSize, out length, out size, out uniformType, name);
        }

        public void GetAttachedShaders(int program, int maxCount, out int count, out int obj)
        {
            gl30.GetAttachedShaders(program, maxCount, out count, out obj);
        }
        
        public int GetAttribLocation(int program, string name)
        {
            return gl30.GetAttribLocation(program, name);
        }
        
        public void Get(int getPName, bool[] parameters)
        {
            gl30.Get(getPName, parameters);
        }

        public void GetBufferParameter(int bufferTarget, int bufferPName, int[]parameters)
        {
            gl30.GetBufferParameter(bufferTarget, bufferPName, parameters);
        }

        public int GetError()
        {
            return gl30.GetError();
        }

        public void Get(int getPName, float[] parameters)
        {
            gl30.Get(getPName, parameters);
        }

        public void Get(int getPName, int[] parameters)
        {
            gl30.Get(getPName, parameters);
        }

        public void GetFramebufferAttachmentParameter(int framebufferTarget, int framebufferAttachment, int framebufferAttachmentPName, int[]parameters)
        {
            gl30.GetFramebufferAttachmentParameter(framebufferTarget, framebufferAttachment, framebufferAttachmentPName, parameters);
        }

        public void GetProgram(int program, int programPName, int[] parameters)
        {
            gl30.GetProgram(program, programPName, parameters);
        }

        public void GetProgram(int program, int programPName, out int parameter)
        {
            gl30.GetProgram(program, programPName, out parameter);
        }

        public string GetProgramInfoLog(int program)
        {
            return gl30.GetProgramInfoLog(program);
        }
        
        public void GetShaderPrecisionFormat(int shaderType, int precisionType, int[] range, int[] precision)
        {
            if (this.gl41 == null)
                throw new NotSupportedException("GetShaderPrecisionFormat requires an OpenGL 4.1 capable device.");

            gl41.GetShaderPrecisionFormat(shaderType, precisionType, range, precision);
        }

        public void GetShaderSource(int shader, int bufSize, out int length, StringBuilder source)
        {
            gl30.GetShaderSource(shader, bufSize, out length, source);
        }

        public string GetString(int getStringPName)
        {
            return gl30.GetString(getStringPName);
        }
        
        public void GetTexParameter(int textureTarget, int texturePName, float [] parameters)
        {
            gl30.GetTexParameter(textureTarget, texturePName, parameters);
        }

        public void GetTexParameter(int textureTarget, int texturePName, int[] parameters)
        {
            gl30.GetTexParameter(textureTarget, texturePName, parameters);
        }

        public void GetUniform(int program, int location, float [] parameters)
        {
            gl30.GetUniform(program, location, parameters);
        }

        public void GetUniform(int program, int location, int[] parameters)
        {
            gl30.GetUniform(program, location, parameters);
        }

        public int GetUniformLocation(int program, string name)
        {
            return gl30.GetUniformLocation(program, name);
        }

        public void GetVertexAttrib(int index, int vertexAttribPName, float[] parameters)
        {
            gl30.GetVertexAttrib(index, vertexAttribPName, parameters);
        }

        public void GetVertexAttrib(int index, int vertexAttribPName, int[] parameters)
        {
            gl30.GetVertexAttrib(index, vertexAttribPName, parameters);
        }

        public void GetVertexAttribPointer<T>(int index, int pname, T[] pointer)
            where T: struct
        {
            gl30.GetVertexAttribPointer<T>(index, pname, pointer);
        }

        public void GetVertexAttribPointer<T>(int index, int pname, T[,] pointer)
            where T : struct
        {
            gl30.GetVertexAttribPointer<T>(index, pname, pointer);
        }

        public void Hint(int hintTarget, int mode)
        {
            gl30.Hint(hintTarget, mode);
        }

        public bool IsBuffer(int buffer)
        {
            return gl30.IsBuffer(buffer);
        }

        public bool IsEnabled(int capability)
        {
            return gl30.IsEnabled(capability);
        }

        public bool IsFramebuffer(int framebuffer)
        {
            return gl30.IsFramebuffer(framebuffer);
        }

        public bool IsProgram(int program)
        {
            return gl30.IsProgram(program);
        }

        public bool IsRenderbuffer(int renderbuffer)
        {
            return gl30.IsRenderbuffer(renderbuffer);
        }

        public bool IsShader(int shader)
        {
            return gl30.IsShader(shader);
        }

        public bool IsTexture(int texture)
        {
            return gl30.IsTexture(texture);
        }

        public void LineWidth(float width)
        {
            gl30.LineWidth(width);
        }

        public void LinkProgram(int program)
        {
            gl30.LinkProgram(program);
        }

        public void PixelStore(int pixelStorePName, int parameter)
        {
            gl30.PixelStore(pixelStorePName, parameter);
        }

        public void PolygonOffset(float factor, float units)
        {
            gl30.PolygonOffset(factor, units);
        }

        public void ReadPixels(int x, int y, int width, int height, int pixelFormat, int pixelType, IntPtr pixels)
        {
            gl30.ReadPixels(x, y, width, height, pixelFormat, pixelType, pixels);
        }

        public void ReleaseShaderCompiler()
        {
            if (this.gl41 == null)
                throw new NotSupportedException("GetShaderPrecisionFormat requires an OpenGL 4.1 capable device.");
            gl41.ReleaseShaderCompiler();
        }

        public void RenderbufferStorage(int target, int internalFormat, int width, int height)
        {
            gl30.RenderBufferStorage(target, internalFormat, width, height);
        }

        public void SampleCoverage(float value, bool invert)
        {
            gl30.SampleCoverage(value, invert);
        }

        public void Scissor(int x, int y, int width, int height)
        {
            gl30.Scissor(x, y, width, height);
        }

        public void ShaderBinary(int count, int [] shaders, int binaryformat, IntPtr binary, int length)
        {
            if (this.gl41 == null)
                throw new NotSupportedException("GetShaderPrecisionFormat requires an OpenGL 4.1 capable device.");
            gl41.ShaderBinary(count, shaders, binaryformat, binary, length);
        }

        public void ShaderSource(int shader, string source)
        {
            gl30.ShaderSource(shader, source);
        }

        public void StencilFunc(int function, int reference, int mask)
        {
            gl30.StencilFunc(function, reference, mask);
        }

        public void StencilFuncSeparate(int face, int function, int reference, int mask)
        {
            gl30.StencilFuncSeparate(face, function, reference, mask);
        }

        public void StencilMask(int mask)
        {
            gl30.StencilMask(mask);
        }

        public void StencilMaskSeparate(int face, int mask)
        {
            gl30.StencilMaskSeparate(face, mask);
        }

        public void StencilOp(int failOperation, int zfailOperation, int zpassOperation)
        {
            gl30.StencilOp(failOperation, zfailOperation, zpassOperation);
        }

        public void StencilOpSeparate(int face, int failOperation, int zfailOperation, int zpassOperation)
        {
            gl30.StencilOpSeparate(face, failOperation, zfailOperation, zpassOperation);
        }
        
        public void TexImage2D(int textureTarget, int level, int internalFormat, int width, int height, int border, int pixelFormat, int pixelType, IntPtr pixels)
        {
            gl30.TexImage2D(textureTarget, level, internalFormat, width, height, border, pixelFormat, pixelType, pixels);
        }

        public void TexParameter(int textureTarget, int texturePName, float parameter)
        {
            gl30.TexParameter(textureTarget, texturePName, parameter);
        }

        public void TexParameter(int textureTarget, int texturePName, float [] parameter)
        {
            gl30.TexParameter(textureTarget, texturePName, parameter);
        }

        public void TexParameter(int textureTarget, int texturePName, int parameter)
        {
            gl30.TexParameter(textureTarget, texturePName, parameter);
        }

        public void TexParameter(int textureTarget, int texturePName, int[] parameter)
        {
            gl30.TexParameter(textureTarget, texturePName, parameter);
        }

        public void TexSubImage2D(int textureTarget, int level, int xoffset, int yoffset, int width, int height, int border, int pixelFormat, int pixelType, IntPtr pixels)
        {
            gl30.TexSubImage2D(textureTarget, level, xoffset, yoffset, width, height, border, pixelFormat, pixelType, pixels);
        }

        public void Uniform(int location, float value)
        {
            gl30.Uniform(location, value);
        }

        public void Uniform1(int location, int count, float[] value)
        {
            gl30.Uniform1(location, count, value);
        }

        public void Uniform(int location, float v0, float v1)
        {
            gl30.Uniform(location, v0, v1);
        }

        public void Uniform2(int location, int count, float[] value)
        {
            gl30.Uniform2(location, count, value);
        }

        public void Uniform(int location, float v0, float v1, float v2)
        {
            gl30.Uniform(location, v0, v1, v2);
        }

        public void Uniform3(int location, int count, float[] value)
        {
            gl30.Uniform3(location, count, value);
        }

        public void Uniform(int location, float v0, float v1, float v2, float v3)
        {
            gl30.Uniform(location, v0, v1, v2, v3);
        }

        public void Uniform4(int location, int count, float[] value)
        {
            gl30.Uniform4(location, count, value);
        }

        public void Uniform(int location, int value)
        {
            gl30.Uniform(location, value);
        }

        public void Uniform1(int location, int count, int[] value)
        {
            gl30.Uniform1(location, count, value);
        }

        public void Uniform(int location, int v0, int v1)
        {
            gl30.Uniform(location, v0, v1);
        }

        public void Uniform2(int location, int count, int[] value)
        {
            gl30.Uniform2(location, count, value);
        }

        public void Uniform(int location, int v0, int v1, int v2)
        {
            gl30.Uniform(location, v0, v1, v2);
        }

        public void Uniform3(int location, int count, int[] value)
        {
            gl30.Uniform3(location, count, value);
        }

        public void Uniform(int location, int v0, int v1, int v2, int v3)
        {
            gl30.Uniform(location, v0, v1, v2, v3);
        }

        public void Uniform4(int location, int count, int[] value)
        {
            gl30.Uniform4(location, count, value);
        }

        public void UniformMatrix2(int location, bool transpose, float[] matrix)
        {
            gl30.UniformMatrix2(location, transpose, matrix);
        }

        public void UniformMatrix3(int location, bool transpose, float[] matrix)
        {
            gl30.UniformMatrix3(location, transpose, matrix);
        }

        public void UniformMatrix4(int location, bool transpose, float[] matrix)
        {
            gl30.UniformMatrix4(location, transpose, matrix);
        }

        public void Uniform(int location, bool transpose, ref Matrix matrix)
        {
            gl30.Uniform(location, transpose, ref matrix);
        }

        public void UseProgram(int program)
        {
            gl30.UseProgram(program);
        }

        public void ValidateProgram(int program)
        {
            gl30.ValidateProgram(program);
        }

        public void VertexAttrib(int index, float x)
        {
            gl30.VertexAttrib(index, x);
        }

        public void VertexAttrib1(int index, float[] values)
        {
            gl30.VertexAttrib1(index, values);
        }

        public void VertexAttrib(int index, float x,float y)
        {
            gl30.VertexAttrib(index, x, y);
        }

        public void VertexAttrib2(int index, float[] values)
        {
            gl30.VertexAttrib2(index, values);
        }

        public void VertexAttrib(int index, float x, float y, float z)
        {
            gl30.VertexAttrib(index, x, y, z);
        }

        public void VertexAttrib3(int index, float[] values)
        {
            gl30.VertexAttrib3(index, values);
        }

        public void VertexAttrib(int index, float x, float y, float z, float w)
        {
            gl30.VertexAttrib(index, x, y, z, w);
        }

        public void VertexAttrib4(int index, float[] values)
        {
            gl30.VertexAttrib4(index, values);
        }

        public void VertexAttribPointer(int index, int size, int vertexAttribType, bool normalized, int stride, IntPtr pointer)
        {
            gl30.VertexAttribPointer(index, size, vertexAttribType, normalized, stride, pointer);
        }

        public void Viewport(int x, int y, int width, int height)
        {
            gl30.Viewport(x, y, width, height);
        }
    }
}
