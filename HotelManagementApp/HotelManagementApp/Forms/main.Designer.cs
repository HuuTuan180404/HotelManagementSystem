namespace HotelManagementApp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelFunction = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.panelLogout = new Guna.UI2.WinForms.Guna2Panel();
            this.lbLogout = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picLogout = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnStaff = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnBooking = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbTime = new MaterialSkin.Controls.MaterialLabel();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.pic_minus = new System.Windows.Forms.PictureBox();
            this.panelRoomManagement = new Guna.UI2.WinForms.Guna2Panel();
            this.ucRoomManagement = new HotelManagementApp.User_Controls.UC_RoomManagement();
            this.panelFunction.SuspendLayout();
            this.panelLogout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minus)).BeginInit();
            this.panelRoomManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFunction
            // 
            this.panelFunction.Controls.Add(this.panelLogout);
            this.panelFunction.Controls.Add(this.guna2Panel2);
            this.panelFunction.Controls.Add(this.btnStaff);
            this.panelFunction.Controls.Add(this.guna2Button1);
            this.panelFunction.Controls.Add(this.btnBooking);
            this.panelFunction.Controls.Add(this.btnEmployee);
            this.panelFunction.Controls.Add(this.btnRoom);
            this.panelFunction.Controls.Add(this.btnCustomer);
            this.panelFunction.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFunction.Location = new System.Drawing.Point(0, 0);
            this.panelFunction.Name = "panelFunction";
            this.panelFunction.Size = new System.Drawing.Size(241, 817);
            this.panelFunction.TabIndex = 17;
            // 
            // panelLogout
            // 
            this.panelLogout.Controls.Add(this.lbLogout);
            this.panelLogout.Controls.Add(this.picLogout);
            this.panelLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLogout.Location = new System.Drawing.Point(0, 754);
            this.panelLogout.Name = "panelLogout";
            this.panelLogout.Size = new System.Drawing.Size(241, 63);
            this.panelLogout.TabIndex = 24;
            this.panelLogout.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelLogout_MouseClick);
            // 
            // lbLogout
            // 
            this.lbLogout.BackColor = System.Drawing.Color.Transparent;
            this.lbLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.lbLogout.Location = new System.Drawing.Point(103, 15);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(82, 30);
            this.lbLogout.TabIndex = 1;
            this.lbLogout.Text = "LOGOUT";
            this.lbLogout.Click += new System.EventHandler(this.lbLogout_Click);
            // 
            // picLogout
            // 
            this.picLogout.Image = global::HotelManagementApp.Properties.Resources.logout;
            this.picLogout.ImageRotate = 0F;
            this.picLogout.Location = new System.Drawing.Point(45, 13);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(33, 34);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogout.TabIndex = 0;
            this.picLogout.TabStop = false;
            this.picLogout.Click += new System.EventHandler(this.picLogout_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 138);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(241, 5);
            this.guna2Panel2.TabIndex = 19;
            // 
            // btnStaff
            // 
            this.btnStaff.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnStaff.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnStaff.Image = global::HotelManagementApp.Properties.Resources.male;
            this.btnStaff.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnStaff.ImageRotate = 0F;
            this.btnStaff.Location = new System.Drawing.Point(70, 32);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnStaff.Size = new System.Drawing.Size(100, 100);
            this.btnStaff.TabIndex = 23;
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.guna2Button1.CheckedState.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.guna2Button1.Location = new System.Drawing.Point(36, 457);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 22;
            this.guna2Button1.Text = "Services";
            this.guna2Button1.UseTransparentBackground = true;
            // 
            // btnBooking
            // 
            this.btnBooking.AutoRoundedCorners = true;
            this.btnBooking.BackColor = System.Drawing.Color.Transparent;
            this.btnBooking.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnBooking.BorderRadius = 21;
            this.btnBooking.BorderThickness = 1;
            this.btnBooking.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBooking.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnBooking.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnBooking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBooking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBooking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBooking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBooking.FillColor = System.Drawing.Color.Transparent;
            this.btnBooking.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnBooking.Location = new System.Drawing.Point(36, 244);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(180, 45);
            this.btnBooking.TabIndex = 21;
            this.btnBooking.Text = "Bookings";
            this.btnBooking.UseTransparentBackground = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.AutoRoundedCorners = true;
            this.btnEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployee.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnEmployee.BorderRadius = 21;
            this.btnEmployee.BorderThickness = 1;
            this.btnEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployee.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnEmployee.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmployee.FillColor = System.Drawing.Color.Transparent;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnEmployee.Location = new System.Drawing.Point(36, 386);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(180, 45);
            this.btnEmployee.TabIndex = 20;
            this.btnEmployee.Text = "Employees";
            this.btnEmployee.UseTransparentBackground = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.AutoRoundedCorners = true;
            this.btnRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnRoom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnRoom.BorderRadius = 21;
            this.btnRoom.BorderThickness = 1;
            this.btnRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRoom.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnRoom.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRoom.FillColor = System.Drawing.Color.Transparent;
            this.btnRoom.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnRoom.Location = new System.Drawing.Point(36, 173);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(180, 45);
            this.btnRoom.TabIndex = 19;
            this.btnRoom.Text = "Rooms";
            this.btnRoom.UseTransparentBackground = true;
            // 
            // btnCustomer
            // 
            this.btnCustomer.AutoRoundedCorners = true;
            this.btnCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnCustomer.BorderRadius = 21;
            this.btnCustomer.BorderThickness = 1;
            this.btnCustomer.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomer.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnCustomer.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomer.FillColor = System.Drawing.Color.Transparent;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnCustomer.Location = new System.Drawing.Point(36, 315);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(180, 45);
            this.btnCustomer.TabIndex = 16;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.UseTransparentBackground = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lbTime);
            this.guna2Panel1.Controls.Add(this.pic_close);
            this.guna2Panel1.Controls.Add(this.pic_minus);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(241, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1268, 79);
            this.guna2Panel1.TabIndex = 18;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Depth = 0;
            this.lbTime.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbTime.Location = new System.Drawing.Point(68, 32);
            this.lbTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(174, 19);
            this.lbTime.TabIndex = 13;
            this.lbTime.Text = "giờ, thứ ngày tháng nam";
            // 
            // pic_close
            // 
            this.pic_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_close.Image = ((System.Drawing.Image)(resources.GetObject("pic_close.Image")));
            this.pic_close.Location = new System.Drawing.Point(1206, 12);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(50, 50);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_close.TabIndex = 11;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // pic_minus
            // 
            this.pic_minus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_minus.Image = ((System.Drawing.Image)(resources.GetObject("pic_minus.Image")));
            this.pic_minus.Location = new System.Drawing.Point(1150, 12);
            this.pic_minus.Name = "pic_minus";
            this.pic_minus.Size = new System.Drawing.Size(50, 50);
            this.pic_minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_minus.TabIndex = 12;
            this.pic_minus.TabStop = false;
            this.pic_minus.Click += new System.EventHandler(this.pic_minus_Click);
            // 
            // panelRoomManagement
            // 
            this.panelRoomManagement.Controls.Add(this.ucRoomManagement);
            this.panelRoomManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRoomManagement.Location = new System.Drawing.Point(241, 79);
            this.panelRoomManagement.Name = "panelRoomManagement";
            this.panelRoomManagement.Size = new System.Drawing.Size(1268, 738);
            this.panelRoomManagement.TabIndex = 19;
            // 
            // ucRoomManagement
            // 
            this.ucRoomManagement.BackColor = System.Drawing.Color.White;
            this.ucRoomManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucRoomManagement.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucRoomManagement.Location = new System.Drawing.Point(0, 0);
            this.ucRoomManagement.Name = "ucRoomManagement";
            this.ucRoomManagement.Size = new System.Drawing.Size(1268, 738);
            this.ucRoomManagement.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 817);
            this.Controls.Add(this.panelRoomManagement);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelFunction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelFunction.ResumeLayout(false);
            this.panelLogout.ResumeLayout(false);
            this.panelLogout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minus)).EndInit();
            this.panelRoomManagement.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_minus;
        private System.Windows.Forms.PictureBox pic_close;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelFunction;
        private Guna.UI2.WinForms.Guna2Button btnCustomer;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel panelRoomManagement;
        private User_Controls.UC_RoomManagement ucRoomManagement;
        private Guna.UI2.WinForms.Guna2Button btnRoom;
        private MaterialSkin.Controls.MaterialLabel lbTime;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Button btnBooking;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ImageButton btnStaff;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel panelLogout;
        private Guna.UI2.WinForms.Guna2PictureBox picLogout;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbLogout;
    }
}