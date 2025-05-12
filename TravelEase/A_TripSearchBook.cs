// A_TripSearchBook.cs
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TravelEase
{
    public partial class A_TripSearchBook : UserControl
    {
        private int loggedInTouristId;
        public A_TripSearchBook(int touristId)
        {
            InitializeComponent();
            this.Load += A_TripSearchBook_Load;
            loggedInTouristId = touristId;
            button1.Click += button1_Click;
        }

        private void A_TripSearchBook_Load(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();

                // Populate Date dropdown
                FillCombo(conn,
                          "SELECT DISTINCT CAST(TDate AS DATE) AS TDate FROM Trip",
                          comboBoxDate, "TDate", "TDate");

                // Populate Destination dropdown
                FillCombo(conn,
                          "SELECT DISTINCT TDestination FROM Trip",
                          comboBoxDestination, "TDestination", "TDestination");

                // Populate Group Size dropdown
                FillCombo(conn,
                          "SELECT DISTINCT TGroupSize FROM Trip",
                          comboBoxGroupSize, "TGroupSize", "TGroupSize");

                // Populate Duration dropdown
                FillCombo(conn,
                          "SELECT DISTINCT TDuration FROM Trip",
                          comboBoxDuration, "TDuration", "TDuration");

                // Populate Rating dropdown
                FillCombo(conn,
                          "SELECT DISTINCT TRating FROM Trip",
                          comboBoxRating, "TRating", "TRating");

                // Populate Activity Type dropdown (via TourCategories)
                using (var cmd = new SqlCommand(
                    "SELECT DISTINCT c.TCName FROM Trip t " +
                    "JOIN TourCategories c ON t.TCCategoryID = c.TCategoryID", conn))
                {
                    var dt = new DataTable();
                    new SqlDataAdapter(cmd).Fill(dt);
                    comboBoxActivityType.DataSource = dt;
                    comboBoxActivityType.DisplayMember = "TCName";
                    comboBoxActivityType.ValueMember = "TCName";
                    comboBoxActivityType.SelectedIndex = -1;
                }
            }
        }

        private void FillCombo(SqlConnection conn, string sql, ComboBox cb, string disp, string val)
        {
            using (var da = new SqlDataAdapter(sql, conn))
            {
                var dt = new DataTable();
                da.Fill(dt);
                cb.DataSource = dt;
                cb.DisplayMember = disp;
                cb.ValueMember = val;
                cb.SelectedIndex = -1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            string sql =
                "SELECT t.TripID, t.TDestination, t.TDuration, t.TGroupSize, " +
                "c.TCName AS ActivityType, t.TRating, t.TDate " +
                "FROM Trip t " +
                "JOIN TourCategories c ON t.TCCategoryID = c.TCategoryID " +
                "WHERE 1=1";

            var parameters = new List<SqlParameter>();

            if (comboBoxDate.SelectedIndex != -1)
            {
                sql += " AND CAST(t.TDate AS DATE) = CAST(@TDate AS DATE)";
                parameters.Add(new SqlParameter("@TDate", comboBoxDate.SelectedValue));
            }
            if (comboBoxDestination.SelectedIndex != -1)
            {
                sql += " AND t.TDestination = @Destination";
                parameters.Add(new SqlParameter("@Destination", comboBoxDestination.SelectedValue));
            }
            if (comboBoxGroupSize.SelectedIndex != -1)
            {
                sql += " AND t.TGroupSize = @GroupSize";
                parameters.Add(new SqlParameter("@GroupSize", comboBoxGroupSize.SelectedValue));
            }
            if (comboBoxDuration.SelectedIndex != -1)
            {
                sql += " AND t.TDuration = @Duration";
                parameters.Add(new SqlParameter("@Duration", comboBoxDuration.SelectedValue));
            }
            if (comboBoxRating.SelectedIndex != -1)
            {
                sql += " AND t.TRating = @Rating";
                parameters.Add(new SqlParameter("@Rating", comboBoxRating.SelectedValue));
            }
            if (comboBoxActivityType.SelectedIndex != -1)
            {
                sql += " AND c.TCName = @ActivityType";
                parameters.Add(new SqlParameter("@ActivityType", comboBoxActivityType.SelectedValue));
            }

            DataTable results = new DataTable();
            try
            {
                using (var conn = new SqlConnection(connStr))
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                    new SqlDataAdapter(cmd).Fill(results);
                }

                // Bind to DataGridView:
                dataGridViewResults.DataSource = results;

                if (results.Rows.Count == 0)
                {
                    MessageBox.Show("No matching trips found.", "No Results",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search failed: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TripIdBook_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void A_TripSearchBook_Load_1(object sender, EventArgs e)
        {

        }

        private void buttonBook_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(TripIdBook.Text, out int tripId))
            {
                MessageBox.Show("Please enter a numeric Trip ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            string connStr = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();

                // First verify the trip exists and has available spots
        //        string verifyQuery = @"
        //SELECT TAvailableSpots 
        //FROM Trip 
        //WHERE TripID = @TripId";

        //        SqlCommand verifyCmd = new SqlCommand(verifyQuery, conn);
        //        verifyCmd.Parameters.AddWithValue("@TripId", tripId);

        //        int availableSpots = (int)verifyCmd.ExecuteScalar();

        //        if (availableSpots <= 0)
        //        {
        //            MessageBox.Show("No available spots left for this trip", "Error",
        //                           MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }

                // Start transaction to ensure all operations complete successfully
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. Create a new booking record
                    string insertBookingQuery = @"
            INSERT INTO Booking (BStatus, BDate) 
            VALUES (0, @BookingDate); 
            SELECT SCOPE_IDENTITY();"; // Get the new BookingID

                    SqlCommand insertBookingCmd = new SqlCommand(insertBookingQuery, conn, transaction);
                    insertBookingCmd.Parameters.AddWithValue("@BookingDate", DateTime.Now);
                    int bookingId = Convert.ToInt32(insertBookingCmd.ExecuteScalar());

                    // 2. Create the tourist booking relationship
                    string insertTouristBookingQuery = @"
            INSERT INTO TouristBooking (TouristID, BookingID, TripID)
            VALUES (@TouristId, @BookingId, @TripId)";

                    SqlCommand insertTouristBookingCmd = new SqlCommand(insertTouristBookingQuery, conn, transaction);
                    insertTouristBookingCmd.Parameters.AddWithValue("@TouristId", loggedInTouristId);
                    insertTouristBookingCmd.Parameters.AddWithValue("@BookingId", bookingId);
                    insertTouristBookingCmd.Parameters.AddWithValue("@TripId", tripId);
                    insertTouristBookingCmd.ExecuteNonQuery();

                    // 3. Update available spots in the trip
            //        string updateTripQuery = @"
            //UPDATE Trip 
            //SET TAvailableSpots = TAvailableSpots - 1 
            //WHERE TripID = @TripId";

                    //SqlCommand updateTripCmd = new SqlCommand(updateTripQuery, conn, transaction);
                    //updateTripCmd.Parameters.AddWithValue("@TripId", tripId);
                    //updateTripCmd.ExecuteNonQuery();

                    // Commit transaction if all operations succeeded
                    transaction.Commit();

                    MessageBox.Show("Trip booked successfully!", "Success",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the upcoming trips view
                    // upcomingtrip_Click(sender, e);
                }
                catch (Exception ex)
                {
                    // Roll back if any error occurs
                    transaction.Rollback();
                    MessageBox.Show("Booking failed: " + ex.Message, "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void TripIdBook_TextChanged_1(object sender, EventArgs e)
        {

        }

    }
}
