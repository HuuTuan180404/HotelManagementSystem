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

namespace HotelManagementApp.Forms
{
    public partial class BookingManagement : Form
    {
        private FilterInfoCollection CaptureDevices;
        private VideoCaptureDevice VideoSource;

        public BookingManagement()
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

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            picturebox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void BookingManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnStop_Click(sender, e);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (VideoSource != null && VideoSource.IsRunning)
            {
                VideoSource.SignalToStop();
                VideoSource.WaitForStop();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (picturebox.Image == null)
            {
                MessageBox.Show("Không có ảnh để quét!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Bitmap bitmap = new Bitmap(picturebox.Image); // Tạo bản sao tránh lỗi đa luồng

            BarcodeReader reader = new BarcodeReader();
            Result result = reader.Decode(bitmap);

            if (result != null)
            {
                show.Text = result.Text;
                MessageBox.Show("Mã QR: " + result.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã QR!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            bitmap.Dispose();
        }
    }
}
