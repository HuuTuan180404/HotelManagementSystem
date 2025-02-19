using Guna.UI2.WinForms;
using HotelManagementApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace HotelManagementApp.User_Controls
{
    public partial class Room : UserControl
    {
        function function = new function();

        String query;

        public Room()
        {
            InitializeComponent();
        }        

        private void Room_Load(object sender, EventArgs e)
        {
            query = "SELECT TOP (1000) [RooNo] ,[RooType] ,[RooBed] ," +
                "CONCAT('Floor- ',[RooFloor]) as RooFloor ,[RooCustomer] ,[RooPrice] ," +
                "[RooStatus] ,[RooNote] FROM [HotelManagementSystem].[dbo].[Room]";

            DataSet dataSet = function.getData(query);
            dataGridView.DataSource = dataSet.Tables[0];
            FormatColumnHeaders();
        }

        private void btnAllRoom_Click(object sender, EventArgs e)
        {
            query = "SELECT TOP (1000) [RooNo] ,[RooType] ,[RooBed] ," +
                "CONCAT('Floor- ',[RooFloor]) as RooFloor ,[RooCustomer] ,[RooPrice] ," +
                "[RooStatus] ,[RooNote] FROM [HotelManagementSystem].[dbo].[Room]";

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
                case "RooID": return "Mã phòng";
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

        private void AddButtonColumn()
        {
            // Kiểm tra nếu cột button đã tồn tại thì không thêm nữa
            if (dataGridView.Columns["btnDetails"] == null)
            {
                DataGridViewImageColumn btnImage=new DataGridViewImageColumn();

                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.HeaderText = "Thao Tác"; 
                btnColumn.Text = "Xem Chi Tiết";  
                btnColumn.UseColumnTextForButtonValue = true; 
                btnColumn.Name = "btnDetails";
                dataGridView.Columns.Add(btnColumn);
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (roomType.Text.Trim() == "" || price.Text.Trim() == "")
            {
                MessageBox.Show("Please enter all fields", "Warming",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                function.insertRoom((int)floor.Value, (int)numberOfRoom.Value, roomType.Text, (int)numbeOfBed.Value,
                    (int)numberOfPeople.Value, Convert.ToInt32(price.Text), note.Text);
                Room_Load(this, null);
            }
        }

        // double click vào 1 record của phòng
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex]; // Lấy dòng được chọn

                // Lấy dữ liệu từng cột
                string roomNo = row.Cells["RooNo"].Value.ToString();
                string roomType = row.Cells["RooType"].Value.ToString();
                string bed = row.Cells["RooBed"].Value.ToString();
                string customer = row.Cells["RooCustomer"].Value.ToString();
                string price = row.Cells["RooPrice"].Value.ToString();
                string status = row.Cells["RooStatus"].Value.ToString();
                string note = row.Cells["RooNote"].Value != null ? row.Cells["RooNote"].Value.ToString() : "Không có ghi chú";

                // Tạo thông báo
                string message = $"Số phòng: {roomNo}\nLoại: {roomType}\nSố giường: {bed}\nSố khách: {customer}\nGiá: {price}\nTrạng thái: {status}\nGhi chú: {note}";

                // Hiển thị thông báo
                //MessageBox.Show(message, "Thông tin phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RoomDetail roomDetail = new RoomDetail();
                if (roomDetail.ShowDialog() == DialogResult.OK)
                {
                    //label1.Text = "Bạn đã nhập: " + form2.SelectedOption;
                    MessageBox.Show(roomDetail.SelectedOption, "Thông tin phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //roomDetail.ShowDialog();

            }
        }

    }
}
