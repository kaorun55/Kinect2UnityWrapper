using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kinect2
{
    public class BodyFrameSource : ComPtr<IBodyFrameSource>
    {
        BodyFrameReader bodyFrameReader = null;

        public BodyFrameSource( IntPtr ptr )
            : base( ptr )
        {
        }

        public BodyFrameReader OpenReader()
        {
            if ( bodyFrameReader == null ) {
                IntPtr ptr = IntPtr.Zero;
                var hr = ComPointer.OpenReader( out ptr );
                if ( hr != 0 ) {
                    throw new Exception( hr.ToString() );
                }

                bodyFrameReader = new BodyFrameReader( ptr );
            }

            return bodyFrameReader;
        }

        protected override void DisposeUnmanagedResource()
        {
            if ( bodyFrameReader != null ) {
                bodyFrameReader.Dispose();
                bodyFrameReader = null;
            }

            base.DisposeUnmanagedResource();
        }
    }
}
