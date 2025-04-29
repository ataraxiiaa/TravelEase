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
    public partial class A_Reviews : UserControl
    {
        public A_Reviews()
        {
            InitializeComponent();
        }

        private void A_Reviews_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void approveButton_Click(object sender, EventArgs e)
        {

        }

        private void tripReviewsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tripReviewsDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void searchTextBox_GotFocus(object sender, EventArgs e)
        {
            if (searchTextbox.Text == "Search for users...")
            {
                searchTextbox.Text = "";
                searchTextbox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void searchTextBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextbox.Text))
            {
                searchTextbox.Text = "Search for users...";
                searchTextbox.ForeColor = System.Drawing.Color.Gray;
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
