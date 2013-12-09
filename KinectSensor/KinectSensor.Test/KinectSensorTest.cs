using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KinectSensor.Test
{
    [TestClass]
    public class KinectSensorTest
    {
        public static KinectSensor GetKinectSensor()
        {
            IntPtr sensor = IntPtr.Zero;
            var hr = NativeMethods.GetDefaultKinectSensor( ref sensor );
            Assert.AreEqual( 0, hr );

            return (KinectSensor)Marshal.GetObjectForIUnknown( sensor );
        }

        public static KinectSensor OpenKinectSensor()
        {
            var kinect = GetKinectSensor();
            var hr = kinect.Open();
            Assert.AreEqual( 0, hr );

            return kinect;
        }

        [TestMethod]
        public void CreateInstance()
        {
            KinectSensor kinect = GetKinectSensor();

            IntPtr status = IntPtr.Zero;
            var hr = kinect.get_Status( out status );
            Assert.AreEqual( 0, hr );

            //Assert.AreEqual( 0, Marshal.ReadInt32( status ) );
        }

        [TestMethod]
        public void Open()
        {
            KinectSensor kinect = OpenKinectSensor();
        }

        [TestMethod]
        public void Close()
        {
            KinectSensor kinect = OpenKinectSensor();

            var hr = kinect.Close();
            Assert.AreEqual( 0, hr );
        }

        [TestMethod]
        public void get_ColorFrameSource()
        {
            KinectSensor kinect = OpenKinectSensor();

            IntPtr ptr = IntPtr.Zero;
            var hr = kinect.get_ColorFrameSource( out ptr );
            Assert.AreEqual( 0, hr );

            var colorFrameSource = (ColorFrameSource)Marshal.GetObjectForIUnknown( ptr );
        }
    }
}
