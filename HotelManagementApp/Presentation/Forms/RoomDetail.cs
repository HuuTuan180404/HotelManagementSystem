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
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using TheArtOfDevHtmlRenderer.Adapters;
using System.Collections;
using DataTransferObject;
using Business;


namespace Presentation.Forms
{
    public partial class RoomDetail : Form
    {
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private RoomDTO RoomDTO;
        //private RoomB RoomB;

        public RoomDetail()
        {
            InitializeComponent();
        }

        public RoomDetail(string RId) : this()
        {
            
        }


        private void RoomDetail_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void loadDataFor_comboboxRoomType()
        {

        }

        private void loadDataFor_comboboxStatus()
        {
            //comboboxStatus.Items.Clear();
            //comboboxStatus.SelectedIndex = 0;
            //var status = RoomB.getListRoomStatus().Select(room_status => room_status.RStatus);
            //foreach (var item in status)
            //    comboboxStatus.Items.Add(item.ToString());
        }






























        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            toolTipRoomDetail.SetToolTip(btnUpdate, "Update room");
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            toolTipRoomDetail.SetToolTip(btnDelete, "Delete room");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private bool alert(string message)
        {
            DialogResult result = MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                return true;
            return false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void comboboxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboboxStatus_SelectedValueChanged(object sender, EventArgs e)
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
    }
}
