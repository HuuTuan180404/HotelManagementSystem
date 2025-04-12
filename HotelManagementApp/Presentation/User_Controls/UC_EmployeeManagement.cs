using Business;
using DataTransferObject;
using Presentation.Forms;
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

namespace Presentation.User_Controls
{
    public partial class UC_EmployeeManagement : UserControl
    {
        private EmployeeBusiness employeeBusiness;
        private List<EmployeeDTO> currentList;

        public UC_EmployeeManagement()
        {
            InitializeComponent();
            employeeBusiness = new EmployeeBusiness();
            currentList = employeeBusiness.GetAllEmployees();
            LoadData();
            LoadComboBoxes();
            dtgEmployee.CellClick += DtgEmployee_CellClick;
        }

        private void DtgEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    string employeeId = dtgEmployee.Rows[e.RowIndex].Cells["EId"].Value.ToString();
                    EmployeeDTO employee = employeeBusiness.GetEmployee(employeeId);
                    if (employee != null)
                    {
                        AddEmployees editForm = new AddEmployees(employee);
                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                RefreshData();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}\n\nChi tiết: {ex.InnerException?.Message}", 
                                    "Lỗi Cập Nhật", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thông tin nhân viên: {ex.Message}\n\nChi tiết: {ex.InnerException?.Message}", 
                    "Lỗi", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            dtgEmployee.DataSource = currentList;
            UpdateStatistics();
        }

        private void LoadComboBoxes()
        {
            // Load status options
            cbStatus.Items.Clear();
            cbStatus.Items.Add("Tất cả");
            cbStatus.Items.Add("Active");
            cbStatus.Items.Add("Inactive");
            cbStatus.Items.Add("On Leave");
            cbStatus.SelectedIndex = 0;

            // Load role options
            cbDepartment.Items.Clear();
            cbDepartment.Items.Add("Tất cả");
            var roles = currentList.Select(e => e.ERole).Distinct().ToList();
            foreach (var role in roles)
            {
                cbDepartment.Items.Add(role);
            }
            cbDepartment.SelectedIndex = 0;
        }

        private void UpdateStatistics()
        {
            int total = currentList.Count;
            int active = currentList.Count(e => e.Status == "Active");
            int inactive = currentList.Count(e => e.Status == "Inactive");
            int onLeave = currentList.Count(e => e.Status == "On Leave");

            lblTotalNumber.Text = total.ToString();
            lblActiveNumber.Text = active.ToString();
            lblInactiveNumber.Text = inactive.ToString();
        }

        
        private void btnEdit_Click(object sender, EventArgs e)
        {

        }




        private void ApplyFilters()
        {
            var filteredList = currentList;

            // Apply status filter
            if (cbStatus.SelectedIndex > 0)
            {
                string selectedStatus = cbStatus.SelectedItem.ToString();
                filteredList = filteredList.Where(e => e.Status == selectedStatus).ToList();
            }

            // Apply role filter
            if (cbDepartment.SelectedIndex > 0)
            {
                filteredList = filteredList.Where(e => e.ERole == cbDepartment.SelectedItem.ToString()).ToList();
            }

            dtgEmployee.DataSource = filteredList;
            UpdateStatistics();
        }

        private void RefreshData()
        {
            currentList = employeeBusiness.GetAllEmployees();
            LoadComboBoxes();
            ApplyFilters();
        }

       
        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchEmployee.Text.ToLower();
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                currentList = employeeBusiness.GetEmployeesByString(searchText);
            }
            else
            {
                currentList = employeeBusiness.GetAllEmployees();
            }
            ApplyFilters();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtgEmployee.SelectedRows.Count > 0)
            {
                string employeeId = dtgEmployee.SelectedRows[0].Cells["EId"].Value.ToString();
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (employeeBusiness.DeleteEmployee(employeeId))
                    {
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshData();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployees addForm = new AddEmployees();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                RefreshData();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // TODO: Implement export functionality
            MessageBox.Show("Chức năng xuất dữ liệu sẽ được triển khai sau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
