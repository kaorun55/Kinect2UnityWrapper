using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kinect2.Test
{
    [TestClass]
    public class BodyTest
    {
        [TestMethod]
        public void GetJoints()
        {
            var bodyReader = BodyFrameTest.GetBodyFrameReader();
            using ( var bodyFrame = bodyReader.AcquireLatestFrame() ) {
                Body[] bodies = new Body[6];
                bodyFrame.GetAndRefreshBodyData( bodies );
                foreach ( var body in bodies ) {
                    Joint[] joints = new Joint[(int)JointType.Count];
                    body.GetJoints( joints );
                }
            }
        }
    }
}
