using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yes.Views
{
    /// <summary>
    /// Represents the home form of the application.
    /// </summary>
    public partial class HomeForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the HomeForm class.
        /// </summary>
        public HomeForm()
        {
            InitializeComponent();
        }

        private void TitleLable_Click(object sender, EventArgs e)
        {

        }

        private void PageTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void BooksFormButton_Click(object sender, EventArgs e)
        {
            BooksForm booksForm= new BooksForm();
            booksForm.Show();
            this.Hide();
        }

        private void AuthorsFormButton_Click(object sender, EventArgs e)
        {
            AuthorsForm authorsForm= new AuthorsForm();
            authorsForm.Show();
            this.Hide();
        }

        private void GenresFormButton_Click(object sender, EventArgs e)
        {
            GenresForm genresForm= new GenresForm();
            genresForm.Show();
            this.Hide();
        }

        private void ReviewsFormButton_Click(object sender, EventArgs e)
        {
            ReviewsForm reviewsForm= new ReviewsForm();
            reviewsForm.Show();
            this.Hide();
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
