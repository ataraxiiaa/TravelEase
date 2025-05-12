namespace TravelEase
{
    partial class S_abandonedBookings
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.managerReservationsHeader = new System.Windows.Forms.Label();
            this.abDataViewer = new System.Windows.Forms.DataGridView();
            this.ABID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abRefundCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adRefundStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abandonedBookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourismDatabaseDataSet = new TravelEase.tourismDatabaseDataSet();
            this.reservationsPanel = new System.Windows.Forms.Panel();
            this.abandonedBookingsTableAdapter = new TravelEase.tourismDatabaseDataSetTableAdapters.AbandonedBookingsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.tourismDatabaseDataSet7 = new TravelEase.tourismDatabaseDataSet7();
            this.abandonedBookingsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.abandonedBookingsTableAdapter1 = new TravelEase.tourismDatabaseDataSet7TableAdapters.AbandonedBookingsTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.abDataViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abandonedBookingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourismDatabaseDataSet)).BeginInit();
            this.reservationsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tourismDatabaseDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abandonedBookingsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // managerReservationsHeader
            // 
            this.managerReservationsHeader.AutoSize = true;
            this.managerReservationsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.managerReservationsHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerReservationsHeader.ForeColor = System.Drawing.Color.White;
            this.managerReservationsHeader.Location = new System.Drawing.Point(0, 0);
            this.managerReservationsHeader.Name = "managerReservationsHeader";
            this.managerReservationsHeader.Size = new System.Drawing.Size(343, 45);
            this.managerReservationsHeader.TabIndex = 5;
            this.managerReservationsHeader.Text = "Abandoned Bookings";
            this.managerReservationsHeader.Click += new System.EventHandler(this.managerReservationsHeader_Click);
            // 
            // abDataViewer
            // 
            this.abDataViewer.AllowUserToAddRows = false;
            this.abDataViewer.AllowUserToDeleteRows = false;
            this.abDataViewer.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.abDataViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abDataViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ABID,
            this.abReason,
            this.abRefundCost,
            this.adRefundStatus,
            this.bookingID});
            this.abDataViewer.Location = new System.Drawing.Point(81, 39);
            this.abDataViewer.Name = "abDataViewer";
            this.abDataViewer.RowHeadersWidth = 51;
            this.abDataViewer.RowTemplate.Height = 24;
            this.abDataViewer.Size = new System.Drawing.Size(735, 258);
            this.abDataViewer.TabIndex = 6;
            // 
            // ABID
            // 
            this.ABID.HeaderText = "Abandoned Booking ID";
            this.ABID.MinimumWidth = 6;
            this.ABID.Name = "ABID";
            this.ABID.Width = 125;
            // 
            // abReason
            // 
            this.abReason.HeaderText = "Reason";
            this.abReason.MinimumWidth = 6;
            this.abReason.Name = "abReason";
            this.abReason.Width = 125;
            // 
            // abRefundCost
            // 
            this.abRefundCost.HeaderText = "Refund Cost";
            this.abRefundCost.MinimumWidth = 6;
            this.abRefundCost.Name = "abRefundCost";
            this.abRefundCost.Width = 125;
            // 
            // adRefundStatus
            // 
            this.adRefundStatus.HeaderText = "Refund Status";
            this.adRefundStatus.MinimumWidth = 6;
            this.adRefundStatus.Name = "adRefundStatus";
            this.adRefundStatus.ReadOnly = true;
            this.adRefundStatus.Width = 125;
            // 
            // bookingID
            // 
            this.bookingID.HeaderText = "Booking ID";
            this.bookingID.MinimumWidth = 6;
            this.bookingID.Name = "bookingID";
            this.bookingID.Width = 125;
            // 
            // abandonedBookingsBindingSource
            // 
            this.abandonedBookingsBindingSource.DataMember = "AbandonedBookings";
            this.abandonedBookingsBindingSource.DataSource = this.tourismDatabaseDataSet;
            // 
            // tourismDatabaseDataSet
            // 
            this.tourismDatabaseDataSet.DataSetName = "tourismDatabaseDataSet";
            this.tourismDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationsPanel
            // 
            this.reservationsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.reservationsPanel.Controls.Add(this.abDataViewer);
            this.reservationsPanel.Location = new System.Drawing.Point(8, 108);
            this.reservationsPanel.Name = "reservationsPanel";
            this.reservationsPanel.Size = new System.Drawing.Size(1113, 332);
            this.reservationsPanel.TabIndex = 7;
            // 
            // abandonedBookingsTableAdapter
            // 
            this.abandonedBookingsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(89, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "Get Data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tourismDatabaseDataSet7
            // 
            this.tourismDatabaseDataSet7.DataSetName = "tourismDatabaseDataSet7";
            this.tourismDatabaseDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // abandonedBookingsBindingSource1
            // 
            this.abandonedBookingsBindingSource1.DataMember = "AbandonedBookings";
            this.abandonedBookingsBindingSource1.DataSource = this.tourismDatabaseDataSet7;
            // 
            // abandonedBookingsTableAdapter1
            // 
            this.abandonedBookingsTableAdapter1.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(717, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 52);
            this.button2.TabIndex = 9;
            this.button2.Text = "Reasons Report";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(558, 463);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 52);
            this.button3.TabIndex = 10;
            this.button3.Text = "Loss Report";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // S_abandonedBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reservationsPanel);
            this.Controls.Add(this.managerReservationsHeader);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "S_abandonedBookings";
            this.Size = new System.Drawing.Size(1375, 693);
            this.Load += new System.EventHandler(this.S_abandonedBookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abDataViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abandonedBookingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourismDatabaseDataSet)).EndInit();
            this.reservationsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tourismDatabaseDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abandonedBookingsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label managerReservationsHeader;
        private System.Windows.Forms.DataGridView abDataViewer;
        private System.Windows.Forms.Panel reservationsPanel;
        private tourismDatabaseDataSet tourismDatabaseDataSet;
        private System.Windows.Forms.BindingSource abandonedBookingsBindingSource;
        private tourismDatabaseDataSetTableAdapters.AbandonedBookingsTableAdapter abandonedBookingsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource abandonedBookingsBindingSource1;
        private tourismDatabaseDataSet7 tourismDatabaseDataSet7;
        private tourismDatabaseDataSet7TableAdapters.AbandonedBookingsTableAdapter abandonedBookingsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ABID;
        private System.Windows.Forms.DataGridViewTextBoxColumn abReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn abRefundCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn adRefundStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}