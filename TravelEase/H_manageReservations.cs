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
    public partial class H_manageReservations : UserControl
    {
        public H_manageReservations()
        {
            InitializeComponent();
            this.Load += H_manageReservations_Load;
        }

        private void H_manageReservations_Load(object sender, EventArgs e)
        {

        }

        private void Dasboard_lbl_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reservationsDataViewer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            string query = "SELECT BookingID, BDate, BStatus FROM Booking";

            SqlConnection conn = new SqlConnection(connection);
            conn.Open();

            SqlDataAdapter adapt = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            reservationsDataViewer.Columns.Clear();  // Clear previous columns
            reservationsDataViewer.DataSource = dt;  // Bind data

            // Rename column headers AFTER binding
            reservationsDataViewer.Columns["BookingID"].HeaderText = "Booking ID";
            reservationsDataViewer.Columns["BDate"].HeaderText = "Booking Date";
            reservationsDataViewer.Columns["BStatus"].HeaderText = "Booking Status";

            reservationsDataViewer.CellValueChanged += reservationsDataViewer_CellValueChanged;

            // Add the CurrentCellDirtyStateChanged event handler to commit changes for checkboxes
            reservationsDataViewer.CurrentCellDirtyStateChanged += (Sender, EventArgs) =>
            {
                if (reservationsDataViewer.IsCurrentCellDirty)
                    reservationsDataViewer.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };
        }

        private void reservationsDataViewer_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && reservationsDataViewer.Columns[e.ColumnIndex].Name == "BStatus")
            {
                bool isApproved = Convert.ToBoolean(reservationsDataViewer.Rows[e.RowIndex].Cells["BStatus"].Value);
                int bookingID = Convert.ToInt32(reservationsDataViewer.Rows[e.RowIndex].Cells["BookingID"].Value);

                string newStatus = isApproved ? "approved" : "rejected";

                UpdateBookingStatus(bookingID, isApproved, newStatus); 
                reservationsDataViewer.Rows[e.RowIndex].Cells["BStatus"].Value = isApproved;
            }
        }

        private void UpdateBookingStatus(int bookingID, bool isApproved, string newStatus)
        {
            string connection = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                int status = isApproved ? 1 : 0;

                string updateQuery = "UPDATE Booking SET BStatus = " + status + " WHERE BookingID = " + bookingID;

                // Debugging message
                MessageBox.Show("Booking " + bookingID.ToString() + " has been " + newStatus);

                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    // Pass the integer status (1 or 0) to the query
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@id", bookingID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
