using System;
using System.Collections;
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
using Microsoft.ReportingServices.Diagnostics.Internal;

namespace TravelEase
{
    public partial class TO_Dashboard : UserControl
    {
        private int id;
        private string username;

        public TO_Dashboard(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void TO_Dashboard_Load(object sender, EventArgs e)
        {
            name_lbl.Text = "Name: " + username;

            string query = @"
            SELECT u.UserID, c.CName 
            FROM UserInfo u
            JOIN TourOperator t ON u.UserID = t.TourOperatorID
            JOIN CompanyProfile c ON t.CProfileID = c.CProfileID
            WHERE u.UName = @TourOperatorUsername";

            string connection = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connection))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@TourOperatorUsername", username);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    companyname_lbl.Text = "Company Name: " + reader["CName"].ToString();
                    this.id = Convert.ToInt32(reader["UserID"]);
                }
                else
                {
                    name_lbl.Text = "Hi, Unknown";
                    companyname_lbl.Text = "Company not found";
                }
                reader.Close();
                string ratingQuery = "SELECT AVG(ORRating) AS AvgRating FROM TouristReviewOperator WHERE OperatorID = @OperatorID";
                SqlCommand ratingCmd = new SqlCommand(ratingQuery, conn);
                ratingCmd.Parameters.AddWithValue("@OperatorID", this.id);

                object result = ratingCmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    double avgRating = Convert.ToDouble(result);
                    torating_lbl.Text = $"Rating: {avgRating:F1} / 5";
                }
                else
                {
                    torating_lbl.Text = "Avg. Rating: N/A";
                }
            }
            string responseTimeQuery = @"
                SELECT AVG(DATEDIFF(SECOND, QGenerationTime, ResponseTime)) AS AvgResponseTimeSeconds 
                FROM Queries 
                WHERE TourOperatorID = @TOID 
                AND Response IS NOT NULL 
                AND ResponseTime IS NOT NULL";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(responseTimeQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@TOID", this.id); 
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        int avgSeconds = Convert.ToInt32(result);
                        TimeSpan responseTime = TimeSpan.FromSeconds(avgSeconds);
                        avgresponse_lbl.Text = $"Avg Response Time: {responseTime.Hours}h {responseTime.Minutes}m {responseTime.Seconds}s";
                    }
                    else
                    {
                        avgresponse_lbl.Text = "Avg Response Time: No data";
                    }
                }
            }
        }


        private void name_lbl_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Hotel hotel = new Hotel();
            hotel.Show();
        }
    }
}
