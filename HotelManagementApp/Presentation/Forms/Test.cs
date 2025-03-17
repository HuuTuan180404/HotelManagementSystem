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
        private FilterInfoCollection CaptureDevices;
        private VideoCaptureDevice VideoSource;

        public Test()
        {
            InitializeComponent();
            StartCamera();
        }

        private void StartCamera()
        {
            CaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            VideoSource = new VideoCaptureDevice(CaptureDevices[0].MonikerString);
            VideoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
            VideoSource.Start();
        }

        private bool isQRCodeScanned = false; // Tránh đọc QR nhiều lần
        private bool isScanning = false;

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (!isScanning) return; // Chỉ quét khi nhấn btnStart

            try
            {
                using (Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone()) // Clone ảnh từ camera
                {
                    BarcodeReader reader = new BarcodeReader();
                    Result result = reader.Decode(bitmap);

                    if (result != null)
                    {
                        isScanning = false;
                        this.Invoke((MethodInvoker)delegate
                        {
                            show.Text = result.Text;
                            MessageBox.Show("Mã QR: " + result.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        });
                        stopCamera(); // Tắt camera
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xử lý QR: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BookingManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnStop_Click(sender, e);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stopCamera();
        }

        private void stopCamera()
        {
            isScanning = false;
            if (VideoSource != null)
            {
                if (VideoSource.IsRunning)
                {
                    //VideoSource.SignalToStop();
                    //VideoSource.WaitForStop();
                    VideoSource.Stop();
                }
                VideoSource.NewFrame -= VideoSource_NewFrame;
                VideoSource = null;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (VideoSource == null || !VideoSource.IsRunning)
            {
                StartCamera();
            }
            isScanning = true;
        }
    }
}
