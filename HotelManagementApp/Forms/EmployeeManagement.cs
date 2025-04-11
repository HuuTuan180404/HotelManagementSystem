using System;
using System.Windows.Forms;

namespace HotelManagementApp.Forms
{
    public partial class EmployeeManagement : Form
    {
        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBox();
            dgvEmployee.CellDoubleClick += DgvEmployee_CellDoubleClick;
            dgvEmployee.CellClick += DgvEmployee_CellClick;
            // Initially disable delete button
            btnDelete.Enabled = false;
            // Clear any initial selection
            dgvEmployee.ClearSelection();
        }

        private void DgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Enable delete button only when a cell is selected and it's not a header cell
            btnDelete.Enabled = e.RowIndex >= 0;
        }

        private void DgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployee.Rows[e.RowIndex];
                string EId = row.Cells["EId"].Value.ToString();
                EmployeeDTO employee = employeeData.GetEmployee(EId);
                if (employee != null)
                {
                    EmployeeDetail employeeDetail = new EmployeeDetail(employee);
                    employeeDetail.ShowDialog();
                    LoadData();
                }
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentCell != null && dgvEmployee.CurrentCell.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployee.Rows[dgvEmployee.CurrentCell.RowIndex];
                string EId = row.Cells["EId"].Value.ToString();
                EmployeeDTO employee = employeeData.GetEmployee(EId);
                if (employee != null)
                {
                    DialogResult result = MessageBox.Show(
                        "Bạn có chắc chắn muốn xóa nhân viên này?",
                        "Xác nhận xóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (employeeData.DeleteEmployee(EId))
                        {
                            MessageBox.Show("Xóa nhân viên thành công!");
                            LoadData();
                            // Clear selection after deletion
                            dgvEmployee.ClearSelection();
                            btnDelete.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Xóa nhân viên thất bại!");
                        }
                    }
                }
            }
        }
    }
} 