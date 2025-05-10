using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TravelEase.growthDataTableAdapters;

namespace TravelEase
{
    public partial class activeProvidersForm : Form
    {
        public activeProvidersForm()
        {
            InitializeComponent();
        }

        private void activeProvidersForm_Load(object sender, EventArgs e)
        {
            var adapter = new UserInfoTableAdapter();
            var data = adapter.activeProviders();


            growthChart.Series.Clear();
            growthChart.ChartAreas.Clear();
            growthChart.Titles.Clear();


            var chartarea = new ChartArea("MainArea");
            growthChart.ChartAreas.Add(chartarea);


            var series = new Series("Active Providers");
            series.ChartType = SeriesChartType.Bar;
            series.XValueType = ChartValueType.String; 
            series.YValueType = ChartValueType.Int32;

            foreach (DataRow row in data.Rows)
            {
                string month = row["Month"].ToString();
                int count = Convert.ToInt32(row["ActiveProviders"]);
                series.Points.AddXY(month, count);
            }
            growthChart.Series.Add(series);


            growthChart.Titles.Add("Monthly Active Service Providers");



        }

        private void growthChart_Click(object sender, EventArgs e)
        {

        }
    }
}
