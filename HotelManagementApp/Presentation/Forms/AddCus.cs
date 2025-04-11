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

        public AddCus()
        {
            InitializeComponent();
            LoadCustomerTypes();
            LoadGenders();
            GenerateCustomerId();
        }

        private void GenerateCustomerId()
        {
            if (!isEditMode)
            {
                var customers = customerBusiness.GetAllCustomers();
                
                // Lấy danh sách các số đã được sử dụng
                var usedNumbers = customers
                    .Select(c => c.CId)
                    .Where(id => id.StartsWith("C") && id.Length == 4)
                    .Select(id => 
                    {
                        if (int.TryParse(id.Substring(1), out int number))
                            return number;
                        return -1;
                    })
                    .Where(n => n > 0)
                    .OrderBy(n => n)
                    .ToList();

                // Nếu chưa có số nào được sử dụng, bắt đầu từ 1
                if (!usedNumbers.Any())
                {
                    txtCId.Text = "C001";
                    return;
                }

                // Tìm số nhỏ nhất chưa được sử dụng
                int nextNumber = 1;
                foreach (int number in usedNumbers)
                {
                    if (number != nextNumber)
                        break;
                    nextNumber++;
                }

                txtCId.Text = $"C{nextNumber:D3}";
            }
        }

        public void SetCustomerData(CustomerDTO customer)
        {
            isEditMode = true;
            originalCustomerId = customer.CId;

            txtCId.Text = customer.CId;
            txtCustomerName.Text = customer.Name;
            cboGender.SelectedItem = customer.Gender;
            txtPhone.Text = customer.Phone;
            txtEmail.Text = customer.Email;
            txtAddress.Text = customer.Address;
            cboCustomerType.SelectedItem = customer.Type;

            txtCId.Enabled = false; // Disable ID field in edit mode
            this.Text = "Edit Customer";
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

                bool success;
                if (isEditMode)
                {
                    success = customerBusiness.UpdateCustomer(customer);
                }
                else
                {
                    success = customerBusiness.AddCustomer(customer);
                }

                if (success)
                {
                    MessageBox.Show($"Customer {(isEditMode ? "updated" : "added")} successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Failed to {(isEditMode ? "update" : "add")} customer!",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
