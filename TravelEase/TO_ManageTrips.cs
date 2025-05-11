using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace TravelEase
{
    public partial class TO_ManageTrips : UserControl
    {
        int tourID;
        DataTable dt;
        public TO_ManageTrips(int tourID = 1)
        {
            InitializeComponent();
            this.tourID = tourID;
        }

        private void TO_ManageTrips_Load(object sender, EventArgs e)
        {
            this.filterComboBox.SelectedIndex = 0;
            LoadTrips();
        }
        private void LoadTrips()
        {
            string connection = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                string query = "SELECT * FROM Trip WHERE TourOperatorID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", tourID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                TripsDataGridView.DataSource = dt;
            }
        }
        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddTripbtn_Click(object sender, EventArgs e)
        {
            if (TripsDataGridView.CurrentRow == null || TripsDataGridView.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a trip to add and fill columns to add");
                return;
            }

            DataRow row = ((DataRowView)TripsDataGridView.CurrentRow.DataBoundItem).Row;

            string connection = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Trip 
                (TPrice, TDate, TGroupSize, TDuration, TRating, TDestination, TourOperatorID, TCCategoryID)
                VALUES (@price, @date, @groupSize, @duration, @rating, @destination, @operator, @category)", conn);

                cmd.Parameters.AddWithValue("@price", row["TPrice"]);
                cmd.Parameters.AddWithValue("@date", row["TDate"]);
                cmd.Parameters.AddWithValue("@groupSize", row["TGroupSize"]);
                cmd.Parameters.AddWithValue("@duration", row["TDuration"]);
                cmd.Parameters.AddWithValue("@rating", row["TRating"]);
                cmd.Parameters.AddWithValue("@destination", row["TDestination"]);
                cmd.Parameters.AddWithValue("@operator", this.tourID);
                cmd.Parameters.AddWithValue("@category", row["TCCategoryID"]);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Trip added successfully.");
        }

        private void deleteTripbtn_Click(object sender, EventArgs e)
        {

            if (TripsDataGridView.SelectedRows.Count > 0)
            {
                int tripId = Convert.ToInt32(TripsDataGridView.SelectedRows[0].Cells["TripID"].Value);
                string connStr = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string query = "DELETE FROM Trip WHERE TripID = @id AND TourOperatorID = @opId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", tripId);
                    cmd.Parameters.AddWithValue("@opId", this.tourID);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadTrips();
                MessageBox.Show("Trip deleted successfully.");
            }
            else
            {
                MessageBox.Show("Please select a trip to delete.");
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadTrips();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
