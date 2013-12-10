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
            return new ColorFrame( ComPointer.AcquireLatestFrame() );
        }
    }
}
