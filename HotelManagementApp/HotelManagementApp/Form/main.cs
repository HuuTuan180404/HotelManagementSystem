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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void img_hide_Click(object sender, EventArgs e)
        {
            tb_password.UseSystemPasswordChar = true;
            img_hide.Visible = false;
            img_show.Visible = true;
        }

        private void img_show_Click(object sender, EventArgs e)
        {
            tb_password.UseSystemPasswordChar = false;
            tb_password.PasswordChar = '\0';
            img_hide.Visible = true;
            img_show.Visible = false;    
        }


        private void img_show_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(img_show, "Show password");
        }

        private void img_hide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(img_hide, "Hide password");
        }

        private void lb_username_Click(object sender, EventArgs e)
        {
        }
    }
}
