using DataTransferObject;
using System;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Business;

namespace Presentation.Forms
{
    public partial class AddEmployee : Form
    {
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        public event Action DataChanged;
        private EmployeeBusiness EmployeeBusiness = new EmployeeBusiness();

        public AddEmployee()
        {
            InitializeComponent();
            LoadRoles();
        }

        private void LoadRoles()
        {
            comboboxRole.DataSource = EmployeeBusiness.GetAllEmployeeRoles();
            comboboxRole.SelectedIndex = -1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboboxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupboxRole.Text = comboboxRole.SelectedItem.ToString();
            var roles = EmployeeBusiness.GetAllEmployeeRoles();
            EmployeeDTO role = roles.FirstOrDefault(item => item.ERole == groupboxRole.Text);
            lbRoleDescription.Text = role.ERoleDescription;
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            moveForm(sender, e);
        }

        private void moveForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnAdd, "Add");
        }

        private void comboboxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbStatus.Text = comboboxStatus.SelectedItem.ToString();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            lbPhone.Text = txtPhone.Text;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lbEmail.Text = txtEmail.Text;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            lbAddress.Text = txtAddress.Text;
        }

        private void editRole_Click(object sender, EventArgs e)
        {
            MessageBox.Show("editRole_Click", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var employee = new EmployeeDTO
                {
                    EId = GenerateEmployeeId(),
                    EName = txtName.Text.Trim(),
                    EPhone = txtPhone.Text.Trim(),
                    EEmail = txtEmail.Text.Trim(),
                    EAddress = txtAddress.Text.Trim(),
                    ERole = comboboxRole.SelectedValue.ToString(),
                    EStatus = "Active"
                };

                if (EmployeeBusiness.AddEmployee(employee))
                {
                    MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataChanged?.Invoke();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to add employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter employee name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please enter phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please enter address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (comboboxRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private string GenerateEmployeeId()
        {
            return "E" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
} 