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

        public TO_Dashboard(string username = "")
        {
            InitializeComponent();
            this.username = username;
        }

        private void TO_Dashboard_Load(object sender, EventArgs e)
        {
            string connection = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            string query = @"SELECT TO.TourOperatorID, UI.UName
                     FROM TourOperator TO
                     INNER JOIN UserInfo UI ON TO.TourOperatorID = UI.UserID
                     WHERE UI.UName = @username";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    id = reader.GetInt32(0); // TourOperatorID
                    name_lbl.Text = "Welcome, " + reader.GetString(1); // UName
                }
                else
                {
                    name_lbl.Text = "User not found";
                }

                reader.Close();
            }
        }

        private void name_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
