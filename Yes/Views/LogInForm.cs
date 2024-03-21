using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCatalog.Controllers;
using System.Windows.Forms;
using Yes.Controllers;

namespace Yes.Views
{
    public partial class LoginForm : Form
    {
        UsersController UsersController;
        public LoginForm()
        {
            InitializeComponent();
            this.UsersController = new UsersController();
        }
        // Sample method to simulate authentication
        

        private void LoginTitleLabel_Click(object sender, EventArgs e)
        {

        }
        
        private void KeyPictureBox_Click(object sender, EventArgs e)
        {
              if (PasswordTextBox.UseSystemPasswordChar)
            {
                // If the password is currently hidden, show it.
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                // If the password is currently shown, hide it.
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserSignInButton_Click_1(object sender, EventArgs e)
        {
            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Text;
            bool isValidUser = UsersController.IsUserValid(email, password);
            if (isValidUser)
            {
                // User is valid, get their username
                string username = UsersController.GetUserNameByEmail(email);

                // Perform further actions after successful login, e.g., navigating to another form
                MessageBox.Show("Login successful. Welcome, " + username + "!");

                this.Hide();
                HomeForm homeForm = new HomeForm();
                homeForm.Show();
            }
            else
            {
                // User is not valid, show an error message
                MessageBox.Show("Invalid email or password. Please try again.");
            }

        }

        private async void LoginForm_Load(object sender, EventArgs e)
        {
            for (double opacity = 0; opacity <= 1; opacity += 0.1)
            {
                this.Opacity = opacity;
                await Task.Delay(15);
            }
        }

        private async void ExitLabel_Click(object sender, EventArgs e)
        {
            for (double opacity = 1; opacity >= 0; opacity -= 0.1)
            {
                this.Opacity = opacity;
                await Task.Delay(15);
            }
            System.Environment.Exit(1);
        }
    }
}

