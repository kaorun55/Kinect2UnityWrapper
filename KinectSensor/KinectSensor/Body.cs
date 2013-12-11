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
            using ( var ptr = new UnmanagedMemory( Marshal.SizeOf( typeof( Joint ) ) * (int)JointType.Count ) ) {
                ComPointer.GetJoints( (uint)JointType.Count, ptr.Pointer );
                for ( int i = 0; i < joints.Length; i++ ) {
                    IntPtr p = (IntPtr)(ptr.Pointer.ToInt64() + (Marshal.SizeOf( typeof( Joint ) )* i));
                    joints[i] = (Joint)Marshal.PtrToStructure( p, typeof( Joint ) );
                }
            }
        }
    }
}
