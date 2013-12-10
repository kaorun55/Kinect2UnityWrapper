using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Kinect2
{
    public enum ColorImageFormat
    {
        None	= 0,
        Rgba	= 1,
        Yuv	    = 2,
        Bgra	= 3,
        Bayer	= 4,
        Yuy2	= 5
    }

    public class ColorFrame : ComPtr<IColorFrame>
    {
        public ColorFrame( IntPtr ptr )
            : base( ptr )
        {
        }

        public void CopyConvertedFrameDataToArray(byte[] frameData, ColorImageFormat colorFormat)
        {
            using ( var ptr = new UnmanagedMemory( frameData.Length ) ) {
                ComPointer.CopyConvertedFrameDataToArray( (ulong)frameData.Length, ptr.Pointer, (UInt64)colorFormat );
                Marshal.Copy( ptr.Pointer, frameData, 0, frameData.Length );
            }
        }
    }
}
