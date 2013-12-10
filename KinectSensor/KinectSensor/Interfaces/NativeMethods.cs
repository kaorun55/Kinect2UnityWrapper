using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Kinect2
{
    public class NativeMethods
    {
        // V2
        [DllImport( @"Kinect20.dll" )]
        public static extern int GetKinectSensorCollection( out IntPtr kinectSensorCollection );

        [DllImport( @"Kinect20.dll" )]
        public static extern int GetDefaultKinectSensor( out IntPtr defaultKinectSensor );
    }
}
