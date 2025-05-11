using System.Runtime.InteropServices;
using Presentation.User_Controls;
using System.Collections.Generic;
using AForge.Video.DirectShow;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using AForge.Video;
using System.Data;
using System.Linq;
using System.Text;
using System;
using ZXing;
using DataTransferObject;
using System.Threading;
using System.Timers;
using Business;
using ZXing.Common;
using System.Configuration;

namespace Presentation.Forms
{
    public partial class AddBooking : Form
    {
        private FilterInfoCollection captureDevices;
        private VideoCaptureDevice videoSource;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        RoomB RoomB;

        public AddBooking()
        {
            InitializeComponent();
            RoomB = new RoomB();
            LoadAllRoomTypes();
            LoadRooms(RoomB.GetAllRooms());
            FirstLoad();
        }

        public AddBooking(string roomId) : this()
        {
            btnShowItem.Tag = roomId;
            RoomDTO RoomDTO = RoomB.GetRoom(roomId);
            btnShowItem.Text = $"{RoomDTO.RId} - {RoomDTO.RType}";
        }

        private void FirstLoad()
        {
            timeCheckin.Text = DateTime.Now.ToString("HH:mm");
            dateCheckin.Text = DateTime.Now.ToString("dd/MM/yyyy");

            timeCheckout.Text = ConfigurationManager.AppSettings["CheckOutTime"];
            dateCheckout.Text = DateTime.Now.AddDays(1).ToString("dd/MM/yyyy");
        }

        private void LoadAllRoomTypes()
        {
            comboboxRoomType.Items.Clear();
            comboboxRoomType.Items.Add("All");
            var types = RoomB.GetAllRoomTypes()
                .Select(type => type.RType);
            foreach (var type in types)
                comboboxRoomType.Items.Add(type.ToString());
            comboboxRoomType.SelectedIndex = 0;
        }

        private void LoadRooms(List<RoomDTO> listRooms)
        {
            flowLayoutPanel.Controls.Clear();
            foreach (var i in listRooms)
            {
                itemRoom item = new itemRoom(i);
                flowLayoutPanel.Controls.Add(item);
            }
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            moveForm(sender, e);
        }

        private void moveForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer_for_select_room_Tick(object sender, EventArgs e)
        {
            if (itemIsShow == false)
            {
                flowLayoutPanel.Height += 10;
                if (flowLayoutPanel.Height >= flowLayoutPanel.MaximumSize.Height)
                {
                    itemIsShow = true;
                    timer_for_select_room.Stop();
                }
            }
            else
            {
                flowLayoutPanel.Height -= 10;
                if (flowLayoutPanel.Height <= flowLayoutPanel.MinimumSize.Height)
                {
                    itemIsShow = false;
                    timer_for_select_room.Stop();
                }
            }
        }

        private void btnShowItem_Click(object sender, EventArgs e)
        {
            timer_for_select_room.Start();
            if (itemIsShow)
            {
                btnShowItem.Image = Presentation.Properties.Resources.left;
                timer2.Stop();
                flowLayoutPanel.AutoScroll = false;
            }
            else
            {
                btnShowItem.Image = Presentation.Properties.Resources.down;
                flowLayoutPanel.AutoScroll = true;
                timer2.Start();
            }
        }

        private void btnClearFilter_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnClearFilter, "Clear fields");
        }

        private void timeCheckin_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                timeCheckin.Text = string.Empty;
            }
        }

        private void timeCheckout_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                timeCheckout.Text = string.Empty;
            }
        }

        private void dateCheckin_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                dateCheckin.Text = string.Empty;
            }
        }

        private void dateCheckout_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                dateCheckout.Text = string.Empty;
            }
        }

        private void timeCheckin_Click(object sender, EventArgs e)
        {
            timeCheckin.SelectionStart = 0;
        }

        private void timeCheckout_Click(object sender, EventArgs e)
        {
            timeCheckout.SelectionStart = 0;
        }

        private void dateCheckin_Click(object sender, EventArgs e)
        {
            dateCheckin.SelectionStart = 0;
        }

        private void dateCheckout_Click(object sender, EventArgs e)
        {
            dateCheckout.SelectionStart = 0;
        }

        private void comboboxRoomType_SelectedValueChanged(object sender, EventArgs e)
        {
            FilterRoom();
        }

        private void floor_ValueChanged(object sender, EventArgs e)
        {
            FilterRoom();
        }

        private void FilterRoom()
        {
            if (comboboxRoomType.SelectedIndex == 0 && floor.Value < 0)
            {
                LoadRooms(RoomB.GetAllRooms());
                btnClearFilter.Visible = false;
                return;
            }

            List<RoomDTO> rooms = RoomB.GetAllRooms();
            if (floor.Value >= 0)
            {
                rooms = rooms.Where(r => r.getNumberOfFloor() == (int)floor.Value).ToList();
            }

            if (comboboxRoomType.SelectedIndex != 0)
            {
                string type = comboboxRoomType.SelectedItem.ToString();
                rooms = rooms.Where(r => r.RType == type).ToList();
            }
            btnClearFilter.Visible = true;
            LoadRooms(rooms);
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            floor.Value = floor.Minimum;
            comboboxRoomType.SelectedIndex = 0;
            btnClearFilter.Visible = false;
        }

        bool itemIsShow = false;
        private void btnShowItem_Leave(object sender, EventArgs e)
        {
            if (itemIsShow) { btnShowItem.PerformClick(); }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (itemRoom.IS_SELECTED)
            {
                btnShowItem.Text = itemRoom.ID;
                timer2.Start(); // đóng cái flow layout panel
                itemRoom.IS_SELECTED = false;
                btnShowItem.Tag = itemRoom.RoomId;
                btnShowItem.PerformClick();
            }
        }

        private void btnQR_Click(object sender, EventArgs e)
        {
            var qrForm = new QR();
            qrForm.OnCustomerScanned += (customer) =>
            {
                var customerBusiness = new Business.CustomerBusiness();
                var dbCustomer = customerBusiness.GetCustomerById(customer.CId);

                if (dbCustomer != null)
                {
                    txtId.Text = dbCustomer.CId;
                    txtName.Text = dbCustomer.Name;
                    selectGender.SelectedItem = dbCustomer.Gender;
                    txtAddress.Text = dbCustomer.Address;
                    txtPhone.Text = dbCustomer.Phone;
                    txtEmail.Text = dbCustomer.Email;
                }
                else
                {
                    txtId.Text = customer.CId;
                    txtName.Text = customer.Name;
                    selectGender.SelectedItem = customer.Gender;
                    txtAddress.Text = customer.Address;
                    txtPhone.Text = "";
                    txtEmail.Text = "";
                }
            };
            qrForm.ShowDialog();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
                txtId.IconRight = null;
            else txtId.IconRight = Properties.Resources.find1;
        }

        private void txtId_IconRightClick(object sender, EventArgs e)
        {

        }

        
    }
}