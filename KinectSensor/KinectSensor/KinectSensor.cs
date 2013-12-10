using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kinect2
{
    public class KinectSensor : ComPtr<IKinectSensor>
    {
        public static KinectSensor Default
        {
            get;
            private set;
        }

        static KinectSensor()
        {
            IntPtr ptr = IntPtr.Zero;
            var hr = NativeMethods.GetDefaultKinectSensor( out ptr );
            if ( hr != 0)  {
                throw new Exception( hr.ToString() );
            }

            Default = new KinectSensor( ptr );
        }

        public KinectSensor( IntPtr ptr )
            : base( ptr )
        {
        }

        public void Open()
        {
            ComPointer.Open();
        }

        public void Close()
        {
            ComPointer.Close();
        }

        ColorFrameSource colorFrameSource = null;
        public ColorFrameSource ColorFrameSource
        {
            get
            {
                if ( colorFrameSource == null ) {
                    colorFrameSource = new ColorFrameSource( ComPointer.get_ColorFrameSource() );
                }

                return colorFrameSource;
            }
        }

        BodyFrameSource bodyFrameSource = null;
        public BodyFrameSource BodyFrameSource
        {
            get
            {
                if ( bodyFrameSource == null ) {
                    bodyFrameSource = new BodyFrameSource( ComPointer.get_BodyFrameSource() );
                }

                return bodyFrameSource;
            }
        }


        protected override void DisposeUnmanagedResource()
        {
            if ( bodyFrameSource != null ) {
                bodyFrameSource.Dispose();
                bodyFrameSource = null;
            }

            if ( colorFrameSource != null ) {
                colorFrameSource.Dispose();
                colorFrameSource = null;
            }

            base.DisposeUnmanagedResource();
        }
    }
}
