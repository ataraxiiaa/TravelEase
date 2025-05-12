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
    public partial class A_ManageTrips : UserControl
    {
        public A_ManageTrips()
        {
            InitializeComponent();
        }

        void LoadAllTrips()
        {
            string query = "SELECT * FROM Trip";
            string connection = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            using(SqlConnection conn = new SqlConnection(connection))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                TripsDataGridView.DataSource = dt;
            }
        }
        private void A_ManageTrips_Load(object sender, EventArgs e)
        {
            this.filterComboBox.SelectedIndex = 0;
            LoadAllTrips();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void searchTextBox_GotFocus(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "Search for Trips...")
            {
                searchTextBox.Text = "";
                searchTextBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void searchTextBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                searchTextBox.Text = "Search for Trips...";
                searchTextBox.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadAllTrips();
        }

        private void AddTripbtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteTripbtn_Click(object sender, EventArgs e)
        {
            if (TripsDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a trip to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tripId = Convert.ToInt32(TripsDataGridView.SelectedRows[0].Cells["TripID"].Value);
            string connection = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            string query = "DELETE FROM Trip WHERE TripID = @TripID";

            DialogResult result = MessageBox.Show("Are you sure you want to delete this trip?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            using (SqlConnection conn = new SqlConnection(connection))
            {
             conn.Open();
             SqlCommand cmd = new SqlCommand(query, conn);
             cmd.Parameters.AddWithValue("@TripID", tripId);

             int rowsAffected = cmd.ExecuteNonQuery();
             if (rowsAffected > 0)
             {
                 MessageBox.Show("Trip deleted successfully.");
                 LoadAllTrips(); // Refresh
             }
             else
             {
                 MessageBox.Show("Trip not found or couldn't be deleted.");
             }
            }
        }
    }
}
