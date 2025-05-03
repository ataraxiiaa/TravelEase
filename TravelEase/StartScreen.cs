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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
            WireHoverEvents(touristPanel);
            WireHoverEvents(adminPanel);
            WireHoverEvents(serviceProviderPanel);
            WireHoverEvents(tourOperatorPanel);
        }
        private void WireHoverEvents(Panel panel)
        {
            panel.MouseEnter += panel_HoverEnter;
            panel.MouseLeave += panel_HoverLeave;

            foreach (Control ctrl in panel.Controls)
            {
                ctrl.MouseEnter += (s, e) => panel_HoverEnter(panel, e);
                ctrl.MouseLeave += (s, e) => panel_HoverLeave(panel, e);
            }
        }
        private void title_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void panel_HoverEnter(object sender, EventArgs e)
        {
            Panel hoveredPanel = sender as Panel;
            if (hoveredPanel != null)
                hoveredPanel.BackColor = Color.FromArgb(40, 50, 90); 
        }

        private void panel_HoverLeave(object sender, EventArgs e)
        {
            Panel hoveredPanel = sender as Panel;
            if (hoveredPanel != null)
                hoveredPanel.BackColor = Color.FromArgb(24, 30, 65); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void OpenLoginForm(int userType)
        {
            this.Hide();
            Login loginForm = new Login(userType);
            loginForm.StartPosition = FormStartPosition.Manual;
            loginForm.Location = this.Location;
            loginForm.Show();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
           OpenLoginForm(0);
        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            OpenLoginForm(3);
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            OpenLoginForm(2);
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            OpenLoginForm(1);
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
