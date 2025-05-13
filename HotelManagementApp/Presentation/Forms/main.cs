using Presentation.Forms;
using Presentation.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using Business;
using DataTransferObject;

namespace Presentation.Forms
{
    public partial class Main : Form
    {
        private bool sideBarIsShow = false;
        private Timer timer;
        private EmployeeBusiness employeeBusiness;
        private EmployeeDTO currentEmployee;

        public Main()
        {
            InitializeComponent(); ThayDoiMau();
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss dddd, dd/MM/yyyy");
            timer = new Timer();
            timer.Interval = 1000; // Cập nhật mỗi 1 giây
            timer.Tick += Timer_Tick;
            timer.Start();
            employeeBusiness = new EmployeeBusiness();

            // Thêm item cho menuLuaChon nếu chưa có
            if (menuLuaChon.Items.Count == 0)
            {
                menuLuaChon.Items.Add("Chỉnh sửa thông tin", null, EditInfo_Click);
                menuLuaChon.Items.Add("Đăng xuất", null, LogoutMenu_Click);
            }
            // Gán sự kiện click chuột cho picLoadEA
            this.picLoadEA.MouseClick += picLoadEA_MouseClick;
        }

        private void ThayDoiMau()
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss dddd, dd/MM/yyyy");
        }

        private void pic_minus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            UC_BookingManagement.BringToFront();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            UC_RoomManagement.BringToFront();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            UC_CustomerManagement.BringToFront();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            UC_EmployeeManagement.BringToFront();
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelLogout_MouseClick(object sender, MouseEventArgs e)
        {
            logout();
        }

        private void picLogout_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void lbLogout_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void logout()
        {
            try
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đăng xuất: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sideBarIsShow)
            {
                sideBar.Width -= 20;
                if (sideBar.Width == sideBar.MinimumSize.Width)
                {
                    sideBarIsShow = false;
                    timer1.Stop();
                }
            }
            else
            {
                sideBar.Width += 20;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    sideBarIsShow = true;
                    timer1.Stop();
                }
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Login login = new Login();
            //login.ShowDialog();
            //this.Close();
            UC_ThongKe.BringToFront();
        }

        private void UC_BookingManagement_Load(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            UC_BookingManagement.Left = (panelUC.ClientSize.Width - UC_BookingManagement.Width) / 2;
            UC_BookingManagement.Top = (panelUC.ClientSize.Height - UC_BookingManagement.Height) / 2;
        }

        public void SetCurrentEmployee(string employeeId)
        {
            try
            {
                currentEmployee = employeeBusiness.GetEmployee(employeeId);
                if (currentEmployee != null)
                {
                    // Load avatar nếu có
                    if (!string.IsNullOrEmpty(currentEmployee.Avatar))
                    {
                        try
                        {
                            using (var webClient = new System.Net.WebClient())
                            {
                                byte[] imageBytes = webClient.DownloadData(currentEmployee.Avatar);
                                using (var ms = new System.IO.MemoryStream(imageBytes))
                                {
                                    picLoadEA.Image = Image.FromStream(ms);
                                }
                            }
                        }
                        catch
                        {
                            // Nếu không load được ảnh, để trống
                            picLoadEA.Image = null;
                        }
                    }
                    else
                    {
                        // Nếu không có avatar, để trống
                        picLoadEA.Image = null;
                    }

                    // Load tên nhân viên
                    lbLoadTenNV.Text = currentEmployee.Name;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load thông tin nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void picLoadEA_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                menuLuaChon.Show(picLoadEA, new Point(e.X, e.Y));
            }
        }

        private void EditInfo_Click(object sender, EventArgs e)
        {
            if (currentEmployee != null)
            {
                AddEmployees editForm = new AddEmployees(currentEmployee);
                editForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LogoutMenu_Click(object sender, EventArgs e)
        {
            logout();
        }
    }
}
