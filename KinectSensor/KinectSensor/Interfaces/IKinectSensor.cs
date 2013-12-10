using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Kinect2
{
    [Guid( "3C6EBA94-0DE1-4360-B6D4-653A10794C8B" )]
    [InterfaceType( ComInterfaceType.InterfaceIsIUnknown )]
    [ComImport()]
    public interface IKinectSensor
    {
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        void SubscribeIsAvailableChanged( out IntPtr waitableHandle );
        
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        void UnsubscribeIsAvailableChanged( IntPtr waitableHandle );
        
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        void GetIsAvailableChangedEventData(  IntPtr waitableHandle, out IntPtr eventData );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        void Open();

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        void Close();

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        void get_IsOpen( out IntPtr isOpen );
        
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        void get_IsAvailable( out IntPtr isAvailable );
        
        // IColorFrameSource**
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        IntPtr get_ColorFrameSource();
        
        // IDepthFrameSource**
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        IntPtr get_DepthFrameSource();
        
        // IBodyFrameSource**
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        IntPtr get_BodyFrameSource();
        
        // IBodyIndexFrameSource **
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        IntPtr get_BodyIndexFrameSource();
        
        // IInfraredFrameSource** 
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        IntPtr get_InfraredFrameSource();
        
        // ILongExposureInfraredFrameSource**
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        void get_LongExposureInfraredFrameSource( IntPtr longExposureInfraredFrameSource );
        
        // IAudioSource**
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        void get_AudioSource( IntPtr audioSource );
        
        // IMultiSourceFrameReader** 
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        void OpenMultiSourceFrameReader( UInt64 enabledFrameSourceTypes, IntPtr multiSourceFrameReader );
        
        // ICoordinateMapper**
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        void get_CoordinateMapper( IntPtr coordinateMapper );
        
        // outwrites_z_(bufferSize)  WCHAR *
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        void get_UniqueKinectId( int bufferSize, IntPtr uniqueKinectId );
        
        // KinectStatus*
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        void get_Status( out IntPtr status);
        
        // DWORD *
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        void get_KinectCapabilities( out IntPtr capabilities);
    }
}
