using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kinect2.Test
{
    [TestClass]
    public class ColorFrameReaderTest
    {
        public static ColorFrameReader GetColorFrameReader()
        {
            var kinect = KinectSensor.Default;
            kinect.Open();
            return kinect.ColorFrameSource.OpenReader();
        }

        [TestMethod]
        public void AcquireLatestFrame()
        {
            var colorRedaer = GetColorFrameReader();
            using ( var colorFrame = colorRedaer.AcquireLatestFrame() ) {
            }
        }
    }
}
