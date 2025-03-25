using Presentation.User_Controls;
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
    public partial class Form1 : Form
    {
        SelectAttribute SelectAttribute = null;
        int count = 8;
        public Form1()
        {
            InitializeComponent();
            SelectAttribute = new SelectAttribute(8);
            this.Controls.Add(SelectAttribute);
            SelectAttribute.Location = new Point(10, 10);
        }

        private void selectAttribute1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SelectAttribute.addAttribute(new itemAttribute("attribute " + (++count), true));
        }
    }
}
