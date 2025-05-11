namespace TravelEase
{
    partial class S_manageReservations
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
            this.reservationsDataViewer = new System.Windows.Forms.DataGridView();
            this.bookingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerReservationsHeader = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.reservationsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsDataViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // reservationsPanel
            // 
            this.reservationsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.reservationsPanel.Controls.Add(this.reservationsDataViewer);
            this.reservationsPanel.Location = new System.Drawing.Point(8, 108);
            this.reservationsPanel.Name = "reservationsPanel";
            this.reservationsPanel.Size = new System.Drawing.Size(1113, 332);
            this.reservationsPanel.TabIndex = 5;
            this.reservationsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // reservationsDataViewer
            // 
            this.reservationsDataViewer.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reservationsDataViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationsDataViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingID,
            this.bookingDate,
            this.bookingStatus});
            this.reservationsDataViewer.Location = new System.Drawing.Point(81, 39);
            this.reservationsDataViewer.Name = "reservationsDataViewer";
            this.reservationsDataViewer.RowHeadersWidth = 51;
            this.reservationsDataViewer.RowTemplate.Height = 24;
            this.reservationsDataViewer.Size = new System.Drawing.Size(434, 258);
            this.reservationsDataViewer.TabIndex = 0;
            this.reservationsDataViewer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reservationsDataViewer_CellContentClick);
            // 
            // bookingID
            // 
            this.bookingID.HeaderText = "Booking ID";
            this.bookingID.MinimumWidth = 6;
            this.bookingID.Name = "bookingID";
            this.bookingID.ReadOnly = true;
            this.bookingID.Width = 125;
            // 
            // bookingDate
            // 
            this.bookingDate.HeaderText = "Booking Date";
            this.bookingDate.MinimumWidth = 6;
            this.bookingDate.Name = "bookingDate";
            this.bookingDate.ReadOnly = true;
            this.bookingDate.Width = 125;
            // 
            // bookingStatus
            // 
            this.bookingStatus.HeaderText = "Booking Status";
            this.bookingStatus.MinimumWidth = 6;
            this.bookingStatus.Name = "bookingStatus";
            this.bookingStatus.Width = 125;
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
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(89, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "Get Data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportButton
            // 
            this.reportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.reportButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reportButton.Location = new System.Drawing.Point(717, 463);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(128, 52);
            this.reportButton.TabIndex = 7;
            this.reportButton.Text = "Get Payment Report";
            this.reportButton.UseVisualStyleBackColor = false;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // S_manageReservations
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reservationsPanel);
            this.Controls.Add(this.managerReservationsHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "S_manageReservations";
            this.Size = new System.Drawing.Size(1375, 693);
            this.Load += new System.EventHandler(this.H_manageReservations_Load);
            this.reservationsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reservationsDataViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel reservationsPanel;
        private System.Windows.Forms.Label managerReservationsHeader;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView reservationsDataViewer;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingStatus;
        private System.Windows.Forms.Button reportButton;
    }
}
