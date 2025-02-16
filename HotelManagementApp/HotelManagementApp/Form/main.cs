using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMRConnector;

namespace HotelManagementApp
{
    public partial class main : Form
    {
        DbConnector database;
        public main()
        {
            InitializeComponent();
            database = new DbConnector();
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


        private void pic_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pic_minus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //bool check = database.IsValidNamePass(tb_username.Text.Trim(), tb_password.Text.Trim());
            if (tb_username.Text.Trim() == string.Empty || tb_password.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter the edit box", "Warming", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                //if (check)
                //{
                   
                //}
                //else
                //{
                //    MessageBox.Show("Invalid Username or password","Username or Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_forgetPassword_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
