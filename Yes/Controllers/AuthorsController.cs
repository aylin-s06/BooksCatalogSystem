using BookCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yes.Controllers
{
    /// <summary>
    /// Controller responsible for handling author-related actions.
    /// </summary>
    class AuthorsController
    {
        /// <summary>
        /// Searches for all books authored by authors whose names contain the specified search input.
        /// </summary>
        /// <param name="searchInput">The input string used for searching author names.</param>
        /// <returns>A list of anonymous objects representing authors and their books matching the search input.</returns>
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
