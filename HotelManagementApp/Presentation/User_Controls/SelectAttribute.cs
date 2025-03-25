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
        int H = 35;
        int ROW = 1;
        int COUNT_ATTRIBUTE = 2;
        private SelectAttribute()
        {
            InitializeComponent();
            demo();
        }

        public SelectAttribute(int countAttribute) : this()
        {
            this.COUNT_ATTRIBUTE = countAttribute;
            this.ROW = (countAttribute + 1) / 2;
        }

        private void SelectAttribute_Load(object sender, EventArgs e)
        {
            this.Height = H * ROW;
            Debug.WriteLine(ROW + " " + tableLayout.RowCount);
            Debug.WriteLine(this.Height + " " + COUNT_ATTRIBUTE);
            demo();
        }

        private void demo()
        {
            tableLayout.RowCount = ROW;
            float equalHeight = 100f / ROW;
            Debug.WriteLine(tableLayout.RowCount);
            Debug.WriteLine("ROW= " + ROW);
            tableLayout.RowStyles.Clear();
            for (int i = 0; i < ROW; i++)
            {
                Debug.WriteLine(i);
                tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, equalHeight));
            }

            for (int i = 0; i < COUNT_ATTRIBUTE; i++)
            {
                addAttribute(new itemAttribute(i.ToString()));
            }
        }

        public void addAttribute(itemAttribute itemAttribute)
        {
            tableLayout.Controls.Add(itemAttribute);
            itemAttribute.Dock = DockStyle.Fill;
        }
    }
}
