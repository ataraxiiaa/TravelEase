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
    public partial class TO_ManageTrips : UserControl
    {
        public TO_ManageTrips()
        {
            InitializeComponent();
        }

        private void TO_ManageTrips_Load(object sender, EventArgs e)
        {
            this.filterComboBox.SelectedIndex = 0;
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
