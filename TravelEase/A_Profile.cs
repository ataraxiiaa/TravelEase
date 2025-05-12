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
    public partial class A_Profile : UserControl
    {
        private readonly int touristId;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
        public A_Profile(int touristID)
        {
            InitializeComponent();
            touristId = touristID;
            LoadTripIds();
        }

        private bool hasClearedSearchPreference = false;

        private void travelHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void LoadTripIds()
        {
            comboBox1.Items.Clear();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"SELECT DISTINCT TCName FROM TourCategories";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBox1.Items.Add(reader["TCName"].ToString());
                            }
                        }
                    }
                }

                if (comboBox1.Items.Count == 0)
                {
                    MessageBox.Show("No categories available.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories: {ex.Message}");
            }
        }

        private void approveButton_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            string selectedCategory = comboBox1.SelectedItem.ToString();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE Tourist SET TPreferredCategory = @Category WHERE TouristID = @TouristId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Category", selectedCategory);
                        command.Parameters.AddWithValue("@TouristId", touristId);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Preference updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No tourist found with the given ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating preference: {ex.Message}");
            }
        }

        private void history_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT t.TripID, t.TDuration, t.TDestination, t.TDate, t.TGroupSize
                FROM Trip t
                INNER JOIN TouristBooking tb ON t.TripID = tb.TripID    
                INNER JOIN Booking b ON b.BookingID = tb.BookingID
                WHERE tb.TouristID = @TouristId and b.BStatus ='True' and t.TDate < GETDATE()";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TouristId", touristId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    travelHistory.DataSource = dt;
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error: {sqlEx.Number} - {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void A_Profile_Load(object sender, EventArgs e)
        {
        }
    }
}