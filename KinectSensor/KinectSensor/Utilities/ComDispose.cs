using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Kinect2
{
    public class ComPtr<T> : IDisposable where T : class 
    {
        protected T ComPointer
        {
            get;
            private set;
        }

        IntPtr ptr = IntPtr.Zero;

        protected ComPtr( IntPtr ptr )
        {
            this.ptr = ptr;
            ComPointer = (T)Marshal.GetObjectForIUnknown( ptr );
        }

        private void DisposeUnmanagedResource()
        {
            if ( ComPointer != null ) {
                Marshal.ReleaseComObject( ComPointer );
                ComPointer = null;
            }

            if ( ptr != IntPtr.Zero ) {
                Marshal.Release( ptr );
                ptr = IntPtr.Zero;
            }
        }

        private void DisposeManagedResource()
        {
        }

        #region dispose

        private bool disposed = false;

        public void Dispose() 
        {
            Dispose(true);

            GC.SuppressFinalize(this);      
        }

        protected virtual void Dispose(bool disposing)
        {
            // If you need thread safety, use a lock around these 
            // operations, as well as in your methods that use the resource.
            if ( !disposed ) {
                // If disposing equals true, dispose all managed
                // and unmanaged resources.
                if ( disposing ) {
                    DisposeManagedResource();
                }

                // Call the appropriate methods to clean up
                // unmanaged resources here.
                // If disposing is false,
                // only the following code is executed.
                DisposeUnmanagedResource();

                // Indicate that the instance has been disposed.
                disposed = true;
            }
        }
        #endregion
    }
}
