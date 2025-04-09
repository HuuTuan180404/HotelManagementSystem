using Business;
using DataTransferObject;
using Presentation.Forms;
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

namespace Presentation.User_Controls
{
    public partial class UC_BookingManagement : UserControl
    {
        BookingB BookingB;
        RoomB RoomB;
        public UC_BookingManagement()
        {
            InitializeComponent();
            BookingB = new BookingB();
            RoomB = new RoomB();
            LoadData(BookingB.GetAllBookings());
            FirstLoad();
        }

        private void FirstLoad()
        {
            View(dataGridView.Rows[0]);
        }

        private void LoadData(List<BookingDTO> list)
        {
            dataGridView.DataSource = list;
            RenameColumns();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Debug.WriteLine(e.RowIndex);
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                View(row);
            }
        }

        private void View(DataGridViewRow row)
        {
            titleID.Text = $"ID: {row.Cells["BId"].Value.ToString()}";
            ViewCustomerInfo(row.Cells["CId"].Value.ToString());
            ViewRoomInfo(row.Cells["RId"].Value.ToString());
            ViewBookingInfo(row);
        }

        private void ViewCustomerInfo(string id)
        {

        }

        private void ViewRoomInfo(string id)
        {
            RoomDTO roomDTO = RoomB.GetRoom(id);
            if (roomDTO != null)
            {
                rooNo.Text = roomDTO.RId;
                pricePerNight.Text = roomDTO.RPricePerNight.ToString();
                roomType.Text = roomDTO.RType;
                quantityBeds.Text = roomDTO.RTBedCount.ToString();
                quantityGuests.Text = roomDTO.RTMaxGuests.ToString();
            }
        }

        private void ViewBookingInfo(DataGridViewRow row)
        {
            timeCheckIn.Text = row.Cells["BTimeCheckIn"].Value.ToString();
            timeCheckOut.Text = row.Cells["BTimeCheckOut"].Value.ToString();
            bookingStatus.Text = row.Cells["BStatus"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBooking addBooking = new AddBooking();
            addBooking.ShowDialog();
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
                    DataGridViewRow row = dataGridView.Rows[hitTestInfo.RowIndex];
                    CreateContextMenuRightClick(row);
                    contextMenuStrip.Show(dataGridView, new Point(e.X, e.Y)); // Hiển thị menu
                }
            }
        }

        private void CreateContextMenuRightClick(DataGridViewRow row)
        {
            contextMenuStrip.Items.Clear();
            contextMenuStrip.Items.Add("View ", null, (sender, e) => { View(row); });
            contextMenuStrip.Items.Add("Edit ", null, demo);
            contextMenuStrip.Items.Add("Làm mới", null, demo);
        }

        private void demo(object sender, EventArgs e)
        {

        }

        private void RenameColumns()
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                switch (column.Name)
                {
                    case "BId":
                        column.HeaderText = "Id Đặt Phòng";
                        break;
                    case "RId":
                        column.HeaderText = "Mã Phòng";
                        break;
                    case "CId":
                        column.HeaderText = "Id Khách Hàng";
                        break;
                    case "BTimeCheckIn":
                        column.HeaderText = "Nhận Phòng";
                        break;
                    case "BTimeCheckOut":
                        column.HeaderText = "Trả Phòng";
                        break;
                    case "BStatus":
                        column.HeaderText = "Trạng thái";
                        break;
                    case "BCreateAt":
                        column.HeaderText = "Ngày tạo";
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
