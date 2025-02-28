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

        private void loadData_comboboxOtherStatus()
        {
            query = @"SELECT RSStatus
                      FROM (" + ClassRooms_Status.TABLE_Rooms_Status + ") AS A";
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
                        comboboxOtherStatus.Items.Add(reader["RSStatus"].ToString());
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
            loadData_comboboxOtherStatus();
            loadData();
        }

        private void btnAllRoom_Click(object sender, EventArgs e)
        {
            btnAllRoom.Checked = true;
            comboboxOtherStatus.BorderColor = Color.FromArgb(185, 189, 199);
            comboboxOtherStatus.ForeColor = Color.FromArgb(185, 189, 199);

            loadData();
        }

        // double click vào 1 record
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                ClassRoom room = new ClassRoom(Convert.ToInt32(row.Cells["RID"].Value.ToString()));
                room.setRoomsByRID();
                
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
            query = ClassRoom.TABLE_Rooms + " WHERE RSStatus = @RSStatus";

            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@RSStatus", comboboxOtherStatus.SelectedItem.ToString());

            DataSet dataSet = function.getDataSet(cmd);
            dataGridView.DataSource = dataSet.Tables[0];
        }

        private void loadData()
        {
            query = ClassRoom.TABLE_Rooms + " ORDER BY RFloor ASC, RNo ASC;";

            DataSet dataSet = function.getData(query);
            dataGridView.DataSource = dataSet.Tables[0];
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            AddRoom addRoom = new AddRoom();
            addRoom.DataChanged += loadData;
            addRoom.ShowDialog();
        }

    }
}
