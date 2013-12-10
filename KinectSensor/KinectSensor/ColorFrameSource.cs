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
            return new ColorFrameReader( ComPointer.OpenReader() );
        }
    }
}
