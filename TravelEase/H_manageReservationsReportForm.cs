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
    public partial class H_manageReservationsReportForm : Form
    {
        public H_manageReservationsReportForm()
        {
            InitializeComponent();
        }

        private void H_manageReservationsReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tourismDatabaseDataSet.Hotels' table. You can move, or remove it, as needed.
            this.hotelsTableAdapter.Fill(this.tourismDatabaseDataSet.Hotels);
            this.reportViewer1.RefreshReport();

        }
    }
}
