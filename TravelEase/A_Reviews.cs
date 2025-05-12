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
    public partial class A_Reviews : UserControl
    {
        public A_Reviews()
        {
            InitializeComponent();
        }

        private void A_Reviews_Load(object sender, EventArgs e)
        {
            searchTextbox.Text = "Search for Reviews...";
            searchTextbox.ForeColor = Color.Gray;
            LoadTripReviews();
            LoadServiceReviews();
        }
        private void LoadTripReviews()
        {
            string connStr = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            string query = "SELECT TReviewID, TouristID, TripID, TRRating, TRComment FROM TouristReviewTrip";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tripReviewsDataGridView.DataSource = dt;
            }
        }

        private void LoadServiceReviews()
        {
            string connStr = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            string query = "SELECT SReviewID, TouristID, ServiceID, SRATING, SComment FROM ServiceReviews";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                serviceReviewsDataGridView.DataSource = dt;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            string id = searchTextbox.Text;
            string query;

            if (reviewsTabControl.SelectedTab == tripReviewsTab)
            {
                query = "SELECT * FROM TouristReviewTrip WHERE TReviewID = @id";
            }
            else if (reviewsTabControl.SelectedTab == serviceReviewsTab)
            {
                query = "SELECT * FROM ServiceReviews WHERE SReviewID = @id";
            }
            else
            {
                MessageBox.Show("Please select a valid tab to search.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    if (reviewsTabControl.SelectedTab == tripReviewsTab)
                    {
                        tripReviewsDataGridView.DataSource = dt;
                    }
                    else if (reviewsTabControl.SelectedTab == serviceReviewsTab)
                    {
                        serviceReviewsDataGridView.DataSource = dt;
                    }
                }
                else
                {
                    MessageBox.Show("No reviews found for the given Review ID.");
                }
            }
        }


        private void approveButton_Click(object sender, EventArgs e)
        {

        }

        private void tripReviewsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tripReviewsDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void searchTextBox_GotFocus(object sender, EventArgs e)
        {
            if (searchTextbox.Text == "Search for Reviews...")
            {
                searchTextbox.Text = "";
                searchTextbox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void searchTextBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextbox.Text))
            {
                searchTextbox.Text = "Search for Reviews...";
                searchTextbox.ForeColor = System.Drawing.Color.Gray;
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(reviewsTabControl.SelectedTab == tripReviewsTab)
            {
                if (tripReviewsDataGridView.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = tripReviewsDataGridView.SelectedRows[0].Index;
                    int reviewId = Convert.ToInt32(tripReviewsDataGridView.Rows[selectedRowIndex].Cells["TReviewID"].Value);
                    string connStr = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
                    string query = "DELETE FROM TouristReviewTrip WHERE TReviewID = @TReviewID";
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        SqlCommand cmd = new SqlCommand(query, conn);
                        query = "DELETE FROM ModeratorTripReviews where TReviewID = @TReviewID";
                        SqlCommand cmd1 = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@TReviewID", reviewId);
                        cmd1.Parameters.AddWithValue("@TReviewID", reviewId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        cmd1.ExecuteNonQuery();
                        conn.Close();
                    }
                    MessageBox.Show("Review deleted successfully.");
                    LoadTripReviews();
                }
                else
                {
                    MessageBox.Show("Please select a review to delete.");
                }
            }
            else if(reviewsTabControl.SelectedTab == serviceReviewsTab)
            {
                if (serviceReviewsDataGridView.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = serviceReviewsDataGridView.SelectedRows[0].Index;
                    int reviewId = Convert.ToInt32(serviceReviewsDataGridView.Rows[selectedRowIndex].Cells["SReviewID"].Value);
                    string connStr = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
                    string query = "DELETE FROM ServiceReviews WHERE SREVIEWID = @SReviewID";
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        SqlCommand cmd = new SqlCommand(query, conn);
                        query = "DELETE FROM ModerateServiceReviews where SReviewID = @SReviewID";
                        SqlCommand cmd1 = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@SReviewID", reviewId);
                        cmd1.Parameters.AddWithValue("@SReviewID", reviewId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        cmd1.ExecuteNonQuery();
                        conn.Close();
                    }
                    MessageBox.Show("Review deleted successfully.");
                    LoadServiceReviews();
                }
                else
                {
                    MessageBox.Show("Please select a review to delete.");
                }
            }
        }

        private void tripReviewsDataGridView_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Reviews_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
