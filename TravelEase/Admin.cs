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
using TravelEase;

namespace TravelEase
{
    public partial class Admin : Form
    {
        string adminUsername;
        public Admin(string username)
        {
            InitializeComponent();
            adminUsername = username;
        }
        private void LoadView(UserControl view)
        {
            panelMain.Controls.Clear();
            view.Dock = DockStyle.Fill;
            panelMain.Controls.Add(view);
            view.BringToFront();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            LoadView(new A_Dashboard(adminUsername));
            string connection = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            // string connection = "Data Source = LOQ - 15\\SQLEXPRESS; Initial Catalog = tourismDatabase";
            string query = "SELECT ModID, MUsername FROM Moderator WHERE MUsername = @adminUsername";
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@adminUsername", adminUsername);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string username = reader["MUsername"].ToString();
                username_lbl.Text = username;
            }
            else
            {
                username_lbl.Text = "Name: Not found";
            }
            reader.Close();
            conn.Close();

        }

        private void Users_btn_Click(object sender, EventArgs e)
        {
            LoadView(new A_ManageUsers());
        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            LoadView(new A_Dashboard(adminUsername));
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_btn_MouseLeave(object sender, EventArgs e)
        {
            Dashboard_btn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Users_btn_MouseLeave(object sender, EventArgs e)
        {
            Users_btn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            Trips_btn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Reviews_btn_MouseLeave(object sender, EventArgs e)
        {
            Reviews_btn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Trips_btn_Click(object sender, EventArgs e)
        {
            LoadView(new A_ManageTrips());
        }

        private void Reviews_btn_Click(object sender, EventArgs e)
        {
            LoadView(new A_Reviews());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // LoadView(new A_Settings());
            StartScreen s = new StartScreen();
            s.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
