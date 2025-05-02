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
    public partial class A_TripDashboard : UserControl
    {
        private Touristcs parentForm;
        public A_TripDashboard(Touristcs parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void upcomingtrip_Click(object sender, EventArgs e)
        {
           
        }

        private void booktrip_Click(object sender, EventArgs e)
        {
            
        }

        private void canceltrip_Click(object sender, EventArgs e)
        {
            parentForm.LoadView2(new A_CancelTrip());
        }
    }
}
