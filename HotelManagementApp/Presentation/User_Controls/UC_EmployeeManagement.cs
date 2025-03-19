using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.User_Controls
{
    public partial class UC_EmployeeManagement : UserControl
    {
        public UC_EmployeeManagement()
        {
            InitializeComponent();
        }

        private void txtSearchEmployee_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchEmployee.Text))
            {
                txtSearchEmployee.Text = "Tìm kiếm...";
                txtSearchEmployee.ForeColor = Color.Gray;
            }
        }

        private void txtSearchEmployee_Enter(object sender, EventArgs e)
        {
            if (txtSearchEmployee.Text == "Tìm kiếm...")
            {
                txtSearchEmployee.Text = "";
                txtSearchEmployee.ForeColor = Color.Black;
            }
        }
    }
}
