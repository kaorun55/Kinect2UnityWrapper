using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Kinect2.Interfaces;

namespace Kinect2
{
    public class Body : ComPtr<IBody>
    {
        public Body( IntPtr ptr )
            : base( ptr )
        {
        }

        public void GetJoints( Joint[] joints )
        {
            IntPtr[] ptr = new IntPtr[(int)JointType.Count];
            ComPointer.GetJoints( (uint)JointType.Count, ptr );
            for ( int i = 0; i < joints.Length; i++ ) {
                joints[i] = (Joint)Marshal.PtrToStructure( ptr[i], typeof(Joint) );
            }
        }
    }
}
