using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kinect2.Test
{
    [TestClass]
    public class ColorFrameTest
    {
        ColorFrameReader colorRedaer;

        public ColorFrame GetColorFrame()
        {
            colorRedaer = ColorFrameReaderTest.GetColorFrameReader();
            return AcquireLatestFrame();
        }

        public ColorFrame AcquireLatestFrame()
        {
            IntPtr ptr = IntPtr.Zero;
            var hr = colorRedaer.AcquireLatestFrame( out ptr );
            Assert.AreEqual( 0, hr );

            return (ColorFrame)Marshal.GetObjectForIUnknown( ptr );
        }

        [TestMethod]
        public void CopyConvertedFrameDataToArray()
        {
            //UInt64 count = 1920*1080*4;
            //IntPtr ptr = Marshal.AllocHGlobal( (int)count );

            //var colorFrame = GetColorFrame();
            //var hr = colorFrame.CopyConvertedFrameDataToArray( count, ptr, (UInt64)ColorImageFormat.Bgra );
            //Assert.AreEqual( 0, hr );

            //var pixels = new byte[count];
            //Marshal.Copy( ptr, pixels, 0, (int)count );


            //Marshal.FreeHGlobal( ptr );
        }

        [TestMethod]
        public void AcquireLatestFrameTest()
        {
            var frame = GetColorFrame();
            //frame = AcquireLatestFrame();
        }
    }
}
