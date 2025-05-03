namespace TravelEase
{
    partial class TO_Dashboard
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
            this.companyname_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
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
            this.Dasboard_lbl.Size = new System.Drawing.Size(403, 45);
            this.Dasboard_lbl.TabIndex = 1;
            this.Dasboard_lbl.Text = "Tour Operator Dashboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.companyname_lbl);
            this.panel1.Controls.Add(this.name_lbl);
            this.panel1.Location = new System.Drawing.Point(60, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 226);
            this.panel1.TabIndex = 2;
            // 
            // companyname_lbl
            // 
            this.companyname_lbl.AutoSize = true;
            this.companyname_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyname_lbl.ForeColor = System.Drawing.Color.White;
            this.companyname_lbl.Location = new System.Drawing.Point(59, 117);
            this.companyname_lbl.Name = "companyname_lbl";
            this.companyname_lbl.Size = new System.Drawing.Size(232, 32);
            this.companyname_lbl.TabIndex = 1;
            this.companyname_lbl.Text = "Company Name: ";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.ForeColor = System.Drawing.Color.White;
            this.name_lbl.Location = new System.Drawing.Point(59, 62);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(104, 32);
            this.name_lbl.TabIndex = 0;
            this.name_lbl.Text = "Name: ";
            // 
            // TO_Dashboard
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dasboard_lbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TO_Dashboard";
            this.Size = new System.Drawing.Size(1441, 693);
            this.Load += new System.EventHandler(this.TO_Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Dasboard_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label companyname_lbl;
        private System.Windows.Forms.Label name_lbl;
    }
}
