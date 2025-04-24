using Business;
using DataTransferObject;
using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void FirstLoad()
        {
            RoomDTO roomDTO = RoomB.GetRoom(BookingDTO.RId);
            bookingId.Text = $"Mã đặt phòng: {BookingDTO.BId}";
            roomId.Text = $"Mã phòng: {BookingDTO.RId}";
            TypeOfRoom.Text = $"Loại phòng: {roomDTO.RType}";
            price.Text = $"Giá: {roomDTO.RPricePerNight.ToString()}";
            timeCheckIn.Text = $"CheckIn: {BookingDTO.BTimeCheckIn.ToString()}";
            timeCheckOut.Text = $"CheckOut: {BookingDTO.BTimeCheckOut.ToString()}";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            CustomerDTO customer = CustomerBusiness.GetCustomerById(BookingDTO.CId);
            if (customer.Name != txtHoTen.Text ||
                customer.CId != txtCCCD.Text ||
                customer.Phone != txtSDT.Text)
            {
                MessageBox.Show("Thông tin khách hàng checkin không đúng!", "Thông tin sai",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn muốn nhận phòng?", "Xác nhận",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    MessageBox.Show("OK");
                }
                else MessageBox.Show("Cancel");
            }
        }
    }
}
