using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace KinectSensor
{
    [Guid( "3C6EBA94-0DE1-4360-B6D4-653A10794C8B" )]
    [InterfaceType( ComInterfaceType.InterfaceIsIUnknown )]
    [ComImport()]
    public interface KinectSensor
    {
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int SubscribeIsAvailableChanged( out IntPtr waitableHandle );
        
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int UnsubscribeIsAvailableChanged( IntPtr waitableHandle );
        
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int GetIsAvailableChangedEventData(  IntPtr waitableHandle, out IntPtr eventData );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int Open();

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int Close();

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_IsOpen( out IntPtr isOpen );
        
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_IsAvailable( out IntPtr isAvailable );
        
        // IColorFrameSource**
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_ColorFrameSource( out IntPtr colorFrameSource);
        
        // IDepthFrameSource**
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_DepthFrameSource( IntPtr depthFrameSource);
        
        // IBodyFrameSource**
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_BodyFrameSource( IntPtr bodyFrameSource );
        
        // IBodyIndexFrameSource **
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_BodyIndexFrameSource( IntPtr bodyIndexFrameSource );
        
        // IInfraredFrameSource** 
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_InfraredFrameSource( IntPtr infraredFrameSource );
        
        // ILongExposureInfraredFrameSource**
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_LongExposureInfraredFrameSource( IntPtr longExposureInfraredFrameSource );
        
        // IAudioSource**
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_AudioSource( IntPtr audioSource );
        
        // IMultiSourceFrameReader** 
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int OpenMultiSourceFrameReader( UInt64 enabledFrameSourceTypes, IntPtr multiSourceFrameReader );
        
        // ICoordinateMapper**
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_CoordinateMapper( IntPtr coordinateMapper );
        
        // outwrites_z_(bufferSize)  WCHAR *
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_UniqueKinectId( int bufferSize, IntPtr uniqueKinectId );
        
        // KinectStatus*
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_Status( out IntPtr status);
        
        // DWORD *
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_KinectCapabilities( out IntPtr capabilities);
    }
}
