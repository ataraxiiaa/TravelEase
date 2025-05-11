namespace TravelEase
{
    partial class H_ratingReportForm
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
            this.touristReviewTripBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.touristReviewTripDataSet = new TravelEase.TouristReviewTripDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.touristReviewTripTableAdapter = new TravelEase.TouristReviewTripDataSetTableAdapters.TouristReviewTripTableAdapter();
            this.tourismDatabaseDataSet2 = new TravelEase.tourismDatabaseDataSet2();
            this.tourismDatabaseDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TouristReviewOperatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.touristReviewOperator = new TravelEase.TouristReviewOperator();
            this.touristReviewOperatorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.touristReviewOperatorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.touristReviewTripBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.touristReviewTripDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourismDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourismDatabaseDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TouristReviewOperatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.touristReviewOperator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.touristReviewOperatorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.touristReviewOperatorBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // touristReviewTripBindingSource
            // 
            this.touristReviewTripBindingSource.DataMember = "TouristReviewTrip";
            this.touristReviewTripBindingSource.DataSource = this.touristReviewTripDataSet;
            // 
            // touristReviewTripDataSet
            // 
            this.touristReviewTripDataSet.DataSetName = "TouristReviewTripDataSet";
            this.touristReviewTripDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.touristReviewOperatorBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TravelEase.H_ratingReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(196, 85);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(827, 441);
            this.reportViewer1.TabIndex = 0;
            // 
            // touristReviewTripTableAdapter
            // 
            this.touristReviewTripTableAdapter.ClearBeforeFill = true;
            // 
            // tourismDatabaseDataSet2
            // 
            this.tourismDatabaseDataSet2.DataSetName = "tourismDatabaseDataSet2";
            this.tourismDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tourismDatabaseDataSet2BindingSource
            // 
            this.tourismDatabaseDataSet2BindingSource.DataSource = this.tourismDatabaseDataSet2;
            this.tourismDatabaseDataSet2BindingSource.Position = 0;
            // 
            // TouristReviewOperatorBindingSource
            // 
            this.TouristReviewOperatorBindingSource.DataMember = "TouristReviewOperator";
            this.TouristReviewOperatorBindingSource.DataSource = this.tourismDatabaseDataSet2;
            // 
            // touristReviewOperator
            // 
            this.touristReviewOperator.DataSetName = "TouristReviewOperator";
            this.touristReviewOperator.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // touristReviewOperatorBindingSource1
            // 
            this.touristReviewOperatorBindingSource1.DataSource = this.touristReviewOperator;
            this.touristReviewOperatorBindingSource1.Position = 0;
            // 
            // touristReviewOperatorBindingSource2
            // 
            this.touristReviewOperatorBindingSource2.DataSource = this.touristReviewOperator;
            this.touristReviewOperatorBindingSource2.Position = 0;
            // 
            // H_ratingReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1357, 646);
            this.Controls.Add(this.reportViewer1);
            this.Name = "H_ratingReportForm";
            this.Text = "H_ratingReportForm";
            this.Load += new System.EventHandler(this.H_ratingReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.touristReviewTripBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.touristReviewTripDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourismDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourismDatabaseDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TouristReviewOperatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.touristReviewOperator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.touristReviewOperatorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.touristReviewOperatorBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private TouristReviewTripDataSet touristReviewTripDataSet;
        private System.Windows.Forms.BindingSource touristReviewTripBindingSource;
        private TouristReviewTripDataSetTableAdapters.TouristReviewTripTableAdapter touristReviewTripTableAdapter;
        private System.Windows.Forms.BindingSource tourismDatabaseDataSet2BindingSource;
        private tourismDatabaseDataSet2 tourismDatabaseDataSet2;
        private System.Windows.Forms.BindingSource TouristReviewOperatorBindingSource;
        private System.Windows.Forms.BindingSource touristReviewOperatorBindingSource1;
        private TouristReviewOperator touristReviewOperator;
        private System.Windows.Forms.BindingSource touristReviewOperatorBindingSource2;
    }
}