using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Kinect2
{
    [Guid( "9BEA498C-C59C-4653-AAF9-D884BAB7C35B" )]
    [InterfaceType( ComInterfaceType.InterfaceIsIUnknown )]
    [ComImport()]
    public interface ColorFrameReader
    {
        // _Out_  WAITABLE_HANDLE *
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int SubscribeFrameArrived( out IntPtr waitableHandle );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int UnsubscribeFrameArrived( IntPtr waitableHandle );
        
        // _Out_  IColorFrameArrivedEventArgs **
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int GetFrameArrivedEventData( IntPtr waitableHandle, out IntPtr eventData );
        
        // _COM_Outptr_  IColorFrame **
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int AcquireLatestFrame( out IntPtr colorFrame );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_IsPaused( out IntPtr isPaused );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int put_IsPaused( Int64 isPaused );
        
        // _COM_Outptr_  IColorFrameSource **
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_ColorFrameSource( out IntPtr colorFrameSource );
    }
}
