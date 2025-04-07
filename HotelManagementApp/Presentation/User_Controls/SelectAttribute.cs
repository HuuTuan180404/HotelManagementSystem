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
    public partial class SelectAttribute : UserControl
    {
        int H = 55;
        int ROW = 1;
        int COUNT_ATTRIBUTE = 2;
        List<string> attributes;

        public event Action<Dictionary<string, object>> ACTION;

        public List<string> attributesChecked;

        private SelectAttribute()
        {
            InitializeComponent();
        }

        public SelectAttribute(List<string> list) : this()
        {
            this.attributesChecked = list;
            this.attributes = list;
            this.COUNT_ATTRIBUTE = list.Count;
            this.ROW = (COUNT_ATTRIBUTE + 1) / 2;
        }

        private void SelectAttribute_Load(object sender, EventArgs e)
        {
            this.Height = H * ROW;
            LoadProperties();
        }

        private void LoadProperties()
        {
            tableLayout.RowCount = ROW;
            float equalHeight = 100f / ROW;
            tableLayout.RowStyles.Clear();
            for (int i = 0; i < ROW; i++)
            {
                tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, equalHeight));
            }

            foreach (var i in attributes)
            {
                itemAttribute itemAttribute = new itemAttribute(i, true);
                itemAttribute.nameCol = i;
                addAttribute(itemAttribute);
            }
        }

        public void addAttribute(itemAttribute itemAttribute)
        {
            itemAttribute.ACTION += (Dictionary<string, object> data) =>
            {
                ACTION?.Invoke(data);
                this.Visible = false;
            };
            tableLayout.Controls.Add(itemAttribute);
            itemAttribute.Dock = DockStyle.Fill;
        }

        private void SelectAttribute_MouseEnter(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void SelectAttribute_MouseLeave(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
