using BookCatalog.Controllers;
using BookCatalog.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Yes.Views
{
    /// <summary>
    /// Represents the form for displaying genres and books within those genres.
    /// </summary>
    public partial class GenresForm : Form
    {
        GenresController genresController;

        /// <summary>
        /// Initializes a new instance of the GenresForm class.
        /// </summary>
        public GenresForm()
        {
            InitializeComponent();
            this.genresController = new GenresController();
            PopulateGenresComboBox();
        }

        private void PopulateGenresComboBox()
        {
            try
            {
                // Retrieve genres from the database
                List<Genre> genres = GetAllGenres();

                // Clear existing items in the ComboBox
                GenresComboBox.Items.Clear();

                // Populate ComboBox with genres
                foreach (Genre genre in genres)
                {
                    GenresComboBox.Items.Add(genre.Name);
                }

                // Optionally, select the first item in the ComboBox
                if (GenresComboBox.Items.Count > 0)
                {
                    GenresComboBox.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private List<Genre> GetAllGenres()
        {
            using (var context = new BookCatalogContext())
            {
                // Retrieve all genres from the database
                return context.Genre.ToList();
            }
        }
        private void GenresComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GenresComboBox.SelectedItem != null)
            {
                // Get the selected genre name
                string selectedGenre = GenresComboBox.SelectedItem.ToString();

                // Call the method with the selected genre
                BooksByGenredataGridView1.DataSource = genresController.SearchAllFromSelectedGenre(selectedGenre);
            }
            else
            {
                // Handle the case when no item is selected in the ComboBox
                MessageBox.Show("Please select a genre.");
            }
        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void PageTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void SearchByLabel_Click(object sender, EventArgs e)
        {

        }

        private void BooksByGenredataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void GenresForm_Load(object sender, EventArgs e)
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
            ReviewsForm reviewsForm = new ReviewsForm();
            reviewsForm.Show();
        }
    }
}
