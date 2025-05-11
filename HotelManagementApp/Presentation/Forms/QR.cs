using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using Business;

namespace Presentation.Forms
{
    public partial class QR : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private Timer timer;
        public event Action<DataTransferObject.CustomerDTO> OnCustomerScanned;
        public QR()
        {
            InitializeComponent();
        }

        private void QR_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("Không tìm thấy webcam!");
                return;
            }

            // Khởi tạo webcam đầu tiên
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
        }
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pictureBoxWebcam.Image = bitmap;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Bắt đầu webcam
            videoSource.Start();

            // Khởi tạo Timer để quét QR
            timer = new Timer();
            timer.Interval = 100; // Quét mỗi 100ms
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        private void HandleCustomerScanned(DataTransferObject.CustomerDTO customer)
        {
            var customerBusiness = new CustomerBusiness();
            var dbCustomer = customerBusiness.GetCustomerById(customer.CId);

            if (dbCustomer != null)
            {
                // Khách đã có, trả về luôn
                OnCustomerScanned?.Invoke(dbCustomer);
                this.Close();
            }
            else
            {
                // Khách chưa có, mở form AddCus để nhập số điện thoại
                var addCusForm = new AddCus();
                addCusForm.SetCustomerData(customer, false);
                addCusForm.FocusPhoneField();
                if (addCusForm.ShowDialog() == DialogResult.OK)
                {
                    // Sau khi thêm mới, chỉ cần đóng QR, KHÔNG gọi lại OnCustomerScanned
                    this.Close();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBoxWebcam.Image != null)
            {
                Bitmap bitmap = new Bitmap(pictureBoxWebcam.Image);
                try
                {
                    BarcodeReader reader = new BarcodeReader();
                    var result = reader.Decode(bitmap);
                    if (result != null)
                    {
                        txtQRResult.Text = result.Text;
                        timer.Stop();
                        videoSource.SignalToStop();
                        string[] parts = result.Text.Split('|');
                        if (parts.Length >= 7)
                        {
                            var customer = new DataTransferObject.CustomerDTO
                            {
                                CId = parts[0],
                                Name = parts[2],
                                Gender = parts[4] == "Nam" ? "Male" : (parts[4] == "Nữ" ? "Female" : "Other"),
                                Address = parts[5],
                                Type = "New"
                            };
                            HandleCustomerScanned(customer);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Định dạng QR code không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            timer.Start();
                        }
                    }
                }
                catch (Exception ex)
                {
                    txtQRResult.Text = "Lỗi: " + ex.Message;
                }
                finally
                {
                    bitmap.Dispose();
                }
            }
        }

        private void QR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource = null;
            }
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            timer?.Stop();
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
            }

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
                openFileDialog.Title = "Chọn ảnh chứa mã QR";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (Bitmap bitmap = new Bitmap(openFileDialog.FileName))
                        {
                            pictureBoxWebcam.Image = new Bitmap(bitmap);
                            BarcodeReader reader = new BarcodeReader
                            {
                                Options = new ZXing.Common.DecodingOptions { TryHarder = true }
                            };
                            var result = reader.Decode(bitmap);
                            if (result != null)
                            {
                                txtQRResult.Text = result.Text;
                                string[] parts = result.Text.Split('|');
                                if (parts.Length >= 7)
                                {
                                    var customer = new DataTransferObject.CustomerDTO
                                    {
                                        CId = parts[0],
                                        Name = parts[2],
                                        Gender = parts[4] == "Nam" ? "Male" : (parts[4] == "Nữ" ? "Female" : "Other"),
                                        Address = parts[5],
                                        Type = "New"
                                    };
                                    HandleCustomerScanned(customer);
                                    return;
                                }
                                else
                                {
                                    MessageBox.Show("Định dạng QR code không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                txtQRResult.Text = "Không tìm thấy mã QR trong ảnh.";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        txtQRResult.Text = "Lỗi: " + ex.Message;
                    }
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (timer != null && timer.Enabled)
            {
                timer.Stop();
            }

            // Dừng webcam nếu đang chạy
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
            }

            // Xóa hình ảnh trong pictureBoxWebcam
            pictureBoxWebcam.Image = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
