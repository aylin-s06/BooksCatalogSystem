using BookCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Yes.Controllers
{
    class GenresController
    {
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
