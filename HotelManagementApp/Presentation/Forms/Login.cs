using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
//using AMRConnector;

namespace Presentation.Forms
{
    public partial class Login : Form
    {
        private readonly EmployeeBusiness employeeBusiness = new EmployeeBusiness();
        //DbConnector database;
        private int failedLoginCount = 0; // Biến đếm số lần đăng nhập sai
        private bool forceForgotPassword = false;
        public Login()
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

        private void pic_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pic_minus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (forceForgotPassword)
            {
                MessageBox.Show("Bạn đã nhập sai quá nhiều lần. Vui lòng sử dụng chức năng 'Quên mật khẩu' để lấy lại mật khẩu!", "Bắt buộc lấy lại mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Hide();
                using (var forgotForm = new ForgotPassword())
                {
                    forgotForm.ShowDialog();
                }
                this.Show();
                failedLoginCount = 0;
                forceForgotPassword = false;
                return;
            }

            string username = tb_username.Text.Trim();
            string password = tb_password.Text.Trim();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ ID và mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kiểm tra đăng nhập
            if (employeeBusiness.ValidateLogin(username, password))
            {
                failedLoginCount = 0;
                forceForgotPassword = false;
                this.Hide();
                ConfigPresentation.CURRENT_EId=username;
                Main dashboard = new Main();
                dashboard.ShowDialog();
                this.Close();
            }
            else
            {
                failedLoginCount++;
                MessageBox.Show("ID hoặc mật khẩu không đúng!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (failedLoginCount == 5)
                {
                    var result = MessageBox.Show(
                        "Bạn đã nhập sai mật khẩu 5 lần liên tiếp.\nBạn có muốn sử dụng 'Quên mật khẩu' không?",
                        "Gợi ý lấy lại mật khẩu",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        this.Hide();
                        using (var forgotForm = new ForgotPassword())
                        {
                            forgotForm.ShowDialog();
                        }
                        this.Show();
                        failedLoginCount = 0;
                    }
                    // Nếu chọn No, cho nhập tiếp, nhưng sẽ kiểm tra ở lần thứ 8
                }
                else if (failedLoginCount >= 8)
                {
                    forceForgotPassword = true;
                    MessageBox.Show("Bạn đã nhập sai quá nhiều lần. Vui lòng sử dụng 'Quên mật khẩu' để lấy lại mật khẩu!", "Bắt buộc lấy lại mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Hide();
                    using (var forgotForm = new ForgotPassword())
                    {
                        forgotForm.ShowDialog();
                    }
                    this.Show();
                    failedLoginCount = 0;
                    forceForgotPassword = false;
                }
            }
        }

        private void lb_forgetPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var forgotForm = new ForgotPassword())
            {
                forgotForm.ShowDialog();
            }
            this.Show();
        }
    }
}
