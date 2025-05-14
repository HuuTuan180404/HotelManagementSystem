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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.txtQRResult = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.btnSelectImage = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.cameraPanel = new System.Windows.Forms.Panel();
            this.scanFrame = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxWebcam = new Guna.UI2.WinForms.Guna2PictureBox();
            this.mainPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.resultPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            this.cameraPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebcam)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.controlPanel);
            this.mainPanel.Controls.Add(this.cameraPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(10);
            this.mainPanel.Size = new System.Drawing.Size(1000, 600);
            this.mainPanel.TabIndex = 0;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.controlPanel.Controls.Add(this.resultPanel);
            this.controlPanel.Controls.Add(this.buttonPanel);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(710, 10);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(280, 580);
            this.controlPanel.TabIndex = 1;
            // 
            // resultPanel
            // 
            this.resultPanel.Controls.Add(this.btnExit);
            this.resultPanel.Controls.Add(this.txtQRResult);
            this.resultPanel.Controls.Add(this.resultLabel);
            this.resultPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultPanel.Location = new System.Drawing.Point(0, 200);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(280, 380);
            this.resultPanel.TabIndex = 31;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.Image = global::Presentation.Properties.Resources._3094700;
            this.btnExit.Location = new System.Drawing.Point(0, 345);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(280, 35);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 28;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtQRResult
            // 
            this.txtQRResult.BackColor = System.Drawing.Color.White;
            this.txtQRResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQRResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQRResult.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQRResult.ForeColor = System.Drawing.Color.Black;
            this.txtQRResult.Location = new System.Drawing.Point(0, 28);
            this.txtQRResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQRResult.Multiline = true;
            this.txtQRResult.Name = "txtQRResult";
            this.txtQRResult.ReadOnly = true;
            this.txtQRResult.Size = new System.Drawing.Size(280, 352);
            this.txtQRResult.TabIndex = 26;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.resultLabel.Location = new System.Drawing.Point(0, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(124, 28);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Text = "Kết quả quét";
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.btnSelectImage);
            this.buttonPanel.Controls.Add(this.btnStart);
            this.buttonPanel.Controls.Add(this.btnStop);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Padding = new System.Windows.Forms.Padding(10);
            this.buttonPanel.Size = new System.Drawing.Size(280, 200);
            this.buttonPanel.TabIndex = 30;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnSelectImage.Image = global::Presentation.Properties.Resources._360_F_525379615_AQlcYaHQqJJAYRoBkjDKGO31G1bp9CYw;
            this.btnSelectImage.Location = new System.Drawing.Point(40, 120);
            this.btnSelectImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(200, 45);
            this.btnSelectImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSelectImage.TabIndex = 33;
            this.btnSelectImage.TabStop = false;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click_1);
            // 
            // btnStart
            // 
            this.btnStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnStart.Image = global::Presentation.Properties.Resources.qr_scan_icon_2048x2048_aeh36n7y;
            this.btnStart.Location = new System.Drawing.Point(40, 10);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 45);
            this.btnStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnStart.TabIndex = 31;
            this.btnStart.TabStop = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // btnStop
            // 
            this.btnStop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnStop.Image = global::Presentation.Properties.Resources.images;
            this.btnStop.Location = new System.Drawing.Point(40, 65);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(200, 45);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnStop.TabIndex = 32;
            this.btnStop.TabStop = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click_1);
            // 
            // cameraPanel
            // 
            this.cameraPanel.Controls.Add(this.scanFrame);
            this.cameraPanel.Controls.Add(this.label1);
            this.cameraPanel.Controls.Add(this.pictureBoxWebcam);
            this.cameraPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.cameraPanel.Location = new System.Drawing.Point(10, 10);
            this.cameraPanel.Name = "cameraPanel";
            this.cameraPanel.Size = new System.Drawing.Size(700, 580);
            this.cameraPanel.TabIndex = 0;
            // 
            // scanFrame
            // 
            this.scanFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))), ((int)(((byte)(30)))));
            this.scanFrame.Location = new System.Drawing.Point(0, 3);
            this.scanFrame.Name = "scanFrame";
            this.scanFrame.Size = new System.Drawing.Size(700, 2);
            this.scanFrame.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 552);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Đặt mã QR vào khung hình";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxWebcam
            // 
            this.pictureBoxWebcam.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWebcam.BorderRadius = 10;
            this.pictureBoxWebcam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxWebcam.ImageRotate = 0F;
            this.pictureBoxWebcam.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxWebcam.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxWebcam.Name = "pictureBoxWebcam";
            this.pictureBoxWebcam.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.pictureBoxWebcam.ShadowDecoration.Depth = 5;
            this.pictureBoxWebcam.ShadowDecoration.Enabled = true;
            this.pictureBoxWebcam.Size = new System.Drawing.Size(700, 580);
            this.pictureBoxWebcam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWebcam.TabIndex = 14;
            this.pictureBoxWebcam.TabStop = false;
            // 
            // QR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QR_FormClosing);
            this.Load += new System.EventHandler(this.QR_Load);
            this.mainPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.resultPanel.ResumeLayout(false);
            this.resultPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            this.cameraPanel.ResumeLayout(false);
            this.cameraPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebcam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel cameraPanel;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxWebcam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel scanFrame;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.PictureBox btnSelectImage;
        private System.Windows.Forms.PictureBox btnStop;
        private System.Windows.Forms.PictureBox btnStart;
        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox txtQRResult;
        private System.Windows.Forms.PictureBox btnExit;
    }
}