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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Shown += Start_Shown;

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

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register regForm = new Register();
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
            this.Hide();
            Admin adminForm = new Admin();
            adminForm.StartPosition = FormStartPosition.Manual;
            adminForm.Location = this.Location;
            adminForm.Show();
        }


        private void Login_Button_MouseLeave_1(object sender, EventArgs e)
        {
            Login_Button.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
