using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yes.Controllers;

namespace Yes.Views
{
    public partial class AuthorsForm : Form
    {
        AuthorsController authorsController;
        public AuthorsForm()
        {
            InitializeComponent();
            this.authorsController = new AuthorsController();
        }
        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }
        private void SearchByLabel_Click(object sender, EventArgs e)
        {

        }
        private void PageTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void BooksByAuthordataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BackButtonBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }

        private void NextButtonBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            BooksForm booksForm = new BooksForm();
            booksForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AuthorNameBox_TextChanged(object sender, EventArgs e)
        {
            string author = AuthorNameBox.Text;
            BooksByAuthordataGridView.DataSource = authorsController.SearchAllBooksByAuthor(author);
        }
    }
}
