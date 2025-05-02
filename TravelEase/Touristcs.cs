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
        public Touristcs()
        {
            InitializeComponent();
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
            LoadView(new A_TripSearchBook());
        }

        private void Users_btn_Click(object sender, EventArgs e)
        {
            LoadView(new A_Passes());
        }

        private void Trips_btn_Click(object sender, EventArgs e)
        {
            LoadView(new A_Review_A_Trip(this));
        }


        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadView(new A_Profile());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadView(new A_TripDashboard(this));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
