using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Kinect2
{
    [Guid( "57621D82-D8EE-4783-B412-F7E019C96CFD" )]
    [InterfaceType( ComInterfaceType.InterfaceIsIUnknown )]
    [ComImport()]
    public interface IColorFrameSource
    {
        // WAITABLE_HANDLE *
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int SubscribeFrameCaptured( out IntPtr waitableHandle );
        
        // WAITABLE_HANDLE
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int UnsubscribeFrameCaptured( IntPtr waitableHandle );
        
        // WAITABLE_HANDLE
        // IFrameCapturedEventArgs **
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int GetFrameCapturedEventData( IntPtr waitableHandle, out IntPtr eventData );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_IsActive( out IntPtr isActive );
        
        // IColorFrameReader **
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int OpenReader( out IntPtr reader );
        
        // ColorImageFormat
        // IFrameDescription **
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int CreateFrameDescription( Int64 format, IntPtr frameDescription );
        
        // IFrameDescription **
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_FrameDescription( IntPtr rawFrameDescription );
        
        // IKinectSensor **
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_KinectSensor( IntPtr sensor );
    }
}
