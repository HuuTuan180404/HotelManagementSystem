using DataTransferObject;
using System;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Business;

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

        public event Action DataChanged;
        private RoomB RoomB = new RoomB();

        public AddRoom()
        {
            InitializeComponent();
            loadDataFor_comboboxStatus();
            loadDataFor_comboboxRoomType();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadDataFor_comboboxRoomType()
        {
            comboboxRoomType.Items.Clear();
            var types = RoomB.getListRoomType().Select(type => type.RType);
            foreach (var type in types)
                comboboxRoomType.Items.Add(type.ToString());
            comboboxRoomType.SelectedIndex = 0;
        }

        private void loadDataFor_comboboxStatus()
        {
            comboboxStatus.Items.Clear();
            var status = RoomB.getListRoomStatus().Select(room_status => room_status.RStatus);
            foreach (var item in status)
                comboboxStatus.Items.Add(item.ToString());
            comboboxStatus.SelectedIndex = 0;
        }

        private void comboboxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupboxType.Text = comboboxRoomType.SelectedItem.ToString();
            var types = RoomB.getListRoomType();
            RoomTypeDTO type = types.FirstOrDefault(item => item.RType == groupboxType.Text);
            lbBedCount.Text = type.RTBedCount.ToString();
            lbMaxGuests.Text = type.RTMaxGuests.ToString();
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

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnAdd, "Add");
        }

        private void floor_ValueChanged(object sender, EventArgs e)
        {
            lbFloor.Text = floor.Value.ToString();
        }

        private void numRoom_ValueChanged(object sender, EventArgs e)
        {
            lbNo.Text = numRoom.Value.ToString();
        }

        private void comboboxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbStatus.Text = comboboxStatus.SelectedItem.ToString();
        }

        private void price_TextChanged(object sender, EventArgs e)
        {
            lbPrice.Text = price.Text;
        }

        private void note_TextChanged(object sender, EventArgs e)
        {
            lbDescription.Text = note.Text;
        }

        private void editType_Click(object sender, EventArgs e)
        {
            MessageBox.Show("editType_Click", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void editStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("editType_Click", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void numRoom_KeyUp(object sender, KeyEventArgs e)
        {
            numRoom_ValueChanged(this, null);
        }

        private void floor_KeyUp(object sender, KeyEventArgs e)
        {
            floor_ValueChanged(this, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
