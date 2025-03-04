using HotelManagementApp.Classes;
using HotelManagementApp.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementApp.User_Controls
{
    public partial class UC_BookingManagement : UserControl
    {

        function function = new function();
        public UC_BookingManagement()
        {
            InitializeComponent();
        }

        private void UC_BookingManagement_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            //string query = ClassBooking.TABLE_Bookings + " ORDER BY BID DESC";

            //DataSet dataSet = function.getData(query);
            //dataGridView.DataSource = dataSet.Tables[0];
        }

        //private bool isFilterRowVisible = false; // Mặc định ẩn

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                titleID.Text = "ID: " + row.Cells["BID"].Value.ToString();
                ClassRoom room = new ClassRoom(row.Cells[0].Value.ToString());
                rooNo.Text = room.getRoomID();
                pricePerNight.Text = room.RPricePerNight.ToString();
                ClassRoom_Type type = room.getRoomType();
                roomType.Text = type.RType;
                quantityBeds.Text = type.RTBedCount.ToString();
                quantityGuests.Text = type.RTMaxGuests.ToString();

                bookingStatus.Text = row.Cells["BStatus"].Value.ToString();
                timeCheckIn.Text = row.Cells["BTimeCheckIn"].Value.ToString();
                timeCheckOut.Text = row.Cells["BTimeCheckOut"].Value.ToString();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBooking addBooking = new AddBooking();
            addBooking.ShowDialog();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //edit booking
        }

        //private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (isFilterRowVisible && e.RowIndex == 0) // Chỉ lọc nếu nhập vào hàng đầu tiên
        //    {
        //        string filterString = "";
        //        DataTable dt = (DataTable)dataGridView.DataSource;

        //        for (int i = 0; i < dt.Columns.Count; i++)
        //        {
        //            string cellValue = dataGridView.Rows[0].Cells[i].Value?.ToString();
        //            if (!string.IsNullOrEmpty(cellValue))
        //            {
        //                if (filterString != "") filterString += " AND ";
        //                filterString += $"[{dt.Columns[i].ColumnName}] LIKE '%{cellValue}%'";
        //            }
        //        }

        //        dt.DefaultView.RowFilter = filterString; // Áp dụng lọc
        //    }
        //}

        //private void dataGridView_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Right)
        //    {
        //        var hitTestInfo = dataGridView.HitTest(e.X, e.Y);

        //        if (hitTestInfo.RowIndex >= 0) // Kiểm tra có hàng hay không
        //        {
        //            dataGridView.ClearSelection();
        //            dataGridView.Rows[hitTestInfo.RowIndex].Selected = true; // Chọn hàng
        //            CreateContextMenuRightClick();
        //            contextMenuStrip.Show(dataGridView, new Point(e.X, e.Y)); // Hiển thị menu
        //        }
        //    }
        //}
        //private void CreateContextMenuRightClick()
        //{
        //    contextMenuStrip.Items.Clear();
        //    contextMenuStrip.Items.Add("Edit ", null, demo);
        //    contextMenuStrip.Items.Add("Sửa hàng", null, demo);
        //    contextMenuStrip.Items.Add("Làm mới", null, demo);
        //}

        //private void demo(object sender, EventArgs e)
        //{

        //}

        //private void ToggleFilterRow()
        //{
        //    if (!isFilterRowVisible)
        //    {
        //        // Hiển thị hàng filter
        //        DataTable dt = (DataTable)dataGridView.DataSource;
        //        DataRow filterRow = dt.NewRow();
        //        dt.Rows.InsertAt(filterRow, 0);
        //        isFilterRowVisible = true;
        //    }
        //    else
        //    {
        //        // Ẩn hàng filter
        //        DataTable dt = (DataTable)dataGridView.DataSource;
        //        if (dt.Rows.Count > 0)
        //        {
        //            dt.Rows.RemoveAt(0); // Xóa hàng đầu tiên
        //        }
        //        isFilterRowVisible = false;
        //    }
        //}
    }
}
