using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kinect2.Test
{
    [TestClass]
    public class KinectSensorTest
    {
        public static KinectSensor GetKinectSensor()
        {
            return KinectSensor.Default;
        }

        public static KinectSensor OpenKinectSensor()
        {
            var kinect = KinectSensor.Default;
            kinect.Open();
            return kinect;
        }

        [TestMethod]
        public void CreateInstance()
        {
            KinectSensor kinect = KinectSensor.Default;
        }

        [TestMethod]
        public void Open()
        {
            var kinect = OpenKinectSensor();
        }

        [TestMethod]
        public void Close()
        {
            var kinect = OpenKinectSensor();

            kinect.Close();
        }

        [TestMethod]
        public void get_ColorFrameSource()
        {
            var kinect = OpenKinectSensor();

            var colorFrameSource = kinect.ColorFrameSource;
        }
    }
}
