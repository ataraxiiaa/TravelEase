﻿namespace TravelEase
{
    partial class ActiveReportForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.activeUsersChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.activeUsersChart)).BeginInit();
            this.SuspendLayout();
            // 
            // activeUsersChart
            // 
            chartArea1.Name = "ChartArea1";
            this.activeUsersChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.activeUsersChart.Legends.Add(legend1);
            this.activeUsersChart.Location = new System.Drawing.Point(-1, -1);
            this.activeUsersChart.Name = "activeUsersChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.activeUsersChart.Series.Add(series1);
            this.activeUsersChart.Size = new System.Drawing.Size(897, 540);
            this.activeUsersChart.TabIndex = 0;
            this.activeUsersChart.Text = "Active Users";
            this.activeUsersChart.Click += new System.EventHandler(this.activeUsersChart_Click);
            // 
            // ActiveReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 567);
            this.Controls.Add(this.activeUsersChart);
            this.Name = "ActiveReportForm";
            this.Text = "ActiveReportForm";
            this.Load += new System.EventHandler(this.ActiveReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activeUsersChart)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart activeUsersChart;
    }
}