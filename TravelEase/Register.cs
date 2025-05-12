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

namespace TravelEase
{
    public partial class Register : Form
    {
        private int userType;
        public Register(int userType)
        {
            InitializeComponent();
            this.Shown += Start_Shown;
            this.userType = userType;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            UsernameTextBox.Text = "";
            Password_Text_Box.Text = "";
            Password_Text_Box.UseSystemPasswordChar = false;

        }
        private void Start_Shown(object sender, EventArgs e)
        {
            UsernameTextBox.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Login_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(this.BackgroundImage, -100, 0);
        }

        private void Username_Label_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                Password_Text_Box.PasswordChar = '\0';
            }
            else
            {
                Password_Text_Box.PasswordChar = '*';
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            StartScreen start = new StartScreen();
            start.StartPosition = FormStartPosition.Manual;
            start.Location = this.Location;
            start.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load_1(object sender, EventArgs e)
        {

        }

        private void Registerbtn_click(object sender, EventArgs e)
        {
            string connection = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            string query = "";

            string username = UsernameTextBox.Text;
            string password = Password_Text_Box.Text;
            string email = emailtxtbox.Text;
            DateTime registerDate = DateTime.Now;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                string checkQuery = "SELECT COUNT(*) FROM UserInfo WHERE UName = @UName";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@UName", username);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.");
                        return;
                    }
                }

                string insertUserQuery = @"INSERT INTO UserInfo (UName, UPassword, UEmail, URegisterDate)
                                       OUTPUT INSERTED.UserID
                                       VALUES (@UName, @UPassword, @UEmail, @URegisterDate)";

                SqlCommand cmd = new SqlCommand(insertUserQuery, conn);
                cmd.Parameters.AddWithValue("@UName", username);
                cmd.Parameters.AddWithValue("@UPassword", password);
                cmd.Parameters.AddWithValue("@UEmail", email);
                cmd.Parameters.AddWithValue("@URegisterDate",registerDate);

                int newUserId = (int)cmd.ExecuteScalar();

                if (userType == 0) // Tourist
                {
                    touristDetailsform detailsForm = new touristDetailsform();
                    if (detailsForm.ShowDialog() == DialogResult.OK)
                    {
                        string insertTourist = @"
                        INSERT INTO Tourist (TouristID, TAge, TNationality, TPreferredCategory, DTPID) 
                        VALUES (@ID, @Age, @Nationality, @Category, NULL)";

                        cmd = new SqlCommand(insertTourist, conn);

                        cmd.Parameters.AddWithValue("@ID", newUserId);
                        cmd.Parameters.AddWithValue("@Age", detailsForm.age);
                        cmd.Parameters.AddWithValue("@Nationality", detailsForm.name);
                        cmd.Parameters.AddWithValue("@Category", detailsForm.category);
                        cmd.ExecuteNonQuery();

                    }
                }
                else if (userType == 1) // Admin
                {
                    string insertMod = "INSERT INTO Moderator (MUsername, MPassword) VALUES (@UName, @UPassword)";
                    cmd = new SqlCommand(insertMod, conn);
                    cmd.Parameters.AddWithValue("@ID", newUserId);
                    cmd.Parameters.AddWithValue("@UName", username);
                    cmd.Parameters.AddWithValue("@UPassword", password);
                    cmd.ExecuteNonQuery();
                }
                else if (userType == 2) // Tour Operator
                {
                    string insertCompany = "INSERT INTO CompanyProfile (CName) OUTPUT INSERTED.CProfileID VALUES (@CName)";
                    cmd = new SqlCommand(insertCompany, conn);
                    cmd.Parameters.AddWithValue("@CName", username + " Tours");
                    int profileId = (int)cmd.ExecuteScalar();

                    string insertOperator = "INSERT INTO TourOperator (TourOperatorID, CProfileID) VALUES (@ID, @CProfileID)";
                    cmd = new SqlCommand(insertOperator, conn);
                    cmd.Parameters.AddWithValue("@ID", newUserId);
                    cmd.Parameters.AddWithValue("@CProfileID", profileId);
                    cmd.ExecuteNonQuery();
                }
                else if (userType == 3) // Service Provider
                {
                    string insertSP = "INSERT INTO ServiceProvider (ServiceProviderID, SPPHONE) VALUES (@ID, '123456789')";
                    cmd = new SqlCommand(insertSP, conn);
                    cmd.Parameters.AddWithValue("@ID", newUserId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("User registered successfully!");
            }
        }
    }
}
