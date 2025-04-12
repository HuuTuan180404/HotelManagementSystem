using DataTransferObject;
using System;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Business;
using System.Collections.Generic;
using System.Diagnostics;
using System.Configuration;

namespace Presentation.Forms
{
    public partial class AddRoom : Form
    {
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        RoomB RoomB;

        public AddRoom()
        {
            InitializeComponent();
            RoomB = new RoomB();

            LoadData_Types(RoomB.GetAllRoomTypes().Select(t => t.RType).ToList());
            LoadData_States(RoomB.GetAllRoomStates().Select(t => t.RStatus).ToList());
            FirstLoad();
        }

        private void FirstLoad()
        {
            price.Text = ConfigurationManager.AppSettings["DefaultRoomPrice"];
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

        private void LoadData_Types(List<string> list)
        {
            comboboxRoomType.Items.Clear();
            comboboxRoomType.DataSource = list;
            comboboxRoomType.SelectedIndex = 0;
        }

        private void LoadData_States(List<string> list)
        {
            comboboxStatus.Items.Clear();
            comboboxStatus.DataSource = list;
            comboboxStatus.SelectedIndex = 0;
        }

        private void floor_ValueChanged(object sender, EventArgs e)
        {
            lbRoomId.Text = $"Roo{floor.Value}-{numRoom.Value}";
        }

        private void numRoom_ValueChanged(object sender, EventArgs e)
        {
            lbRoomId.Text = $"Roo{floor.Value}-{numRoom.Value}";
        }

        private void comboboxRoomType_SelectedValueChanged(object sender, EventArgs e)
        {
            lbType.Text = comboboxRoomType.SelectedItem.ToString();
            RoomDTO ro = RoomB.GetType(comboboxRoomType.SelectedItem.ToString());
            lbBedCount.Text = ro.RTBedCount.ToString();
            lbMaxGuests.Text = ro.RTMaxGuests.ToString();
            lbTypeDescription.Text = ro.RTypeDescription.ToString();
        }

        private void price_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal a = Convert.ToDecimal(price.Text);
                lbPrice.Text = a.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboboxStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            lbStatus.Text = comboboxStatus.SelectedItem.ToString();
            RoomDTO ro = RoomB.GetStatus(comboboxStatus.SelectedItem.ToString());
            lbStatusDescription.Text = ro.RStatusDescription.ToString();
        }

        private void note_TextChanged(object sender, EventArgs e)
        {
            lbRoomDescription.Text = note.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                RoomDTO roomDTO = new RoomDTO
                {
                    RId = lbRoomId.Text,
                    RType = lbType.Text,
                    RStatus = lbStatus.Text,
                    RPricePerNight = Convert.ToDecimal(lbPrice.Text),
                    RDescription = lbRoomDescription.Text
                };
                RoomB.AddRoom(roomDTO);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
