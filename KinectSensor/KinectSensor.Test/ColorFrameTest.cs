using System;
using System.Runtime.InteropServices;
using System.Threading;
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
            return colorRedaer.AcquireLatestFrame();
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
            using ( var frame = GetColorFrame() ) {
            }

            Thread.Sleep( 100 );

            using ( var frame2 = AcquireLatestFrame() ) {
            }
        }
    }
}
