using Business;
using DataTransferObject;
using System;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation.Forms
{
    public partial class AddCus : Form
    {
        private CustomerBusiness customerBusiness = new CustomerBusiness();
        private bool isEditMode = false;
        private string originalCustomerId = "";

        // Thêm sự kiện static để thông báo khi có khách hàng mới
        public static event EventHandler CustomerAdded;

        public AddCus()
        {
            InitializeComponent();
            LoadCustomerTypes();
            LoadGenders();
            txtCId.Enabled = true; // Cho phép nhập số CCCD
        }

        public void SetCustomerData(CustomerDTO customer, bool isEdit = true)
        {
            isEditMode = isEdit;
            originalCustomerId = customer.CId;

            txtCId.Text = customer.CId;
            txtCustomerName.Text = customer.Name;
            cboGender.SelectedItem = customer.Gender;
            txtPhone.Text = customer.Phone;
            txtEmail.Text = customer.Email;
            txtAddress.Text = customer.Address;
            cboCustomerType.SelectedItem = customer.Type;

            txtCId.Enabled = !isEdit; // Nếu là thêm mới thì cho nhập, còn sửa thì không
            this.Text = isEdit ? "Edit Customer" : "Add Customer";
        }

        private void LoadCustomerTypes()
        {
            cboCustomerType.Items.Clear();
            var types = customerBusiness.GetCustomerTypes();
            foreach (var type in types)
            {
                cboCustomerType.Items.Add(type);
            }
            cboCustomerType.SelectedIndex = 0;
        }

        private void LoadGenders()
        {
            cboGender.Items.Clear();
            var genders = customerBusiness.GetGenders();
            foreach (var gender in genders)
            {
                cboGender.Items.Add(gender);
            }
            cboGender.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtCId.Text))
            {
                MessageBox.Show("Please enter Customer ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Please enter Customer Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please enter Phone Number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow numbers and backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow letters, spaces, and backspace
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var customer = new CustomerDTO
                {
                    CId = txtCId.Text,
                    Name = txtCustomerName.Text,
                    Gender = cboGender.SelectedItem.ToString(),
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text,
                    Type = cboCustomerType.SelectedItem.ToString()
                };

                if (isEditMode)
                {
                    string result = customerBusiness.UpdateCustomerWithMessage(customer);
                    if (result == "OK")
                    {
                        MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    bool success = customerBusiness.AddCustomer(customer);
                    if (success)
                    {
                        MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Kích hoạt sự kiện khi thêm khách hàng mới thành công
                        CustomerAdded?.Invoke(this, EventArgs.Empty);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FocusPhoneField()
        {
            txtPhone.Focus();
        }
    }
}
