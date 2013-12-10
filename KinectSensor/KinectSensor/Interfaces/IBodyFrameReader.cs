using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Kinect2.Interfaces
{
    [Guid( "45532DF5-A63C-418F-A39F-C567936BC051" )]
    [InterfaceType( ComInterfaceType.InterfaceIsIUnknown )]
    [ComImport()]
    public interface IBodyFrameReader
    {
        // _Out_  WAITABLE_HANDLE *waitableHandle
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int SubscribeFrameArrived( out IntPtr waitableHandle );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int UnsubscribeFrameArrived( IntPtr waitableHandle );
        
        // _Out_  IBodyFrameArrivedEventArgs **eventData
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int GetFrameArrivedEventData( IntPtr waitableHandle, out IntPtr eventData );
        
        // _COM_Outptr_  IBodyFrame **bodyFrame
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int AcquireLatestFrame( out IntPtr bodyFrame );
        
        // _Out_  BOOLEAN *isPaused
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_IsPaused( out IntPtr isPaused );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int put_IsPaused( Int64 isPaused );
        
        // _COM_Outptr_  IBodyFrameSource **bodyFrameSource
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_BodyFrameSource( out IntPtr bodyFrameSource );
    }
}
