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
    public interface IColorFrameReader
    {
        // _Out_  WAITABLE_HANDLE *
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        void SubscribeFrameArrived( out IntPtr waitableHandle );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        void UnsubscribeFrameArrived( IntPtr waitableHandle );
        
        // _Out_  IColorFrameArrivedEventArgs **
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        void GetFrameArrivedEventData( IntPtr waitableHandle, out IntPtr eventData );
        
        // _COM_Outptr_  IColorFrame **
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        IntPtr AcquireLatestFrame();

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        void get_IsPaused( out IntPtr isPaused );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        void put_IsPaused( Int64 isPaused );
        
        // _COM_Outptr_  IColorFrameSource **
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        void get_ColorFrameSource( out IntPtr colorFrameSource );
    }
}
