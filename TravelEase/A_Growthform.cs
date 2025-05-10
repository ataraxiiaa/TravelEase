using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;

namespace TravelEase
{
    public partial class A_Growthform : Form
    {
        public A_Growthform()
        {
            InitializeComponent();
        }

        private void A_Growthform_Load(object sender, EventArgs e)
        {
            LoadNewRegistrations();
        }

        private void LoadNewRegistrations()
        {
            string connStr = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = @"
                    SELECT 
                        FORMAT(URegisterDate, 'yyyy-MM') AS Month,
                        COUNT(*) AS NewUsers
                    FROM UserInfo
                    GROUP BY FORMAT(URegisterDate, 'yyyy-MM')
                    ORDER BY Month";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);


                growthChart.Series.Clear();
                growthChart.ChartAreas.Clear();

                growthChart.ChartAreas.Add("MainArea");
                Series series = new Series("New Registrations");
                series.ChartType = SeriesChartType.Column;

                foreach (DataRow row in dt.Rows)
                {
                    series.Points.AddXY(row["Month"].ToString(), Convert.ToInt32(row["NewUsers"]));
                }

                growthChart.Series.Add(series);
                growthChart.ChartAreas["MainArea"].AxisX.Title = "Month";
                growthChart.ChartAreas["MainArea"].AxisY.Title = "New Users";
            }
        }

        private void growthChart_Click(object sender, EventArgs e)
        {

        }
    }
}
