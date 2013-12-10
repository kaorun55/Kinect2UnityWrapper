using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Kinect2.Interfaces
{
    [Guid( "46AEF731-98B0-4D18-827B-933758678F4A" )]
    [InterfaceType( ComInterfaceType.InterfaceIsIUnknown )]
    [ComImport()]
    public interface IBody
    {
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int GetJoints( uint capacity, out IntPtr joints );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int GetJointOrientations( uint capacity, out IntPtr jointOrientations );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_Engaged( out IntPtr detectionResult );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int GetExpressionDetectionResults( uint capacity, out IntPtr detectionResults );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int GetActivityDetectionResults( uint capacity, out IntPtr detectionResults );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int GetAppearanceDetectionResults( uint capacity, out IntPtr detectionResults );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_HandLeftState( out IntPtr handState );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_HandLeftConfidence( out IntPtr confidence );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_HandRightState( out IntPtr handState );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_HandRightConfidence( out IntPtr confidence );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_ClippedEdges( out IntPtr clippedEdges );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_TrackingId( out IntPtr trackingId );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_IsTracked( out IntPtr tracked );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_IsRestricted( out IntPtr isRestricted );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_Lean( out IntPtr amount );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int get_LeanTrackingState( out IntPtr trackingState );
    }
}
