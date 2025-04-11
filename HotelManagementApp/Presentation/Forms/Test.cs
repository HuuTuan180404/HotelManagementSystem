using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Presentation.Forms
{
    public partial class Test : Form
    {
        private FilterInfoCollection captureDevices;
        private VideoCaptureDevice videoSource;

        private Timer timeoutTimer;

        public Test()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            captureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (captureDevices.Count == 0)
            {
                MessageBox.Show("Không tìm thấy camera!");
                return;
            }

            videoSource = new VideoCaptureDevice(captureDevices[0].MonikerString);
            videoSource.NewFrame += VideoSource_NewFrame;
            videoSource.Start();

            timeoutTimer = new Timer();
            timeoutTimer.Interval = 3000;
            timeoutTimer.Tick += TimeoutTimer_Tick;
            timeoutTimer.Start();
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            //pictureBoxCamera.Image = bitmap;
            try
            {
                BarcodeReader reader = new BarcodeReader();
                var result = reader.Decode(bitmap);
                if (result != null)
                {
                    show.Invoke(new MethodInvoker(delegate
                    {
                        show.Text = result.Text;
                        timeoutTimer.Stop();
                        StopCamera();
                    }));
                }
            }
            catch { }
        }

        private void TimeoutTimer_Tick(object sender, EventArgs e)
        {
            timeoutTimer.Stop();
            StopCamera();
            MessageBox.Show("Không phát hiện mã QR");
        }

        private void Test_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCamera();
        }

        private void StopCamera()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource = null;
            }
        }
    }
}
