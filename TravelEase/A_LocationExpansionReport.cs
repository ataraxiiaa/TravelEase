using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TravelEase.growthDataTableAdapters;

namespace TravelEase
{
    public partial class A_LocationExpansionReport : Form
    {
        public A_LocationExpansionReport()
        {
            InitializeComponent();
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void A_LocationExpansionReport_Load(object sender, EventArgs e)
        {
            var adapter = new growthDataTableAdapters.TripTableAdapter();
            var data = adapter.newLocations();

            locationExpansion.Series.Clear();
            locationExpansion.ChartAreas.Clear();
            locationExpansion.Titles.Clear();

            ChartArea chartarea = new ChartArea("MainArea");


            chartarea.AxisX.Title = "Month";
            chartarea.AxisY.Title = "Number of New Locations";
            locationExpansion.ChartAreas.Add(chartarea);

            Series series = new Series("New Locations")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 3,
                Color = Color.SteelBlue,
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Int32
            };

            foreach(DataRow dataRow in data.Rows)
            {
                string month = dataRow["Month"].ToString();
                int count = Convert.ToInt32(dataRow["NewDestinations"]);
                series.Points.AddXY(month, count);
            }

            locationExpansion.Series.Add(series);
            locationExpansion.Titles.Add("Location Expansion Report");
            locationExpansion.Legends[0].Docking = Docking.Top;

        }
    }
}
