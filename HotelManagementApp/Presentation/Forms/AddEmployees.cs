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


namespace Presentation.Forms
{
    public partial class AddEmployees : Form    
    {
        private EmployeeBusiness employeeBusiness;
        private EmployeeDTO employeeDTO;

        public AddEmployees()
        {
            InitializeComponent();
            employeeBusiness = new EmployeeBusiness();
            
            // Auto-generate ID for new employee and disable the field
            txtMaNV.Text = employeeBusiness.GetNextAvailableId();
            txtMaNV.ReadOnly = true;  // Use ReadOnly instead of Enabled to maintain visual consistency
            txtMaNV.TabStop = false;  // Skip this field when using Tab key
            
            LoadComboBoxes();
        }

        public AddEmployees(EmployeeDTO employeeDTO) : this()
        {
            this.employeeDTO = employeeDTO;
            LoadEmployeeData();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (employeeDTO == null) // Only for new employees
            {
                txtMaNV.Text = employeeBusiness.GetNextAvailableId();
                txtMaNV.ReadOnly = true;
                txtMaNV.TabStop = false;
            }
        }

        private void LoadComboBoxes()
        {
            // Load gender options
            cboGender.Items.Add("Male");
            cboGender.Items.Add("Female");
            cboGender.Items.Add("Other");

            // Load status options
            cboStatus.Items.Add("Active");
            cboStatus.Items.Add("Inactive");
            cboStatus.Items.Add("On Leave");

            // Load role options from EmployeeRole table
            var roles = employeeBusiness.GetAllRoles();
            foreach (var role in roles)
            {
                cboRole.Items.Add(role);
            }
        }

        private void LoadEmployeeData()
        {
            if (employeeDTO != null)
            {
                txtMaNV.Text = employeeDTO.EId;
                txtMaNV.ReadOnly = true; // Use ReadOnly instead of Enabled
                txtMaNV.TabStop = false;
                txtTenNV.Text = employeeDTO.Name;
                cboGender.SelectedItem = employeeDTO.Gender;
                txtSDT.Text = employeeDTO.Phone;
                txtEmail.Text = employeeDTO.Email;
                txtDiaChi.Text = employeeDTO.Address;
                cboStatus.SelectedItem = employeeDTO.Status;
                cboRole.SelectedItem = employeeDTO.ERole;
            }
        }

        private bool ValidateInput()
        {
            // Validate Employee ID
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            return true;
        }

        



        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    EmployeeDTO newEmployee = new EmployeeDTO
                    {
                        EId = txtMaNV.Text,
                        Name = txtTenNV.Text,
                        Gender = cboGender.SelectedItem.ToString(),
                        Phone = txtSDT.Text,
                        Email = txtEmail.Text,
                        Address = txtDiaChi.Text,
                        Status = cboStatus.SelectedItem.ToString(),
                        ERole = cboRole.SelectedItem.ToString()
                    };

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
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
