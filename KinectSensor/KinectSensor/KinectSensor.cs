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
            var hr = ComPointer.Open();
            if ( hr != 0 ) {
                throw new Exception( hr.ToString() );
            }
        }

        public void Close()
        {
            var hr = ComPointer.Close();
            if ( hr != 0 ) {
                throw new Exception( hr.ToString() );
            }
        }

        ColorFrameSource colorFrameSource = null;
        public ColorFrameSource ColorFrameSource
        {
            get
            {
                if ( colorFrameSource == null ) {
                    IntPtr ptr = IntPtr.Zero;
                    var hr = ComPointer.get_ColorFrameSource( out ptr );
                    if ( hr != 0 ) {
                        throw new Exception( hr.ToString() );
                    }

                    colorFrameSource = new ColorFrameSource( ptr );
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
                    IntPtr ptr = IntPtr.Zero;
                    var hr = ComPointer.get_BodyFrameSource( out ptr );
                    if ( hr != 0 ) {
                        throw new Exception( hr.ToString() );
                    }

                    colorFrameSource = new ColorFrameSource( ptr );
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
