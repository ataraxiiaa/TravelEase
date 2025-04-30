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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
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
             LoadView(new A_Dashboard()); 

        }

        private void Users_btn_Click(object sender, EventArgs e)
        {
            LoadView(new A_ManageUsers());
        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            LoadView(new A_Dashboard());
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
            LoadView(new A_Settings());
        }
    }
}
