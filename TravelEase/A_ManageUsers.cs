using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TravelEase
{

    public partial class A_ManageUsers : UserControl
    {
        public A_ManageUsers()
        {
            InitializeComponent();
        }

        private void A_ManageUsers_Load(object sender, EventArgs e)
        {
            this.filterComboBox.SelectedIndex = 0;
        }
        private void searchTextBox_GotFocus(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "Search for users...")
            {
                searchTextBox.Text = "";
                searchTextBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void searchTextBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                searchTextBox.Text = "Search for users...";
                searchTextBox.ForeColor = System.Drawing.Color.Gray;
            }
        }


        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addUserButton_Click(object sender, EventArgs e)
        {

        }


        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void usersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
