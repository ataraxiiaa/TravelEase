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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            this.Shown += Start_Shown;
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
            Login loginForm = new Login();
            loginForm.StartPosition = FormStartPosition.Manual;
            loginForm.Location = this.Location;  
            loginForm.Show();
        }
    }
}
