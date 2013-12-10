using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kinect2.Test
{
    [TestClass]
    public class BodyFrameSourceTest
    {
        public static BodyFrameSource GetBodyFrameSource()
        {
            var kinect = KinectSensorTest.OpenKinectSensor();
            return kinect.BodyFrameSource;
        }

        [TestMethod]
        public void OpenReader()
        {
            var bodyFrame = GetBodyFrameSource();
        }

        [TestMethod]
        public void BodyCount()
        {
            var bodyFrame = GetBodyFrameSource();
            Assert.AreEqual( 6, bodyFrame.BodyCount );
        }
    }
}
