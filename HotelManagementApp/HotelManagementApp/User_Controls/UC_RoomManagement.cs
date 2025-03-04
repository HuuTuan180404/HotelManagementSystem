using Guna.UI2.WinForms;
using HotelManagementApp.Classes;
using HotelManagementApp.Forms;
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
using TheArtOfDevHtmlRenderer.Adapters;

namespace HotelManagementApp.User_Controls
{
    public partial class UC_RoomManagement : UserControl
    {
        function function = new function();

        string query;

        public UC_RoomManagement()
        {
            InitializeComponent();
        }

        private void loadData_Status()
        {
            query = $"SELECT RStatus FROM {ClassRoom_Status.TABLE_NAME}";
            using (SqlConnection conn = function.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    comboboxOtherStatus.Items.Clear();

                    while (reader.Read())
                    {
                        comboboxOtherStatus.Items.Add(reader["RStatus"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                }
            }
            comboboxOtherStatus.SelectedIndex = 0;
        }

        private void Room_Load(object sender, EventArgs e)
        {
            loadData_Status();
            loadData();
        }

        private void btnAllRoom_Click(object sender, EventArgs e)
        {
            btnAllRoom.Checked = true;
            comboboxOtherStatus.BorderColor = Color.FromArgb(185, 189, 199);
            comboboxOtherStatus.ForeColor = Color.FromArgb(185, 189, 199);

            loadData();
        }

        private void dataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dataGridView.HitTest(e.X, e.Y);

                if (hitTestInfo.RowIndex >= 0) // Kiểm tra có hàng hay không
                {
                    dataGridView.ClearSelection();
                    dataGridView.Rows[hitTestInfo.RowIndex].Selected = true; // Chọn hàng
                    CreateContextMenuRightClick();
                    contextMenuStrip.Show(dataGridView, new Point(e.X, e.Y)); // Hiển thị menu
                }
            }
        }

        private void demo(object sender, EventArgs e)
        {

        }

        private void CreateContextMenuRightClick()
        {
            contextMenuStrip.Items.Clear();
            contextMenuStrip.Items.Add("Edit", null, demo);
            contextMenuStrip.Items.Add("View detail", null, demo);
            contextMenuStrip.Items.Add("Làm mới", null, demo);
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                ClassRoom room = new ClassRoom(row.Cells[0].Value.ToString());

                Debug.WriteLine(room.ToString());

                RoomDetail roomDetail = new RoomDetail(room);
                if (roomDetail.ShowDialog() == DialogResult.OK)
                    Room_Load(this, null);
            }
        }

        private void comboboxOtherStatus_Click(object sender, EventArgs e)
        {
            btnAllRoom.Checked = false;
            comboboxOtherStatus.BorderColor = Color.FromArgb(19, 102, 217);
            comboboxOtherStatus.ForeColor = Color.FromArgb(19, 102, 217);
            filterByStatus();
        }

        private void comboboxOtherStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterByStatus();
        }

        private void filterByStatus()
        {
            query = ClassRoom.TABLE_ROOMS_DETAIL + " WHERE RStatus = @RStatus";

            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@RStatus", comboboxOtherStatus.SelectedItem.ToString());

            DataSet dataSet = function.getDataSet(cmd);
            dataGridView.DataSource = dataSet.Tables[0];
        }

        private void loadData()
        {
            DataSet dataSet = function.getDataSet(new SqlCommand("EXEC Table_Rooms_Detail"));
            dataGridView.DataSource = dataSet.Tables[0];
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            AddRoom addRoom = new AddRoom();
            addRoom.DataChanged += loadData;
            addRoom.ShowDialog();
        }


        private void btnFilter_Click(object sender, EventArgs e)
        {

        }
    }
}
