using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yes.Views;

namespace Yes
{
    public partial class IntroForm : Form
    {
        /// <summary>
        /// Represents the introductory form for the Blood Bank Management System, which displays a loading animation and transitions to the login form when loading is complete.
        /// </summary>
        public IntroForm()
        {

            InitializeComponent();
            
        }
       
        private void LoadingLabel_Click(object sender, EventArgs e)
        {

        }

        private void IntroFormLoad_Click(object sender, EventArgs e)
        {


        }

        private void IntroTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private async void IntroForm_Load_1(object sender, EventArgs e)
        {
            for (double opacity = 0; opacity <= 1; opacity += 0.1)
            {
                this.Opacity = opacity;
                await Task.Delay(15);
            }
            // Simulate loading process (you should replace this with your actual loading logic)
            await Task.Delay(2500); 

            // Once loading is complete, hide the IntroForm, show the LoginForm, and close the IntroForm
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
