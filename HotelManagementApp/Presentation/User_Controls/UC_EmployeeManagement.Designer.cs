﻿namespace Presentation.User_Controls
{
    partial class UC_EmployeeManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExport = new Guna.UI2.WinForms.Guna2Button();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.tbLayoutCard = new System.Windows.Forms.TableLayoutPanel();
            this.cardOnLeave = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblOLNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cardInactive = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblInactiveNumber = new System.Windows.Forms.Label();
            this.label2lblInactiveTitle = new System.Windows.Forms.Label();
            this.cardActive = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblActiveNumber = new System.Windows.Forms.Label();
            this.lblActiveTitle = new System.Windows.Forms.Label();
            this.cardTotal = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblTotalNumber = new System.Windows.Forms.Label();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDepartment = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.dtgEmployee = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.txtSearchEmployee = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlAction.SuspendLayout();
            this.tbLayoutCard.SuspendLayout();
            this.cardOnLeave.SuspendLayout();
            this.cardInactive.SuspendLayout();
            this.cardActive.SuspendLayout();
            this.cardTotal.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmployee)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.BorderRadius = 5;
            this.btnExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(1030, 13);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(120, 40);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // pnlAction
            // 
            this.pnlAction.Controls.Add(this.btnExport);
            this.pnlAction.Controls.Add(this.btnDelete);
            this.pnlAction.Controls.Add(this.btnAdd);
            this.pnlAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAction.Location = new System.Drawing.Point(0, 279);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.pnlAction.Size = new System.Drawing.Size(1200, 65);
            this.pnlAction.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(181, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbLayoutCard
            // 
            this.tbLayoutCard.ColumnCount = 4;
            this.tbLayoutCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbLayoutCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbLayoutCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbLayoutCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbLayoutCard.Controls.Add(this.cardOnLeave, 0, 0);
            this.tbLayoutCard.Controls.Add(this.cardInactive, 2, 0);
            this.tbLayoutCard.Controls.Add(this.cardActive, 1, 0);
            this.tbLayoutCard.Controls.Add(this.cardTotal, 0, 0);
            this.tbLayoutCard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbLayoutCard.Location = new System.Drawing.Point(20, 94);
            this.tbLayoutCard.Name = "tbLayoutCard";
            this.tbLayoutCard.Padding = new System.Windows.Forms.Padding(10);
            this.tbLayoutCard.RowCount = 1;
            this.tbLayoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLayoutCard.Size = new System.Drawing.Size(1160, 100);
            this.tbLayoutCard.TabIndex = 1;
            // 
            // cardOnLeave
            // 
            this.cardOnLeave.BackColor = System.Drawing.Color.Transparent;
            this.cardOnLeave.Controls.Add(this.lblOLNumber);
            this.cardOnLeave.Controls.Add(this.label3);
            this.cardOnLeave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardOnLeave.FillColor = System.Drawing.Color.White;
            this.cardOnLeave.Location = new System.Drawing.Point(298, 13);
            this.cardOnLeave.Name = "cardOnLeave";
            this.cardOnLeave.Radius = 10;
            this.cardOnLeave.ShadowColor = System.Drawing.Color.Black;
            this.cardOnLeave.ShadowDepth = 5;
            this.cardOnLeave.Size = new System.Drawing.Size(279, 74);
            this.cardOnLeave.TabIndex = 3;
            this.cardOnLeave.Click += new System.EventHandler(this.cardOnLeave_Click);
            // 
            // lblOLNumber
            // 
            this.lblOLNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOLNumber.AutoSize = true;
            this.lblOLNumber.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOLNumber.Location = new System.Drawing.Point(193, 15);
            this.lblOLNumber.Name = "lblOLNumber";
            this.lblOLNumber.Size = new System.Drawing.Size(46, 54);
            this.lblOLNumber.TabIndex = 3;
            this.lblOLNumber.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "On Leave Employees";
            // 
            // cardInactive
            // 
            this.cardInactive.BackColor = System.Drawing.Color.Transparent;
            this.cardInactive.Controls.Add(this.lblInactiveNumber);
            this.cardInactive.Controls.Add(this.label2lblInactiveTitle);
            this.cardInactive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardInactive.FillColor = System.Drawing.Color.White;
            this.cardInactive.Location = new System.Drawing.Point(868, 13);
            this.cardInactive.Name = "cardInactive";
            this.cardInactive.Radius = 10;
            this.cardInactive.ShadowColor = System.Drawing.Color.Black;
            this.cardInactive.ShadowDepth = 5;
            this.cardInactive.Size = new System.Drawing.Size(279, 74);
            this.cardInactive.TabIndex = 2;
            this.cardInactive.Click += new System.EventHandler(this.cardInactive_Click);
            // 
            // lblInactiveNumber
            // 
            this.lblInactiveNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblInactiveNumber.AutoSize = true;
            this.lblInactiveNumber.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInactiveNumber.Location = new System.Drawing.Point(193, 15);
            this.lblInactiveNumber.Name = "lblInactiveNumber";
            this.lblInactiveNumber.Size = new System.Drawing.Size(46, 54);
            this.lblInactiveNumber.TabIndex = 3;
            this.lblInactiveNumber.Text = "0";
            // 
            // label2lblInactiveTitle
            // 
            this.label2lblInactiveTitle.AutoSize = true;
            this.label2lblInactiveTitle.BackColor = System.Drawing.Color.Transparent;
            this.label2lblInactiveTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2lblInactiveTitle.Location = new System.Drawing.Point(15, 15);
            this.label2lblInactiveTitle.Name = "label2lblInactiveTitle";
            this.label2lblInactiveTitle.Size = new System.Drawing.Size(178, 28);
            this.label2lblInactiveTitle.TabIndex = 1;
            this.label2lblInactiveTitle.Text = "Inactive Employees";
            // 
            // cardActive
            // 
            this.cardActive.BackColor = System.Drawing.Color.Transparent;
            this.cardActive.Controls.Add(this.lblActiveNumber);
            this.cardActive.Controls.Add(this.lblActiveTitle);
            this.cardActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardActive.FillColor = System.Drawing.Color.White;
            this.cardActive.Location = new System.Drawing.Point(583, 13);
            this.cardActive.Name = "cardActive";
            this.cardActive.Radius = 10;
            this.cardActive.ShadowColor = System.Drawing.Color.Black;
            this.cardActive.ShadowDepth = 5;
            this.cardActive.Size = new System.Drawing.Size(279, 74);
            this.cardActive.TabIndex = 1;
            this.cardActive.Click += new System.EventHandler(this.cardActive_Click);
            // 
            // lblActiveNumber
            // 
            this.lblActiveNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblActiveNumber.AutoSize = true;
            this.lblActiveNumber.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveNumber.Location = new System.Drawing.Point(191, 15);
            this.lblActiveNumber.Name = "lblActiveNumber";
            this.lblActiveNumber.Size = new System.Drawing.Size(46, 54);
            this.lblActiveNumber.TabIndex = 2;
            this.lblActiveNumber.Text = "0";
            // 
            // lblActiveTitle
            // 
            this.lblActiveTitle.AutoSize = true;
            this.lblActiveTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblActiveTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveTitle.Location = new System.Drawing.Point(15, 15);
            this.lblActiveTitle.Name = "lblActiveTitle";
            this.lblActiveTitle.Size = new System.Drawing.Size(165, 28);
            this.lblActiveTitle.TabIndex = 2;
            this.lblActiveTitle.Text = "Active Employees";
            // 
            // cardTotal
            // 
            this.cardTotal.BackColor = System.Drawing.Color.Transparent;
            this.cardTotal.Controls.Add(this.lblTotalNumber);
            this.cardTotal.Controls.Add(this.lblTotalTitle);
            this.cardTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardTotal.FillColor = System.Drawing.Color.White;
            this.cardTotal.Location = new System.Drawing.Point(13, 13);
            this.cardTotal.Name = "cardTotal";
            this.cardTotal.Radius = 10;
            this.cardTotal.ShadowColor = System.Drawing.Color.Black;
            this.cardTotal.ShadowDepth = 5;
            this.cardTotal.Size = new System.Drawing.Size(279, 74);
            this.cardTotal.TabIndex = 0;
            this.cardTotal.Click += new System.EventHandler(this.cardTotal_Click);
            // 
            // lblTotalNumber
            // 
            this.lblTotalNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalNumber.AutoSize = true;
            this.lblTotalNumber.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNumber.Location = new System.Drawing.Point(166, 15);
            this.lblTotalNumber.Name = "lblTotalNumber";
            this.lblTotalNumber.Size = new System.Drawing.Size(46, 54);
            this.lblTotalNumber.TabIndex = 1;
            this.lblTotalNumber.Text = "0";
            // 
            // lblTotalTitle
            // 
            this.lblTotalTitle.AutoSize = true;
            this.lblTotalTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.Size = new System.Drawing.Size(153, 28);
            this.lblTotalTitle.TabIndex = 0;
            this.lblTotalTitle.Text = "Total Employees";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.tbLayoutCard);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20);
            this.pnlHeader.Size = new System.Drawing.Size(1200, 214);
            this.pnlHeader.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "EMPLOYEE MANAGEMENT";
            // 
            // cbDepartment
            // 
            this.cbDepartment.BackColor = System.Drawing.Color.Transparent;
            this.cbDepartment.BorderRadius = 5;
            this.cbDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDepartment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDepartment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbDepartment.ItemHeight = 30;
            this.cbDepartment.Items.AddRange(new object[] {
            "Tất cả vị trí",
            "Nhân viên ",
            "Lễ tân",
            "....."});
            this.cbDepartment.Location = new System.Drawing.Point(340, 10);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(200, 36);
            this.cbDepartment.TabIndex = 1;
            this.cbDepartment.SelectedIndexChanged += new System.EventHandler(this.cbDepartment_SelectedIndexChanged);
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbStatus.BorderRadius = 5;
            this.cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbStatus.ItemHeight = 30;
            this.cbStatus.Items.AddRange(new object[] {
            "Tất cả trạng thái",
            "Đang làm",
            "Đang nghỉ",
            "Đã nghỉ việc"});
            this.cbStatus.Location = new System.Drawing.Point(620, 10);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(560, 36);
            this.cbStatus.TabIndex = 2;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.cbStatus);
            this.pnlFilter.Controls.Add(this.cbDepartment);
            this.pnlFilter.Controls.Add(this.txtSearchEmployee);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 214);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.pnlFilter.Size = new System.Drawing.Size(1200, 65);
            this.pnlFilter.TabIndex = 5;
            // 
            // dtgEmployee
            // 
            this.dtgEmployee.AllowUserToAddRows = false;
            this.dtgEmployee.AllowUserToDeleteRows = false;
            this.dtgEmployee.AllowUserToResizeColumns = false;
            this.dtgEmployee.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dtgEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgEmployee.ColumnHeadersHeight = 45;
            this.dtgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgEmployee.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dtgEmployee.Location = new System.Drawing.Point(0, 0);
            this.dtgEmployee.Name = "dtgEmployee";
            this.dtgEmployee.RowHeadersVisible = false;
            this.dtgEmployee.RowHeadersWidth = 51;
            this.dtgEmployee.RowTemplate.Height = 40;
            this.dtgEmployee.Size = new System.Drawing.Size(1200, 456);
            this.dtgEmployee.TabIndex = 4;
            this.dtgEmployee.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dtgEmployee.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dtgEmployee.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgEmployee.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgEmployee.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgEmployee.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgEmployee.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgEmployee.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dtgEmployee.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dtgEmployee.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgEmployee.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgEmployee.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgEmployee.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgEmployee.ThemeStyle.HeaderStyle.Height = 45;
            this.dtgEmployee.ThemeStyle.ReadOnly = false;
            this.dtgEmployee.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgEmployee.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgEmployee.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgEmployee.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgEmployee.ThemeStyle.RowsStyle.Height = 40;
            this.dtgEmployee.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dtgEmployee.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgEmployee.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEmployee_CellDoubleClick);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.dtgEmployee);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 344);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1200, 456);
            this.pnlContent.TabIndex = 7;
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.BorderRadius = 5;
            this.txtSearchEmployee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchEmployee.DefaultText = "";
            this.txtSearchEmployee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchEmployee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchEmployee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchEmployee.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchEmployee.IconRight = global::Presentation.Properties.Resources.find1;
            this.txtSearchEmployee.Location = new System.Drawing.Point(20, 10);
            this.txtSearchEmployee.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.PlaceholderText = "Search Employee ...";
            this.txtSearchEmployee.SelectedText = "";
            this.txtSearchEmployee.Size = new System.Drawing.Size(300, 40);
            this.txtSearchEmployee.TabIndex = 0;
            this.txtSearchEmployee.IconRightClick += new System.EventHandler(this.txtSearchEmployee_IconRightClick_1);
            this.txtSearchEmployee.TextChanged += new System.EventHandler(this.txtSearchEmployee_TextChanged);
            // 
            // UC_EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UC_EmployeeManagement";
            this.Size = new System.Drawing.Size(1200, 800);
            this.pnlAction.ResumeLayout(false);
            this.tbLayoutCard.ResumeLayout(false);
            this.cardOnLeave.ResumeLayout(false);
            this.cardOnLeave.PerformLayout();
            this.cardInactive.ResumeLayout(false);
            this.cardInactive.PerformLayout();
            this.cardActive.ResumeLayout(false);
            this.cardActive.PerformLayout();
            this.cardTotal.ResumeLayout(false);
            this.cardTotal.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmployee)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnExport;
        private System.Windows.Forms.Panel pnlAction;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.TableLayoutPanel tbLayoutCard;
        private Guna.UI2.WinForms.Guna2ShadowPanel cardInactive;
        private System.Windows.Forms.Label lblInactiveNumber;
        private System.Windows.Forms.Label label2lblInactiveTitle;
        private Guna.UI2.WinForms.Guna2ShadowPanel cardActive;
        private System.Windows.Forms.Label lblActiveNumber;
        private System.Windows.Forms.Label lblActiveTitle;
        private Guna.UI2.WinForms.Guna2ShadowPanel cardTotal;
        private System.Windows.Forms.Label lblTotalNumber;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbDepartment;
        private Guna.UI2.WinForms.Guna2ComboBox cbStatus;
        private System.Windows.Forms.Panel pnlFilter;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchEmployee;
        private Guna.UI2.WinForms.Guna2DataGridView dtgEmployee;
        private System.Windows.Forms.Panel pnlContent;
        private Guna.UI2.WinForms.Guna2ShadowPanel cardOnLeave;
        private System.Windows.Forms.Label lblOLNumber;
        private System.Windows.Forms.Label label3;
    }
}
