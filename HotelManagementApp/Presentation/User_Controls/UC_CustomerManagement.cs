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
    public partial class UC_CustomerManagement : UserControl
    {
        private CustomerBusiness customerBusiness = new CustomerBusiness();

        public UC_CustomerManagement()
        {
            InitializeComponent();
            ConfigureDataGridView();
            LoadCustomers();
            
            // Đăng ký sự kiện CellDoubleClick
            dgvCustomers.CellDoubleClick += DgvCustomers_CellDoubleClick;
            
            // Đăng ký sự kiện SelectionChanged
            dgvCustomers.SelectionChanged += DgvCustomers_SelectionChanged;
            
            // Đăng ký sự kiện click cho các panel
            pnlCustomerVIP.Click += pnlCustomerVIP_Click;
            pnlNewCustomer.Click += pnlNewCustomer_Click;
            pnlRevenue.Click += pnlRevenue_Click;
            
            // Ẩn nút xóa khi khởi động
            btDelete.Visible = false;
        }

        private void ConfigureDataGridView()
        {
            // Cấu hình các thuộc tính chung của DataGridView
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.AllowUserToResizeRows = false;
            dgvCustomers.AllowUserToResizeColumns = false;
            dgvCustomers.AllowUserToOrderColumns = false;
            dgvCustomers.ReadOnly = false;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.MultiSelect = true;

            // Xóa tất cả các cột hiện có
            dgvCustomers.Columns.Clear();

            // Tạo và thêm cột checkbox
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "Select";
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 40;
            checkBoxColumn.ReadOnly = false;
            checkBoxColumn.FalseValue = false;
            checkBoxColumn.TrueValue = true;
            checkBoxColumn.IndeterminateValue = false;
            checkBoxColumn.HeaderCell = new DataGridViewCheckBoxHeaderCell();
            dgvCustomers.Columns.Add(checkBoxColumn);

            // Thêm các cột khác
            var cidColumn = new DataGridViewTextBoxColumn();
            cidColumn.DataPropertyName = "CId";
            cidColumn.HeaderText = "Mã KH";
            cidColumn.Width = 80;
            cidColumn.ReadOnly = true;
            dgvCustomers.Columns.Add(cidColumn);

            var nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Họ và Tên";
            nameColumn.Width = 150;
            nameColumn.ReadOnly = true;
            dgvCustomers.Columns.Add(nameColumn);

            var genderColumn = new DataGridViewTextBoxColumn();
            genderColumn.DataPropertyName = "Gender";
            genderColumn.HeaderText = "Giới Tính";
            genderColumn.Width = 80;
            genderColumn.ReadOnly = true;
            dgvCustomers.Columns.Add(genderColumn);

            var phoneColumn = new DataGridViewTextBoxColumn();
            phoneColumn.DataPropertyName = "Phone";
            phoneColumn.HeaderText = "Số Điện Thoại";
            phoneColumn.Width = 100;
            phoneColumn.ReadOnly = true;
            dgvCustomers.Columns.Add(phoneColumn);

            var emailColumn = new DataGridViewTextBoxColumn();
            emailColumn.DataPropertyName = "Email";
            emailColumn.HeaderText = "Email";
            emailColumn.Width = 150;
            emailColumn.ReadOnly = true;
            dgvCustomers.Columns.Add(emailColumn);

            var addressColumn = new DataGridViewTextBoxColumn();
            addressColumn.DataPropertyName = "Address";
            addressColumn.HeaderText = "Địa Chỉ";
            addressColumn.Width = 200;
            addressColumn.ReadOnly = true;
            dgvCustomers.Columns.Add(addressColumn);

            var typeColumn = new DataGridViewTextBoxColumn();
            typeColumn.DataPropertyName = "Type";
            typeColumn.HeaderText = "Loại KH";
            typeColumn.Width = 80;
            typeColumn.ReadOnly = true;
            dgvCustomers.Columns.Add(typeColumn);

            // Cấu hình style cho header
            dgvCustomers.EnableHeadersVisualStyles = false;
            dgvCustomers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
            dgvCustomers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCustomers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvCustomers.ColumnHeadersHeight = 40;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Cấu hình style cho cells
            dgvCustomers.DefaultCellStyle.Font = new Font("Segoe UI", 9.75F);
            dgvCustomers.DefaultCellStyle.BackColor = Color.White;
            dgvCustomers.DefaultCellStyle.ForeColor = Color.Black;
            dgvCustomers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(87, 227, 211);
            dgvCustomers.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Cấu hình alternating row color
            dgvCustomers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);

            // Đăng ký sự kiện
            dgvCustomers.CellClick += DgvCustomers_CellClick;
            dgvCustomers.CurrentCellDirtyStateChanged += DgvCustomers_CurrentCellDirtyStateChanged;
        }

        private void LoadCustomers()
        {
            var customers = customerBusiness.GetAllCustomers();
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = customers;
            UpdateCustomerCounts(customers);

            dgvCustomers.SuspendLayout();
            foreach (DataGridViewRow row in dgvCustomers.Rows)
            {
                row.Cells["Select"].Value = false;
            }
            dgvCustomers.ResumeLayout();
            btDelete.Visible = false;
        }

        private void UpdateCustomerCounts(List<CustomerDTO> customers)
        {
            lbTotalCustomer.Text = customers.Count.ToString();
            lbNewCustomer.Text = customers.Count(c => c.Type == "New").ToString();
            lbCustomerVIP.Text = customers.Count(c => c.Type == "VIP").ToString();
            lbRegular.Text = customers.Count(c=> c.Type =="Regular").ToString();
        }

        private void DgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo không click vào header
            {
                var selectedCustomer = dgvCustomers.Rows[e.RowIndex].DataBoundItem as CustomerDTO;
                if (selectedCustomer != null)
                {
                    AddCus editForm = new AddCus();
                    editForm.SetCustomerData(selectedCustomer);
                    editForm.ShowDialog();
                    LoadCustomers(); // Refresh data after editing
                }
            }
        }

        private void DgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            // Hiện/ẩn nút xóa dựa trên việc có dòng nào được chọn hay không
            btDelete.Visible = dgvCustomers.SelectedRows.Count > 0;
        }

        private void DgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCustomers.Columns["Select"].Index)
            {
                if (e.RowIndex == -1) // Header Click
                {
                    bool isChecked = false;
                    foreach (DataGridViewRow row in dgvCustomers.Rows)
                    {
                        if (row.Cells["Select"].Value != null && (bool)row.Cells["Select"].Value)
                        {
                            isChecked = true;
                            break;
                        }
                    }

                    foreach (DataGridViewRow row in dgvCustomers.Rows)
                    {
                        row.Cells["Select"].Value = !isChecked;
                    }

                    btDelete.Visible = !isChecked;
                }
                else if (e.RowIndex >= 0) // Row Click
                {
                    DataGridViewCheckBoxCell cell = dgvCustomers.Rows[e.RowIndex].Cells["Select"] as DataGridViewCheckBoxCell;
                    if (cell != null)
                    {
                        cell.Value = cell.Value == null || !(bool)cell.Value;
                        dgvCustomers.EndEdit();

                        // Kiểm tra xem có checkbox nào được chọn không
                        bool hasChecked = false;
                        foreach (DataGridViewRow row in dgvCustomers.Rows)
                        {
                            if (row.Cells["Select"].Value != null && (bool)row.Cells["Select"].Value)
                            {
                                hasChecked = true;
                                break;
                            }
                        }
                        btDelete.Visible = hasChecked;
                    }
                }
            }
        }

        private void DgvCustomers_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvCustomers.IsCurrentCellDirty && dgvCustomers.CurrentCell is DataGridViewCheckBoxCell)
            {
                dgvCustomers.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

     
        private void cboCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchName = txtSearchCustomer.Text.Trim();
            string selectedType = cboCustomerType.SelectedItem?.ToString();
            var customers = customerBusiness.GetAllCustomers();

            // Nếu có nhập tên tìm kiếm, lọc theo tên trước
            if (!string.IsNullOrEmpty(searchName))
            {
                customers = customers.Where(c => c.Name.IndexOf(searchName, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }

            // Sau đó lọc theo loại khách hàng nếu không phải "Tất cả"
            if (selectedType != "Tất cả" && !string.IsNullOrEmpty(selectedType))
            {
                customers = customers.Where(c => c.Type == selectedType).ToList();
            }

            dgvCustomers.DataSource = customers;
            UpdateCustomerCounts(customers);
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // Thêm checkbox vào header
            DataGridViewCheckBoxCell headerCell = new DataGridViewCheckBoxCell();
            dgvCustomers.Rows[0].Cells[0] = headerCell;
        }



        private void btDelete_Click(object sender, EventArgs e)
        {
            var selectedRows = dgvCustomers.Rows
                .Cast<DataGridViewRow>()
                .Where(row => Convert.ToBoolean(row.Cells[0].Value) == true)
                .ToList();

            if (selectedRows.Count > 0)
            {
                var result = MessageBox.Show($"Bạn có muốn xóa {selectedRows.Count} khách hàng đã chọn không?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool hasError = false;
                    foreach (var row in selectedRows)
                    {
                        var customer = row.DataBoundItem as CustomerDTO;
                        if (customer != null)
                        {
                            if (!customerBusiness.DeleteCustomer(customer.CId))
                            {
                                hasError = true;
                            }
                        }
                    }

                    if (hasError)
                    {
                        MessageBox.Show("Có lỗi xảy ra trong quá trình xóa một số khách hàng!",
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Xóa khách hàng thành công!", "Thành Công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    LoadCustomers(); // Refresh data after deleting
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btAddCustomer_Click(object sender, EventArgs e)
        {
            AddCus addCus = new AddCus();
            addCus.ShowDialog();
            LoadCustomers(); // Refresh data after adding
        }

        private void txtSearchCustomer_IconRightClick(object sender, EventArgs e)
        {
            string searchName = txtSearchCustomer.Text.Trim();
            string selectedType = cboCustomerType.SelectedItem?.ToString();
            var customers = customerBusiness.GetAllCustomers();

            // Nếu combobox là "Tất cả" thì chỉ tìm theo tên
            if (selectedType == "Tất cả" || string.IsNullOrEmpty(selectedType))
            {
                if (!string.IsNullOrEmpty(searchName))
                {
                    customers = customers.Where(c => c.Name.IndexOf(searchName, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
                }
            }
            // Nếu có chọn loại khách hàng cụ thể thì tìm theo cả tên và loại
            else
            {
                customers = customers.Where(c => c.Type == selectedType).ToList();
                if (!string.IsNullOrEmpty(searchName))
                {
                    customers = customers.Where(c => c.Name.IndexOf(searchName, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
                }
            }

            // Hiển thị kết quả
            dgvCustomers.DataSource = customers;
            UpdateCustomerCounts(customers);
        }

        private void pnlCustomerVIP_Click(object sender, EventArgs e)
        {
            // Lọc và hiển thị khách hàng VIP
            var customers = customerBusiness.GetAllCustomers();
            var vipCustomers = customers.Where(c => c.Type == "VIP").ToList();
            dgvCustomers.DataSource = vipCustomers;
            
            // Cập nhật combobox
            cboCustomerType.SelectedItem = "VIP";
        }

        private void pnlNewCustomer_Click(object sender, EventArgs e)
        {
            // Lọc và hiển thị khách hàng mới
            var customers = customerBusiness.GetAllCustomers();
            var newCustomers = customers.Where(c => c.Type == "New").ToList();
            dgvCustomers.DataSource = newCustomers;
            
            // Cập nhật combobox
            cboCustomerType.SelectedItem = "New";
        }

        private void pnlRevenue_Click(object sender, EventArgs e)
        {
            // Lọc và hiển thị khách hàng thường
            var customers = customerBusiness.GetAllCustomers();
            var regularCustomers = customers.Where(c => c.Type == "Regular").ToList();
            dgvCustomers.DataSource = regularCustomers;
            
            // Cập nhật combobox
            cboCustomerType.SelectedItem = "Regular";
        }

        private void pnlTotalCustomer_Click(object sender, EventArgs e)
        {
            cboCustomerType.SelectedItem = "Tất cả"; // Reset về "Tất cả"
            LoadCustomers(); // Load lại tất cả khách hàng
        }
    }

    // Thêm class DataGridViewCheckBoxHeaderCell
    public class DataGridViewCheckBoxHeaderCell : DataGridViewColumnHeaderCell
    {
        private bool isChecked = false;
        private bool isCheckBoxVisible = true;

        public DataGridViewCheckBoxHeaderCell()
        {
        }

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, 
            int rowIndex, DataGridViewElementStates dataGridViewElementState, object value, 
            object formattedValue, string errorText, DataGridViewCellStyle cellStyle, 
            DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, dataGridViewElementState, value, 
                formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);

            if (isCheckBoxVisible)
            {
                int checkBoxSize = 15;
                Point checkBoxLocation = new Point(
                    cellBounds.Location.X + (cellBounds.Width - checkBoxSize) / 2,
                    cellBounds.Location.Y + (cellBounds.Height - checkBoxSize) / 2);
                Rectangle checkBoxRect = new Rectangle(checkBoxLocation, new Size(checkBoxSize, checkBoxSize));
                
                ControlPaint.DrawCheckBox(graphics, checkBoxRect, 
                    isChecked ? ButtonState.Checked : ButtonState.Normal);
            }
        }
    }
}
