using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Kinect2;

namespace KinectSensor.TestApp
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        Kinect2.KinectSensor kinect;
        ColorFrameReader colorReader;

        public MainWindow()
        {
            InitializeComponent();

            Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded( object sender, RoutedEventArgs e )
        {
            kinect = Kinect2.KinectSensor.Default;
            kinect.Open();
            colorReader = kinect.ColorFrameSource.OpenReader();

            CompositionTarget.Rendering += CompositionTarget_Rendering;
        }

        void CompositionTarget_Rendering( object sender, EventArgs e )
        {
            try {
                using ( var colorFrame = colorReader.AcquireLatestFrame() ) {
                    if ( colorFrame != null ) {
                        var pixels = new byte[1920*1080*4];
                        colorFrame.CopyConvertedFrameDataToArray( pixels, ColorImageFormat.Bgra );

                        ImageColor.Source = BitmapSource.Create( 1920, 1080, 96, 96, PixelFormats.Bgra32, null, pixels, 1920 * 4 );
                    }
                }
            }
            catch ( Exception ex ) {
                Trace.WriteLine( ex.Message );
            }
        }
    }
}
