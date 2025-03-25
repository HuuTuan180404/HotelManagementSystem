namespace Presentation.User_Controls
{
    partial class itemAttribute
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkbox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.checkbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 40);
            this.panel1.TabIndex = 0;
            // 
            // checkbox
            // 
            this.checkbox.AutoSize = true;
            this.checkbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkbox.CheckedState.BorderRadius = 0;
            this.checkbox.CheckedState.BorderThickness = 0;
            this.checkbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkbox.Location = new System.Drawing.Point(0, 0);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(145, 40);
            this.checkbox.TabIndex = 1;
            this.checkbox.Text = "guna2CheckBox1";
            this.checkbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkbox.UncheckedState.BorderRadius = 0;
            this.checkbox.UncheckedState.BorderThickness = 0;
            this.checkbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // itemAttribute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "itemAttribute";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(149, 44);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CheckBox checkbox;
    }
}
