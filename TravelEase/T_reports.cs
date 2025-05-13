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
    public partial class T_reports : Form
    {
        public T_reports()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            T_bookingReportForm t = new T_bookingReportForm();
            t.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            T_revenueCatReportForm t = new T_revenueCatReportForm();
            t.Show();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            T_bookingPeriodReportForm t = new T_bookingPeriodReportForm();
            t.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            T_revenueBookReportForm t = new T_revenueBookReportForm();
            t.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            T_ratingDestinationReportForm t = new T_ratingDestinationReportForm();
            t.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            T_bookingCityReportForm t = new T_bookingCityReportForm();
            t.Show();
        }
    }
}
