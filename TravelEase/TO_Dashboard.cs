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
            string connection = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            // string connection = "Data Source = LOQ - 15\\SQLEXPRESS; Initial Catalog = tourismDatabase";
            string query = "SELECT UserID, UName FROM UserInfo WHERE UName = @TourOperatorUsername";
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TourOperatorUsername", username);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string username = "Name: " + reader["UName"].ToString();
                name_lbl.Text = username;
            }
            else
            {
                name_lbl.Text = "Name: Not found";
            }
            reader.Close();
            conn.Close();
        }

        private void name_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
