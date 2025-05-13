using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MaterialSkin;
using MaterialSkin.Controls;
using Business;
using DataTransferObject;
using System.Xml.Linq;
using System.IO;

namespace Presentation.Forms
{
    public partial class AddEmployees : Form    
    {
        private readonly EmployeeBusiness employeeBusiness;
        private readonly EmployeeDTO employeeDTO;
        private string selectedAvatarPath;

        public AddEmployees()
        {
            InitializeComponent();
            employeeBusiness = new EmployeeBusiness();
            
            // Set placeholder text for ID field
            txtMaNV.PlaceholderText = "Nhập mã nhân viên";
            txtMaNV.Text = "";
            txtMaNV.ReadOnly = false;
            txtMaNV.TabStop = true;
            
            LoadComboBoxes();
            SetupPasswordValidation();
        }

        public AddEmployees(EmployeeDTO employeeDTO) : this()
        {
            this.employeeDTO = employeeDTO;
            LoadEmployeeData();
        }

        private void SetupPasswordValidation()
        {
            // Add password validation tooltip
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(txtPassword, "Mật khẩu phải có ít nhất 8 ký tự, bao gồm chữ hoa, chữ thường, số và ký tự đặc biệt");
            
            // Show/hide password
            btnShowPassword.Click += (s, e) => {
                txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
                btnShowPassword.Text = txtPassword.UseSystemPasswordChar ? "👁️" : "👁️‍🗨️";
            };

            // Set initial password visibility
            txtPassword.UseSystemPasswordChar = true;
            btnShowPassword.Text = "👁️";
        }

        private void LoadComboBoxes()
        {
            try
            {
                // Load gender options
                cboGender.Items.Clear();
                cboGender.Items.Add("Male");
                cboGender.Items.Add("Female");
                cboGender.Items.Add("Other");

                // Load status options
                cboStatus.Items.Clear();
                cboStatus.Items.Add("Active");
                cboStatus.Items.Add("Inactive");
                cboStatus.Items.Add("On Leave");

                // Load role options from EmployeeRole table
                cboRole.Items.Clear();
                var roles = employeeBusiness.GetAllRoles();
                foreach (var role in roles)
                {
                    cboRole.Items.Add(role);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadEmployeeData()
        {
            try
            {
                if (employeeDTO != null)
                {
                    txtMaNV.Text = employeeDTO.EId;
                    txtMaNV.ReadOnly = false;
                    txtMaNV.Enabled = false;
                    txtMaNV.TabStop = false;
                    txtTenNV.Text = employeeDTO.Name;
                    cboGender.SelectedItem = employeeDTO.Gender;
                    txtSDT.Text = employeeDTO.Phone;
                    txtEmail.Text = employeeDTO.Email;
                    txtDiaChi.Text = employeeDTO.Address;
                    cboStatus.SelectedItem = employeeDTO.Status;
                    cboRole.SelectedItem = employeeDTO.ERole;

                    // Load avatar if exists
                    if (!string.IsNullOrEmpty(employeeDTO.Avatar) && File.Exists(employeeDTO.Avatar))
                    {
                        selectedAvatarPath = employeeDTO.Avatar;
                        picAvatar.Image = Image.FromFile(employeeDTO.Avatar);
                    }

                    // Disable password field for existing employee
                    txtPassword.Enabled = false;
                    btnShowPassword.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thông tin nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            try
            {
                // Validate Employee ID
                if (string.IsNullOrWhiteSpace(txtMaNV.Text) || txtMaNV.Text.Trim() == "0")
                {
                    MessageBox.Show("Mã nhân viên không được để trống hoặc là 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaNV.Focus();
                    return false;
                }

                // Validate Name
                if (string.IsNullOrWhiteSpace(txtTenNV.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenNV.Focus();
                    return false;
                }

                // Validate Gender
                if (cboGender.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn giới tính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboGender.Focus();
                    return false;
                }

                // Validate Phone Number
                if (string.IsNullOrWhiteSpace(txtSDT.Text))
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSDT.Focus();
                    return false;
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtSDT.Text, @"^[0-9]{10,11}$"))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập 10-11 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSDT.Focus();
                    return false;
                }

                // Validate Email
                if (!string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    try
                    {
                        var addr = new System.Net.Mail.MailAddress(txtEmail.Text);
                        if (addr.Address != txtEmail.Text)
                        {
                            MessageBox.Show("Email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtEmail.Focus();
                            return false;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmail.Focus();
                        return false;
                    }
                }

                // Validate Address
                if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDiaChi.Focus();
                    return false;
                }

                // Validate Status
                if (cboStatus.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn trạng thái!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboStatus.Focus();
                    return false;
                }

                // Validate Role
                if (cboRole.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn vai trò!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboRole.Focus();
                    return false;
                }

                // Validate Password for new employee
                if (employeeDTO == null && string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi kiểm tra dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnSelectAvatar_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                    openFileDialog.Title = "Chọn ảnh đại diện";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        selectedAvatarPath = openFileDialog.FileName;
                        picAvatar.Image = Image.FromFile(selectedAvatarPath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveAvatar_Click(object sender, EventArgs e)
        {
            try
            {
                picAvatar.Image = null;
                selectedAvatarPath = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đóng form: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    EmployeeDTO newEmployee = new EmployeeDTO
                    {
                        EId = txtMaNV.Text.Trim(),
                        Name = txtTenNV.Text.Trim(),
                        Gender = cboGender.SelectedItem.ToString(),
                        Phone = txtSDT.Text.Trim(),
                        Email = txtEmail.Text?.Trim(),
                        Address = txtDiaChi.Text.Trim(),
                        Status = cboStatus.SelectedItem.ToString(),
                        ERole = cboRole.SelectedItem.ToString(),
                        Avatar = selectedAvatarPath
                    };

                    // Sửa logic mật khẩu: Nếu cập nhật và không nhập mật khẩu mới thì giữ nguyên mật khẩu cũ
                    if (employeeDTO == null)
                    {
                        // Thêm mới: luôn cần mật khẩu
                        newEmployee.Password = txtPassword.Text;
                    }
                    else if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                    {
                        // Cập nhật: chỉ set lại nếu có nhập mật khẩu mới
                        newEmployee.Password = txtPassword.Text;
                    }
                    else
                    {
                        // Cập nhật: giữ nguyên mật khẩu cũ
                        newEmployee.Password = employeeDTO.Password;
                    }

                    bool result;
                    if (employeeDTO == null)
                    {
                        result = employeeBusiness.AddEmployee(newEmployee);
                        if (result)
                        {
                            MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    else
                    {
                        result = employeeBusiness.UpdateEmployee(newEmployee);
                        if (result)
                        {
                            MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu thông tin: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
