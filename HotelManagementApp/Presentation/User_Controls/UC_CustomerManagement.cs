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
    public partial class UC_CustomerManagement : UserControl
    {
        public UC_CustomerManagement()
        {
            InitializeComponent();
        }

        

        private void txtSearchCustom_Enter(object sender, EventArgs e)
        {
            if (txtSearchCustom.Text == "Tìm kiếm...")
            {
                txtSearchCustom.Text = "";
                txtSearchCustom.ForeColor = Color.Black;
            }
        }

        private void txtSearchCustom_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchCustom.Text))
            {
                txtSearchCustom.Text = "Tìm kiếm...";
                txtSearchCustom.ForeColor = Color.Gray;
            }
        }
    }
}
