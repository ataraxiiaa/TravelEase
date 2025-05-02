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
    public partial class A_CancelTrip : UserControl
    {
        public A_CancelTrip()
        {
            InitializeComponent();
        }

        private void A_CancelTrip_Load(object sender, EventArgs e)
        {

        }

        private bool hasClearedCancelSearch = false;

        private void CancelSearchTextBox_Enter(object sender, EventArgs e)
        {
            if (!hasClearedCancelSearch)
            {
                CancelSearchTextBox.Clear();  // Clears the text
                hasClearedCancelSearch = true;  // Marks that it has been cleared once
            }
        }

    }
}
