using BookCatalog.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yes.Controllers
{
    /// <summary>
    /// Controller responsible for handling review-related actions.
    /// </summary>
    class ReviewsController
    {
        /// <summary>
        /// Searches for book reviews by book name.
        /// </summary>
        /// <param name="searchInput">The input string used for searching book titles.</param>
        /// <returns>A list of anonymous objects containing book title, comment, and rating matching the search input.</returns>
        public List<object> SearchBookReviewsByBookName(string searchInput)
        {
            using (var context = new BookCatalogContext())
            {
                var reviews = context.Review
                    .Where(r => r.Book.Title.Contains(searchInput))
                    .Select(r => new
                    {
                        BookTitle = r.Book.Title,
                        r.Comment,
                        r.Rating,
                        
                    })
                    .ToList<object>();

                return reviews;
            }
        }
    }
}
