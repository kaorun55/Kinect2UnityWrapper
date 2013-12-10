using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Kinect2
{
    [StructLayout( LayoutKind.Sequential )]
    public struct Joint
    {
        JointType JointType;
        CameraSpacePoint Position;
        TrackingState TrackingState;
    }

    [StructLayout( LayoutKind.Sequential )]
    public struct CameraSpacePoint
    {
        public float X;
        public float Y;
        public float Z;
    };

    public enum JointType
    {
        SpineBase	    = 0,
        SpineMid	    = 1,
        Neck	        = 2,
        Head	        = 3,
        ShoulderLeft	= 4,
        ElbowLeft	    = 5,
        WristLeft	    = 6,
        HandLeft	    = 7,
        ShoulderRight	= 8,
        ElbowRight	    = 9,
        WristRight	    = 10,
        HandRight	    = 11,
        HipLeft	        = 12,
        KneeLeft	    = 13,
        AnkleLeft	    = 14,
        FootLeft	    = 15,
        HipRight	    = 16,
        KneeRight	    = 17,
        AnkleRight	    = 18,
        FootRight	    = 19,
        SpineShoulder	= 20,
        HandTipLeft	    = 21,
        ThumbLeft	    = 22,
        HandTipRight	= 23,
        ThumbRight	    = 24,
        Count	= (ThumbRight + 1)
    }

    public enum TrackingState
    {
        NotTracked	= 0,
        Inferred	= 1,
        Tracked	    = 2
    }
}
