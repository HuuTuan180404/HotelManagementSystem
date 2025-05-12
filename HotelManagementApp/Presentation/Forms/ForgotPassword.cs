using System;
using System.Windows.Forms;
using Business;
using DataTransferObject;

namespace Presentation.Forms
{
    public partial class ForgotPassword : Form
    {
        private readonly EmployeeBusiness employeeBusiness = new EmployeeBusiness();

        public ForgotPassword()
        {
            InitializeComponent();
            txtNewPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;
            img_show.Visible = true;
            img_hide.Visible = false;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
            var loginForm = new Login();
            loginForm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string eId = txtMaNV.Text.Trim();
            string phone = txtSDT.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(eId) || string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận không khớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!employeeBusiness.IsValidPassword(newPassword))
            {
                MessageBox.Show("Mật khẩu mới không đủ mạnh!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var employee = employeeBusiness.GetEmployee(eId);
            if (employee == null)
            {
                MessageBox.Show("Không tìm thấy nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.Equals(employee.Phone, phone, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Số điện thoại không khớp với mã nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (employeeBusiness.ResetPassword(eId, newPassword))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                var loginForm = new Login();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi đặt lại mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void img_hide_Click(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;
            img_hide.Visible = false;
            img_show.Visible = true;
        }

        private void img_show_Click(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = false;
            txtConfirmPassword.UseSystemPasswordChar = false;
            img_hide.Visible = true;
            img_show.Visible = false;
        }

        private void img_hide_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(img_hide, "Ẩn mật khẩu");
        }

        private void img_show_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(img_show, "Hiện mật khẩu");
        }
    }
}
