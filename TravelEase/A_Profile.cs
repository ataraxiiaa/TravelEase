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
    public partial class A_Profile : UserControl
    {
        public A_Profile()
        {
            InitializeComponent();
        }

        private bool hasClearedSearchPreference = false;

        private void searchPreference_Enter(object sender, EventArgs e)
        {
            if (!hasClearedSearchPreference)
            {
                searchPreference.Clear();  // Clears the text
                hasClearedSearchPreference = true;  // Marks that it has been cleared once
            }
        }

    }
}
