namespace Presentation.Forms
{
    partial class QR
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtQRResult = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnSelectImage = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.pictureBoxWebcam = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnStart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebcam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtQRResult
            // 
            this.txtQRResult.Location = new System.Drawing.Point(124, 296);
            this.txtQRResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQRResult.Multiline = true;
            this.txtQRResult.Name = "txtQRResult";
            this.txtQRResult.ReadOnly = true;
            this.txtQRResult.Size = new System.Drawing.Size(332, 68);
            this.txtQRResult.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::Presentation.Properties.Resources._3094700;
            this.btnExit.Location = new System.Drawing.Point(672, 382);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 50);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 11;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Image = global::Presentation.Properties.Resources._360_F_525379615_AQlcYaHQqJJAYRoBkjDKGO31G1bp9CYw;
            this.btnSelectImage.Location = new System.Drawing.Point(10, 144);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(100, 50);
            this.btnSelectImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSelectImage.TabIndex = 10;
            this.btnSelectImage.TabStop = false;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // btnStop
            // 
            this.btnStop.Image = global::Presentation.Properties.Resources.images;
            this.btnStop.Location = new System.Drawing.Point(10, 75);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 50);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnStop.TabIndex = 8;
            this.btnStop.TabStop = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pictureBoxWebcam
            // 
            this.pictureBoxWebcam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxWebcam.ImageRotate = 0F;
            this.pictureBoxWebcam.Location = new System.Drawing.Point(124, 11);
            this.pictureBoxWebcam.Name = "pictureBoxWebcam";
            this.pictureBoxWebcam.Size = new System.Drawing.Size(333, 262);
            this.pictureBoxWebcam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWebcam.TabIndex = 7;
            this.pictureBoxWebcam.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Image = global::Presentation.Properties.Resources.qr_scan_icon_2048x2048_aeh36n7y;
            this.btnStart.Location = new System.Drawing.Point(10, 11);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 50);
            this.btnStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnStart.TabIndex = 6;
            this.btnStart.TabStop = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // QR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 443);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.txtQRResult);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.pictureBoxWebcam);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QR_FormClosing);
            this.Load += new System.EventHandler(this.QR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebcam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnStart;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxWebcam;
        private System.Windows.Forms.PictureBox btnStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtQRResult;
        private System.Windows.Forms.PictureBox btnSelectImage;
        private System.Windows.Forms.PictureBox btnExit;
    }
}