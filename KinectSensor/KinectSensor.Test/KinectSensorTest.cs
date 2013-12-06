using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KinectSensor.Test
{
    [TestClass]
    public class KinectSensorTest
    {
        // V2

        [TestMethod]
        public void GetDefaultKinectSensor()
        {
            IntPtr sensor = IntPtr.Zero;
            var hr = NativeMethods.GetDefaultKinectSensor( ref sensor );
            Assert.AreNotEqual( 0, hr );
        }

        [TestMethod]
        public void GetKinectSensorCollection()
        {
            IntPtr sensor = IntPtr.Zero;
            var hr = NativeMethods.GetKinectSensorCollection( ref sensor );
            Assert.AreNotEqual( 0, hr );
        }

        // V1

        [TestMethod]
        public void NuiCreateSensorByIndex()
        {
            int count = 0;
            int hr = NativeMethods.NuiGetSensorCount( ref count );
            Assert.AreEqual( 0, hr );
        }
    }
}
