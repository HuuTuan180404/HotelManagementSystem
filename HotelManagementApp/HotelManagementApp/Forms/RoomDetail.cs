using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementApp.Forms
{
    public partial class RoomDetail : Form
    {
        public string SelectedOption { get; private set; }

        public RoomDetail()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            toolTipRoomDetail.SetToolTip(btnUpdate, "Update room");
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            toolTipRoomDetail.SetToolTip(btnDelete, "Delete room");
        }
    }
}
