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
        private readonly EmployeeBusiness employeeBusiness;
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
            checkBoxColumn.Width = 40;
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

            // Đảm bảo cột Select luôn nhỏ và cố định size
            if (dtgEmployee.Columns.Contains("chkSelect"))
            {
                dtgEmployee.Columns["chkSelect"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dtgEmployee.Columns["chkSelect"].Width = 30;
            }
            // Các cột còn lại fill đều màn hình
            foreach (DataGridViewColumn col in dtgEmployee.Columns)
            {
                if (col.Name != "chkSelect")
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    col.FillWeight = 1;
                }
            }
            // Đảm bảo header không bị wrap
            dtgEmployee.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
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
            try
            {
                // Create a new list with only the fields we want to display
                var displayList = currentList.Select(e => new
                {
                    e.EId,
                    e.Name,
                    e.Gender,
                    e.Phone,
                    e.Email,
                    e.Address,
                    e.Status,
                    e.ERole,
                    e.RoleDescription,
                    e.Avatar
                }).ToList();

                dtgEmployee.DataSource = displayList;
                UpdateStatistics();
                dtgEmployee.ClearSelection();

                // Đảm bảo cột Select luôn nhỏ và cố định size
                if (dtgEmployee.Columns.Contains("chkSelect"))
                {
                    dtgEmployee.Columns["chkSelect"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dtgEmployee.Columns["chkSelect"].Width = 30;
                }
                // Các cột còn lại fill đều màn hình
                foreach (DataGridViewColumn col in dtgEmployee.Columns)
                {
                    if (col.Name != "chkSelect")
                    {
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 1;
                    }
                }

                // Xóa hoàn toàn cột Password nếu có
                if (dtgEmployee.Columns.Contains("Password"))
                {
                    dtgEmployee.Columns.Remove("Password");
                }

                // Định dạng lại width cho các cột để header đủ chữ và đều
                if (dtgEmployee.Columns["EId"] != null)
                {
                    dtgEmployee.Columns["EId"].HeaderText = "Mã NV";
                    dtgEmployee.Columns["EId"].Width = 110;
                }
                if (dtgEmployee.Columns["Name"] != null)
                {
                    dtgEmployee.Columns["Name"].HeaderText = "Tên NV";
                    dtgEmployee.Columns["Name"].Width = 140;
                }
                if (dtgEmployee.Columns["Gender"] != null)
                {
                    dtgEmployee.Columns["Gender"].HeaderText = "Giới tính";
                    dtgEmployee.Columns["Gender"].Width = 90;
                }
                if (dtgEmployee.Columns["Phone"] != null)
                {
                    dtgEmployee.Columns["Phone"].HeaderText = "SĐT";
                    dtgEmployee.Columns["Phone"].Width = 110;
                }
                if (dtgEmployee.Columns["Email"] != null)
                {
                    dtgEmployee.Columns["Email"].HeaderText = "Email";
                    dtgEmployee.Columns["Email"].Width = 150;
                }
                if (dtgEmployee.Columns["Address"] != null)
                {
                    dtgEmployee.Columns["Address"].HeaderText = "Địa chỉ";
                    dtgEmployee.Columns["Address"].Width = 150;
                }
                if (dtgEmployee.Columns["Status"] != null)
                {
                    dtgEmployee.Columns["Status"].HeaderText = "Trạng thái";
                    dtgEmployee.Columns["Status"].Width = 110;
                }
                if (dtgEmployee.Columns["ERole"] != null)
                {
                    dtgEmployee.Columns["ERole"].HeaderText = "Vai trò";
                    dtgEmployee.Columns["ERole"].Width = 110;
                    dtgEmployee.Columns["ERole"].DisplayIndex = 7;
                    dtgEmployee.Columns["ERole"].Visible = true;
                }

                // Hide unnecessary columns
                if (dtgEmployee.Columns["RoleDescription"] != null)
                {
                    dtgEmployee.Columns["RoleDescription"].Visible = false;
                }
                if (dtgEmployee.Columns["Avatar"] != null)
                {
                    dtgEmployee.Columns["Avatar"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComboBoxes()
        {
            try
            {
                // Load status options
                cbStatus.Items.Clear();
                cbStatus.Items.Add("Tất cả");
                cbStatus.Items.Add("Active");
                cbStatus.Items.Add("Inactive");
                cbStatus.Items.Add("On Leave");
                cbStatus.SelectedIndex = 0;

                // Load department/role options from database
                cbDepartment.Items.Clear();
                cbDepartment.Items.Add("Tất cả");
                var roles = employeeBusiness.GetAllRoles(); // Lấy từ database
                foreach (var role in roles)
                {
                    cbDepartment.Items.Add(role);
                }
                cbDepartment.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStatistics()
        {
            try
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

                // Tổng số nhân viên thực tế trong database (không theo bộ lọc)
                int total = employeeBusiness.GetAllEmployees().Count;
                int active = filteredList.Count(e => e.Status == "Active");
                int inactive = filteredList.Count(e => e.Status == "Inactive");
                int onLeave = filteredList.Count(e => e.Status == "On Leave");

                // Update UI
                lblTotalNumber.Text = total.ToString();
                lblActiveNumber.Text = active.ToString();
                lblInactiveNumber.Text = inactive.ToString();
                lblOLNumber.Text = onLeave.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật thống kê: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyFilters()
        {
            try
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
                    filteredList = filteredList.Where(e => e.Status == cbStatus.SelectedItem.ToString()).ToList();
                }

                // Apply search filter
                if (!string.IsNullOrWhiteSpace(txtSearchEmployee.Text))
                {
                    string searchText = txtSearchEmployee.Text.ToLower();
                    filteredList = filteredList.Where(e =>
                        e.EId.ToLower().Contains(searchText) ||
                        e.Name.ToLower().Contains(searchText) ||
                        e.Phone.ToLower().Contains(searchText) ||
                        (e.Email != null && e.Email.ToLower().Contains(searchText))
                    ).ToList();
                }

                // Tạo displayList không chứa Password
                var displayList = filteredList.Select(e => new
                {
                    e.EId,
                    e.Name,
                    e.Gender,
                    e.Phone,
                    e.Email,
                    e.Address,
                    e.Status,
                    e.ERole,
                    e.RoleDescription,
                    e.Avatar
                }).ToList();

                // Update DataGridView
                dtgEmployee.DataSource = displayList;
                UpdateStatistics();
                dtgEmployee.ClearSelection();

                // Đảm bảo cột Select luôn nhỏ và cố định size
                if (dtgEmployee.Columns.Contains("chkSelect"))
                {
                    dtgEmployee.Columns["chkSelect"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dtgEmployee.Columns["chkSelect"].Width = 30;
                }
                // Các cột còn lại fill đều màn hình
                foreach (DataGridViewColumn col in dtgEmployee.Columns)
                {
                    if (col.Name != "chkSelect")
                    {
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lọc dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshData()
        {
            try
            {
                currentList = employeeBusiness.GetAllEmployees();
                LoadData();
                LoadComboBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi làm mới dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            ApplyFilters();
        }

        private void txtSearchEmployee_IconRightClick(object sender, EventArgs e)
        {
            txtSearchEmployee.Text = "";
            ApplyFilters();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = dtgEmployee.Rows.Cast<DataGridViewRow>()
                    .Where(row => row.Cells[0].Value != null && (bool)row.Cells[0].Value)
                    .ToList();

                if (selectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa {selectedRows.Count} nhân viên đã chọn?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool allSuccess = true;
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        string eId = row.Cells["EId"].Value.ToString();
                        if (!employeeBusiness.DeleteEmployee(eId))
                        {
                            allSuccess = false;
                        }
                    }

                    if (allSuccess)
                    {
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshData();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi xóa một số nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (AddEmployees form = new AddEmployees())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        RefreshData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Xuất danh sách nhân viên";
                    saveFileDialog.FileName = "DanhSachNhanVien_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Danh sách nhân viên");

                            // Add headers
                            worksheet.Cell(1, 1).Value = "Mã NV";
                            worksheet.Cell(1, 2).Value = "Tên NV";
                            worksheet.Cell(1, 3).Value = "Giới tính";
                            worksheet.Cell(1, 4).Value = "SĐT";
                            worksheet.Cell(1, 5).Value = "Email";
                            worksheet.Cell(1, 6).Value = "Địa chỉ";
                            worksheet.Cell(1, 7).Value = "Trạng thái";
                            worksheet.Cell(1, 8).Value = "Vai trò";

                            // Style headers
                            var headerRange = worksheet.Range(1, 1, 1, 8);
                            headerRange.Style.Fill.BackgroundColor = XLColor.FromArgb(46, 144, 250);
                            headerRange.Style.Font.Bold = true;
                            headerRange.Style.Font.FontColor = XLColor.White;
                            headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                            // Add data
                            int row = 2;
                            foreach (DataGridViewRow dgvRow in dtgEmployee.Rows)
                            {
                                worksheet.Cell(row, 1).Value = dgvRow.Cells["EId"].Value?.ToString();
                                worksheet.Cell(row, 2).Value = dgvRow.Cells["Name"].Value?.ToString();
                                worksheet.Cell(row, 3).Value = dgvRow.Cells["Gender"].Value?.ToString();
                                worksheet.Cell(row, 4).Value = dgvRow.Cells["Phone"].Value?.ToString();
                                worksheet.Cell(row, 5).Value = dgvRow.Cells["Email"].Value?.ToString();
                                worksheet.Cell(row, 6).Value = dgvRow.Cells["Address"].Value?.ToString();
                                worksheet.Cell(row, 7).Value = dgvRow.Cells["Status"].Value?.ToString();
                                worksheet.Cell(row, 8).Value = dgvRow.Cells["ERole"].Value?.ToString();
                                row++;
                            }

                            // Auto-fit columns
                            worksheet.Columns().AdjustToContents();

                            // Save file
                            workbook.SaveAs(saveFileDialog.FileName);
                            MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất file Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    string eId = dtgEmployee.Rows[e.RowIndex].Cells["EId"].Value.ToString();
                    EmployeeDTO employee = currentList.FirstOrDefault(emp => emp.EId == eId);
                    if (employee != null)
                    {
                        using (AddEmployees form = new AddEmployees(employee))
                        {
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                RefreshData();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở thông tin nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cardOnLeave_Click(object sender, EventArgs e)
        {
            cbStatus.SelectedItem = "On Leave";
        }

        private void cardActive_Click(object sender, EventArgs e)
        {
            cbStatus.SelectedItem = "Active";
        }

        private void cardInactive_Click(object sender, EventArgs e)
        {
            cbStatus.SelectedItem = "Inactive";
        }

        private void cardTotal_Click(object sender, EventArgs e)
        {
            cbStatus.SelectedItem = "Tất cả";
        }

        private void txtSearchEmployee_IconRightClick_1(object sender, EventArgs e)
        {
            txtSearchEmployee.Text = "";
            ApplyFilters();
        }
    }
}
