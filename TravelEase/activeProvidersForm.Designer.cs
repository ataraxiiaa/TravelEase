namespace TravelEase
{
    partial class activeProvidersForm
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
            this.growthChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.growthChart)).BeginInit();
            this.SuspendLayout();
            // 
            // growthChart
            // 
            chartArea1.Name = "ChartArea1";
            this.growthChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.growthChart.Legends.Add(legend1);
            this.growthChart.Location = new System.Drawing.Point(3, 0);
            this.growthChart.Name = "growthChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.growthChart.Series.Add(series1);
            this.growthChart.Size = new System.Drawing.Size(801, 448);
            this.growthChart.TabIndex = 0;
            this.growthChart.Text = "chart1";
            this.growthChart.Click += new System.EventHandler(this.growthChart_Click);
            // 
            // activeProvidersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.growthChart);
            this.Name = "activeProvidersForm";
            this.Text = "activeProvidersForm";
            this.Load += new System.EventHandler(this.activeProvidersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.growthChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart growthChart;
    }
}