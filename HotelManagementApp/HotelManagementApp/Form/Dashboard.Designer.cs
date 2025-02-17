namespace HotelManagementApp
{
    partial class Dashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pnUnderline = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.btnRoom = new Guna.UI2.WinForms.Guna2Button();
            this.pic_minus = new System.Windows.Forms.PictureBox();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.pnUnderline);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnCustomers);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnRoom);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(291, 615);
            this.guna2CustomGradientPanel1.TabIndex = 17;
            // 
            // pnUnderline
            // 
            this.pnUnderline.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnUnderline.BorderRadius = 20;
            this.pnUnderline.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnUnderline.Location = new System.Drawing.Point(36, 127);
            this.pnUnderline.Name = "pnUnderline";
            this.pnUnderline.Size = new System.Drawing.Size(180, 10);
            this.pnUnderline.TabIndex = 18;
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomers.BorderRadius = 20;
            this.btnCustomers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomers.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnCustomers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Location = new System.Drawing.Point(89, 192);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(180, 45);
            this.btnCustomers.TabIndex = 16;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseTransparentBackground = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnRoom.BorderRadius = 20;
            this.btnRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRoom.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnRoom.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRoom.ForeColor = System.Drawing.Color.White;
            this.btnRoom.Image = global::HotelManagementApp.Properties.Resources.extra_bed;
            this.btnRoom.ImageSize = new System.Drawing.Size(40, 40);
            this.btnRoom.Location = new System.Drawing.Point(36, 76);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(180, 45);
            this.btnRoom.TabIndex = 15;
            this.btnRoom.Text = "Room";
            this.btnRoom.UseTransparentBackground = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // pic_minus
            // 
            this.pic_minus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_minus.Image = ((System.Drawing.Image)(resources.GetObject("pic_minus.Image")));
            this.pic_minus.Location = new System.Drawing.Point(788, 12);
            this.pic_minus.Name = "pic_minus";
            this.pic_minus.Size = new System.Drawing.Size(50, 50);
            this.pic_minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_minus.TabIndex = 12;
            this.pic_minus.TabStop = false;
            this.pic_minus.Click += new System.EventHandler(this.pic_minus_Click);
            // 
            // pic_close
            // 
            this.pic_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_close.Image = ((System.Drawing.Image)(resources.GetObject("pic_close.Image")));
            this.pic_close.Location = new System.Drawing.Point(844, 12);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(50, 50);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_close.TabIndex = 11;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.pnUnderline;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 615);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.pic_minus);
            this.Controls.Add(this.pic_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_minus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_minus;
        private System.Windows.Forms.PictureBox pic_close;
        private Guna.UI2.WinForms.Guna2Button btnRoom;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btnCustomers;
        private Guna.UI2.WinForms.Guna2Panel pnUnderline;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}