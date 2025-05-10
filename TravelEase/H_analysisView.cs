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

namespace TravelEase
{
    public partial class H_analysisView : UserControl
    {
        public H_analysisView()
        {
            InitializeComponent();
        }

        private void H_analysisView_Load(object sender, EventArgs e)
        {

        }

        private void getFeedbackButton_Click(object sender, EventArgs e)
        {

            string connection = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            string query = "SELECT s.ServiceID as [Service ID], tr.TRComment as Comments, t.TRating as [Trip Rating] FROM Services s, Trip t, TouristReviewTrip tr where s.TripID = t.TripID and tr.TripID = t.TripID";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                dt.Clear();
                adapt.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;  
                    dataGridView1.Refresh();

                    MessageBox.Show($"Retrieved {dt.Rows.Count} records successfully!");
                }
                else
                {
                    MessageBox.Show("No records found");
                }
            }
        }

        private void getRevenueButton_Click(object sender, EventArgs e)
        {
            string connection = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            string query = "select ServiceID as [Service ID], SPrice as [Service Price] from Services";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                dt.Clear();
                adapt.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();

                    MessageBox.Show($"Retrieved {dt.Rows.Count} records successfully");
                }
                else
                {
                    MessageBox.Show("No records found");
                }
            }
        }

        private void getOccupanyButton_Click(object sender, EventArgs e)
        {
            string connection = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            string query = "select ServiceID as [Hotel ID], (HRoomsOccupied * 100 / HRoomCount) as [Occupancy Rate] from Hotels";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                dt.Clear();
                adapt.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();

                    MessageBox.Show($"Retrieved {dt.Rows.Count} records successfully");
                }
                else
                {
                    MessageBox.Show("No records found");
                }
            }
        }
    }
}
