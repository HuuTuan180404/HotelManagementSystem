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

        private ClassRoom_Type classRooms_Type;

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
            string query = $"SELECT RStatus FROM {ClassRoom_Status.TABLE_NAME}";

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
                        comboboxStatus.Items.Add(reader["RStatus"].ToString());
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
            string query = $"SELECT [RType] FROM {ClassRoom_Type.TABLE_NAME}";

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
                        comboboxRoomType.Items.Add(reader["RType"].ToString());
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
            classRooms_Type = new ClassRoom_Type(groupboxType.Text);
            lbBedCount.Text = classRooms_Type.RTBedCount.ToString();
            lbMaxGuests.Text = classRooms_Type.RTMaxGuests.ToString();
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
            if (room.isExists())
            {
                MessageBox.Show("Phòng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                room.RStatus = comboboxStatus.Text;
                room.RType = comboboxRoomType.Text;
                room.RPricePerNight = Convert.ToDecimal(lbPrice.Text);
                room.RDescription = lbDescription.Text;

                if (room.insertInto())
                {
                    DataChanged?.Invoke();
                    MessageBox.Show("Successfully!", "Thanh cong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void editType_Click(object sender, EventArgs e)
        {
            MessageBox.Show("editType_Click", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void editStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("editType_Click", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void numRoom_KeyUp(object sender, KeyEventArgs e)
        {
            numRoom_ValueChanged(this, null);
        }

        private void floor_KeyUp(object sender, KeyEventArgs e)
        {
            floor_ValueChanged(this, null);
        }

    }
}
