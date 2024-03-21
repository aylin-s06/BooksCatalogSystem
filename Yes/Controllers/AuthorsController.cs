using BookCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yes.Controllers
{
    class AuthorsController
    {
        public List<object> SearchAllBooksByAuthor(string searchInput)
        {
            using (var context = new BookCatalogContext())
            {
                var authors = context.Author
                    .Where(a => a.Name.Contains(searchInput))
                    .SelectMany(a => a.Books.Select(b => new
                    {
                        AuthorName = a.Name,
                        BookTitle = b.Title
                    }))
                    .ToList<object>();

                return authors;
            }
        }
    }
}
