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
            this.components = new System.ComponentModel.Container();
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lbFloor = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayout
            // 
            this.flowLayout.AutoScroll = true;
            this.flowLayout.Location = new System.Drawing.Point(122, 0);
            this.flowLayout.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Padding = new System.Windows.Forms.Padding(2);
            this.flowLayout.Size = new System.Drawing.Size(1096, 155);
            this.flowLayout.TabIndex = 2;
            this.flowLayout.WrapContents = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Presentation.Properties.Resources.floor;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(22, 33);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(75, 89);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lbFloor
            // 
            this.lbFloor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFloor.AutoSize = true;
            this.lbFloor.BackColor = System.Drawing.Color.Transparent;
            this.lbFloor.Depth = 0;
            this.lbFloor.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbFloor.Location = new System.Drawing.Point(54, 68);
            this.lbFloor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbFloor.Name = "lbFloor";
            this.lbFloor.Size = new System.Drawing.Size(10, 19);
            this.lbFloor.TabIndex = 3;
            this.lbFloor.Text = "2";
            // 
            // itemFloor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbFloor);
            this.Controls.Add(this.flowLayout);
            this.Controls.Add(this.guna2PictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "itemFloor";
            this.Size = new System.Drawing.Size(1218, 155);
            this.Load += new System.EventHandler(this.itemFloor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayout;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private MaterialSkin.Controls.MaterialLabel lbFloor;
    }
}
