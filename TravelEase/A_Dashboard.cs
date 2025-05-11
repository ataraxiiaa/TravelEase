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
        string adminUsername;
        public A_Dashboard(string username)
        {
            InitializeComponent();
            this.Load += A_Dashboard_Load;
            adminUsername = username;
        }

        private void A_Dashboard_Load(object sender, EventArgs e)
        {
            string connection = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            string query = "SELECT ModID, MUsername FROM Moderator WHERE MUsername = @adminUsername";

            using (SqlConnection conn = new SqlConnection(connection))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@adminUsername", adminUsername);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lblAdminID.Text = "Admin ID: " + reader["ModID"].ToString();
                        lblName.Text = "Name: " + reader["MUsername"].ToString();
                    }
                    else
                    {
                        lblAdminID.Text = "ERROR: 909";
                        lblName.Text = "ERROR: 910";
                    }
                }
            }
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

        private void usrreports_btn_Click(object sender, EventArgs e)
        {
            A_Growthform a = new A_Growthform();
            a.Show();
            a.BringToFront();
        }

        private void activerep_btn_Click(object sender, EventArgs e)
        {
            ActiveReportForm a = new ActiveReportForm();
            a.Show();
            a.BringToFront();
        }

        private void patnerrprt_btn_Click(object sender, EventArgs e)
        {
            activeProvidersForm a = new activeProvidersForm();
            a.Show();
            a.BringToFront();
        }

        private void rgnlExpansion_btn_Click(object sender, EventArgs e)
        {
            A_LocationExpansionReport r = new A_LocationExpansionReport();
            r.Show();
            r.BringToFront();
        }
    }
}
