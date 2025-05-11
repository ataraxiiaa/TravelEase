namespace TravelEase
{
    partial class A_LocationExpansionReport
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
            this.locationExpansion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.locationExpansion)).BeginInit();
            this.SuspendLayout();
            // 
            // locationExpansion
            // 
            chartArea1.Name = "ChartArea1";
            this.locationExpansion.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.locationExpansion.Legends.Add(legend1);
            this.locationExpansion.Location = new System.Drawing.Point(0, 0);
            this.locationExpansion.Name = "locationExpansion";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.locationExpansion.Series.Add(series1);
            this.locationExpansion.Size = new System.Drawing.Size(889, 483);
            this.locationExpansion.TabIndex = 0;
            this.locationExpansion.Text = "chart1";
            // 
            // A_LocationExpansionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 486);
            this.Controls.Add(this.locationExpansion);
            this.Name = "A_LocationExpansionReport";
            this.Text = "A_LocationExpansionReport";
            this.Load += new System.EventHandler(this.A_LocationExpansionReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.locationExpansion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart locationExpansion;
    }
}