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
using static Guna.UI2.Native.WinApi;

namespace Presentation.User_Controls
{
    public partial class UC_BookingManagement : UserControl
    {
        BookingB BookingB;
        RoomB RoomB;
        CustomerBusiness CustomerBusiness;

        public UC_BookingManagement()
        {
            InitializeComponent();
            BookingB = new BookingB();
            RoomB = new RoomB();
            CustomerBusiness = new CustomerBusiness();
            LoadData(BookingB.GetAllBookings());
        }

        private void LoadData(List<BookingDTO> currentList)
        {
            currentList.Sort((a, b) => -a.BCreateAt.CompareTo(b.BCreateAt));
            dataGridView.DataSource = currentList;
            RenameColumns();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
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
            try
            {
                CustomerDTO customerDTO = CustomerBusiness.GetCustomerById(id);
                if (customerDTO != null)
                {
                    customerID.Text = customerDTO.CId;
                    fullName.Text = customerDTO.Name;
                    phoneNumber.Text = customerDTO.Phone;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
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
            DialogResult dialogResult = addBooking.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                LoadData(BookingB.GetAllBookings());
            }
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

            //OK
            contextMenuStrip.Items.Add("Xem", Properties.Resources.show_password, (sender, e) => { View(row); });

            // OK
            contextMenuStrip.Items.Add("Nhận phòng ", Properties.Resources.checkedIn, (sender, e) =>
            {
                try
                {
                    string status = row.Cells["BStatus"].Value.ToString();
                    if (status != "Confirmed")
                    {
                        MessageBox.Show("Không thể nhận phòng");
                        return;
                    }

                    RoomDTO roomDTO = RoomB.GetRoom(row.Cells["RId"].Value.ToString());
                    if (RoomB.RoomIsAvailable(roomDTO.RId))
                    {
                        CheckIn checkIn = new CheckIn(roomDTO.RId, true);
                        checkIn.DataChanged += this.DataRoomsChanged;
                        checkIn.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show(roomDTO.RStatusDescription, "Không thể nhận phòng",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Không có lịch đặt nào");
                }
            });

            // OK
            contextMenuStrip.Items.Add("Thêm dịch vụ", null, (sender, e) =>
            {
                if (row.Cells["BStatus"].Value.ToString() == "CheckedIn")
                {
                    UseServide useServide = new UseServide(row.Cells[0].Value.ToString());
                    useServide.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không thể thực hiện",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                }
            });

            //OK
            contextMenuStrip.Items.Add("Trả phòng - Thanh toán", null, (sender, e) =>
            {
                try
                {
                    string status = row.Cells["BStatus"].Value.ToString();
                    if (status == "CheckedIn" || status == "Expired")
                    {
                        string id = row.Cells[0].Value.ToString();
                        Payment payment = new Payment(id); // mã payment là mã BId
                        DialogResult dialogResult = payment.ShowDialog();
                        if (dialogResult == DialogResult.OK)
                        {
                            BookingB.ChuyenTrangThai(id, "CheckedOut");
                            LoadData(BookingB.GetAllBookings());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể thực hiện",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            });
        }

        private void DataRoomsChanged(object sender, EventArgs e)
        {
            LoadData(BookingB.GetAllBookings());
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

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {            
            int a = BookingB.DatPhongOnl(RoomB);
            LoadData(BookingB.GetAllBookings());
        }
    }
}
