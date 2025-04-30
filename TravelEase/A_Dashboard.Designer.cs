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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
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
            this.Dasboard_lbl.Size = new System.Drawing.Size(291, 45);
            this.Dasboard_lbl.TabIndex = 0;
            this.Dasboard_lbl.Text = "Admin Dashboard";
            this.Dasboard_lbl.Click += new System.EventHandler(this.Dasboard_lbl_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(75, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 154);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(796, 291);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // A_Dashboard
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dasboard_lbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "A_Dashboard";
            this.Size = new System.Drawing.Size(1441, 693);
            this.Load += new System.EventHandler(this.A_Dashboard_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Dasboard_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
