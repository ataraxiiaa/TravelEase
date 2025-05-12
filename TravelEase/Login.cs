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
    public partial class Login : Form
    {
        private int userType;
        public Login(int userType)
        {
            InitializeComponent();
            this.Shown += Start_Shown;
            this.userType = userType;
        }

        private void Start_Load(object sender, EventArgs e)
        {
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
            PasswordTextBox.UseSystemPasswordChar = false;
        }
        private void Start_Shown(object sender, EventArgs e)
        {
            UsernameTextBox.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Username_Enter(object sender, EventArgs e)
        {

        }
        private void Username_Leave(object sender, EventArgs e)
        {

        }
        private void Username_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PasswordTextBox_Checked(object sender, EventArgs e)
        {

        }

        private void Username_Label_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CheckBoxShowPassword(object sender, EventArgs e)
        {
            if(ShowPasswordCheckBox.Checked)
            {
                PasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                PasswordTextBox.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            Form nextForm = null;
            string table = "";
            switch(userType)
            {
                case 0:
                    nextForm = new Touristcs();
                    break;
                case 1:
                    nextForm = new Admin(username);
                    break;
                case 2:
                    nextForm = new TourOperator(username);
                    break;
                case 3:
                    nextForm = new Hotel();
                    break;
                default:
                    MessageBox.Show("Invalid user type.");
                    return;
            }

            string connString = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            string query = "";
            if (userType == 1) {
                
                query = $"SELECT COUNT(*) FROM Moderator WHERE MUsername = @username AND MPassword = @password";
                
            }
            else if (userType == 0)
            {
                query = @"
                SELECT u.UserID
                FROM UserInfo u
                INNER JOIN Tourist r ON u.UserID = r.TouristID
                WHERE u.UName = @username AND u.UPassword = @password";
            }
            else if(userType == 2)
            {
                query = @"
                SELECT u.UserID
                FROM UserInfo u
                INNER JOIN TourOperator r ON u.UserID = r.TourOperatorID
                WHERE u.UName = @username AND u.UPassword = @password";
            }
            else if(userType == 3)
            {
                query = @"
                SELECT u.UserID
                FROM UserInfo u
                INNER JOIN ServiceProvider r ON u.UserID = r.ServiceProviderID
                WHERE u.UName = @username AND u.UPassword = @password";
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        object result = cmd.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int userExists) && userExists > 0)
                        {
                            MessageBox.Show("Login successful!", "Success");
                            this.Hide();
                            nextForm.StartPosition = FormStartPosition.Manual;
                            nextForm.Location = this.Location;
                            nextForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid credentials.", "Login Failed");
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register regForm = new Register(this.userType);
            regForm.StartPosition = FormStartPosition.Manual;
            regForm.Location = this.Location;
            regForm.Show();
        }
        //private void Login_Paint(object sender, PaintEventArgs e)
        //{
        //    e.Graphics.DrawImage(this.BackgroundImage, -100, 0); 
        //}

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }


        private void Login_Button_MouseLeave_1(object sender, EventArgs e)
        {
            Login_Button.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
