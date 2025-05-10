// A_TripSearchBook.cs
using System;
using System.Collections.Generic;
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
            this.Load += A_TripSearchBook_Load;
            button1.Click += button1_Click;
        }

        private void A_TripSearchBook_Load(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();

                // Populate Date dropdown
                FillCombo(conn,
                          "SELECT DISTINCT CAST(TDate AS DATE) AS TDate FROM Trip",
                          comboBoxDate, "TDate", "TDate");

                // Populate Destination dropdown
                FillCombo(conn,
                          "SELECT DISTINCT TDestination FROM Trip",
                          comboBoxDestination, "TDestination", "TDestination");

                // Populate Group Size dropdown
                FillCombo(conn,
                          "SELECT DISTINCT TGroupSize FROM Trip",
                          comboBoxGroupSize, "TGroupSize", "TGroupSize");

                // Populate Duration dropdown
                FillCombo(conn,
                          "SELECT DISTINCT TDuration FROM Trip",
                          comboBoxDuration, "TDuration", "TDuration");

                // Populate Rating dropdown
                FillCombo(conn,
                          "SELECT DISTINCT TRating FROM Trip",
                          comboBoxRating, "TRating", "TRating");

                // Populate Activity Type dropdown (via TourCategories)
                using (var cmd = new SqlCommand(
                    "SELECT DISTINCT c.TCName FROM Trip t " +
                    "JOIN TourCategories c ON t.TCCategoryID = c.TCategoryID", conn))
                {
                    var dt = new DataTable();
                    new SqlDataAdapter(cmd).Fill(dt);
                    comboBoxActivityType.DataSource = dt;
                    comboBoxActivityType.DisplayMember = "TCName";
                    comboBoxActivityType.ValueMember = "TCName";
                    comboBoxActivityType.SelectedIndex = -1;
                }
            }
        }

        private void FillCombo(SqlConnection conn, string sql, ComboBox cb, string disp, string val)
        {
            using (var da = new SqlDataAdapter(sql, conn))
            {
                var dt = new DataTable();
                da.Fill(dt);
                cb.DataSource = dt;
                cb.DisplayMember = disp;
                cb.ValueMember = val;
                cb.SelectedIndex = -1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            string sql =
                "SELECT t.TripID, t.TDestination, t.TDuration, t.TGroupSize, " +
                "c.TCName AS ActivityType, t.TRating, t.TDate " +
                "FROM Trip t " +
                "JOIN TourCategories c ON t.TCCategoryID = c.TCategoryID " +
                "WHERE 1=1";

            var parameters = new List<SqlParameter>();

            if (comboBoxDate.SelectedIndex != -1)
            {
                sql += " AND CAST(t.TDate AS DATE) = CAST(@TDate AS DATE)";
                parameters.Add(new SqlParameter("@TDate", comboBoxDate.SelectedValue));
            }
            if (comboBoxDestination.SelectedIndex != -1)
            {
                sql += " AND t.TDestination = @Destination";
                parameters.Add(new SqlParameter("@Destination", comboBoxDestination.SelectedValue));
            }
            if (comboBoxGroupSize.SelectedIndex != -1)
            {
                sql += " AND t.TGroupSize = @GroupSize";
                parameters.Add(new SqlParameter("@GroupSize", comboBoxGroupSize.SelectedValue));
            }
            if (comboBoxDuration.SelectedIndex != -1)
            {
                sql += " AND t.TDuration = @Duration";
                parameters.Add(new SqlParameter("@Duration", comboBoxDuration.SelectedValue));
            }
            if (comboBoxRating.SelectedIndex != -1)
            {
                sql += " AND t.TRating = @Rating";
                parameters.Add(new SqlParameter("@Rating", comboBoxRating.SelectedValue));
            }
            if (comboBoxActivityType.SelectedIndex != -1)
            {
                sql += " AND c.TCName = @ActivityType";
                parameters.Add(new SqlParameter("@ActivityType", comboBoxActivityType.SelectedValue));
            }

            DataTable results = new DataTable();
            try
            {
                using (var conn = new SqlConnection(connStr))
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                    new SqlDataAdapter(cmd).Fill(results);
                }

                // Bind to DataGridView:
                dataGridViewResults.DataSource = results;

                if (results.Rows.Count == 0)
                {
                    MessageBox.Show("No matching trips found.", "No Results",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search failed: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TripIdBook_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
