using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kinect2.Test
{
    [TestClass]
    public class ColorFrameSourceTest
    {
        public static ColorFrameSource GetColorFrameSource()
        {
            KinectSensor kinect = KinectSensorTest.OpenKinectSensor();

            IntPtr ptr = IntPtr.Zero;
            var hr = kinect.get_ColorFrameSource( out ptr );
            Assert.AreEqual( 0, hr );

            return (ColorFrameSource)Marshal.GetObjectForIUnknown( ptr );
        }

        [TestMethod]
        public void OpenReader()
        {
            IntPtr ptr = IntPtr.Zero;
            var colorFrame = GetColorFrameSource();
            var hr = colorFrame.OpenReader( out ptr );
            Assert.AreEqual( 0, hr );

            var reader = (IColorFrameReader)Marshal.GetObjectForIUnknown( ptr );
        }
    }
}
