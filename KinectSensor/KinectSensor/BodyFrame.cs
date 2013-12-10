using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Kinect2.Interfaces;

namespace Kinect2
{
    public class BodyFrame : ComPtr<IBodyFrame>
    {
        public BodyFrame( IntPtr ptr )
            : base( ptr )
        {
        }

        public void GetAndRefreshBodyData( Body[] bodies )
        {
            IBody[] b = new IBody[6];
            IntPtr[] ptr = new IntPtr[6];
            ComPointer.GetAndRefreshBodyData( 6, ptr );
            for ( int i = 0; i < bodies.Length; i++ ) {
                bodies[i] = new Body( ptr[i] );
            }
        }

        public Int64 RelativeTime()
        {
            return ComPointer.get_RelativeTime();
        }
    }
}
