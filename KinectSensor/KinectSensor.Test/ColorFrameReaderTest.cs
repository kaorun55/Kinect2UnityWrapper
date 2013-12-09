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
            var hr = colorFrame.OpenReader( out ptr );
            Assert.AreEqual( 0, hr );

            return (ColorFrameReader)Marshal.GetObjectForIUnknown( ptr );
        }

        [TestMethod]
        public void AcquireLatestFrame()
        {
            IntPtr ptr = IntPtr.Zero;
            var colorRedaer = GetColorFrameReader();
            var hr = colorRedaer.AcquireLatestFrame( out ptr );
            Assert.AreEqual( 0, hr );

            var frame = (ColorFrame)Marshal.GetObjectForIUnknown( ptr );
        }
    }
}
