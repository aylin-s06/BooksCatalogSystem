using BookCatalog.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookCatalog.Controllers
{
    class BooksController
    {
        public List<object> SearchAllBooks(string searchInput)
        {
            using (var context = new BookCatalogContext())
            {
                var booksQuery = context.Book.AsQueryable();

                    booksQuery = booksQuery.Where(b => b.Title.Contains(searchInput));
                
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
