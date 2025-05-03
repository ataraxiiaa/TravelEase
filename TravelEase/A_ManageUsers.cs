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
            LoadAllUsers();
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
        private void LoadAllUsers()
        {
            string query = "SELECT UserID, UName, UEmail, UAccountStatus, URegisterDate FROM UserInfo";

            using (SqlConnection conn = new SqlConnection("Data Source=ALI\\SQLEXPRESS;Initial Catalog=tourismDatabase;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open();
                    adapter.Fill(dt);
                    usersDataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string filter = filterComboBox.SelectedItem.ToString();
            string searchValue = searchTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchValue) || searchValue == "Search for users...")
            {
                MessageBox.Show("Please enter a search value.");
                return;
            }

            string query = "SELECT UserID, UName, UEmail, UAccountStatus, URegisterDate FROM UserInfo WHERE ";
            SqlCommand cmd = new SqlCommand();

            switch (filter)
            {
                case "Username":
                    query += "UName LIKE @search";
                    cmd.Parameters.AddWithValue("@search", "%" + searchValue + "%");
                    break;

                case "UserID":
                    query += "UserID = @search";
                    if (int.TryParse(searchValue, out int userID))
                        cmd.Parameters.AddWithValue("@search", userID);
                    else
                    {
                        MessageBox.Show("Invalid User ID.");
                        return;
                    }
                    break;

                case "Account Status":
                    query += "UAccountStatus = @search";
                    if (searchValue.Equals("active", StringComparison.OrdinalIgnoreCase))
                        cmd.Parameters.AddWithValue("@search", 1);
                    else if (searchValue.Equals("inactive", StringComparison.OrdinalIgnoreCase))
                        cmd.Parameters.AddWithValue("@search", 0);
                    else
                    {
                        MessageBox.Show("Enter 'Active' or 'Inactive' for account status.");
                        return;
                    }
                    break;
            }

            cmd.CommandText = query;

            using (SqlConnection conn = new SqlConnection("Data Source=ALI\\SQLEXPRESS;Initial Catalog=tourismDatabase;Integrated Security=True"))
            {
                cmd.Connection = conn;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open();
                    adapter.Fill(dt);
                    usersDataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}
