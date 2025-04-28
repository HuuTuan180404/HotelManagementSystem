using Business;
using DataTransferObject;
using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class CheckIn : Form
    {
        BookingDTO BookingDTO;

        BookingB BookingB;
        CustomerBusiness CustomerBusiness;
        RoomB RoomB;

        public event EventHandler DataChanged;

        private CheckIn()
        {
            InitializeComponent();
            BookingB = new BookingB();
            CustomerBusiness = new CustomerBusiness();
            RoomB = new RoomB();
        }

        public CheckIn(string bookingId) : this()
        {
            BookingDTO = BookingB.GetBooking(bookingId);
            FirstLoad();
        }

        public CheckIn(string roomId, bool isRoomId) : this()
        {
            BookingDTO = BookingB.GetBookingsByRoomId(roomId)
                .OrderBy(bk => bk.BTimeCheckIn)
                .Where(bk => bk.BStatus == "Confirmed" && bk.BTimeCheckOut >= DateTime.Now)
                .FirstOrDefault();

            FirstLoad();
        }

        private void FirstLoad()
        {
            if (BookingDTO != null)
            {
                RoomDTO roomDTO = RoomB.GetRoom(BookingDTO.RId);
                bookingId.Text = $"Mã đặt phòng: {BookingDTO.BId}";
                roomId.Text = $"Mã phòng: {BookingDTO.RId}";
                TypeOfRoom.Text = $"Loại phòng: {roomDTO.RType}";
                price.Text = $"Giá: {roomDTO.RPricePerNight.ToString()}";
                timeCheckIn.Text = $"CheckIn: {BookingDTO.BTimeCheckIn.ToString()}";
                timeCheckOut.Text = $"CheckOut: {BookingDTO.BTimeCheckOut.ToString()}";
            }
            else
            {
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                if (!RoomB.RoomIsAvailable(BookingDTO.RId))
                {
                    MessageBox.Show("Phòng chưa sẵn sàng để đón khách", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                CustomerDTO customer = CustomerBusiness.GetCustomerById(BookingDTO.CId);
                if (customer.Name != txtHoTen.Text ||

                    customer.CId != txtCCCD.Text ||
                    customer.Phone != txtSDT.Text)
                {
                    MessageBox.Show("Thông tin checkin không đúng!", "Thông tin sai",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn muốn nhận phòng?", "Xác nhận",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.OK)
                    {
                        BookingB.CheckIn(BookingDTO.BId);
                        RoomB.ChangeStatus(BookingDTO.RId, "Occupied");
                        DataChanged?.Invoke(this, EventArgs.Empty);
                        MessageBox.Show("Thành công!", "Thành công",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
