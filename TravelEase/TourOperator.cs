using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public TourOperator(string username)
        {
            InitializeComponent();
            TourOperatorUsername = username;
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
            LoadView(new TO_Dashboard());
        }

        private void Reviews_btn_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            LoadView(new TO_Dashboard());
        }

        private void Users_btn_Click(object sender, EventArgs e)
        {
            LoadView(new TO_Queries());
        }

        private void Trips_btn_Click(object sender, EventArgs e)
        {
            LoadView(new TO_ManageTrips());
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
    }
}
