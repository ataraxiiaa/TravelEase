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
    public partial class A_TripSearchBook : UserControl
    {
        public A_TripSearchBook()
        {
            InitializeComponent();
        }

        private bool hasCleared = false;

        private void ActTypeText_Enter(object sender, EventArgs e)
        {
            if (!hasCleared)
            {
                ActTypeText.Clear();  // Clears the textbox
                hasCleared = true;    // Marks that it has been cleared once
            }
        }

        private bool hasClearedDest = false;
        private bool hasClearedDate = false;
        private bool hasClearedGroup = false;
        private bool hasClearedPrice = false;
        private bool hasClearedNameEntry = false;

        private void DestText_Enter(object sender, EventArgs e)
        {
            if (!hasClearedDest)
            {
                DestText.Clear();
                hasClearedDest = true;
            }
        }

        private void DateText_Enter(object sender, EventArgs e)
        {
            if (!hasClearedDate)
            {
                DateText.Clear();
                hasClearedDate = true;
            }
        }

        private void GroupText_Enter(object sender, EventArgs e)
        {
            if (!hasClearedGroup)
            {
                GroupText.Clear();
                hasClearedGroup = true;
            }
        }

        private void PriceText_Enter(object sender, EventArgs e)
        {
            if (!hasClearedPrice)
            {
                PriceText.Clear();
                hasClearedPrice = true;
            }
        }

        private void NameEntryText_Enter(object sender, EventArgs e)
        {
            if (!hasClearedNameEntry)
            {
                NameEntryText.Clear();
                hasClearedNameEntry = true;
            }
        }

    }
}
