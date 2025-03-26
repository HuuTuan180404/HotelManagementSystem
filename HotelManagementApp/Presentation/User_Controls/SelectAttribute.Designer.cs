namespace Presentation.User_Controls
{
    partial class SelectAttribute
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.AutoSize = true;
            this.tableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayout.BackColor = System.Drawing.Color.White;
            this.tableLayout.ColumnCount = 2;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(6, 6);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 2;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout.Size = new System.Drawing.Size(230, 78);
            this.tableLayout.TabIndex = 0;
            // 
            // SelectAttribute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayout);
            this.Name = "SelectAttribute";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(242, 90);
            this.Load += new System.EventHandler(this.SelectAttribute_Load);
            this.MouseEnter += new System.EventHandler(this.SelectAttribute_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.SelectAttribute_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
    }
}
