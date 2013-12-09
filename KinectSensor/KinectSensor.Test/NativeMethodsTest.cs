using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kinect2.Test
{
    [TestClass]
    public class NativeMethodsTest
    {
        [TestMethod]
        public void GetDefaultKinectSensor()
        {
            IntPtr sensor = IntPtr.Zero;
            var hr = NativeMethods.GetDefaultKinectSensor( ref sensor );
            Assert.AreEqual( 0, hr );
        }

        [TestMethod]
        public void GetKinectSensorCollection()
        {
            IntPtr sensor = IntPtr.Zero;
            var hr = NativeMethods.GetKinectSensorCollection( ref sensor );
            Assert.AreEqual( 0, hr );
        }

    }
}
