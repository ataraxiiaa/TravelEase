using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TravelEase
{
    public partial class A_TripDashboard : UserControl
    {


        private Touristcs parentForm;
        private string connectionString = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
        private int loggedInTouristId;

        // Constructor accepts TouristId from login
        public A_TripDashboard(Touristcs parent, int touristId)
        {
            InitializeComponent();
            this.parentForm = parent;
            loggedInTouristId = touristId;
        }

        private void upcomingtrip_Click(object sender, EventArgs e)
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
                WHERE tb.TouristID = @TouristId"; // AND b.BStatus = 1";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TouristId", loggedInTouristId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    queriesDataGridView.DataSource = dt;
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


        private void booktrip_Click(object sender, EventArgs e)
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
                WHERE tb.TouristID = @TouristId and b.BStatus ='True'"; // AND b.BStatus = 1";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TouristId", loggedInTouristId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    queriesDataGridView.DataSource = dt;
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

        private void canceltrip_Click(object sender, EventArgs e)
        {

            //parentForm.LoadView2(new A_CancelTrip());
            // Validate input
            if (string.IsNullOrWhiteSpace(textBoxCancelTrip.Text) || textBoxCancelTrip.Text == "Enter Trip ID to cancel")
            {
                MessageBox.Show("Please enter a valid Trip ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBoxCancelTrip.Text, out int tripId))
            {
                MessageBox.Show("Please enter a numeric Trip ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if this trip belongs to the logged-in tourist
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // First verify the trip exists and belongs to this tourist
                    string verifyQuery = @"
                SELECT COUNT(*) 
                FROM TouristBooking tb
                INNER JOIN Booking b ON tb.BookingID = b.BookingID
                WHERE tb.TouristID = @TouristId AND tb.TripID = @TripId";

                    SqlCommand verifyCmd = new SqlCommand(verifyQuery, conn);
                    verifyCmd.Parameters.AddWithValue("@TouristId", loggedInTouristId);
                    verifyCmd.Parameters.AddWithValue("@TripId", tripId);

                    int count = (int)verifyCmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("No booking found for this Trip ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Get the BookingID first (we'll need it for both deletions)
                    string getBookingIdQuery = "SELECT BookingID FROM TouristBooking WHERE TouristID = @TouristId AND TripID = @TripId";
                    SqlCommand getBookingIdCmd = new SqlCommand(getBookingIdQuery, conn);
                    getBookingIdCmd.Parameters.AddWithValue("@TouristId", loggedInTouristId);
                    getBookingIdCmd.Parameters.AddWithValue("@TripId", tripId);

                    int bookingId = (int)getBookingIdCmd.ExecuteScalar();

                    // Start transaction to ensure both deletions happen or neither
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // First delete from TouristBooking
                        string deleteTouristBookingQuery = "DELETE FROM TouristBooking WHERE BookingID = @BookingId AND TouristID = @TouristId";
                        SqlCommand deleteTouristBookingCmd = new SqlCommand(deleteTouristBookingQuery, conn, transaction);
                        deleteTouristBookingCmd.Parameters.AddWithValue("@BookingId", bookingId);
                        deleteTouristBookingCmd.Parameters.AddWithValue("@TouristId", loggedInTouristId);
                        deleteTouristBookingCmd.ExecuteNonQuery();

                        // Then delete from Booking
                        string deleteBookingQuery = "DELETE FROM Booking WHERE BookingID = @BookingId";
                        SqlCommand deleteBookingCmd = new SqlCommand(deleteBookingQuery, conn, transaction);
                        deleteBookingCmd.Parameters.AddWithValue("@BookingId", bookingId);
                        deleteBookingCmd.ExecuteNonQuery();

                        // Commit transaction if both deletions succeeded
                        transaction.Commit();

                        MessageBox.Show("Trip cancelled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh the upcoming trips view
                        upcomingtrip_Click(sender, e);
                    }
                    catch
                    {
                        // Roll back if any error occurs
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while cancelling the trip: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void A_TripDashboard_Load(object sender, EventArgs e)
        {

        }

        private void textBoxCancelTrip_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
