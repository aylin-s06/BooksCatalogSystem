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
    public partial class ReviewsForm : Form
    {
        ReviewsController reviewsController;
        public ReviewsForm()
        {
            InitializeComponent();
            this.reviewsController = new ReviewsController();
        }

        private void BookNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string name = BookNameTextBox.Text;
            ReviewsForBookDataGridView.DataSource = reviewsController.SearchBookReviewsByBookName(name);
        }


        private void ReviewsForBookDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PageTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void SearchByLabel_Click(object sender, EventArgs e)
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
            AuthorsForm authorsForm = new AuthorsForm();
            authorsForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }   
}
