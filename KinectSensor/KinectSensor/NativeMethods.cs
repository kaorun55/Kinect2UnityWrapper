using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace KinectSensor
{
    public class NativeMethods
    {
        // V2
        [DllImport( @"Kinect20.dll" )]
        public static extern int GetKinectSensorCollection( ref IntPtr kinectSensorCollection );

        [DllImport( @"Kinect20.dll" )]
        public static extern int GetDefaultKinectSensor( ref IntPtr defaultKinectSensor );
    }
}
