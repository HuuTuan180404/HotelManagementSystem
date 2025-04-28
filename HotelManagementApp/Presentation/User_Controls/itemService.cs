using DataTransferObject;
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
    public partial class itemService : UserControl
    {
        private itemService()
        {
            InitializeComponent();
        }

        public itemService(ServiceDTO serviceDTO) : this()
        {
            SName.Text = serviceDTO.SName;
            SPrice.Text = serviceDTO.SPrice.ToString();
            SDescription.Text = serviceDTO.SDescription;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtQuantity.Text);
                num--;
                if (num != 0) { txtQuantity.Text = num.ToString(); }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Muốn xóa", "Xác nhận",
                        MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {
                        this.Parent.Controls.Remove(this);
                        this.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtQuantity.Text);
                num++;
                txtQuantity.Text = num.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuantity.Text) || int.Parse(txtQuantity.Text) < 1)
            {
                txtQuantity.Text = "1";
            }
        }
    }
}
