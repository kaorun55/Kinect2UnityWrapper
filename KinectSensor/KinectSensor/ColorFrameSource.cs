using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kinect2
{
    public class ColorFrameSource : ComPtr<IColorFrameSource>
    {
        public ColorFrameSource( IntPtr ptr )
            : base( ptr )
        {
        }

        public ColorFrameReader OpenReader()
        {
            IntPtr ptr = IntPtr.Zero;
            var hr = ComPointer.OpenReader( out ptr );
            if ( hr != 0 ) {
                throw new Exception( hr.ToString() );
            }

            return new ColorFrameReader( ptr );
        }
    }
}
