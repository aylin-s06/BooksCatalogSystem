using BookCatalog.Controllers;
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
    public partial class BooksForm : Form
    {
        BooksController booksController;
        public BooksForm()
        {
            InitializeComponent();
            this.booksController = new BooksController();
        }
        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void BooksForm_Load(object sender, EventArgs e)
        {

        }
        private void PageTitleLabel_Click(object sender, EventArgs e)
        {

        }
        private void SearchByLabel_Click(object sender, EventArgs e)
        {
            
        }
        private void BooksdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void BooksImage_Click(object sender, EventArgs e)
        {

        }

        private void BookNameBox_TextChanged(object sender, EventArgs e)
        {
            string name = BookNameBox.Text;
            BooksdataGridView.DataSource = booksController.SearchAllBooks(name);

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
            GenresForm genresForm = new GenresForm();
            genresForm.Show();
        }
    }
}
