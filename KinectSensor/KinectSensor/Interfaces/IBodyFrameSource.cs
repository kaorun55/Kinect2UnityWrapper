using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Kinect2
{
    [Guid( "BB94A78A-458C-4608-AC69-34FEAD1E3BAE" )]
    [InterfaceType( ComInterfaceType.InterfaceIsIUnknown )]
    [ComImport()]
    public interface IBodyFrameSource
    {
        // _Out_  WAITABLE_HANDLE *waitableHandle
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int SubscribeFrameCaptured( out IntPtr waitableHandle );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int UnsubscribeFrameCaptured( IntPtr waitableHandle );
        
        // _Out_  IFrameCapturedEventArgs **eventData
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int GetFrameCapturedEventData( IntPtr waitableHandle, out IntPtr eventData );
        
        // _Out_  BOOLEAN *isActive
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_IsActive( out IntPtr isActive );
        
        // _Out_  INT32 *bodyCount
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        Int32 get_BodyCount();
        
        // _COM_Outptr_  IBodyFrameReader **reader
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int OpenReader( out IntPtr reader );
        
        // _COM_Outptr_  IKinectSensor **sensor
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_KinectSensor( out IntPtr sensor );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int OverrideHandTracking( UInt64 trackingId );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int OverrideAndReplaceHandTracking( UInt64 oldTrackingId, UInt64 newTrackingId );
    }
}
