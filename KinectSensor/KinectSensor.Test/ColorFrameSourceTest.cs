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

            return new ColorFrameSource( ptr );
        }

        [TestMethod]
        public void OpenReader()
        {
            var colorFrame = GetColorFrameSource();
        }
    }
}
