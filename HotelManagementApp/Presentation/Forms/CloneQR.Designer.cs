namespace Presentation.Forms
{
    partial class CloneQR
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
            this.btnSelectImage = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.txtQRResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Image = global::Presentation.Properties.Resources._360_F_525379615_AQlcYaHQqJJAYRoBkjDKGO31G1bp9CYw;
            this.btnSelectImage.Location = new System.Drawing.Point(64, 256);
            this.btnSelectImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(133, 62);
            this.btnSelectImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSelectImage.TabIndex = 26;
            this.btnSelectImage.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Image = global::Presentation.Properties.Resources.qr_scan_icon_2048x2048_aeh36n7y;
            this.btnStart.Location = new System.Drawing.Point(64, 93);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(133, 62);
            this.btnStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnStart.TabIndex = 23;
            this.btnStart.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.Image = global::Presentation.Properties.Resources.images;
            this.btnStop.Location = new System.Drawing.Point(64, 171);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(133, 62);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnStop.TabIndex = 24;
            this.btnStop.TabStop = false;
            // 
            // txtQRResult
            // 
            this.txtQRResult.Location = new System.Drawing.Point(216, 476);
            this.txtQRResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQRResult.Multiline = true;
            this.txtQRResult.Name = "txtQRResult";
            this.txtQRResult.ReadOnly = true;
            this.txtQRResult.Size = new System.Drawing.Size(472, 83);
            this.txtQRResult.TabIndex = 25;
            // 
            // CloneQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 705);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtQRResult);
            this.Controls.Add(this.btnStop);
            this.Name = "CloneQR";
            this.Text = "CloneQR";
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnSelectImage;
        private System.Windows.Forms.PictureBox btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox btnStop;
        private System.Windows.Forms.TextBox txtQRResult;
    }
}