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
    public partial class Touristcs : Form
    {
        int userId = -1;
        public Touristcs(int id)
        {
            InitializeComponent();
            userId = id;
        }
        private void LoadView(UserControl view)
        {
            panel1.Controls.Clear();
            view.Dock = DockStyle.Fill;
            panel1.Controls.Add(view);
            view.BringToFront();
        }
        public void LoadView2(UserControl view)
        {
            panel1.Controls.Clear();
            view.Dock = DockStyle.Fill;
            panel1.Controls.Add(view);
        }
        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            LoadView(new A_TripSearchBook(userId));
        }

        private void Users_btn_Click(object sender, EventArgs e)
        {
            LoadView(new A_Passes());
        }

        private void Trips_btn_Click(object sender, EventArgs e)
        {
            LoadView(new A_Review_A_Trip(this, userId));
        }


        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //LoadView(new A_Profile(userId));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadView(new A_TripDashboard(this, userId));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StartScreen s = new StartScreen();
            s.Show();
            this.Close();
        }
    }
}
