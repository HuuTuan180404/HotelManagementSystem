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

        String query;

        public UC_RoomManagement()
        {
            InitializeComponent();
            List<string> roomStatusList = Enum.GetNames(typeof(EnumRoomStatus)).ToList();
            comboboxOtherStatus.DataSource = roomStatusList;
        }

        private void Room_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnAllRoom_Click(object sender, EventArgs e)
        {
            btnAllRoom.Checked = true;
            comboboxOtherStatus.BorderColor = Color.FromArgb(185, 189, 199);
            comboboxOtherStatus.ForeColor = Color.FromArgb(185, 189, 199);

            loadData();
        }

        private void FormatColumnHeaders()
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.HeaderText = ConvertColumnName(column.HeaderText);
            }
        }

        // Hàm chuyển đổi tên cột SQL sang dạng dễ đọc
        private string ConvertColumnName(string columnName)
        {
            switch (columnName)
            {
                case "RooID": return "ID";
                case "RooNo": return "Phòng";
                case "RooType": return "Loại Phòng";
                case "RooBed": return "Số Giường";
                case "RooCustomer": return "Số Khách";
                case "RooPrice": return "Giá Tiền";
                case "RooStatus": return "Trạng Thái";
                case "RooNote": return "Ghi Chú";
                case "RooFloor": return "Tầng";
                default: return columnName; // Giữ nguyên nếu không có trong danh sách
            }
        }

        // double click vào 1 record
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex]; // Lấy dòng được chọn

                string roomID = row.Cells["RooID"].Value.ToString();

                RoomDetail roomDetail = new RoomDetail(new function().getRoom(roomID));
                if (roomDetail.ShowDialog() == DialogResult.OK)
                {
                    Room_Load(this, null);
                }
            }
        }

        private void comboboxOtherStatus_Click(object sender, EventArgs e)
        {
            btnAllRoom.Checked = false;
            comboboxOtherStatus.BorderColor = Color.FromArgb(19, 102, 217);
            comboboxOtherStatus.ForeColor = Color.FromArgb(19, 102, 217);

            query = "SELECT [RooID],[RooNo] ,[RooType] ,[RooBed] ," +
                "CONCAT('Floor- ',[RooFloor]) as RooFloor ,[RooCustomer] ,[RooPrice] ," +
                "[RooStatus] ,[RooNote] FROM [HotelManagementSystem].[dbo].[Rooms] " +
                "WHERE RooStatus = @RooStatus";

            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@RooStatus", comboboxOtherStatus.SelectedItem.ToString());

            DataSet dataSet = function.getDataSet(cmd);
            dataGridView.DataSource = dataSet.Tables[0];
        }

        private void comboboxOtherStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "SELECT [RooID],[RooNo] ,[RooType] ,[RooBed] ," +
                "CONCAT('Floor- ',[RooFloor]) as RooFloor ,[RooCustomer] ,[RooPrice] ," +
                "[RooStatus] ,[RooNote] FROM [HotelManagementSystem].[dbo].[Rooms] " +
                "WHERE RooStatus = @RooStatus";

            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@RooStatus", comboboxOtherStatus.SelectedItem.ToString());

            DataSet dataSet = function.getDataSet(cmd);
            dataGridView.DataSource = dataSet.Tables[0];
        }

        private void loadData()
        {
            query = "SELECT [RooID],[RooNo] ,[RooType] ,[RooBed] ," +
                "CONCAT('Floor- ',[RooFloor]) as RooFloor ,[RooCustomer] ,[RooPrice] ," +
                "[RooStatus] ,[RooNote] FROM [HotelManagementSystem].[dbo].[Rooms]";

            DataSet dataSet = function.getData(query);
            dataGridView.DataSource = dataSet.Tables[0];
            FormatColumnHeaders();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            AddRoom addRoom = new AddRoom();
            addRoom.DataChanged += loadData;
            addRoom.ShowDialog();

        }
    }
}
