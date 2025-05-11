namespace TravelEase
{
    partial class H_manageReservationsReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.hotelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourismDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourismDatabaseDataSet = new TravelEase.tourismDatabaseDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.hotelsTableAdapter = new TravelEase.tourismDatabaseDataSetTableAdapters.HotelsTableAdapter();
            this.hotelsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableAdapter = new TravelEase.tourismDatabaseDataSetTableAdapters.BookingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourismDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourismDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hotelsBindingSource
            // 
            this.hotelsBindingSource.DataMember = "Hotels";
            this.hotelsBindingSource.DataSource = this.tourismDatabaseDataSetBindingSource;
            // 
            // tourismDatabaseDataSetBindingSource
            // 
            this.tourismDatabaseDataSetBindingSource.DataSource = this.tourismDatabaseDataSet;
            this.tourismDatabaseDataSetBindingSource.Position = 0;
            // 
            // tourismDatabaseDataSet
            // 
            this.tourismDatabaseDataSet.DataSetName = "tourismDatabaseDataSet";
            this.tourismDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bookingBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TravelEase.H_ManageReservationsReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(147, 76);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(840, 478);
            this.reportViewer1.TabIndex = 0;
            // 
            // hotelsTableAdapter
            // 
            this.hotelsTableAdapter.ClearBeforeFill = true;
            // 
            // hotelsBindingSource1
            // 
            this.hotelsBindingSource1.DataMember = "Hotels";
            this.hotelsBindingSource1.DataSource = this.tourismDatabaseDataSetBindingSource;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.tourismDatabaseDataSetBindingSource;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // H_manageReservationsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1357, 646);
            this.Controls.Add(this.reportViewer1);
            this.Name = "H_manageReservationsReportForm";
            this.Text = "H_manageReservationsReportForm";
            this.Load += new System.EventHandler(this.H_manageReservationsReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourismDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourismDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private tourismDatabaseDataSet tourismDatabaseDataSet;
        private System.Windows.Forms.BindingSource tourismDatabaseDataSetBindingSource;
        private System.Windows.Forms.BindingSource hotelsBindingSource;
        private tourismDatabaseDataSetTableAdapters.HotelsTableAdapter hotelsTableAdapter;
        private System.Windows.Forms.BindingSource hotelsBindingSource1;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private tourismDatabaseDataSetTableAdapters.BookingTableAdapter bookingTableAdapter;
    }
}