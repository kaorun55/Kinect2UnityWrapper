using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace KinectSensor
{
    public class NativeMethods
    {
        // V2
        [DllImportAttribute( @"C:\Windows\System32\Kinect30.dll", EntryPoint = "GetKinectSensor" )]
        public static extern int GetKinectSensorCollection( ref IntPtr kinectSensorCollection );

        [DllImportAttribute( @"C:\Windows\System32\Kinect20.dll", EntryPoint = "GetDefaultKinectSensor" )]
        public static extern int GetDefaultKinectSensor( ref IntPtr defaultKinectSensor );

        // V1
        //INuiSensor **ppNuiSensor
        [DllImportAttribute( @"C:\Windows\System32\Kinect10.dll", EntryPoint = "NuiCreateSensorByIndex" )]
        public static extern uint NuiCreateSensorByIndex( int index, ref IntPtr ppNuiSensor );

        [DllImportAttribute( @"C:\Windows\System32\Kinect10.dll", EntryPoint = "NuiGetSensorCount" )]
        public static extern int NuiGetSensorCount( ref int pCount );
    }

    [Guid( "3C6EBA94-0DE1-4360-B6D4-653A10794C8B" )]
    [InterfaceType( ComInterfaceType.InterfaceIsIUnknown )]
    [ComImport()]
    public interface IKinectSensor
    {
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        uint get_Status( out IntPtr status );
    }
}
