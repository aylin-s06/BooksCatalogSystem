using BookCatalog.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yes.Controllers
{
    class ReviewsController
    {
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
