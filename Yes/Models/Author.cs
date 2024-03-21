using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCatalog.Models
{
    /// <summary>
    /// Represents an author of books in the catalog.
    /// </summary>
    class Author
    {
        [Key]
        public int AuthorId { get; set; }  // Unique identifier for the author.
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
