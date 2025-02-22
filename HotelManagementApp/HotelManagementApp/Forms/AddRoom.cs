using HotelManagementApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementApp.Forms
{
    public partial class AddRoom : Form
    {
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        function function = new function();

        public event Action DataChanged;

        public AddRoom()
        {
            InitializeComponent();
            initForm();
        }

        private void initForm()
        {
            //floor.Maximum = ConfigManager.getTotalFloors();
            //comboboxRoomType.DataSource = Enum.GetValues(typeof(EnumRoomType));
            //comboboxStatus.DataSource = Enum.GetValues(typeof(EnumRoomStatus));

            //comboboxRoomType.SelectedIndex = 0;
            //comboboxStatus.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //string numFloor = floor.Text;
            //string numRoom = numberOfRoom.Text;
            //string rooNo = "Roo" + numFloor + "0" + numRoom;

            //string numBed = numbeOfBed.Text;
            //string numPeople = numberOfPeople.Text;
            //string type = comboboxRoomType.Text;
            //string price = this.price.Text;
            //string Status = comboboxStatus.Text;
            //string Note = this.note.Text;

            //string query = "SELECT CASE WHEN EXISTS (SELECT 1 FROM Rooms WHERE RooNo = @RooNo) THEN 1 ELSE 0 END";
            //SqlCommand sqlCommand = new SqlCommand(query);
            //sqlCommand.Parameters.AddWithValue("@RooNo", rooNo);

            //if (function.isExistsRecord(sqlCommand))
            //{
            //    MessageBox.Show("Phòng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    query = @"INSERT INTO Rooms (RooNo, RooType, RooBed, RooFloor, RooCustomer, RooPrice, RooStatus, RooNote)
            //            VALUES (@RooNo, @RooType, @RooBed, @RooFloor, @RooCustomer, @RooPrice, @RooStatus, @RooNote)";
            //    sqlCommand.CommandText = query;
            //    sqlCommand.Parameters.Clear();
            //    sqlCommand.Parameters.AddWithValue("@RooNo", rooNo);
            //    sqlCommand.Parameters.AddWithValue("@RooType", type);
            //    sqlCommand.Parameters.AddWithValue("@RooBed", Int32.Parse(numBed));
            //    sqlCommand.Parameters.AddWithValue("@RooFloor", Int32.Parse(numFloor));
            //    sqlCommand.Parameters.AddWithValue("@RooCustomer", Int32.Parse(numPeople));
            //    sqlCommand.Parameters.AddWithValue("@RooPrice", Int32.Parse(price));
            //    sqlCommand.Parameters.AddWithValue("@RooStatus", Status);
            //    sqlCommand.Parameters.AddWithValue("@RooNote", Note);

            //    if (function.editRecord(sqlCommand, "Thêm phòng"))
            //    {
            //        DataChanged?.Invoke();
            //        MessageBox.Show("Thêm phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else MessageBox.Show("Thêm phòng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnAdd, "Add");
        }
    }
}
