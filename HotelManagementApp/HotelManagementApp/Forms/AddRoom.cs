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

        private ClassRooms_Type classRooms_Type;

        public event Action DataChanged;

        public AddRoom()
        {
            InitializeComponent();
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
            loadData_comboboxRoomType();
            loadData_comboboxOtherStatus();
            price.Text = "0";
            note.Text = "";
        }

        private void loadData_comboboxOtherStatus()
        {
            string query = @"
                        SELECT RSStatus
                        FROM (" + ClassRooms_Status.TABLE_Rooms_Status + ") AS A";

            using (SqlConnection conn = function.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    comboboxStatus.Items.Clear();
                    while (reader.Read())
                    {
                        comboboxStatus.Items.Add(reader["RSStatus"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                }
            }
            comboboxStatus.SelectedIndex = 0;
        }

        private void loadData_comboboxRoomType()
        {
            string query = @"
                        SELECT [RTType]
                        FROM (" + ClassRooms_Type.TABLE_Rooms_Type + ") AS A";

            using (SqlConnection conn = function.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    comboboxRoomType.Items.Clear();
                    while (reader.Read())
                    {
                        comboboxRoomType.Items.Add(reader["RTType"].ToString());
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

        private void floor_ValueChanged(object sender, EventArgs e)
        {
            lbFloor.Text = floor.Value.ToString();
        }

        private void numRoom_ValueChanged(object sender, EventArgs e)
        {
            lbNo.Text = numRoom.Value.ToString();
        }

        private void comboboxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupboxType.Text = comboboxRoomType.SelectedItem.ToString();
            classRooms_Type = new ClassRooms_Type(groupboxType.Text);
            classRooms_Type.setRooms_TypeByRTType();
            lbBedCount.Text = classRooms_Type.GetRTBedCount().ToString();
            lbMaxGuests.Text = classRooms_Type.GetRTMaxGuests().ToString();
        }

        private void comboboxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbStatus.Text = comboboxStatus.SelectedItem.ToString();
        }

        private void price_TextChanged(object sender, EventArgs e)
        {
            lbPrice.Text = price.Text;
        }

        private void note_TextChanged(object sender, EventArgs e)
        {
            lbDescription.Text = note.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClassRoom room = new ClassRoom(Convert.ToInt32(lbFloor.Text), Convert.ToInt32(lbNo.Text));
            if (room.isExistsRoom())
            {
                MessageBox.Show("Phòng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Phòng có thể thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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

        private void editType_Click(object sender, EventArgs e)
        {

        }

        private void editStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
