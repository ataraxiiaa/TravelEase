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
    }
}
