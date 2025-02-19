using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementApp
{
    public partial class RoomManagement : Form
    {
        public RoomManagement()
        {
            InitializeComponent();
        }

        private void pic_minus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            pnUnderline.Size = new System.Drawing.Size(btnRoom.Width, pnUnderline.Height);
            pnUnderline.Top = btnRoom.Bottom + 3;
            pnUnderline.Left = btnRoom.Left;
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            pnUnderline.Size = new System.Drawing.Size(btnCustomers.Width, pnUnderline.Height);
            pnUnderline.Top = btnCustomers.Bottom + 3;
            pnUnderline.Left = btnCustomers.Left;
        }


    }
}
