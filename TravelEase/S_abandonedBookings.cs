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
    public partial class S_abandonedBookings : UserControl
    {
        public S_abandonedBookings()
        {
            InitializeComponent();
        }

        private void managerReservationsHeader_Click(object sender, EventArgs e)
        {

        }

        private void S_abandonedBookings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tourismDatabaseDataSet.AbandonedBookings' table. You can move, or remove it, as needed.
            this.abandonedBookingsTableAdapter.Fill(this.tourismDatabaseDataSet.AbandonedBookings);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connection = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            string query = "SELECT * FROM AbandonedBookings";

            SqlConnection conn = new SqlConnection(connection);
            conn.Open();

            SqlDataAdapter adapt = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            abDataViewer.Columns.Clear();  // Clear previous columns
            abDataViewer.DataSource = dt;  // Bind data

            // Rename column headers AFTER binding
            abDataViewer.Columns["ABID"].HeaderText = "Abandoned Booking ID";
            abDataViewer.Columns["ABReason"].HeaderText = "Reason";
            abDataViewer.Columns["ABRefundCost"].HeaderText = "Refund Cost";
            abDataViewer.Columns["ABRefundStatus"].HeaderText = "Refund Status";
            abDataViewer.Columns["ABRefundStatus"].ReadOnly = true;
            abDataViewer.Columns["BookingID"].HeaderText = "Booking ID";



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            S_reasonReportForm s = new S_reasonReportForm();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            S_lossReportForm s = new S_lossReportForm();
            s.Show();
        }
    }
}
