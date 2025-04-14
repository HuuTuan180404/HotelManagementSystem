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
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.IO;
using ClosedXML.Excel;

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

            // Configure DataGridView
            dtgEmployee.ReadOnly = true;
            dtgEmployee.AllowUserToAddRows = false;
            dtgEmployee.AllowUserToDeleteRows = false;
            dtgEmployee.AllowUserToResizeRows = false;
            dtgEmployee.MultiSelect = true;
            dtgEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Configure header
            dtgEmployee.EnableHeadersVisualStyles = false;
            dtgEmployee.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 144, 250);
            dtgEmployee.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgEmployee.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Bold);
            dtgEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgEmployee.ColumnHeadersHeight = 40;
            dtgEmployee.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Prevent header selection
            dtgEmployee.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(46, 144, 250);
            dtgEmployee.RowHeadersDefaultCellStyle.SelectionBackColor = dtgEmployee.RowHeadersDefaultCellStyle.BackColor;

            // Add checkbox column
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Select";
            checkBoxColumn.Width = 30;
            checkBoxColumn.ReadOnly = false;
            checkBoxColumn.Name = "chkSelect";
            dtgEmployee.Columns.Insert(0, checkBoxColumn);

            // Style for cells
            dtgEmployee.CellPainting += (s, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    e.CellStyle.BackColor = Color.White;
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.SelectionBackColor = Color.White;
                    e.CellStyle.SelectionForeColor = Color.Black;
                }
            };

            // Handle checkbox clicks
            dtgEmployee.CellContentClick += (s, e) =>
            {
                if (e.ColumnIndex == 0 && e.RowIndex >= 0)
                {
                    DataGridViewRow row = dtgEmployee.Rows[e.RowIndex];
                    bool currentValue = row.Cells[0].Value != null && (bool)row.Cells[0].Value;
                    row.Cells[0].Value = !currentValue;
                    dtgEmployee.EndEdit();
                    dtgEmployee.InvalidateRow(e.RowIndex);
                    DtgEmployee_SelectionChanged(s, e);
                }
            };

            // Handle header cell click for "Select All"
            dtgEmployee.CellClick += DtgEmployee_CellClick;
            dtgEmployee.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (dtgEmployee.IsCurrentCellDirty)
                {
                    dtgEmployee.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    dtgEmployee.RefreshEdit();
                }
            };

            // Configure Delete button
            btnDelete.Visible = false;
            dtgEmployee.SelectionChanged += DtgEmployee_SelectionChanged;

            LoadData();
            LoadComboBoxes();          
        }

        private void DtgEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == 0)
            {
                bool currentState = false;
                foreach (DataGridViewRow row in dtgEmployee.Rows)
                {
                    if (row.Cells[0].Value != null && (bool)row.Cells[0].Value)
                    {
                        currentState = true;
                        break;
                    }
                }

                // Toggle state
                foreach (DataGridViewRow row in dtgEmployee.Rows)
                {
                    row.Cells[0].Value = !currentState;
                }

                // Update delete button visibility
                DtgEmployee_SelectionChanged(sender, e);
            }
        }

        private void DtgEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                dtgEmployee.EndEdit();
                dtgEmployee.InvalidateRow(e.RowIndex);
                dtgEmployee.Refresh(); // Force refresh of the grid
                DtgEmployee_SelectionChanged(sender, e);
            }
        }

        private void DtgEmployee_SelectionChanged(object sender, EventArgs e)
        {
            // Show delete button if any checkbox is checked
            bool anyChecked = false;
            foreach (DataGridViewRow row in dtgEmployee.Rows)
            {
                if (row.Cells[0].Value != null && (bool)row.Cells[0].Value)
                {
                    anyChecked = true;
                    break;
                }
            }
            btnDelete.Visible = anyChecked;
        }

        private void LoadData()
        {
            dtgEmployee.DataSource = currentList;
            UpdateStatistics();
            dtgEmployee.ClearSelection();

            // Hide RoleDescription column
            if (dtgEmployee.Columns["RoleDescription"] != null)
            {
                dtgEmployee.Columns["RoleDescription"].Visible = false;
            }
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
            var filteredList = currentList;

            // Apply department filter if selected
            if (cbDepartment.SelectedIndex > 0)
            {
                string selectedRole = cbDepartment.SelectedItem.ToString();
                filteredList = filteredList.Where(e => e.ERole == selectedRole).ToList();
            }

            // Apply status filter if selected
            if (cbStatus.SelectedIndex > 0)
            {
                string selectedStatus = cbStatus.SelectedItem.ToString();
                filteredList = filteredList.Where(e => e.Status == selectedStatus).ToList();
            }

            // Calculate statistics based on filtered list
            int total = filteredList.Count;
            int active = filteredList.Count(e => e.Status == "Active");
            int inactive = filteredList.Count(e => e.Status == "Inactive");
            int onLeave = filteredList.Count(e => e.Status == "On Leave");

            // Update UI
            lblTotalNumber.Text = total.ToString();
            lblActiveNumber.Text = active.ToString();
            lblInactiveNumber.Text = inactive.ToString();
            //lblOLNumber.Text = onLeave.ToString();
        }

        private void ApplyFilters()
        {
            var filteredList = currentList;

            // Apply department filter
            if (cbDepartment.SelectedIndex > 0)
            {
                filteredList = filteredList.Where(e => e.ERole == cbDepartment.SelectedItem.ToString()).ToList();
            }

            // Apply status filter
            if (cbStatus.SelectedIndex > 0)
            {
                string selectedStatus = cbStatus.SelectedItem.ToString();
                filteredList = filteredList.Where(e => e.Status == selectedStatus).ToList();
            }

            dtgEmployee.DataSource = filteredList;
            UpdateStatistics();
        }

        private void RefreshData()
        {
            currentList = employeeBusiness.GetAllEmployees();
            LoadComboBoxes();
            ApplyFilters();
            dtgEmployee.ClearSelection();
            btnDelete.Visible = false; // Hide delete button after refresh
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
            // Remove automatic search on text change
        }

        private void txtSearchEmployee_IconRightClick(object sender, EventArgs e)
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
            // Get all selected employee IDs
            List<string> selectedIds = new List<string>();
            foreach (DataGridViewRow row in dtgEmployee.Rows)
            {
                if (row.Cells[0].Value != null && (bool)row.Cells[0].Value)
                {
                    selectedIds.Add(row.Cells["EId"].Value.ToString());
                }
            }

            if (selectedIds.Count > 0)
            {
                if (MessageBox.Show($"Bạn có chắc chắn muốn xóa {selectedIds.Count} nhân viên đã chọn?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool allSuccess = true;
                    foreach (string id in selectedIds)
                    {
                        if (!employeeBusiness.DeleteEmployee(id))
                        {
                            allSuccess = false;
                        }
                    }

                    if (allSuccess)
                    {
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi xóa một số nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    RefreshData();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployees addForm = new AddEmployees();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                RefreshData();
                dtgEmployee.ClearSelection();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Get selected employees
            List<EmployeeDTO> selectedEmployees = new List<EmployeeDTO>();
            foreach (DataGridViewRow row in dtgEmployee.Rows)
            {
                if (row.Cells[0].Value != null && (bool)row.Cells[0].Value)
                {
                    string employeeId = row.Cells["EId"].Value.ToString();
                    EmployeeDTO employee = employeeBusiness.GetEmployee(employeeId);
                    if (employee != null)
                    {
                        selectedEmployees.Add(employee);
                    }
                }
            }

            if (selectedEmployees.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một nhân viên để xuất dữ liệu!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Chọn nơi lưu file Excel",
                    FileName = $"DanhSachNhanVien_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"
                };

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Employees");

                        // Add headers
                        worksheet.Cell(1, 1).Value = "Mã NV";
                        worksheet.Cell(1, 2).Value = "Họ Tên";
                        worksheet.Cell(1, 3).Value = "Giới Tính";
                        worksheet.Cell(1, 4).Value = "Số Điện Thoại";
                        worksheet.Cell(1, 5).Value = "Email";
                        worksheet.Cell(1, 6).Value = "Địa Chỉ";
                        worksheet.Cell(1, 7).Value = "Trạng Thái";
                        worksheet.Cell(1, 8).Value = "Chức Vụ";

                        // Style header row
                        var headerRow = worksheet.Row(1);
                        headerRow.Style.Font.Bold = true;
                        headerRow.Style.Fill.BackgroundColor = XLColor.FromArgb(46, 144, 250);
                        headerRow.Style.Font.FontColor = XLColor.White;

                        // Add data
                        int row = 2;
                        foreach (var employee in selectedEmployees)
                        {
                            worksheet.Cell(row, 1).Value = employee.EId;
                            worksheet.Cell(row, 2).Value = employee.Name;
                            worksheet.Cell(row, 3).Value = employee.Gender;
                            worksheet.Cell(row, 4).Value = employee.Phone;
                            worksheet.Cell(row, 5).Value = employee.Email;
                            worksheet.Cell(row, 6).Value = employee.Address;
                            worksheet.Cell(row, 7).Value = employee.Status;
                            worksheet.Cell(row, 8).Value = employee.ERole;
                            row++;
                        }

                        // Auto-fit columns
                        worksheet.Columns().AdjustToContents();

                        // Add borders
                        var tableRange = worksheet.Range(1, 1, selectedEmployees.Count + 1, 8);
                        tableRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        tableRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                        // Save workbook
                        workbook.SaveAs(saveDialog.FileName);

                        MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                string errorMessage = $"Có lỗi xảy ra khi xuất file:\n\n" +
                                    $"Message: {ex.Message}\n\n" +
                                    $"Stack Trace: {ex.StackTrace}\n\n" +
                                    $"Inner Exception: {(ex.InnerException != null ? ex.InnerException.Message : "None")}";
                
                MessageBox.Show(errorMessage, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string employeeId = dtgEmployee.Rows[e.RowIndex].Cells["EId"].Value.ToString();
                EmployeeDTO employee = employeeBusiness.GetEmployee(employeeId);
                AddEmployees editForm = new AddEmployees(employee);
                editForm.ShowDialog();
                RefreshData();
                dtgEmployee.ClearSelection();
            }
        }

        private void cardOnLeave_Click(object sender, EventArgs e)
        {
            cbStatus.SelectedItem = "On Leave";
            ApplyFilters();
        }

        private void cardActive_Click(object sender, EventArgs e)
        {
            cbStatus.SelectedItem = "Active";
            ApplyFilters();
        }

        private void cardInactive_Click(object sender, EventArgs e)
        {
            cbStatus.SelectedItem = "Inactive";
            ApplyFilters();
        }

        private void cardTotal_Click(object sender, EventArgs e)
        {
            cbStatus.SelectedItem = "Tất cả";
            ApplyFilters();
        }

        private void txtSearchEmployee_IconRightClick_1(object sender, EventArgs e)
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

       
    }
}
