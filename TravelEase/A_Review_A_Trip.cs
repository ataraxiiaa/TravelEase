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
    
    public partial class A_Review_A_Trip : UserControl
    {
        int tourID =-1;
        private Touristcs parentForm;
        public A_Review_A_Trip(Touristcs parent, int id)
        {
            InitializeComponent();
            this.parentForm = parent;
            tourID = id;
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            parentForm.LoadView2(new A_TripRating(tourID));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parentForm.LoadView2(new A_GuideRating(tourID));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            parentForm.LoadView2(new A_TransportRating(tourID));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parentForm.LoadView2(new A_Review_A_Hotel(tourID));
        }

        private void A_Review_A_Trip_Load(object sender, EventArgs e)
        {

        }
    }
}
