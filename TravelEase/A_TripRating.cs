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
    public partial class A_TripRating : UserControl
    {
        public A_TripRating()
        {
            InitializeComponent();
        }

        private void A_TripRating_Load(object sender, EventArgs e)
        {

        }

        private void Reviews_lbl_Click(object sender, EventArgs e)
        {

        }

        private bool hasClearedSearchTextbox = false;

        private void searchTextbox_Enter(object sender, EventArgs e)
        {
            if (!hasClearedSearchTextbox)
            {
                searchTextbox.Clear();  // Clears the text
                hasClearedSearchTextbox = true;  // Marks that it has been cleared once
            }
        }


        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private bool hasClearedSearchTextbox2 = false;

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!hasClearedSearchTextbox2 && !string.IsNullOrEmpty(searchTextbox.Text))
            {
                searchTextbox.Clear();  // Clears the text
                hasClearedSearchTextbox2 = true;  // Marks that it has been cleared once
            }
        }

    }
}
