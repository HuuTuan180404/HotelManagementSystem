using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class Bank : Form
    {
        BankingB bankingB;
        private Bank()
        {
            InitializeComponent();
            bankingB = new BankingB();
        }

        public Bank(int amout, string noiDung = null) : this()
        {
            picQR.Image = bankingB.GetImageQR(amout, noiDung);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
