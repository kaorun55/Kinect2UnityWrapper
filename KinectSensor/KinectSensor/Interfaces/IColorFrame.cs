using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Kinect2
{
    [Guid( "39D05803-8803-4E86-AD9F-13F6954E4ACA" )]
    [InterfaceType( ComInterfaceType.InterfaceIsIUnknown )]
    [ComImport()]
    public interface IColorFrame
    {
        // _Out_  ColorImageFormat *
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        void get_RawColorImageFormat( out IntPtr rawColorImageFormat );
        
        // _COM_Outptr_  IFrameDescription **
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        void get_FrameDescription( out IntPtr rawFrameDescription );
        
        // _Out_writes_all_(capacity)  BYTE *
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        void CopyRawFrameDataToArray( UInt64 capacity, out IntPtr frameData );
        
        // _Out_  UINT *
        // _Outptr_result_bytebuffer_(*capacity)  BYTE **
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        void AccessRawUnderlyingBuffer( out IntPtr capacity, out IntPtr buffer );
        
        // _Out_writes_all_(capacity)  BYTE *
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        void CopyConvertedFrameDataToArray( UInt64 capacity, IntPtr frameData, UInt64 colorFormat );
        
        // _COM_Outptr_  IFrameDescription **
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        void CreateFrameDescription( UInt64 format, out IntPtr frameDescription );
        
        // _COM_Outptr_  IColorCameraSettings **
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        void get_ColorCameraSettings( out IntPtr colorCameraSettings );
        
        // _Out_  TIMESPAN *
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        void get_RelativeTime( out IntPtr relativeTime );
        
        // _COM_Outptr_  IColorFrameSource **
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        void get_ColorFrameSource( out IntPtr colorFrameSource );
    }
}
