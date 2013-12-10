using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kinect2.Interfaces;

namespace Kinect2
{
    public class BodyFrameReader : ComPtr<IBodyFrameReader>
    {
        public BodyFrameReader( IntPtr ptr )
            : base( ptr )
        {
        }

        public BodyFrame AcquireLatestFrame()
        {
            IntPtr ptr = IntPtr.Zero;
            var hr = ComPointer.AcquireLatestFrame( out ptr );
            if ( hr != 0 ) {
                throw new Exception( hr.ToString() );
            }

            return new BodyFrame( ptr );
        }
    }
}
