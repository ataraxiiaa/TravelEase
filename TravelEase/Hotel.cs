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
    public partial class Hotel : Form
    {
        public Hotel()
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
        private void Hotel_Load(object sender, EventArgs e)
        {
            LoadView(new S_manageReservations());
        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            LoadView(new S_analysisView());
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void manageReservationsButton_Click(object sender, EventArgs e)
        {
            LoadView(new S_manageReservations());
        }

        private void serviceListingButton_Click(object sender, EventArgs e)
        {
            LoadView(new H_serviceListing());
        }

        private void abandonedButton_Click(object sender, EventArgs e)
        {
            LoadView(new S_abandonedBookings());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StartScreen s = new StartScreen();
            s.Show();
            this.Close();
        }
    }
}
