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
            var kinect = KinectSensorTest.OpenKinectSensor();
            return kinect.ColorFrameSource;
        }

        [TestMethod]
        public void OpenReader()
        {
            var colorFrame = GetColorFrameSource();
        }
    }
}
