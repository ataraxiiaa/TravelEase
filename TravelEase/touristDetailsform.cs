using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TravelEase
{
    public partial class touristDetailsform : Form
    {
        public int age;
        public string name;
        public string category;
        public touristDetailsform()
        {
            InitializeComponent();
        }

        public void touristDetailsform_Load(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT TCName FROM TourCategories";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["TCName"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading categories: " + ex.Message);
                }
            }

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            this.age = Convert.ToInt32(UsernameTextBox.Text.Trim());
            this.name = emailtxtbox.Text.Trim();
            this.category = comboBox1.SelectedIndex.ToString();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(category))
            {
                MessageBox.Show("All fields must be filled.");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
