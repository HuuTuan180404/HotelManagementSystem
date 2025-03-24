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
        private EmployeeB employeeB;

        public UC_EmployeeManagement()
        {
            InitializeComponent();
            employeeB = new EmployeeB();
            InitializeDataGridView();
            LoadComboBoxes();
            LoadEmployeeData();
            btnDelete.Enabled = false;
        }

        private void InitializeDataGridView()
        {
            // Configure DataGridView
            dtgEmployee.AutoGenerateColumns = false;
            dtgEmployee.AllowUserToAddRows = false;
            dtgEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Clear existing columns
            dtgEmployee.Columns.Clear();

            // Add checkbox column
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 40;
            checkBoxColumn.Name = "chkSelect";
            dtgEmployee.Columns.Add(checkBoxColumn);

            // Add data columns
            var columns = new[]
            {
                new { Name = "EID", Header = "ID", Width = 80 },
                new { Name = "EName", Header = "Name", Width = 150 },
                new { Name = "EGender", Header = "Gender", Width = 80 },
                new { Name = "EPhone", Header = "Phone", Width = 100 },
                new { Name = "EEmail", Header = "Email", Width = 150 },
                new { Name = "EAddress", Header = "Address", Width = 200 },
                new { Name = "EStatus", Header = "Status", Width = 80 },
                new { Name = "ERole", Header = "Role", Width = 100 },
                new { Name = "ERDescription", Header = "Role Description", Width = 150 }
            };

            foreach (var col in columns)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.Name = col.Name;
                column.HeaderText = col.Header;
                column.DataPropertyName = col.Name;
                column.Width = col.Width;
                dtgEmployee.Columns.Add(column);
            }
        }

        private void UC_EmployeeManagement_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            // Load Status ComboBox
            cbStatus.Items.Clear();
            cbStatus.Items.Add("All");
            cbStatus.Items.Add("Active");
            cbStatus.Items.Add("Inactive");
            cbStatus.Items.Add("On Leave");
            cbStatus.SelectedIndex = 0;

            // Load Department/Role ComboBox
            cbDepartment.Items.Clear();
            cbDepartment.Items.Add("All");
            var roles = employeeB.GetAllRoles();
            foreach (var role in roles)
            {
                cbDepartment.Items.Add(role.ERole);
            }
            cbDepartment.SelectedIndex = 0;
        }

        private void LoadEmployeeData()
        {
            try
            {
                var employees = employeeB.GetAllEmployees();
                
                if (employees == null || employees.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu nhân viên!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Create a binding source
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = employees;
                dtgEmployee.DataSource = bindingSource;

                // Update summary cards
                int totalEmployees = employees.Count;
                int activeEmployees = employees.Count(e => e.EStatus == "Active");
                int inactiveEmployees = totalEmployees - activeEmployees;

                lblTotalNumber.Text = totalEmployees.ToString();
                lblActiveNumber.Text = activeEmployees.ToString();
                lblInactiveNumber.Text = inactiveEmployees.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load dữ liệu nhân viên: {ex.Message}\n\nStack Trace: {ex.StackTrace}", 
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cardActive_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cardTotal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbLayoutCard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblInactiveNumber_Click(object sender, EventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2lblInactiveTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblActiveNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblActiveTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalTitle_Click(object sender, EventArgs e)
        {

        }

        private void pnlFilter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterEmployees();
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterEmployees();
        }

        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            FilterEmployees();
        }

        private void FilterEmployees()
        {
            try
            {
                string searchText = txtSearchEmployee.Text.Trim().ToLower();
                string status = cbStatus.SelectedIndex == 0 ? "" : (cbStatus.SelectedItem?.ToString() ?? "");
                string role = "";
                
                if (cbDepartment.SelectedIndex > 0 && cbDepartment.SelectedItem != null)
                {
                    role = cbDepartment.SelectedItem.ToString();
                }

                var employees = employeeB.GetFilteredEmployees(searchText, status, role);
                
                // Create a binding source
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = employees;
                dtgEmployee.DataSource = bindingSource;

                // Update summary cards
                int totalEmployees = employees.Count;
                int activeEmployees = employees.Count(e => e.EStatus == "Active");
                int inactiveEmployees = totalEmployees - activeEmployees;

                lblTotalNumber.Text = totalEmployees.ToString();
                lblActiveNumber.Text = activeEmployees.ToString();
                lblInactiveNumber.Text = inactiveEmployees.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lọc dữ liệu nhân viên: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgEmployee.Columns["chkSelect"].Index && e.RowIndex >= 0)
            {
                dtgEmployee.EndEdit(); // Ensure the checkbox value is updated

                bool hasChecked = false;
                foreach (DataGridViewRow row in dtgEmployee.Rows)
                {
                    if (row.Cells["chkSelect"].Value != null && 
                        (bool)row.Cells["chkSelect"].Value == true)
                    {
                        hasChecked = true;
                        break;
                    }
                }
                btnDelete.Enabled = hasChecked;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa các nhân viên đã chọn?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<string> employeeIdsToDelete = new List<string>();
                foreach (DataGridViewRow row in dtgEmployee.Rows)
                {
                    if (row.Cells["chkSelect"].Value != null && 
                        (bool)row.Cells["chkSelect"].Value == true)
                    {
                        string employeeId = row.Cells["EID"].Value.ToString();
                        employeeIdsToDelete.Add(employeeId);
                    }
                }

                if (employeeIdsToDelete.Count > 0)
                {
                    try 
                    {
                        if (employeeB.DeleteEmployees(employeeIdsToDelete))
                        {
                            MessageBox.Show("Xóa nhân viên thành công!", 
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadEmployeeData();
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra khi xóa nhân viên!", 
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, 
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    btnDelete.Enabled = false;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
