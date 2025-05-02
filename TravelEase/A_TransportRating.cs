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
    public partial class A_TransportRating : UserControl
    {
        public A_TransportRating()
        {
            InitializeComponent();
        }

        private void A_TransportRating_Load(object sender, EventArgs e)
        {

        }

        private bool hasClearedSearchTextbox2 = false;

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!hasClearedSearchTextbox2 && !string.IsNullOrEmpty(searchTextbox.Text))
            {
                searchTextbox.Clear();  // Clears the text
                hasClearedSearchTextbox2 = true;  // Ensures it is only cleared once
            }
        }


    }
}
