namespace TravelEase
{
    partial class A_Settings
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
            this.settings_lbl = new System.Windows.Forms.Label();
            this.AdminPanelInfo = new System.Windows.Forms.Panel();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.Email_lbl = new System.Windows.Forms.Label();
            this.ID_lbl = new System.Windows.Forms.Label();
            this.AdminPanelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // settings_lbl
            // 
            this.settings_lbl.AutoSize = true;
            this.settings_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.settings_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings_lbl.ForeColor = System.Drawing.Color.White;
            this.settings_lbl.Location = new System.Drawing.Point(0, 0);
            this.settings_lbl.Name = "settings_lbl";
            this.settings_lbl.Size = new System.Drawing.Size(142, 45);
            this.settings_lbl.TabIndex = 1;
            this.settings_lbl.Text = "Settings";
            // 
            // AdminPanelInfo
            // 
            this.AdminPanelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.AdminPanelInfo.Controls.Add(this.ID_lbl);
            this.AdminPanelInfo.Controls.Add(this.Email_lbl);
            this.AdminPanelInfo.Controls.Add(this.Name_lbl);
            this.AdminPanelInfo.Location = new System.Drawing.Point(86, 145);
            this.AdminPanelInfo.Name = "AdminPanelInfo";
            this.AdminPanelInfo.Size = new System.Drawing.Size(427, 168);
            this.AdminPanelInfo.TabIndex = 2;
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_lbl.ForeColor = System.Drawing.Color.White;
            this.Name_lbl.Location = new System.Drawing.Point(28, 30);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(103, 39);
            this.Name_lbl.TabIndex = 0;
            this.Name_lbl.Text = "Name:";
            // 
            // Email_lbl
            // 
            this.Email_lbl.AutoSize = true;
            this.Email_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_lbl.ForeColor = System.Drawing.Color.White;
            this.Email_lbl.Location = new System.Drawing.Point(28, 69);
            this.Email_lbl.Name = "Email_lbl";
            this.Email_lbl.Size = new System.Drawing.Size(76, 31);
            this.Email_lbl.TabIndex = 0;
            this.Email_lbl.Text = "Email:";
            // 
            // ID_lbl
            // 
            this.ID_lbl.AutoSize = true;
            this.ID_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_lbl.ForeColor = System.Drawing.Color.White;
            this.ID_lbl.Location = new System.Drawing.Point(28, 111);
            this.ID_lbl.Name = "ID_lbl";
            this.ID_lbl.Size = new System.Drawing.Size(44, 31);
            this.ID_lbl.TabIndex = 0;
            this.ID_lbl.Text = "ID:";
            // 
            // A_Settings
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.AdminPanelInfo);
            this.Controls.Add(this.settings_lbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "A_Settings";
            this.Size = new System.Drawing.Size(1441, 693);
            this.Load += new System.EventHandler(this.A_Settings_Load);
            this.AdminPanelInfo.ResumeLayout(false);
            this.AdminPanelInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label settings_lbl;
        private System.Windows.Forms.Panel AdminPanelInfo;
        private System.Windows.Forms.Label ID_lbl;
        private System.Windows.Forms.Label Email_lbl;
        private System.Windows.Forms.Label Name_lbl;
    }
}
