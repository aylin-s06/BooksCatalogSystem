using BookCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Yes.Controllers
{
    /// <summary>
    /// Controller responsible for handling genre-related actions.
    /// </summary>
    class GenresController
    {
        /// <summary>
        /// Searches for all books belonging to a selected genre.
        /// </summary>
        /// <param name="searchInput">The name of the genre to search for.</param>
        /// <returns>A list of anonymous objects representing books belonging to the selected genre.</returns>
        public List<object> SearchAllFromSelectedGenre(string searchInput)
        {
            using (var context = new BookCatalogContext())
            {
                var CurrentGenre = context.Genre.FirstOrDefault(d => d.Name == searchInput);
                if (CurrentGenre == null)
                {
                    return new List<object>(); 
                }
                string indexAsString = CurrentGenre.GenreId.ToString();
                int index = int.Parse(indexAsString);

                var genresQuery = context.Book.AsQueryable();

                genresQuery = genresQuery.Where(b => b.GenreId.Equals(index));

                // Join books with genre and author information.

                var books = genresQuery
               .Join(
                      context.Genre,
                      book => book.GenreId,
                      genre => genre.GenreId,
                      (book, genre) => new
                      {
                          Title = book.Title,
                          ISBN = book.ISBN,
                          Genre = genre.Name,
                          AuthorId = book.AuthorId,
                          IsAvailable = book.IsAvailable
                      })
               .Join(
                     context.Author,
                     bookGenre => bookGenre.AuthorId,
                     author => author.AuthorId,
                     (bookGenre, author) => new
                     {
                         bookGenre.Title,
                         bookGenre.ISBN,
                         bookGenre.Genre,
                         Author = author.Name,
                         bookGenre.IsAvailable
                     })
               .ToList();


                return books.Cast<object>().ToList();
            }
        }
    }
}
