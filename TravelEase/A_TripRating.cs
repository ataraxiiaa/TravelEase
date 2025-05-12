using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TravelEase
{
    public partial class A_TripRating : UserControl
    {
        private readonly int touristId;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;

        public A_TripRating(int userId)
        {
            InitializeComponent();
            touristId = userId;
            LoadTripIds(); // Load trips when control is initialized
        }

        private void A_TripRating_Load(object sender, EventArgs e)
        {
            // You can keep this empty or add additional initialization
        }

        private void LoadTripIds()
        {
            comboBoxTripID.Items.Clear();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"SELECT DISTINCT b.TripID 
                                   FROM TouristBooking b
                                   WHERE b.TouristID = @TouristID
                                   AND NOT EXISTS (
                                       SELECT 1 FROM TouristReviewTrip r 
                                       WHERE r.TouristID = b.TouristID 
                                       AND r.TripID = b.TripID
                                   )";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TouristID", touristId);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBoxTripID.Items.Add(reader["TripID"].ToString());
                            }
                        }
                    }
                }

                if (comboBoxTripID.Items.Count == 0)
                {
                    MessageBox.Show("No available trips to review or you've already reviewed all your trips");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading trips: {ex.Message}");
            }
        }

        private void approveButton_Click(object sender, EventArgs e)
        {
            // Validate trip selection
            if (comboBoxTripID.SelectedItem == null)
            {
                MessageBox.Show("Please select a trip to review");
                return;
            }

            // Validate rating
            if (!int.TryParse(textBoxRating.Text, out int rating) || rating < 1 || rating > 5)
            {
                MessageBox.Show("Please enter a valid rating between 1 and 5");
                return;
            }

            // Get values from controls
            int tripId = int.Parse(comboBoxTripID.SelectedItem.ToString());
            string comment = textBox1.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO TouristReviewTrip 
                                   (TouristID, TripID, TRComment, TRRating)
                                   VALUES 
                                   (@TouristID, @TripID, @Comment, @Rating)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TouristID", touristId);
                        command.Parameters.AddWithValue("@TripID", tripId);
                        command.Parameters.AddWithValue("@Comment", comment);
                        command.Parameters.AddWithValue("@Rating", rating);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thank you for your review!");
                            // Clear form for next review
                            comboBoxTripID.Items.Remove(tripId.ToString());
                            textBoxRating.Clear();
                            textBox1.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error submitting review: {ex.Message}");
            }
        }

        // Other event handlers can remain empty unless needed
        private void comboBoxTripID_SelectedIndexChanged(object sender, EventArgs e) {
            
        
        }
        private void textBoxRating_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void Reviews_lbl_Click(object sender, EventArgs e) { }
    }
}