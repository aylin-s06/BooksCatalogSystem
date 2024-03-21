using BookCatalog.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookCatalog.Controllers
{
    class BooksController
    {
        /// <summary>
        /// Controller responsible for handling book-related actions.
        /// </summary>
        public List<object> SearchAllBooks(string searchInput)
        {
            /// <summary>
            /// Searches for all books containing the specified search input in their title.
            /// </summary>
            /// <param name="searchInput">The input string used for searching book titles.</param>
            /// <returns>A list of anonymous objects representing books matching the search input.</returns>
            using (var context = new BookCatalogContext())
            {
                var booksQuery = context.Book.AsQueryable();

                    booksQuery = booksQuery.Where(b => b.Title.Contains(searchInput));

                // Join books with genre and author information.

                var books = booksQuery
               .Join(
                      context.Genre,
                      book => book.GenreId,
                      genre => genre.GenreId,
                      (book, genre) => new
                      { Title = book.Title,
                        ISBN = book.ISBN,
                        Genre = genre.Name, 
                        AuthorId = book.AuthorId,
                        IsAvailable = book.IsAvailable
                      } )
               .Join(
                     context.Author,
                     bookGenre => bookGenre.AuthorId,
                     author => author.AuthorId,
                     (bookGenre, author) => new
                     { bookGenre.Title,
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
