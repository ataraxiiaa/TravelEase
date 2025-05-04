namespace TravelEase
{
    partial class A_Dashboard
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
            this.Dasboard_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAdminID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dasboard_lbl
            // 
            this.Dasboard_lbl.AutoSize = true;
            this.Dasboard_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dasboard_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dasboard_lbl.ForeColor = System.Drawing.Color.White;
            this.Dasboard_lbl.Location = new System.Drawing.Point(0, 0);
            this.Dasboard_lbl.Name = "Dasboard_lbl";
            this.Dasboard_lbl.Size = new System.Drawing.Size(238, 37);
            this.Dasboard_lbl.TabIndex = 0;
            this.Dasboard_lbl.Text = "Admin Dashboard";
            this.Dasboard_lbl.Click += new System.EventHandler(this.Dasboard_lbl_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.lblAdminID);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(54, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 226);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblAdminID
            // 
            this.lblAdminID.AutoSize = true;
            this.lblAdminID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminID.ForeColor = System.Drawing.Color.White;
            this.lblAdminID.Location = new System.Drawing.Point(49, 116);
            this.lblAdminID.Name = "lblAdminID";
            this.lblAdminID.Size = new System.Drawing.Size(101, 24);
            this.lblAdminID.TabIndex = 4;
            this.lblAdminID.Text = "lblAdminID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(49, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 24);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "lblName";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // A_Dashboard
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dasboard_lbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "A_Dashboard";
            this.Size = new System.Drawing.Size(1152, 554);
            this.Load += new System.EventHandler(this.A_Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Dasboard_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAdminID;
        private System.Windows.Forms.Label lblName;
    }
}
