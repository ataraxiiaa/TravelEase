namespace TravelEase
{
    partial class H_serviceListing
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
            this.serviceListingHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Location = new System.Drawing.Point(8, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 226);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // serviceListingHeader
            // 
            this.serviceListingHeader.AutoSize = true;
            this.serviceListingHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.serviceListingHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceListingHeader.ForeColor = System.Drawing.Color.White;
            this.serviceListingHeader.Location = new System.Drawing.Point(0, 0);
            this.serviceListingHeader.Name = "serviceListingHeader";
            this.serviceListingHeader.Size = new System.Drawing.Size(143, 45);
            this.serviceListingHeader.TabIndex = 6;
            this.serviceListingHeader.Text = "Services";
            this.serviceListingHeader.Click += new System.EventHandler(this.managerReservationsHeader_Click);
            // 
            // H_serviceListing
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.serviceListingHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "H_serviceListing";
            this.Size = new System.Drawing.Size(1152, 554);
            this.Load += new System.EventHandler(this.H_serviceListing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label serviceListingHeader;
    }
}
