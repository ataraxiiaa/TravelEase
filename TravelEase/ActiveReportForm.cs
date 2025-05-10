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
    public partial class ActiveReportForm : Form
    {
        public ActiveReportForm()
        {
            InitializeComponent();
        }

        private void ActiveReportForm_Load(object sender, EventArgs e)
        {
            var adapter = new UserInfoTableAdapter();
            var data = adapter.activeUsers();

            activeUsersChart.Series.Clear();
            activeUsersChart.ChartAreas.Clear();
            activeUsersChart.ChartAreas.Add("MainArea");

            var travelerSeries = new Series("Active Travelers")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 3,
                Color = Color.SteelBlue
            };

            var operatorSeries = new Series("Active Operators")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 3,
                Color = Color.OrangeRed
            };

            foreach (DataRow row in data.Rows)
            {
                string month = row["Month"].ToString();
                travelerSeries.Points.AddXY(month, Convert.ToInt32(row["ActiveTravelers"]));
                operatorSeries.Points.AddXY(month, Convert.ToInt32(row["ActiveOperators"]));
            }

            activeUsersChart.Series.Add(travelerSeries);
            activeUsersChart.Series.Add(operatorSeries);

            activeUsersChart.ChartAreas[0].AxisX.Title = "Month";
            activeUsersChart.ChartAreas[0].AxisY.Title = "Number of Active Users";
            activeUsersChart.Legends[0].Docking = Docking.Top;
        }

        private void activeUsersChart_Click(object sender, EventArgs e)
        {

        }
    }
}
