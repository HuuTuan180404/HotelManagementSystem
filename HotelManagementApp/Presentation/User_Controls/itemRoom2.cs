using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using DataTransferObject;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;
using Presentation.Forms;
using Business;
using DocumentFormat.OpenXml.Drawing;


namespace Presentation.User_Controls
{
    public partial class itemRoom2 : UserControl
    {
        RoomDTO RoomDTO;
        RoomB RoomB;

        public event EventHandler DataChanged;

        private itemRoom2()
        {
            InitializeComponent();
            RoomB = new RoomB();
            CreateContentMenuStrip();
        }

        public itemRoom2(RoomDTO roomDTO) : this()
        {
            this.RoomDTO = roomDTO;
            if (RoomDTO != null)
            {
                lbRoom.Text = RoomDTO.RId.ToString();
                lbType.Text = string.Format("{0,-8}: {1}", "Type", RoomDTO.RType);
                lbStatus.Text = string.Format("{0,-8}: {1}", "Status", RoomDTO.RStatus);
            }

            foreach (Control ctrl in this.Controls)
            {
                ctrl.MouseDown += Ctrl_Click;
                ctrl.DoubleClick += Ctrl_DoubleClick;
                gunaToolTip_Room.SetToolTip(ctrl, $"Số giường: {RoomDTO.RTBedCount} | Tối đa: {RoomDTO.RTMaxGuests} | Giá: {RoomDTO.RPricePerNight}");
            }
            btnMenu.MouseDown -= Ctrl_Click;
            btnMenu.DoubleClick -= Ctrl_DoubleClick;
        }

        private void CreateContentMenuStrip()
        {
            menuStrip.Items.Clear();
            menuStrip.Items.Add("Xem chi tiết", Properties.Resources.show_password, (EventHandler)((sender, e) =>
            {
                RoomDetail roomDetail = new RoomDetail(RoomDTO.RId);
                roomDetail.DataChanged += this.DataRoomsChanged;
                roomDetail.ShowDialog();
            }));

            menuStrip.Items.Add("Đặt phòng", Properties.Resources.icon_booking, (sender, e) =>
            {
                if (RoomB.RoomIsAvailable(RoomDTO.RId))
                {
                    AddBooking AddBooking = new AddBooking(RoomDTO.RId);
                    AddBooking.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Phòng chưa sẵn sàng để nhận khách",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                }
            });

            menuStrip.Items.Add("Nhận phòng", Properties.Resources.checkedIn, (EventHandler)((sender, e) =>
            {
                try
                {
                    if (RoomB.RoomIsAvailable(RoomDTO.RId))
                    {
                        CheckIn checkIn = new CheckIn(RoomDTO.RId, true);
                        checkIn.DataChanged += this.DataRoomsChanged;
                        checkIn.ShowDialog();
                    }
                    else
                    {
                        var room = RoomB.GetRoom(RoomDTO.RId);
                        MessageBox.Show(room.RStatusDescription, "Không thể nhận phòng",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Không có lịch đặt nào");
                }
            }));

            menuStrip.Items.Add("Yêu cầu vệ sinh", Properties.Resources.clean, (sender, e) =>
            {
                try
                {
                    RoomDTO roomDTO = RoomB.GetRoom(RoomDTO.RId);
                    if (roomDTO.RStatus != "Cleaning")
                    {
                        roomDTO.RStatus = "Cleaning";
                        RoomB.UpdateRoom(roomDTO);
                        DataChanged?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Phòng đang được dọn vệ sinh");
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            });

            menuStrip.Items.Add("Trả phòng & Thanh toán", null, (sender, e) =>
            {
                try
                {

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            });
        }

        private void Ctrl_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                menuStrip.Show(Cursor.Position);
            }
            else
            {
                gunaToolTip_Room.SetToolTip((Control)sender, $"Số giường: {RoomDTO.RTBedCount} | Tối đa: {RoomDTO.RTMaxGuests} | Giá: {RoomDTO.RPricePerNight}");
            }
        }

        private void DataRoomsChanged(object sender, EventArgs e)
        {
            DataChanged?.Invoke(this, EventArgs.Empty);
        }

        private void itemRoom2_MouseHover(object sender, EventArgs e)
        {
            gunaToolTip_Room.SetToolTip((Control)sender, $"Số giường: {RoomDTO.RTBedCount} | Tối đa: {RoomDTO.RTMaxGuests} | Giá: {RoomDTO.RPricePerNight}");
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuStrip.Show(Cursor.Position);
        }

        private void nextTime_MouseDown(object sender, MouseEventArgs e)
        {
            Ctrl_Click(sender, e);
        }

        private void Ctrl_DoubleClick(object sender, EventArgs e)
        {
            RoomDetail roomDetail = new RoomDetail(RoomDTO.RId);
            roomDetail.DataChanged += DataRoomsChanged;
            roomDetail.ShowDialog();
        }
    }
}
