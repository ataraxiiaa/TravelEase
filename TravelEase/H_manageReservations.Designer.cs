namespace TravelEase
{
    partial class H_manageReservations
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
            this.reservationsPanel = new System.Windows.Forms.Panel();
            this.managerReservationsHeader = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reservationsPanel
            // 
            this.reservationsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.reservationsPanel.Location = new System.Drawing.Point(8, 160);
            this.reservationsPanel.Name = "reservationsPanel";
            this.reservationsPanel.Size = new System.Drawing.Size(1113, 226);
            this.reservationsPanel.TabIndex = 5;
            this.reservationsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // managerReservationsHeader
            // 
            this.managerReservationsHeader.AutoSize = true;
            this.managerReservationsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.managerReservationsHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerReservationsHeader.ForeColor = System.Drawing.Color.White;
            this.managerReservationsHeader.Location = new System.Drawing.Point(0, 0);
            this.managerReservationsHeader.Name = "managerReservationsHeader";
            this.managerReservationsHeader.Size = new System.Drawing.Size(341, 45);
            this.managerReservationsHeader.TabIndex = 4;
            this.managerReservationsHeader.Text = "Manage Reservations";
            this.managerReservationsHeader.Click += new System.EventHandler(this.Dasboard_lbl_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(942, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Get Data";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // H_manageReservations
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reservationsPanel);
            this.Controls.Add(this.managerReservationsHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "H_manageReservations";
            this.Size = new System.Drawing.Size(1152, 554);
            this.Load += new System.EventHandler(this.H_manageReservations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel reservationsPanel;
        private System.Windows.Forms.Label managerReservationsHeader;
        private System.Windows.Forms.Button button1;
    }
}
