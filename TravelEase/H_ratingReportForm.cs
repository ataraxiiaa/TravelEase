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
    public partial class H_ratingReportForm : Form
    {
        public H_ratingReportForm()
        {
            InitializeComponent();
        }

        private void H_ratingReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'touristReviewTripDataSet.TouristReviewTrip' table. You can move, or remove it, as needed.
            this.touristReviewTripTableAdapter.Fill(this.touristReviewTripDataSet.TouristReviewTrip);

            this.reportViewer1.RefreshReport();
        }
    }
}
