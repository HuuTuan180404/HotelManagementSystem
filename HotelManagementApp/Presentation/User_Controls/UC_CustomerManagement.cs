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
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            var customers = customerBusiness.GetAllCustomers();
            dgvCustomers.DataSource = customers;
            UpdateCustomerCounts(customers);
        }

        private void UpdateCustomerCounts(List<CustomerDTO> customers)
        {
            lbTotalCustomer.Text = customers.Count.ToString();
            lbNewCustomer.Text = customers.Count(c => c.Type == "New").ToString();
            lbCustomerVIP.Text = customers.Count(c => c.Type == "VIP").ToString();
            lbRegular.Text = customers.Count(c=> c.Type =="Regular").ToString();
        }

        private void btAddCustomer_Click_1(object sender, EventArgs e)
        {
            AddCus addCus = new AddCus();
            addCus.ShowDialog();
            LoadCustomers(); // Refresh data after adding
        }

            

        
        private void btEdit_Click_1(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                var selectedCustomer = dgvCustomers.SelectedRows[0].DataBoundItem as CustomerDTO;
                if (selectedCustomer != null)
                {
                    AddCus editForm = new AddCus();
                    editForm.SetCustomerData(selectedCustomer);
                    editForm.ShowDialog();
                    LoadCustomers(); // Refresh data after editing
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 khách hàng để chỉnh sửa", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                var selectedCustomer = dgvCustomers.SelectedRows[0].DataBoundItem as CustomerDTO;
                if (selectedCustomer != null)
                {
                    var result = MessageBox.Show("Bạn có muốn xóa khách hàng này không?", "Xác nhận xóa",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (customerBusiness.DeleteCustomer(selectedCustomer.CId))
                        {
                            MessageBox.Show("Xóa khách hàng thành công", "Thành Công",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadCustomers(); // Refresh data after deleting
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa khách hàng!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn 1 khách hàng để xóa!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string searchText = txtSearchCustomer.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                var searchResults = customerBusiness.SearchCustomers(searchText);
                dgvCustomers.DataSource = searchResults;
                UpdateCustomerCounts(searchResults);
            }
            else
            {
                LoadCustomers();
            }
        }

        private void cboCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCustomerType.SelectedIndex > 0)
            {
                string selectedType = cboCustomerType.SelectedItem.ToString();
                var filteredCustomers = customerBusiness.GetAllCustomers()
                    .Where(c => c.Type == selectedType).ToList();
                dgvCustomers.DataSource = filteredCustomers;
                UpdateCustomerCounts(filteredCustomers);
            }
            else
            {
                LoadCustomers();
            }
        }

        private void cboRoomStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
