using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kinect2
{
    public class ColorFrameReader : ComPtr<IColorFrameReader>
    {
        public ColorFrameReader( IntPtr ptr )
            : base( ptr )
        {
        }

        public ColorFrame AcquireLatestFrame()
        {
            IntPtr ptr = IntPtr.Zero;
            var hr = ComPointer.AcquireLatestFrame( out ptr );
            if ( hr != 0 ) {
                throw new Exception( hr.ToString() );
            }

            return new ColorFrame( ptr );
        }
    }
}
