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
            int capacity = IntPtr.Size * 6;
            IntPtr p = Marshal.AllocHGlobal( capacity );
            ComPointer.GetAndRefreshBodyData( 6, p );

            Marshal.FreeHGlobal( p );

            //using ( var ptr = new UnmanagedMemory( IntPtr.Size * 6 ) ) {
            //    IntPtr p = ptr.Pointer;
            //    ComPointer.GetAndRefreshBodyData( 6, out p );
            //}

            //for ( int i = 0; i < bodies.Length; i++ ) {
            //    bodies[i] = new Body( ptr[i] );
            //}
        }

        public Int64 RelativeTime()
        {
            return ComPointer.get_RelativeTime();
        }
    }
}
