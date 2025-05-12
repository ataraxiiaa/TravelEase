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
    public partial class A_TransportRating : UserControl
    {
        private readonly int touristId;
        int serviceId;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
        public A_TransportRating(int userId)
        {
            InitializeComponent();
            touristId = userId;
            LoadTripIds(); // Load trips when control is initialized
        }

        private void LoadTripIds()
        {
            comboBoxTripID.Items.Clear();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"SELECT DISTINCT b.ServiceID 
                                   FROM ServiceReviews b
                                   Join Transport g on g.ServiceID = b.ServiceID
                                   WHERE b.TouristID = @TouristID
                                   AND NOT EXISTS (
                                       SELECT 1 FROM ServiceReviews r 
                                       WHERE r.TouristID = b.TouristID 
                                       AND r.ServiceID = b.ServiceID
                                   )";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ServiceID", serviceId);
                        command.Parameters.AddWithValue("@TouristID", touristId);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBoxTripID.Items.Add(reader["ServiceID"].ToString());
                            }
                        }
                    }
                }

                if (comboBoxTripID.Items.Count == 0)
                {
                    MessageBox.Show("No available guides to review or you've already reviewed all your trips");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading guides: {ex.Message}");
            }
        }
        private void A_TransportRating_Load(object sender, EventArgs e)
        {

        }

        private bool hasClearedSearchTextbox2 = false;



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void approveButton_Click(object sender, EventArgs e)
        {
            // Validate trip selection
            if (comboBoxTripID.SelectedItem == null)
            {
                MessageBox.Show("Please select a guide to review");
                return;
            }

            // Validate rating
            if (!int.TryParse(textBoxRating.Text, out int rating) || rating < 1 || rating > 5)
            {
                MessageBox.Show("Please enter a valid rating between 1 and 5");
                return;
            }

            // Get values from controls
            serviceId = int.Parse(comboBoxTripID.SelectedItem.ToString());
            string comment = textBox1.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO ServiceReviews 
                                   (SRATING, SComment, ServiceID,TouristID )
                                   VALUES 
                                   (@Rating, @Comment, @ServiceID, @TouristID)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Rating", rating);
                        command.Parameters.AddWithValue("@Comment", comment);
                        command.Parameters.AddWithValue("@ServiceID", serviceId);
                        command.Parameters.AddWithValue("@TouristID", touristId);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thank you for your review!");
                            // Clear form for next review
                            comboBoxTripID.Items.Remove(serviceId.ToString());
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

        private void comboBoxTripID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRating_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
