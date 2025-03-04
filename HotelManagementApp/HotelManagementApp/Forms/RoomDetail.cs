using HotelManagementApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using TheArtOfDevHtmlRenderer.Adapters;
using System.Collections;


namespace HotelManagementApp.Forms
{
    public partial class RoomDetail : Form
    {
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private function function = new function();

        private ClassRoom room;
        private ClassRoom_Type classRooms_Type;

        public RoomDetail(ClassRoom room)
        {
            InitializeComponent();
            this.room = room;
            classRooms_Type = room.getRoomType();
        }

        private void RoomDetail_Load(object sender, EventArgs e)
        {
            initControls();
            initPreview();
        }

        private void initPreview()
        {
            groupboxPreview.Text += "\tID: " + this.room.getRoomID();

            lbBedCount.Text = classRooms_Type.RTBedCount.ToString();
            lbMaxGuests.Text = classRooms_Type.RTMaxGuests.ToString();
        }

        private void initControls()
        {
            loadData_RoomType();
            loadData_Status();

            lbFloor.Text=room.RFloor.ToString();
            lbNo.Text=room.RNo.ToString();

            int index = comboboxRoomType.Items.IndexOf(room.RType);

            if (index >= 0)
            {
                comboboxRoomType.SelectedIndex = index;
            }

            index = comboboxStatus.Items.IndexOf(room.RStatus);
            if (index >= 0)
            {
                comboboxStatus.SelectedIndex = index;
            }

            price.Text = room.RPricePerNight.ToString();
            note.Text = room.RDescription;
        }

        public void loadData_Status()
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

        private void loadData_RoomType()
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

        private void btnMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            toolTipRoomDetail.SetToolTip(btnUpdate, "Update room");
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            toolTipRoomDetail.SetToolTip(btnDelete, "Delete room");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (alert("Bạn chắc chắn muốn XÓA phòng ?"))
            {
                if (room.delete())
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private bool alert(string message)
        {
            DialogResult result = MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                return true;
            return false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (alert("Bạn chắc chắn muốn CHỈNH SỬA phòng ?"))
            {
                room.RPricePerNight = Convert.ToDecimal(price.Text);
                room.RStatus = comboboxStatus.Text;
                room.RType = comboboxRoomType.Text;
                room.RDescription = note.Text;

                if (room.updateRoom())
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void comboboxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupboxType.Text = comboboxRoomType.SelectedItem.ToString();
            classRooms_Type = new ClassRoom_Type(groupboxType.Text);
            lbBedCount.Text = classRooms_Type.RTBedCount.ToString();
            lbMaxGuests.Text = classRooms_Type.RTMaxGuests.ToString();
        }

        private void comboboxStatus_SelectedValueChanged(object sender, EventArgs e)
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
    }
}
