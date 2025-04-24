namespace Presentation.User_Controls
{
    partial class itemRoom2
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
            this.lbRoom = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbType = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gunaToolTip_Room = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.menuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRoom
            // 
            this.lbRoom.AutoSize = false;
            this.lbRoom.BackColor = System.Drawing.Color.Transparent;
            this.lbRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoom.Location = new System.Drawing.Point(0, 0);
            this.lbRoom.Margin = new System.Windows.Forms.Padding(0);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(174, 60);
            this.lbRoom.TabIndex = 0;
            this.lbRoom.Text = "Roo2-1";
            this.lbRoom.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbType
            // 
            this.lbType.BackColor = System.Drawing.Color.Transparent;
            this.lbType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.Location = new System.Drawing.Point(0, 65);
            this.lbType.Margin = new System.Windows.Forms.Padding(0);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(174, 33);
            this.lbType.TabIndex = 3;
            this.lbType.Text = "Type: Family";
            this.lbType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbStatus
            // 
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(0, 100);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(174, 33);
            this.lbStatus.TabIndex = 4;
            this.lbStatus.Text = "Status: ";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.Image = global::Presentation.Properties.Resources.door_handle;
            this.btnMenu.Location = new System.Drawing.Point(144, 15);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(30, 30);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 5;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
            this.guna2Elipse1.TargetControl = this;
            // 
            // gunaToolTip_Room
            // 
            this.gunaToolTip_Room.AllowLinksHandling = true;
            this.gunaToolTip_Room.MaximumSize = new System.Drawing.Size(0, 0);
            this.gunaToolTip_Room.ToolTipTitle = "Chi tiết";
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this.btnMenu;
            // 
            // menuStrip
            // 
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // itemRoom2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbRoom);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Name = "itemRoom2";
            this.Size = new System.Drawing.Size(174, 152);
            this.MouseHover += new System.EventHandler(this.itemRoom2_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lbRoom;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.PictureBox btnMenu;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2HtmlToolTip gunaToolTip_Room;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.ContextMenuStrip menuStrip;
    }
}
