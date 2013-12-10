using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kinect2.Test
{
    [TestClass]
    public class BodyFrameTest
    {
        BodyFrameReader bodyReader;

        [TestInitialize]
        void SetUp()
        {
            bodyReader = GetBodyFrameReader();
        }

        public static BodyFrameReader GetBodyFrameReader()
        {
            var kinect = KinectSensor.Default;
            kinect.Open();
            return kinect.BodyFrameSource.OpenReader();
        }

        [TestMethod]
        public void AcquireLatestFrame()
        {
            bodyReader = GetBodyFrameReader();
            using ( var bodyFrame = bodyReader.AcquireLatestFrame() ) {
            }

            using ( var bodyFrame = bodyReader.AcquireLatestFrame() ) {
            }
        }

        [TestMethod]
        public void RelativeTime()
        {
            bodyReader = GetBodyFrameReader();
            using ( var bodyFrame = bodyReader.AcquireLatestFrame() ) {
                Assert.AreNotEqual( 0, bodyFrame.RelativeTime() );
            }            
        }

        [TestMethod]
        public void GetAndRefreshBodyData()
        {
            bodyReader = GetBodyFrameReader();
            using ( var bodyFrame = bodyReader.AcquireLatestFrame() ) {
                Body[] bodies = new Body[6];
                bodyFrame.GetAndRefreshBodyData( bodies );
                foreach ( var body in bodies ) {
                }
            }
        }
    }
}
