namespace Presentation.User_Controls
{
    partial class UC_Test
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
            this.UC_ViewFloorMode = new Presentation.User_Controls.UC_ViewFloorMode();
            this.SuspendLayout();
            // 
            // UC_ViewFloorMode
            // 
            this.UC_ViewFloorMode.BackColor = System.Drawing.Color.White;
            this.UC_ViewFloorMode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UC_ViewFloorMode.Location = new System.Drawing.Point(40, 71);
            this.UC_ViewFloorMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UC_ViewFloorMode.Name = "UC_ViewFloorMode";
            this.UC_ViewFloorMode.Size = new System.Drawing.Size(1294, 745);
            this.UC_ViewFloorMode.TabIndex = 0;
            // 
            // UC_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.UC_ViewFloorMode);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_Test";
            this.Size = new System.Drawing.Size(1395, 882);
            this.Load += new System.EventHandler(this.UC_Test_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UC_ViewFloorMode UC_ViewFloorMode;
    }
}
