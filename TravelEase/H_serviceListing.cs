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
    public partial class H_serviceListing : UserControl
    {
        public H_serviceListing()
        {
            InitializeComponent();
            option = 1;
        }

        private void H_serviceListing_Load(object sender, EventArgs e)
        {

        }

        private void managerReservationsHeader_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            option = 1;
            string connection = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            string query = "SELECT * FROM Hotels";  // or SELECT ServiceID, HRoomCount FROM Hotels

            SqlConnection conn = new SqlConnection(connection);
            conn.Open();

            SqlDataAdapter adapt = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            hotelData.Columns.Clear();  // Clear previous columns
            hotelData.DataSource = dt;  // Bind data

            // Rename column headers AFTER binding
            hotelData.Columns["ServiceID"].HeaderText = "Hotel ID";
            hotelData.Columns["HRoomCount"].HeaderText = "Total Rooms";
            hotelData.Columns["HRoomsOccupied"].HeaderText = "Rooms Occupied";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hotelData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (option == 1)
            {
                S_hotelServiceReportForm h = new S_hotelServiceReportForm();
                h.Show();

            }
            else if (option == 2)
            {
                S_transportReportForm h = new S_transportReportForm();
                h.Show();
            }
            else if (option == 3)
            {
                S_guideReportForm h = new S_guideReportForm();
                h.Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            option = 2;
            string connection = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            string query = "SELECT * FROM Transport";  // or SELECT ServiceID, HRoomCount FROM Hotels

            SqlConnection conn = new SqlConnection(connection);
            conn.Open();

            SqlDataAdapter adapt = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            hotelData.Columns.Clear();  // Clear previous columns
            hotelData.DataSource = dt;  // Bind data

            // Rename column headers AFTER binding
            hotelData.Columns["ServiceID"].HeaderText = "Transport ID";
            hotelData.Columns["TType"].HeaderText = "Transport Type";
            hotelData.Columns["OnTime"].HeaderText = "On Time";

            hotelData.Columns["OnTime"].ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            option = 3;
            string connection = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            string query = "SELECT * FROM Guide";  // or SELECT ServiceID, HRoomCount FROM Hotels

            SqlConnection conn = new SqlConnection(connection);
            conn.Open();

            SqlDataAdapter adapt = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            hotelData.Columns.Clear();  // Clear previous columns
            hotelData.DataSource = dt;  // Bind data

            // Rename column headers AFTER binding
            hotelData.Columns["ServiceID"].HeaderText = "Guide ID";
            hotelData.Columns["GName"].HeaderText = "Guide Name";
        }
    }
}
