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
    public partial class TourOperator : Form
    {
        private string TourOperatorUsername;
        private int id;
        public TourOperator(string username)
        {
            InitializeComponent();
            this.TourOperatorUsername = username;
        }
        private void LoadView(UserControl view)
        {
            panel4.Controls.Clear();
            view.Dock = DockStyle.Fill;
            panel4.Controls.Add(view);
            view.BringToFront();
        }
        private void TourOperator_Load(object sender, EventArgs e)
        {
            LoadView(new TO_Dashboard(this.TourOperatorUsername));
            string connection = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            // string connection = "Data Source = LOQ - 15\\SQLEXPRESS; Initial Catalog = tourismDatabase";
            string query = "SELECT UserID, UName FROM UserInfo WHERE UName = @TourOperatorUsername";
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TourOperatorUsername", TourOperatorUsername);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string username = "Hi, " + reader["UName"].ToString();
                this.TourOperatorUsername = username;
                this.id = Convert.ToInt32(reader["UserID"]);
                name_lbl.Text = username;
            }
            else
            {
                name_lbl.Text = "Name: Not found";
            }
            reader.Close();
            conn.Close();
        }

        private void Reviews_btn_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            LoadView(new TO_Dashboard(this.TourOperatorUsername));
        }

        private void Users_btn_Click(object sender, EventArgs e)
        {
            LoadView(new TO_Queries(this.id));
        }

        private void Trips_btn_Click(object sender, EventArgs e)
        {
            LoadView(new TO_ManageTrips(this.id));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Hotel hotel = new Hotel();
            hotel.Activate();
            hotel.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
