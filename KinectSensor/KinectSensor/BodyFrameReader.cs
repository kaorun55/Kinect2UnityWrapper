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
    }
}
