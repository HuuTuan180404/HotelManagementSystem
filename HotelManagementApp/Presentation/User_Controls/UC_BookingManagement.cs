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
            
        }

        //private bool isFilterRowVisible = false; // Mặc định ẩn

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                
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

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
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
        private void CreateContextMenuRightClick()
        {
            contextMenuStrip.Items.Clear();
            contextMenuStrip.Items.Add("Edit ", null, demo);
            contextMenuStrip.Items.Add("Sửa hàng", null, demo);
            contextMenuStrip.Items.Add("Làm mới", null, demo);
        }

        private void demo(object sender, EventArgs e)
        {

        }

        private void ToggleFilterRow()
        {
            
        }
    }
}
