namespace Presentation.User_Controls
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelStats = new System.Windows.Forms.Panel();
            this.lblTotalEmployees = new System.Windows.Forms.Label();
            this.lblActiveEmployees = new System.Windows.Forms.Label();
            this.lblInactiveEmployees = new System.Windows.Forms.Label();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.lblActiveTitle = new System.Windows.Forms.Label();
            this.lblInactiveTitle = new System.Windows.Forms.Label();
            this.panelControls = new System.Windows.Forms.Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnExport = new Guna.UI2.WinForms.Guna2Button();
            this.dtgEmployee = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelStats.SuspendLayout();
            this.panelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(27, 25);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(521, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "EMPLOYEE MANAGEMENT";
            // 
            // panelStats
            // 
            this.panelStats.Controls.Add(this.lblTotalEmployees);
            this.panelStats.Controls.Add(this.lblActiveEmployees);
            this.panelStats.Controls.Add(this.lblInactiveEmployees);
            this.panelStats.Controls.Add(this.lblTotalTitle);
            this.panelStats.Controls.Add(this.lblActiveTitle);
            this.panelStats.Controls.Add(this.lblInactiveTitle);
            this.panelStats.Location = new System.Drawing.Point(37, 98);
            this.panelStats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(1600, 140);
            this.panelStats.TabIndex = 1;
            // 
            // lblTotalEmployees
            // 
            this.lblTotalEmployees.AutoSize = true;
            this.lblTotalEmployees.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblTotalEmployees.Location = new System.Drawing.Point(133, 25);
            this.lblTotalEmployees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalEmployees.Name = "lblTotalEmployees";
            this.lblTotalEmployees.Size = new System.Drawing.Size(140, 81);
            this.lblTotalEmployees.TabIndex = 2;
            this.lblTotalEmployees.Text = "100";
            // 
            // lblActiveEmployees
            // 
            this.lblActiveEmployees.AutoSize = true;
            this.lblActiveEmployees.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblActiveEmployees.Location = new System.Drawing.Point(667, 25);
            this.lblActiveEmployees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveEmployees.Name = "lblActiveEmployees";
            this.lblActiveEmployees.Size = new System.Drawing.Size(105, 81);
            this.lblActiveEmployees.TabIndex = 3;
            this.lblActiveEmployees.Text = "80";
            // 
            // lblInactiveEmployees
            // 
            this.lblInactiveEmployees.AutoSize = true;
            this.lblInactiveEmployees.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblInactiveEmployees.Location = new System.Drawing.Point(1200, 25);
            this.lblInactiveEmployees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInactiveEmployees.Name = "lblInactiveEmployees";
            this.lblInactiveEmployees.Size = new System.Drawing.Size(105, 81);
            this.lblInactiveEmployees.TabIndex = 4;
            this.lblInactiveEmployees.Text = "20";
            // 
            // lblTotalTitle
            // 
            this.lblTotalTitle.AutoSize = true;
            this.lblTotalTitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotalTitle.Location = new System.Drawing.Point(140, 105);
            this.lblTotalTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.Size = new System.Drawing.Size(153, 28);
            this.lblTotalTitle.TabIndex = 5;
            this.lblTotalTitle.Text = "Total Employees";
            // 
            // lblActiveTitle
            // 
            this.lblActiveTitle.AutoSize = true;
            this.lblActiveTitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblActiveTitle.Location = new System.Drawing.Point(673, 105);
            this.lblActiveTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveTitle.Name = "lblActiveTitle";
            this.lblActiveTitle.Size = new System.Drawing.Size(165, 28);
            this.lblActiveTitle.TabIndex = 6;
            this.lblActiveTitle.Text = "Active Employees";
            // 
            // lblInactiveTitle
            // 
            this.lblInactiveTitle.AutoSize = true;
            this.lblInactiveTitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblInactiveTitle.Location = new System.Drawing.Point(1207, 105);
            this.lblInactiveTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInactiveTitle.Name = "lblInactiveTitle";
            this.lblInactiveTitle.Size = new System.Drawing.Size(178, 28);
            this.lblInactiveTitle.TabIndex = 7;
            this.lblInactiveTitle.Text = "Inactive Employees";
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.txtSearch);
            this.panelControls.Controls.Add(this.cboFilter);
            this.panelControls.Controls.Add(this.btnAdd);
            this.panelControls.Controls.Add(this.btnDelete);
            this.panelControls.Controls.Add(this.btnExport);
            this.panelControls.Location = new System.Drawing.Point(37, 246);
            this.panelControls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(1600, 62);
            this.panelControls.TabIndex = 8;
            this.panelControls.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControls_Paint);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(13, 12);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search Employee...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(400, 37);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cboFilter
            // 
            this.cboFilter.BackColor = System.Drawing.Color.Transparent;
            this.cboFilter.BorderRadius = 10;
            this.cboFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboFilter.ItemHeight = 30;
            this.cboFilter.Location = new System.Drawing.Point(427, 12);
            this.cboFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(265, 36);
            this.cboFilter.TabIndex = 10;
            this.cboFilter.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1067, 12);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 37);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1240, 12);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 37);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            // 
            // btnExport
            // 
            this.btnExport.BorderRadius = 10;
            this.btnExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(1413, 12);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(160, 37);
            this.btnExport.TabIndex = 13;
            this.btnExport.Text = "Export";
            // 
            // dtgEmployee
            // 
            this.dtgEmployee.AllowUserToAddRows = false;
            this.dtgEmployee.AllowUserToDeleteRows = false;
            this.dtgEmployee.AllowUserToResizeRows = false;
            this.dtgEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dtgEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgEmployee.ColumnHeadersHeight = 40;
            this.dtgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgEmployee.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgEmployee.EnableHeadersVisualStyles = false;
            this.dtgEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgEmployee.Location = new System.Drawing.Point(37, 315);
            this.dtgEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgEmployee.MultiSelect = false;
            this.dtgEmployee.Name = "dtgEmployee";
            this.dtgEmployee.ReadOnly = true;
            this.dtgEmployee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgEmployee.RowHeadersVisible = false;
            this.dtgEmployee.RowHeadersWidth = 51;
            this.dtgEmployee.RowTemplate.Height = 35;
            this.dtgEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEmployee.Size = new System.Drawing.Size(1600, 500);
            this.dtgEmployee.TabIndex = 14;
            this.dtgEmployee.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgEmployee.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgEmployee.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgEmployee.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgEmployee.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgEmployee.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgEmployee.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgEmployee.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dtgEmployee.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgEmployee.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgEmployee.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgEmployee.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgEmployee.ThemeStyle.HeaderStyle.Height = 40;
            this.dtgEmployee.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEmployee_CellDoubleClick);
            // 
            // UC_EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.dtgEmployee);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_EmployeeManagement";
            this.Size = new System.Drawing.Size(1675, 862);
            this.panelStats.ResumeLayout(false);
            this.panelStats.PerformLayout();
            this.panelControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Label lblTotalEmployees;
        private System.Windows.Forms.Label lblActiveEmployees;
        private System.Windows.Forms.Label lblInactiveEmployees;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Label lblActiveTitle;
        private System.Windows.Forms.Label lblInactiveTitle;
        private System.Windows.Forms.Panel panelControls;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cboFilter;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnExport;
        private Guna.UI2.WinForms.Guna2DataGridView dtgEmployee;
    }
}
