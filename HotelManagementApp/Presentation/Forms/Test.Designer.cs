namespace Presentation.Forms
{
    partial class Test
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
            this.picturebox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.show = new System.Windows.Forms.TextBox();
            this.btnStop = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // picturebox
            // 
            this.picturebox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picturebox.ImageRotate = 0F;
            this.picturebox.Location = new System.Drawing.Point(349, 26);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(386, 397);
            this.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox.TabIndex = 0;
            this.picturebox.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(94, 163);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(180, 45);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(32, 370);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(266, 20);
            this.show.TabIndex = 2;
            // 
            // btnStop
            // 
            this.btnStop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(108, 240);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(180, 45);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 447);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.show);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picturebox);
            this.Name = "Test";
            this.Text = "BookingManagement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookingManagement_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picturebox;
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private System.Windows.Forms.TextBox show;
        private Guna.UI2.WinForms.Guna2Button btnStop;
    }
}