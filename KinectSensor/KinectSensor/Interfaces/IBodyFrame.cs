using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Kinect2.Interfaces
{
    [Guid( "52884F1F-94D7-4B57-BF87-9226950980D5" )]
    [InterfaceType( ComInterfaceType.InterfaceIsIUnknown )]
    [ComImport()]
    public interface IBodyFrame
    {
        //virtual HRESULT STDMETHODCALLTYPE GetAndRefreshBodyData( 
        //    UINT capacity,
        //    /* [annotation][size_is][out][in] */ 
        //    _Inout_updates_all_(capacity)  IBody **bodies) = 0;
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        void GetAndRefreshBodyData( uint capacity,
                                    ref IntPtr bodies );
        
        // _Out_  Vector4 *floorClipPlane
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_FloorClipPlane( out IntPtr floorClipPlane );
        
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        Int64 get_RelativeTime();
        
        // _COM_Outptr_  IBodyFrameSource **
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_BodyFrameSource( out IntPtr bodyFrameSource );
    }
}
