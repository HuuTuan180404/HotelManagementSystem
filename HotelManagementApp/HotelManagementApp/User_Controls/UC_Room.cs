using Guna.UI2.WinForms;
using HotelManagementApp.Classes;
using HotelManagementApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace HotelManagementApp.User_Controls
{
    public partial class UC_Room : UserControl
    {
        function function = new function();

        String query;

        public UC_Room()
        {
            InitializeComponent();
        }

        private void Room_Load(object sender, EventArgs e)
        {
            query = "SELECT [RooID],[RooNo] ,[RooType] ,[RooBed] ," +
                "CONCAT('Floor- ',[RooFloor]) as RooFloor ,[RooCustomer] ,[RooPrice] ," +
                "[RooStatus] ,[RooNote] FROM [HotelManagementSystem].[dbo].[Rooms]";

            DataSet dataSet = function.getData(query);
            dataGridView.DataSource = dataSet.Tables[0];
            FormatColumnHeaders();
        }

        private void btnAllRoom_Click(object sender, EventArgs e)
        {
            query = "SELECT [RooID],[RooNo] ,[RooType] ,[RooBed] ," +
                "CONCAT('Floor- ',[RooFloor]) as RooFloor ,[RooCustomer] ,[RooPrice] ," +
                "[RooStatus] ,[RooNote] FROM [HotelManagementSystem].[dbo].[Rooms]";

            DataSet dataSet = function.getData(query);
            dataGridView.DataSource = dataSet.Tables[0];
            FormatColumnHeaders();
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
                    Room_Load(this,null);
                }
            }
        }

    }
}
