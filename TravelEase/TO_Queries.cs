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
    public partial class TO_Queries : UserControl
    {
        private int id;
        public TO_Queries(int id = 1)
        {
            InitializeComponent();
            this.id = id;
        }

        private void TO_Queries_Load(object sender, EventArgs e)
        {
            searchTextBox_LostFocus(sender, e);
            LoadQueries();
        }
        private void searchTextBox_GotFocus(object sender, EventArgs e)
        {
            if (searchTextbox.Text == "Search for Queries by id...")
            {
                searchTextbox.Text = "";
                searchTextbox.ForeColor = System.Drawing.Color.Black; 
            }
        }
        private void LoadQueries(string filter = "")
        {
            string connStr = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            string query = "SELECT QueryID, TouristID, QDescription, QStatus FROM Queries WHERE TourOperatorID = @toid";

            if (!string.IsNullOrEmpty(filter))
                query += " AND QueryID = @filterId";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@toid", id);
                if (!string.IsNullOrEmpty(filter))
                    cmd.Parameters.AddWithValue("@filterId", filter);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                queriesDataGridView.DataSource = dt;
            }
        }

        private void searchTextBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextbox.Text))
            {
                searchTextbox.Text = "Search for Queries by id..."; 
                searchTextbox.ForeColor = System.Drawing.Color.Gray; 
            }
        }

        private void usersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TO_Queries_Load_1(object sender, EventArgs e)
        {

        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchTextbox_Enter(object sender, EventArgs e)
        {
            if (searchTextbox.Text == "Search for Queries by id...")
            {
                searchTextbox.Text = "";
                searchTextbox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void searchTextbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextbox.Text))
            {
                searchTextbox.Text = "Search for Queries by id..."; 
                searchTextbox.ForeColor = System.Drawing.Color.Gray; 
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchId = searchTextbox.Text.Trim();
            if (searchId == "Search for Queries by id..." || string.IsNullOrWhiteSpace(searchId))
            {
                LoadQueries(); 
            }
            else
            {
                LoadQueries(searchId);
            }

        }

        private void approveButton_Click(object sender, EventArgs e)
        {
            if (queriesDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a query to respond to.");
                return;
            }

            string responseText = responseTextbox.Text.Trim();
            if (string.IsNullOrWhiteSpace(responseText))
            {
                MessageBox.Show("Please enter a response.");
                return;
            }

            int queryId = Convert.ToInt32(queriesDataGridView.SelectedRows[0].Cells["QueryID"].Value);

            string connStr = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            string updateQuery = @"UPDATE Queries 
                           SET Response = @response, 
                               QStatus = 1, 
                               ResponseTime = @responseTime 
                           WHERE QueryID = @queryId AND TourOperatorID = @toid";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
            {
                cmd.Parameters.AddWithValue("@response", responseText);
                cmd.Parameters.AddWithValue("@responseTime", DateTime.Now);
                cmd.Parameters.AddWithValue("@queryId", queryId);
                cmd.Parameters.AddWithValue("@toid", id);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Response submitted successfully.");
                    responseTextbox.Clear();
                    LoadQueries(); // Refresh the grid
                }
                else
                {
                    MessageBox.Show("Failed to submit response. Please try again.");
                }
            }
        }

    }
}
