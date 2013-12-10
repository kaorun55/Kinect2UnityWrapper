using System;
using System.Collections.Generic;
using System.Linq;
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
        }
    }
}
