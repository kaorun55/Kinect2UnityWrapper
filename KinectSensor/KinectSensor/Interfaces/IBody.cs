using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Kinect2.Interfaces
{
    public enum DetectionResult
    {
        Unknown	= 0,
        No	    = 1,
        Maybe	= 2,
        Yes	    = 3
    }

    public enum HandState
    {
        Unknown	    = 0,
        NotTracked	= 1,
        Open	    = 2,
        Closed	    = 3,
        Lasso	    = 4
    }

    public enum TrackingConfidence
    {
        Low	    = 0,
        High	= 1
    }

    public enum TrackingState
    {
        NotTracked	= 0,
        Inferred	= 1,
        Tracked	    = 2
    }

    [Guid( "46AEF731-98B0-4D18-827B-933758678F4A" )]
    [InterfaceType( ComInterfaceType.InterfaceIsIUnknown )]
    [ComImport()]
    public interface IBody
    {
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        void GetJoints( uint capacity, IntPtr[] joints );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        [PreserveSig]
        int GetJointOrientations( uint capacity, out IntPtr jointOrientations );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        DetectionResult get_Engaged();

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
        HandState get_HandLeftState();

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        TrackingConfidence get_HandLeftConfidence();

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        HandState get_HandRightState();

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        TrackingConfidence get_HandRightConfidence();

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        ulong get_ClippedEdges();

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        UInt64 get_TrackingId();

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        bool get_IsTracked();

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        bool get_IsRestricted();

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        bool get_Lean( out IntPtr amount );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime )]
        TrackingState get_LeanTrackingState();
    }
}
