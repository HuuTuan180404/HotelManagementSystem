using AForge.Video;
using AForge.Video.DirectShow;
using HotelManagementApp.Classes;
using HotelManagementApp.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//using ZXing.Common;
//using AForge.Video;
//using AForge.Video.DirectShow;
using System.Threading;
using System.Runtime.InteropServices;

namespace HotelManagementApp.Forms
{
    public partial class AddBooking : Form
    {

        private FilterInfoCollection CaptureDevices;
        private VideoCaptureDevice VideoSource;

        config_database function = new config_database();
        static List<ClassRoom> classRooms = ClassRoom.getAllRooms();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;


        public AddBooking()
        {
            InitializeComponent();
            loadData_comboboxRoomType();
        }

        private void filterRoom(List<ClassRoom> list)
        {
            flowLayoutPanel.Controls.Clear();
            foreach (var i in list)
            {
                itemRoom item = new itemRoom(i);
                flowLayoutPanel.Controls.Add(item);
            }
        }


        private void loadData_comboboxRoomType()
        {
            string query = $"SELECT * FROM {ClassRoom_Type.TABLE_NAME}";
            string s = "";

            using (SqlConnection conn = function.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    comboboxRoomType.Items.Clear();

                    comboboxRoomType.Items.Add("All");

                    while (reader.Read())
                    {
                        s = $"{reader["RType"].ToString()} - Bed: {reader["RTBedCount"].ToString()} - Guest: {reader["RTMaxGuests"].ToString()}";
                        comboboxRoomType.Items.Add(s);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                }
            }
            comboboxRoomType.SelectedIndex = 0;
        }



        bool itemIsShow = false;

        private void btnShowItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (itemIsShow)
            {
                btnShowItem.Image = Properties.Resources.left;
                timer2.Stop();
                flowLayoutPanel.AutoScroll = false;
            }
            else
            {
                btnShowItem.Image = Properties.Resources.down;
                flowLayoutPanel.AutoScroll = true;
                timer2.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (itemIsShow == false)
            {
                flowLayoutPanel.Height += 10;
                if (flowLayoutPanel.Height >= flowLayoutPanel.MaximumSize.Height)
                {
                    itemIsShow = true;
                    timer1.Stop();
                }
            }
            else
            {
                flowLayoutPanel.Height -= 10;
                if (flowLayoutPanel.Height <= flowLayoutPanel.MinimumSize.Height)
                {
                    itemIsShow = false;
                    timer1.Stop();
                }
            }
        }

        private void btnShowItem_Leave(object sender, EventArgs e)
        {
            if (itemIsShow) { btnShowItem.PerformClick(); }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (itemRoom.IS_SELECTED)
            {
                btnShowItem.Text = itemRoom.ID;
                timer2.Start();
                itemRoom.IS_SELECTED = false;
                btnShowItem.PerformClick();
            }
        }

        private void timeCheckin_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                timeCheckin.Text = string.Empty;
            }
        }

        private void timeCheckout_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                timeCheckout.Text = string.Empty;
            }
        }

        private void dateCheckin_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                dateCheckin.Text = string.Empty;
            }
        }

        private void dateCheckout_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                dateCheckout.Text = string.Empty;
            }
        }

        private void timeCheckin_Click(object sender, EventArgs e)
        {
            timeCheckin.SelectionStart = 0;
        }

        private void timeCheckout_Click(object sender, EventArgs e)
        {
            timeCheckout.SelectionStart = 0;
        }

        private void dateCheckin_Click(object sender, EventArgs e)
        {
            dateCheckin.SelectionStart = 0;
        }

        private void dateCheckout_Click(object sender, EventArgs e)
        {
            dateCheckout.SelectionStart = 0;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void timeCheckin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClearFilter_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnClearFilter, "Clear fields");
        }

        private void Control_ValueChanged(object sender, EventArgs e)
        {
            if (floor.Value == -1 && comboboxRoomType.SelectedIndex == 0)
            {
                btnClearFilter.Visible = false;
                filterRoom(ClassRoom.filterForAddBookingForm(classRooms, Convert.ToInt32(floor.Value), comboboxRoomType.SelectedItem.ToString()));
                return;
            }
            btnClearFilter.Visible = true;
            filterRoom(ClassRoom.filterForAddBookingForm(classRooms, Convert.ToInt32(floor.Value), comboboxRoomType.SelectedItem.ToString()));
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            floor.Value = -1;
            comboboxRoomType.SelectedIndex = 0;
            AddBooking_Load(this, null);
        }

        private void btnClearFilter_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void AddBooking_Load(object sender, EventArgs e)
        {
            filterRoom(classRooms);
        }

        private void AddBooking_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopCamera();
        }

        private void StartCamera()
        {
            CaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            VideoSource = new VideoCaptureDevice(CaptureDevices[0].MonikerString);
            VideoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
            VideoSource.Start();
        }

        private async void btnQR_Click(object sender, EventArgs e)
        {
            StartCamera();
        }
        private bool isQRCodeScanned = false;
        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap1 = (Bitmap)eventArgs.Frame.Clone();
            //btnQR.Image = (Bitmap)eventArgs.Frame.Clone();
            if (btnQR.Image == null)
            {
                MessageBox.Show("Không có ảnh để quét!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Bitmap bitmap = new Bitmap(btnQR.Image);
            BarcodeReader reader = new BarcodeReader();
            Result result = reader.Decode(bitmap);
            if (result != null)
            {
                MessageBox.Show("Mã QR: " + result.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã QR!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            stopCamera();
            bitmap.Dispose();
        }

        private void stopCamera()
        {
            if (VideoSource != null)
            {
                if (VideoSource.IsRunning)
                {
                    VideoSource.SignalToStop();
                    VideoSource.WaitForStop();
                    VideoSource.Stop();
                }
                VideoSource.NewFrame -= VideoSource_NewFrame;
                VideoSource = null;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            stopCamera();
            //this.Close();
            this.Invoke((MethodInvoker)delegate
            {
                this.Close();
            });
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            moveForm(sender, e);
        }

        private void moveForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}