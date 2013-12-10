using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kinect2
{
    public class ColorFrameSource : ComPtr<IColorFrameSource>
    {
        ColorFrameReader colorFrameReader = null;

        public ColorFrameSource( IntPtr ptr )
            : base( ptr )
        {
        }

        public ColorFrameReader OpenReader()
        {
            if ( colorFrameReader == null ) {
                IntPtr ptr = IntPtr.Zero;
                var hr = ComPointer.OpenReader( out ptr );
                if ( hr != 0 ) {
                    throw new Exception( hr.ToString() );
                }

                colorFrameReader = new ColorFrameReader( ptr );
            }

            return colorFrameReader;
        }

        protected override void DisposeUnmanagedResource()
        {
            if ( colorFrameReader != null ) {
                colorFrameReader.Dispose();
                colorFrameReader = null;
            }

            base.DisposeUnmanagedResource();
        }
    }
}
