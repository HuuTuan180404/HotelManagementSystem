namespace Presentation.Forms
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
            this.sideBar = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnMenu = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.btnBooking = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.pic_minus = new System.Windows.Forms.PictureBox();
            this.lbTime = new Guna.UI2.WinForms.Guna2Button();
            this.panelUC = new Guna.UI2.WinForms.Guna2Panel();
            this.UC_RoomManagement = new Presentation.User_Controls.UC_RoomManagement();
            this.UC_EmployeeManagement = new Presentation.User_Controls.UC_EmployeeManagement();
            this.UC_BookingManagement = new Presentation.User_Controls.UC_BookingManagement();
            this.UC_CustomerManagement = new Presentation.User_Controls.UC_CustomerManagement();
            this.UC_ThongKe = new Presentation.User_Controls.UC_ThongKe();
            this.sideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minus)).BeginInit();
            this.panelUC.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.Controls.Add(this.btnMenu);
            this.sideBar.Controls.Add(this.btnThongKe);
            this.sideBar.Controls.Add(this.btnBooking);
            this.sideBar.Controls.Add(this.btnEmployee);
            this.sideBar.Controls.Add(this.btnRoom);
            this.sideBar.Controls.Add(this.btnCustomer);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F);
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sideBar.MaximumSize = new System.Drawing.Size(375, 1061);
            this.sideBar.MinimumSize = new System.Drawing.Size(120, 1061);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(120, 1061);
            this.sideBar.TabIndex = 17;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FillColor = System.Drawing.Color.Transparent;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageRotate = 0F;
            this.btnMenu.Location = new System.Drawing.Point(24, 106);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(68, 73);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 25;
            this.btnMenu.TabStop = false;
            this.btnMenu.UseTransparentBackground = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.AutoRoundedCorners = true;
            this.btnThongKe.BackColor = System.Drawing.Color.Transparent;
            this.btnThongKe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnThongKe.BorderRadius = 35;
            this.btnThongKe.BorderThickness = 1;
            this.btnThongKe.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnThongKe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnThongKe.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongKe.FillColor = System.Drawing.Color.Transparent;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnThongKe.Image = global::Presentation.Properties.Resources._1286853;
            this.btnThongKe.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThongKe.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnThongKe.ImageSize = new System.Drawing.Size(40, 40);
            this.btnThongKe.Location = new System.Drawing.Point(24, 790);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(442, 73);
            this.btnThongKe.TabIndex = 22;
            this.btnThongKe.Text = "Logout";
            this.btnThongKe.UseTransparentBackground = true;
            this.btnThongKe.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.AutoRoundedCorners = true;
            this.btnBooking.BackColor = System.Drawing.Color.Transparent;
            this.btnBooking.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnBooking.BorderRadius = 35;
            this.btnBooking.BorderThickness = 1;
            this.btnBooking.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBooking.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnBooking.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnBooking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBooking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBooking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBooking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBooking.FillColor = System.Drawing.Color.Transparent;
            this.btnBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnBooking.Image = ((System.Drawing.Image)(resources.GetObject("btnBooking.Image")));
            this.btnBooking.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBooking.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnBooking.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBooking.Location = new System.Drawing.Point(24, 475);
            this.btnBooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(442, 73);
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
            this.btnEmployee.BorderRadius = 35;
            this.btnEmployee.BorderThickness = 1;
            this.btnEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployee.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnEmployee.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmployee.FillColor = System.Drawing.Color.Transparent;
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmployee.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnEmployee.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEmployee.Location = new System.Drawing.Point(24, 685);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(442, 73);
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
            this.btnRoom.BorderRadius = 35;
            this.btnRoom.BorderThickness = 1;
            this.btnRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRoom.Checked = true;
            this.btnRoom.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnRoom.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRoom.FillColor = System.Drawing.Color.Transparent;
            this.btnRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnRoom.Image")));
            this.btnRoom.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRoom.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnRoom.ImageSize = new System.Drawing.Size(40, 40);
            this.btnRoom.Location = new System.Drawing.Point(24, 370);
            this.btnRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(442, 73);
            this.btnRoom.TabIndex = 19;
            this.btnRoom.Text = "Rooms";
            this.btnRoom.UseTransparentBackground = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.AutoRoundedCorners = true;
            this.btnCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnCustomer.BorderRadius = 35;
            this.btnCustomer.BorderThickness = 1;
            this.btnCustomer.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomer.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnCustomer.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomer.FillColor = System.Drawing.Color.Transparent;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomer.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnCustomer.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCustomer.Location = new System.Drawing.Point(24, 580);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(442, 73);
            this.btnCustomer.TabIndex = 16;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.UseTransparentBackground = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.pic_close);
            this.guna2Panel1.Controls.Add(this.pic_minus);
            this.guna2Panel1.Controls.Add(this.lbTime);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(120, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(10);
            this.guna2Panel1.Size = new System.Drawing.Size(1804, 103);
            this.guna2Panel1.TabIndex = 18;
            // 
            // pic_close
            // 
            this.pic_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_close.Image = ((System.Drawing.Image)(resources.GetObject("pic_close.Image")));
            this.pic_close.Location = new System.Drawing.Point(1724, 26);
            this.pic_close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(56, 56);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_close.TabIndex = 11;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // pic_minus
            // 
            this.pic_minus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_minus.Image = ((System.Drawing.Image)(resources.GetObject("pic_minus.Image")));
            this.pic_minus.Location = new System.Drawing.Point(1660, 26);
            this.pic_minus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic_minus.Name = "pic_minus";
            this.pic_minus.Size = new System.Drawing.Size(56, 56);
            this.pic_minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_minus.TabIndex = 12;
            this.pic_minus.TabStop = false;
            this.pic_minus.Click += new System.EventHandler(this.pic_minus_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoRoundedCorners = true;
            this.lbTime.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.lbTime.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.lbTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.lbTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.lbTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(10, 10);
            this.lbTime.Margin = new System.Windows.Forms.Padding(10);
            this.lbTime.Name = "lbTime";
            this.lbTime.Padding = new System.Windows.Forms.Padding(10);
            this.lbTime.Size = new System.Drawing.Size(207, 83);
            this.lbTime.TabIndex = 14;
            this.lbTime.Text = "guna2Button2";
            // 
            // panelUC
            // 
            this.panelUC.BackColor = System.Drawing.Color.Transparent;
            this.panelUC.Controls.Add(this.UC_ThongKe);
            this.panelUC.Controls.Add(this.UC_RoomManagement);
            this.panelUC.Controls.Add(this.UC_EmployeeManagement);
            this.panelUC.Controls.Add(this.UC_BookingManagement);
            this.panelUC.Controls.Add(this.UC_CustomerManagement);
            this.panelUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUC.Location = new System.Drawing.Point(120, 103);
            this.panelUC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelUC.Name = "panelUC";
            this.panelUC.Size = new System.Drawing.Size(1804, 952);
            this.panelUC.TabIndex = 19;
            // 
            // UC_RoomManagement
            // 
            this.UC_RoomManagement.BackColor = System.Drawing.Color.White;
            this.UC_RoomManagement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_RoomManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_RoomManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.UC_RoomManagement.Location = new System.Drawing.Point(0, 0);
            this.UC_RoomManagement.Name = "UC_RoomManagement";
            this.UC_RoomManagement.Padding = new System.Windows.Forms.Padding(6);
            this.UC_RoomManagement.Size = new System.Drawing.Size(1804, 952);
            this.UC_RoomManagement.TabIndex = 2;
            // 
            // UC_EmployeeManagement
            // 
            this.UC_EmployeeManagement.BackColor = System.Drawing.Color.White;
            this.UC_EmployeeManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_EmployeeManagement.Location = new System.Drawing.Point(0, 0);
            this.UC_EmployeeManagement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UC_EmployeeManagement.Name = "UC_EmployeeManagement";
            this.UC_EmployeeManagement.Size = new System.Drawing.Size(1804, 952);
            this.UC_EmployeeManagement.TabIndex = 1;
            // 
            // UC_BookingManagement
            // 
            this.UC_BookingManagement.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UC_BookingManagement.BackColor = System.Drawing.Color.White;
            this.UC_BookingManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_BookingManagement.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UC_BookingManagement.Location = new System.Drawing.Point(0, 0);
            this.UC_BookingManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UC_BookingManagement.Name = "UC_BookingManagement";
            this.UC_BookingManagement.Size = new System.Drawing.Size(1804, 952);
            this.UC_BookingManagement.TabIndex = 0;
            this.UC_BookingManagement.Load += new System.EventHandler(this.UC_BookingManagement_Load);
            // 
            // UC_CustomerManagement
            // 
            this.UC_CustomerManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_CustomerManagement.Location = new System.Drawing.Point(0, 0);
            this.UC_CustomerManagement.Margin = new System.Windows.Forms.Padding(4);
            this.UC_CustomerManagement.Name = "UC_CustomerManagement";
            this.UC_CustomerManagement.Size = new System.Drawing.Size(1804, 952);
            this.UC_CustomerManagement.TabIndex = 3;
            // 
            // UC_ThongKe
            // 
            this.UC_ThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_ThongKe.Location = new System.Drawing.Point(0, 0);
            this.UC_ThongKe.Name = "UC_ThongKe";
            this.UC_ThongKe.Size = new System.Drawing.Size(1804, 952);
            this.UC_ThongKe.TabIndex = 26;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panelUC);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.sideBar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.sideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minus)).EndInit();
            this.panelUC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_minus;
        private System.Windows.Forms.PictureBox pic_close;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel sideBar;
        private Guna.UI2.WinForms.Guna2Button btnCustomer;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel panelUC;
        private Guna.UI2.WinForms.Guna2Button btnRoom;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Button btnBooking;
        private Guna.UI2.WinForms.Guna2PictureBox btnMenu;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button btnThongKe;
        private User_Controls.UC_BookingManagement UC_BookingManagement;
        private User_Controls.UC_EmployeeManagement UC_EmployeeManagement;
        private User_Controls.UC_RoomManagement UC_RoomManagement;
        private User_Controls.UC_CustomerManagement UC_CustomerManagement;
        private Guna.UI2.WinForms.Guna2Button lbTime;
        private User_Controls.UC_ThongKe UC_ThongKe;
    }
}