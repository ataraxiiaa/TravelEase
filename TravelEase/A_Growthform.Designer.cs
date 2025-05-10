namespace TravelEase
{
    partial class A_Growthform
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.growthData = new TravelEase.growthData();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.growthChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.growthData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.growthChart)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.growthData;
            // 
            // growthData
            // 
            this.growthData.DataSetName = "growthData";
            this.growthData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TravelEase.A_growthreport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1081, 529);
            this.reportViewer1.TabIndex = 0;
            // 
            // growthChart
            // 
            this.growthChart.AllowDrop = true;
            chartArea1.Name = "ChartArea1";
            this.growthChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.growthChart.Legends.Add(legend1);
            this.growthChart.Location = new System.Drawing.Point(0, 24);
            this.growthChart.Name = "growthChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.growthChart.Series.Add(series1);
            this.growthChart.Size = new System.Drawing.Size(1081, 505);
            this.growthChart.TabIndex = 1;
            this.growthChart.Text = "growthChart";
            this.growthChart.Click += new System.EventHandler(this.growthChart_Click);
            // 
            // A_Growthform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 529);
            this.Controls.Add(this.growthChart);
            this.Controls.Add(this.reportViewer1);
            this.Name = "A_Growthform";
            this.Text = "A_Growthform";
            this.Load += new System.EventHandler(this.A_Growthform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            // ((System.ComponentModel.ISupportInitialize)(this.growthData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.growthChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private growthData growthData;
        private System.Windows.Forms.DataVisualization.Charting.Chart growthChart;
    }
}