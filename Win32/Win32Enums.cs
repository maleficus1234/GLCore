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
using System.Security;

namespace GLCore.Win32
{
    enum PixelFormatFlags
            : int
    {
        DrawToWindow = 0x00000004,
        DrawToBitmap = 0x00000008,
        SupportGdi = 0x00000010,
        SupportOpenGL = 0x00000020,
        GenericAccelerated = 0x00001000,
        GenericFormat = 0x00000040,
        NeedPalette = 0x00000080,
        NeedSystemPalette = 0x00000100,
        DoubleBuffer = 0x00000001,
        Stereo = 0x00000002,
        SwapLayerBuffers = 0x00000800
    }

    [StructLayout(LayoutKind.Sequential)]
    struct PixelFormatDescriptor
    {
        public short nSize;

        public short nVersion;

        public PixelFormatFlags dwFlags;

        public byte iPixelType;

        public byte cColorBits;

        public byte cRedBits;

        public byte cRedShift;

        public byte cGreenBits;

        public byte cGreenShift;

        public byte cBlueBits;

        public byte cBlueShift;

        public byte cAlphaBits;

        public byte cAlphaShift;

        public byte cAccumBits;

        public byte cAccumRedBits;

        public byte cAccumGreenBits;

        public byte cAccumBlueBits;

        public byte cAccumAlphaBits;

        public byte cDepthBits;

        public byte cStencilBits;

        public byte cAuxBuffers;

        public byte iLayerType;

        public byte bReserved;

        public int dwLayerMask;

        public int dwVisibleMask;

        public int dwDamageMask;
    }

    enum Attrib
    : int
    {
        ContextMajorVersion = ((int)0x2091),
        ContextMinorVersion = ((int)0x2092),
        ContextFlags = ((int)0x2094),
        ContextProfileMask = ((int)0x9126)
    }

    internal enum GetWindowLongOffsets : int
    {
        WNDPROC = (-4),
        HINSTANCE = (-6),
        HWNDPARENT = (-8),
        STYLE = (-16),
        EXSTYLE = (-20),
        USERDATA = (-21),
        ID = (-12),
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DeviceMode
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string dmDeviceName;

        public short dmSpecVersion;
        public short dmDriverVersion;
        public short dmSize;
        public short dmDriverExtra;
        public int dmFields;
        public int dmPositionX;
        public int dmPositionY;
        public int dmDisplayOrientation;
        public int dmDisplayFixedOutput;
        public short dmColor;
        public short dmDuplex;
        public short dmYResolution;
        public short dmTTOption;
        public short dmCollate;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string dmFormName;

        public short dmLogPixels;
        public short dmBitsPerPel;
        public int dmPelsWidth;
        public int dmPelsHeight;
        public int dmDisplayFlags;
        public int dmDisplayFrequency;
        public int dmICMMethod;
        public int dmICMIntent;
        public int dmMediaType;
        public int dmDitherType;
        public int dmReserved1;
        public int dmReserved2;
        public int dmPanningWidth;
        public int dmPanningHeight;
    };

    [StructLayout(LayoutKind.Sequential)]
    struct POINT
    {
        public int X;
        public int Y;

        public POINT(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    [Flags]
    internal enum ChangeDisplaySettingsEnum
    {
        // ChangeDisplaySettings types (found in winuser.h)
        UpdateRegistry = 0x00000001,
        Test = 0x00000002,
        Fullscreen = 0x00000004,
    }

    public enum WGL_ARB_pixel_format
    {
        ShareStencilArb = ((int)0x200d),
        AccumBitsArb = ((int)0x201d),
        NumberUnderlaysArb = ((int)0x2009),
        StereoArb = ((int)0x2012),
        MaxPbufferHeightArb = ((int)0x2030),
        TypeRgbaArb = ((int)0x202b),
        SupportGdiArb = ((int)0x200f),
        NeedSystemPaletteArb = ((int)0x2005),
        AlphaBitsArb = ((int)0x201b),
        ShareDepthArb = ((int)0x200c),
        SupportOpenglArb = ((int)0x2010),
        ColorBitsArb = ((int)0x2014),
        AccumRedBitsArb = ((int)0x201e),
        MaxPbufferWidthArb = ((int)0x202f),
        NumberOverlaysArb = ((int)0x2008),
        MaxPbufferPixelsArb = ((int)0x202e),
        NeedPaletteArb = ((int)0x2004),
        RedShiftArb = ((int)0x2016),
        AccelerationArb = ((int)0x2003),
        GreenBitsArb = ((int)0x2017),
        TransparentGreenValueArb = ((int)0x2038),
        PixelTypeArb = ((int)0x2013),
        AuxBuffersArb = ((int)0x2024),
        DrawToWindowArb = ((int)0x2001),
        RedBitsArb = ((int)0x2015),
        NumberPixelFormatsArb = ((int)0x2000),
        GenericAccelerationArb = ((int)0x2026),
        BlueBitsArb = ((int)0x2019),
        PbufferLargestArb = ((int)0x2033),
        AccumAlphaBitsArb = ((int)0x2021),
        TransparentArb = ((int)0x200a),
        FullAccelerationArb = ((int)0x2027),
        ShareAccumArb = ((int)0x200e),
        SwapExchangeArb = ((int)0x2028),
        SwapUndefinedArb = ((int)0x202a),
        TransparentAlphaValueArb = ((int)0x203a),
        PbufferHeightArb = ((int)0x2035),
        TransparentBlueValueArb = ((int)0x2039),
        SwapMethodArb = ((int)0x2007),
        StencilBitsArb = ((int)0x2023),
        DepthBitsArb = ((int)0x2022),
        GreenShiftArb = ((int)0x2018),
        TransparentRedValueArb = ((int)0x2037),
        DoubleBufferArb = ((int)0x2011),
        NoAccelerationArb = ((int)0x2025),
        TypeColorindexArb = ((int)0x202c),
        SwapLayerBuffersArb = ((int)0x2006),
        AccumBlueBitsArb = ((int)0x2020),
        DrawToPbufferArb = ((int)0x202d),
        AccumGreenBitsArb = ((int)0x201f),
        PbufferWidthArb = ((int)0x2034),
        TransparentIndexValueArb = ((int)0x203b),
        AlphaShiftArb = ((int)0x201c),
        DrawToBitmapArb = ((int)0x2002),
        BlueShiftArb = ((int)0x201a),
        SwapCopyArb = ((int)0x2029),
    }
}
