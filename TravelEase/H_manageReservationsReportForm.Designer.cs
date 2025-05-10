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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tourismDatabaseDataSet = new TravelEase.tourismDatabaseDataSet();
            this.tourismDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelsTableAdapter = new TravelEase.tourismDatabaseDataSetTableAdapters.HotelsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tourismDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourismDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.hotelsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TravelEase.H_ManageReservationsReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(559, 269);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // tourismDatabaseDataSet
            // 
            this.tourismDatabaseDataSet.DataSetName = "tourismDatabaseDataSet";
            this.tourismDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tourismDatabaseDataSetBindingSource
            // 
            this.tourismDatabaseDataSetBindingSource.DataSource = this.tourismDatabaseDataSet;
            this.tourismDatabaseDataSetBindingSource.Position = 0;
            // 
            // hotelsBindingSource
            // 
            this.hotelsBindingSource.DataMember = "Hotels";
            this.hotelsBindingSource.DataSource = this.tourismDatabaseDataSetBindingSource;
            // 
            // hotelsTableAdapter
            // 
            this.hotelsTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.tourismDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourismDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private tourismDatabaseDataSet tourismDatabaseDataSet;
        private System.Windows.Forms.BindingSource tourismDatabaseDataSetBindingSource;
        private System.Windows.Forms.BindingSource hotelsBindingSource;
        private tourismDatabaseDataSetTableAdapters.HotelsTableAdapter hotelsTableAdapter;
    }
}