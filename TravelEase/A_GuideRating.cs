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
    public partial class A_GuideRating : UserControl
    {
        public A_GuideRating()
        {
            InitializeComponent();
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

        private void A_GuideRating_Load(object sender, EventArgs e)
        {

        }
    }
}
