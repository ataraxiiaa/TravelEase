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
    public partial class TO_Queries : UserControl
    {
        public TO_Queries()
        {
            InitializeComponent();
        }

        private void TO_Queries_Load(object sender, EventArgs e)
        {
            searchTextBox_LostFocus(sender, e);
        }
        private void searchTextBox_GotFocus(object sender, EventArgs e)
        {
            if (searchTextbox.Text == "Search for Queries by id...")
            {
                searchTextbox.Text = "";
                searchTextbox.ForeColor = System.Drawing.Color.Black; 
            }
        }

        private void searchTextBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextbox.Text))
            {
                searchTextbox.Text = "Search for Queries by id..."; 
                searchTextbox.ForeColor = System.Drawing.Color.Gray; 
            }
        }

        private void usersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TO_Queries_Load_1(object sender, EventArgs e)
        {

        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchTextbox_Enter(object sender, EventArgs e)
        {
            if (searchTextbox.Text == "Search for Queries by id...")
            {
                searchTextbox.Text = "";
                searchTextbox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void searchTextbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextbox.Text))
            {
                searchTextbox.Text = "Search for Queries by id..."; 
                searchTextbox.ForeColor = System.Drawing.Color.Gray; 
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
