using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TravelEase
{
    public partial class A_TripSearchBook : UserControl
    {
        public A_TripSearchBook()
        {
            InitializeComponent();
        }

        private void A_TripSearchBook_Load(object sender, EventArgs e)
        {
            // Populate ComboBox with Tour Categories
            PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            string mainConn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(mainConn))
            {
                string sqlQuery = "SELECT TCategoryID, TCName FROM [dbo].[TourCategories]";
                using (SqlCommand sqlComm = new SqlCommand(sqlQuery, conn))
                {
                    try
                    {
                        conn.Open();
                        SqlDataAdapter sdr = new SqlDataAdapter(sqlComm);
                        DataTable dt = new DataTable();
                        sdr.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No categories found in TourCategories table.");
                            return;
                        }

                        // Add a default "Select a category" option
                        DataRow defaultRow = dt.NewRow();
                        defaultRow["TCName"] = "Select a category";
                        defaultRow["TCategoryID"] = 0;
                        dt.Rows.InsertAt(defaultRow, 0);

                        comboBox1.DisplayMember = "TCName";
                        comboBox1.ValueMember = "TCategoryID";
                        comboBox1.DataSource = dt;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"SQL Error loading categories: {ex.Message}\nError Number: {ex.Number}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading categories: {ex.Message}");
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null && comboBox1.SelectedValue is int categoryId && categoryId != 0)
            {
                PopulateDataGridView(categoryId);
            }
            else
            {
                usersDataGridView.DataSource = null;
            }
        }

        private void PopulateDataGridView(int categoryId)
        {
            string mainConn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(mainConn))
            {
                // Join Trip with TourCategories to get TCName
                string sqlQuery = "SELECT t.TripID AS [ID], t.TPrice AS [Price], t.TDate AS [Date], t.TGroupSize AS [Group Size], " +
                                 "t.TDuration AS [duration], t.TRating AS [rating], t.TDestination AS [Destination], " +
                                 "tc.TCName AS [TripCategory] " +
                                 "FROM [dbo].[Trip] t " +
                                 "JOIN [dbo].[TourCategories] tc ON t.TCCategoryID = tc.TCategoryID " +
                                 "WHERE t.TCCategoryID = @TCCategoryID";
                using (SqlCommand sqlComm = new SqlCommand(sqlQuery, conn))
                {
                    sqlComm.Parameters.AddWithValue("@TCCategoryID", categoryId);
                    try
                    {
                        conn.Open();
                        SqlDataAdapter sdr = new SqlDataAdapter(sqlComm);
                        DataTable dt = new DataTable();
                        sdr.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No trips found for the selected category.");
                        }

                        usersDataGridView.DataSource = dt;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"SQL Error loading trips: {ex.Message}\nError Number: {ex.Number}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading trips: {ex.Message}");
                    }
                }
            }
        }

        private void usersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure a valid cell is clicked (not header row)
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = usersDataGridView.Rows[e.RowIndex];

                try
                {
                    // Helper function to safely get cell value
                    string GetCellValue(string columnName)
                    {
                        // Check if the column exists in the DataGridView
                        if (!usersDataGridView.Columns.Contains(columnName))
                            throw new ArgumentException($"Column '{columnName}' not found in DataGridView.");
                        return row.Cells[columnName].Value?.ToString() ?? "";
                    }

                    // Populate TextBoxes with trip details using DataGridView column names
                    PriceText.Text = usersDataGridView.Columns.Contains("Price") && row.Cells["Price"].Value != null
                        ? Convert.ToDouble(row.Cells["Price"].Value).ToString("C2") // Format as currency
                        : "";
                    DateText.Text = usersDataGridView.Columns.Contains("Date") && row.Cells["Date"].Value != null
                        ? Convert.ToDateTime(row.Cells["Date"].Value).ToString("MM/dd/yyyy") // Format as MM/dd/yyyy
                        : "";
                    GroupText.Text = GetCellValue("Group Size"); // Note space in column name
                    DestText.Text = GetCellValue("Destination");

                    // ActTypeText: Use TripCategory (TCName from TourCategories)
                    ActTypeText.Text = GetCellValue("TripCategory");

                    // NameEntryText: Use rating (TRating)
                    NameEntryText.Text = GetCellValue("rating");

                    // Reset clearing flags to allow re-clearing on next focus
                    hasCleared = false;
                    hasClearedDest = false;
                    hasClearedDate = false;
                    hasClearedGroup = false;
                    hasClearedPrice = false;
                    hasClearedNameEntry = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading trip details: {ex.Message}");
                }
            }
        }

        // TextBox clearing logic
        private bool hasCleared = false;
        private bool hasClearedDest = false;
        private bool hasClearedDate = false;
        private bool hasClearedGroup = false;
        private bool hasClearedPrice = false;
        private bool hasClearedNameEntry = false;

        private void ActTypeText_Enter(object sender, EventArgs e)
        {
            if (!hasCleared)
            {
                ActTypeText.Clear();
                hasCleared = true;
            }
        }

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

        private void ActTypeText_TextChanged(object sender, EventArgs e)
        {
            // Add logic if needed
        }
    }
}