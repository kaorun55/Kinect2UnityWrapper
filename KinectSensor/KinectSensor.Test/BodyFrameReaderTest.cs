using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kinect2.Test
{
    [TestClass]
    public class BodyFrameReaderTest
    {
        public static BodyFrameReader GetBodyFrameReader()
        {
            var kinect = KinectSensor.Default;
            kinect.Open();
            return kinect.BodyFrameSource.OpenReader();
        }

        [TestMethod]
        public void AcquireLatestFrame()
        {
            var bodyRedaer = GetBodyFrameReader();
            using ( var bodyFrame = bodyRedaer.AcquireLatestFrame() ) {
            }
        }
    }
}
