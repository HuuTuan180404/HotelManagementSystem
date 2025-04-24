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


namespace Presentation.User_Controls
{
    public partial class itemRoom2 : UserControl
    {
        RoomDTO RoomDTO;

        public event EventHandler DataChanged;

        private itemRoom2()
        {
            InitializeComponent();
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
                gunaToolTip_Room.SetToolTip(ctrl, $"Số giường: {RoomDTO.RTBedCount} | Tối đa: {RoomDTO.RTMaxGuests} | Giá: {RoomDTO.RPricePerNight}");
            }
            btnMenu.MouseDown -= Ctrl_Click;
        }

        private void CreateContentMenuStrip()
        {
            menuStrip.Items.Clear();
            menuStrip.Items.Add("Xem chi tiết", Properties.Resources.show_password, (sender, e) =>
            {
                RoomDetail roomDetail = new RoomDetail(RoomDTO);
                roomDetail.DataChanged += DataRoomsChanged;
                roomDetail.ShowDialog();
            });

            menuStrip.Items.Add("Đặt phòng", null, (sender, e) =>
            {
                AddBooking AddBooking = new AddBooking(RoomDTO.RId);
                AddBooking.ShowDialog();
            });

            menuStrip.Items.Add("Nhận phòng", null, null);
            menuStrip.Items.Add("Yêu cầu vệ sinh", null, null);
        }

        private void Ctrl_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                RoomDetail roomDetail = new RoomDetail(RoomDTO);
                roomDetail.DataChanged += DataRoomsChanged;
                roomDetail.ShowDialog();
            }
            else
            {
                menuStrip.Show(Cursor.Position);
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
    }
}
