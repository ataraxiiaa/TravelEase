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
    public partial class A_Dashboard : UserControl
    {
        public A_Dashboard()
        {
            InitializeComponent();
            this.Load += A_Dashboard_Load;
        }

        private void A_Dashboard_Load(object sender, EventArgs e)
        {
            string connection = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            // string connection = "Data Source = LOQ - 15\\SQLEXPRESS; Initial Catalog = tourismDatabase";
            string query = "SELECT TOP 1 ModID, MUsername FROM Moderator"; // change later
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string modID = "Admin ID: " + reader["ModID"].ToString();
                string username = "Name: " + reader["MUsername"].ToString();
                lblAdminID.Text = modID;
                lblName.Text = username;
            }
            else
            {
                lblAdminID.Text = "Admin ID: Not found";
                lblName.Text = "Name: Not found";
            }
            reader.Close();
            conn.Close();
        }
        private void Dasboard_lbl_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
