using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.User_Controls
{
    public partial class itemAttribute : UserControl
    {
        public string nameCol { get; set; }

        public event Action<Dictionary<string, object>> ACTION;

        public itemAttribute()
        {
            InitializeComponent();
        }

        public itemAttribute(string lbCheckbox, bool isCheck) : this()
        {
            checkbox.Text = lbCheckbox;
            checkbox.Checked = true;
        }

        public itemAttribute(string lbCheckbox) : this()
        {
            checkbox.Text = lbCheckbox;
            checkbox.Checked = false;
        }

        public string getAttribute()
        {
            return checkbox.Text;
        }

        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            var data = new Dictionary<string, object>();
            data.Add("key", checkbox.Text);
            data.Add("value", checkbox.Checked);
            ACTION?.Invoke(data);
        }
    }
}
