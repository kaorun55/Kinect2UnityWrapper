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
            IntPtr ptr = IntPtr.Zero;
            var colorFrame = ColorFrameSourceTest.GetColorFrameSource();
            return colorFrame.OpenReader();
        }

        [TestMethod]
        public void AcquireLatestFrame()
        {
            IntPtr ptr = IntPtr.Zero;
            var colorRedaer = GetColorFrameReader();
            using ( var colorFrame = colorRedaer.AcquireLatestFrame() ) {
            }
        }
    }
}
