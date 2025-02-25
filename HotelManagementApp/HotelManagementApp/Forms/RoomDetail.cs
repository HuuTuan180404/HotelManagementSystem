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

        private int RID;

        private DataGridViewRow row;

        private ClassRooms_Type classRooms_Type;

        public RoomDetail(DataGridViewRow row)
        {
            InitializeComponent();
            this.row = row;
            this.RID = Convert.ToInt32(row.Cells["RID"].Value.ToString());
        }

        private void RoomDetail_Load(object sender, EventArgs e)
        {
            initControls();
            initPreview();
        }

        private void initPreview()
        {
            groupboxPreview.Text += "\tID: " + this.RID;
            lbBedCount.Text = row.Cells["RTBedCount"].Value.ToString();
            lbMaxGuests.Text = row.Cells["RTMaxGuests"].Value.ToString();
        }

        private void initControls()
        {
            loadData_comboboxRoomType();
            loadData_comboboxOtherStatus();

            floor.Value = Convert.ToInt32(row.Cells["RFloor"].Value.ToString());
            numRoom.Value = Convert.ToInt32(row.Cells["RNo"].Value.ToString());

            int index = comboboxRoomType.Items.IndexOf(row.Cells["RTType"].Value.ToString());

            if (index >= 0)
            {
                comboboxRoomType.SelectedIndex = index;
            }

            index = comboboxStatus.Items.IndexOf(row.Cells["RSStatus"].Value.ToString());
            if (index >= 0)
            {
                comboboxStatus.SelectedIndex = index;
            }

            price.Text = row.Cells["RPricePerNight"].Value.ToString();
            note.Text = row.Cells["RDescription"].Value.ToString();
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
                ClassRoom room = new ClassRoom(this.RID);

                if (room.deleteRecordOfRoom())
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
                ClassRooms_Status classStatus = new ClassRooms_Status(lbStatus.Text);
                classStatus.setRooms_StatusByRSStatus();

                ClassRoom classRoom = new ClassRoom(this.RID, Convert.ToInt32(lbFloor.Text), Convert.ToInt32(lbNo.Text),
                    Convert.ToDecimal(lbPrice.Text), classStatus.GetRSID(), classRooms_Type.GetRTID(), lbDescription.Text);

                if (classRoom.updateRoom())
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
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
