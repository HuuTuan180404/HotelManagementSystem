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
using DataTransferObject;

namespace Presentation.User_Controls
{
    public partial class UC_EmployeeManagement : UserControl
    {
        private EmployeeBusiness employeeBusiness;

        public UC_EmployeeManagement()
        {
            InitializeComponent();
            employeeBusiness = new EmployeeBusiness();
            LoadEmployeeData();
            LoadRoles();
        }

        private void LoadEmployeeData()
        {
            try
            {
                var employees = employeeBusiness.GetAllEmployees();
                
                if (employees == null || employees.Count == 0)
                {
                    MessageBox.Show("No employees found in database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Create DataTable
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Name");
                dt.Columns.Add("Gender");
                dt.Columns.Add("Phone");
                dt.Columns.Add("Email");
                dt.Columns.Add("Address");
                dt.Columns.Add("Status");
                dt.Columns.Add("Role");

                // Add data to DataTable
                foreach (var emp in employees)
                {
                    dt.Rows.Add(
                        emp.EId,
                        emp.EName,
                        emp.EGender,
                        emp.EPhone,
                        emp.EEmail,
                        emp.EAddress,
                        emp.EStatus,
                        emp.ERole
                    );
                }

                // Clear existing data
                dtgEmployee.DataSource = null;
                dtgEmployee.Columns.Clear();
                dtgEmployee.DataSource = dt;

                FormatDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employees: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRoles()
        {
            try
            {
                var roles = employeeBusiness.GetAllEmployeeRoles();
                cboFilter.DataSource = roles;
                cboFilter.DisplayMember = null;
                cboFilter.ValueMember = null;
                cboFilter.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading roles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDataGridView()
        {
            try
            {
                if (dtgEmployee.Columns.Count == 0) return;

                // Set column widths
                dtgEmployee.Columns[0].Width = 80;  // ID
                dtgEmployee.Columns[1].Width = 150; // Name
                dtgEmployee.Columns[2].Width = 80;  // Gender
                dtgEmployee.Columns[3].Width = 100; // Phone
                dtgEmployee.Columns[4].Width = 150; // Email
                dtgEmployee.Columns[5].Width = 200; // Address
                dtgEmployee.Columns[6].Width = 80;  // Status
                dtgEmployee.Columns[7].Width = 100; // Role

                // Set appearance
                dtgEmployee.EnableHeadersVisualStyles = false;
                dtgEmployee.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
                dtgEmployee.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(45, 66, 91);
                dtgEmployee.ThemeStyle.HeaderStyle.ForeColor = Color.White;
                dtgEmployee.ThemeStyle.HeaderStyle.Font = new Font(dtgEmployee.Font.FontFamily, 10, FontStyle.Bold);
                dtgEmployee.ColumnHeadersHeight = 40;

                // Set row appearance
                dtgEmployee.RowTemplate.Height = 35;
                dtgEmployee.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(238, 239, 249);
                dtgEmployee.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dtgEmployee.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(87, 108, 188);
                dtgEmployee.ThemeStyle.RowsStyle.SelectionForeColor = Color.WhiteSmoke;
                dtgEmployee.BackgroundColor = Color.White;
                dtgEmployee.BorderStyle = BorderStyle.None;

                // Enable features
                dtgEmployee.AllowUserToAddRows = false;
                dtgEmployee.AllowUserToDeleteRows = false;
                dtgEmployee.AllowUserToOrderColumns = true;
                dtgEmployee.AllowUserToResizeRows = false;
                dtgEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dtgEmployee.MultiSelect = false;
                dtgEmployee.ReadOnly = true;
                dtgEmployee.RowHeadersVisible = false;

                // Set default styles
                dtgEmployee.ThemeStyle.BackColor = Color.White;
                dtgEmployee.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
                dtgEmployee.ThemeStyle.RowsStyle.BackColor = Color.White;
                dtgEmployee.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
                dtgEmployee.ThemeStyle.RowsStyle.Height = 35;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error formatting grid: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Employee functionality is not yet implemented.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtgEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MessageBox.Show("Edit Employee functionality is not yet implemented.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFilter.SelectedIndex != -1)
            {
                string selectedRole = cboFilter.SelectedItem.ToString();
                var filteredEmployees = employeeBusiness.GetEmployeesByString(selectedRole);
                
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Name");
                dt.Columns.Add("Gender");
                dt.Columns.Add("Phone");
                dt.Columns.Add("Email");
                dt.Columns.Add("Address");
                dt.Columns.Add("Status");
                dt.Columns.Add("Role");

                foreach (var emp in filteredEmployees)
                {
                    dt.Rows.Add(
                        emp.EId,
                        emp.EName,
                        emp.EGender,
                        emp.EPhone,
                        emp.EEmail,
                        emp.EAddress,
                        emp.EStatus,
                        emp.ERole
                    );
                }

                dtgEmployee.DataSource = null;
                dtgEmployee.Columns.Clear();
                dtgEmployee.DataSource = dt;
                FormatDataGridView();
            }
        }

        private void btnAllEmployee_Click(object sender, EventArgs e)
        {
            LoadEmployeeData();
            cboFilter.SelectedIndex = -1;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                var filteredEmployees = employeeBusiness.GetEmployeesByString(searchText);
                
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Name");
                dt.Columns.Add("Gender");
                dt.Columns.Add("Phone");
                dt.Columns.Add("Email");
                dt.Columns.Add("Address");
                dt.Columns.Add("Status");
                dt.Columns.Add("Role");

                foreach (var emp in filteredEmployees)
                {
                    dt.Rows.Add(
                        emp.EId,
                        emp.EName,
                        emp.EGender,
                        emp.EPhone,
                        emp.EEmail,
                        emp.EAddress,
                        emp.EStatus,
                        emp.ERole
                    );
                }

                dtgEmployee.DataSource = null;
                dtgEmployee.Columns.Clear();
                dtgEmployee.DataSource = dt;
                FormatDataGridView();
            }
            else
            {
                LoadEmployeeData();
            }
        }

        private void panelControls_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
