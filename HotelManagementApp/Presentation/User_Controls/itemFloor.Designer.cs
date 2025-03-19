namespace Presentation.User_Controls
{
    partial class itemFloor
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
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.Image = global::Presentation.Properties.Resources.floor;
			this.guna2PictureBox1.ImageRotate = 0F;
			this.guna2PictureBox1.Location = new System.Drawing.Point(31, 32);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.Size = new System.Drawing.Size(50, 55);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2PictureBox1.TabIndex = 0;
			this.guna2PictureBox1.TabStop = false;
			this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
			// 
			// guna2HtmlLabel1
			// 
			this.guna2HtmlLabel1.AutoSize = false;
			this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2HtmlLabel1.Location = new System.Drawing.Point(0, 0);
			this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(0);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new System.Drawing.Size(112, 31);
			this.guna2HtmlLabel1.TabIndex = 1;
			this.guna2HtmlLabel1.Text = "Fl-1";
			this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// itemFloor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.guna2HtmlLabel1);
			this.Controls.Add(this.guna2PictureBox1);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "itemFloor";
			this.Size = new System.Drawing.Size(112, 87);
			this.Load += new System.EventHandler(this.itemFloor_Load);
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
