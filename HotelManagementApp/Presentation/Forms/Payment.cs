using Business;
using DataTransferObject;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class Payment : Form
    {
        ServiceB ServiceB;
        PaymentB PaymentB;
        RoomB RoomB;
        BookingB BookingB;
        CustomerBusiness CustomerBusiness;
        string Id;

        BookingDTO BookingDTO;
        RoomDTO RoomDTO;
        CustomerDTO CustomerDTO;

        private Payment()
        {
            InitializeComponent();
            ServiceB = new ServiceB();
            PaymentB = new PaymentB();
            BookingB = new BookingB();
            RoomB = new RoomB();
            CustomerBusiness = new CustomerBusiness();
        }

        public Payment(string bookingId) : this()
        {
            Id = bookingId;
            KhoiTao();
            FirstLoad();
        }

        private void KhoiTao()
        {
            BookingDTO = BookingB.GetBooking(Id);
            RoomDTO = RoomB.GetRoom(BookingDTO.RId);
            CustomerDTO = CustomerBusiness.GetCustomerById(BookingDTO.CId);
        }

        private void FirstLoad()
        {
            ThongTinHoaDon();
            HoaDonPhong();
            HoaDonDichVu();

            LoadData_ComboBox_PaymentMethod();

            // Tổng cộng
            lbTotal.Text = $"{Convert.ToDecimal(lbTotalRoom.Text) + Convert.ToDecimal(lbTotalServices.Text)}";
        }

        private void ThongTinHoaDon()
        {
            lbName.Text = CustomerDTO.Name;
            lbPhone.Text = CustomerDTO.Phone;
            lbBookingId.Text = $"HD{Id}";
            lbDate.Text = $"{DateTime.Now}";
        }

        private void HoaDonPhong()
        {
            lbMaDatPhong.Text = Id;
            lbRoomId.Text = RoomDTO.RId;
            lbRoomType.Text = RoomDTO.RType;
            lbTimeCheckIn.Text = BookingDTO.BTimeCheckIn.ToString();
            lbTimeCheckOut.Text = BookingDTO.BTimeCheckOut.ToString();
            lbPrice.Text = RoomDTO.RPricePerNight.ToString();

            TimeSpan duration = BookingDTO.BTimeCheckOut - BookingDTO.BTimeCheckIn;
            decimal price = Convert.ToDecimal(duration.TotalDays) * RoomDTO.RPricePerNight;
            lbThanhTien.Text = $"{price}";
        }

        private void HoaDonDichVu()
        {
            List<Object> list = new List<Object>();
            var list_service_usage = ServiceB.GetAllServicesUsage(Id);

            decimal total = 0;

            foreach (var i in list_service_usage)
            {
                var service = ServiceB.GetServiceBySName(i.SName);
                if (service != null)
                {
                    list.Add(new
                    {
                        SName = i.SName,
                        SDescription = service.SDescription,
                        SPrice = service.SPrice,
                        Quantity = i.Quantity,
                        Total = service.SPrice * i.Quantity
                    });
                    total += service.SPrice * i.Quantity;
                }
            }
            lbTotalServices.Text = $"{total}";
            dataGridView.DataSource = list;
        }

        private void LoadData_ComboBox_PaymentMethod()
        {
            comboPaymentMethod.Items.Clear();

            foreach (var i in PaymentB.GetAllPaymentMethods())
            {
                comboPaymentMethod.Items.Add(i.PMethod);
            }
            if (comboPaymentMethod.Items.Count > 0) { comboPaymentMethod.SelectedIndex = 0; }
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xác nhận đã thanh toán hóa đơn",
                      "Xác nhận",
                      MessageBoxButtons.OKCancel,
                      MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
            {
                if (ChuyennPhongSangCleaning())
                {
                    TaoHoaDon();
                }
            }
        }

        private void TaoHoaDon()
        {
            PaymentDTO paymentDTO = new PaymentDTO();
            paymentDTO.BPId = Id;
            paymentDTO.BId = Id;
            paymentDTO.EId = ConfigPresentation.CURRENT_EId;
            paymentDTO.Amount = Convert.ToDecimal(lbTotal.Text);
            paymentDTO.PMethod = comboPaymentMethod.SelectedItem.ToString();

            if (PaymentB.CreateBill(paymentDTO))
            {
                MessageBox.Show("Thành công");
                this.Close();
            }
        }

        private bool ChuyennPhongSangCleaning()
        {
            try
            {
                return RoomB.ChangeStatus(RoomDTO.RId, "Cleaning");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
