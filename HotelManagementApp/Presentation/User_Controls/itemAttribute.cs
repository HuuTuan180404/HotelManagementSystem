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
    public partial class itemAttribute : UserControl
    {
        public string col { get; set; }

        public itemAttribute()
        {
            InitializeComponent();
        }

        public itemAttribute(string lbCheckbox) : this()
        {
            checkbox.Text = lbCheckbox;
            checkbox.Checked = false;
        }

        public itemAttribute(string lbCheckbox, bool isCheck) : this()
        {
            checkbox.Text = lbCheckbox;
            checkbox.Checked = true;
        }

        public string getAttribute()
        {
            return checkbox.Text;
        }
    }
}
