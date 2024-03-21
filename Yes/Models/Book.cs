using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCatalog.Models
{
    /// <summary>
    /// Represents a book in the catalog.
    /// </summary>
    public class Book
    {
        [Key]
        public int BookId { get; set; }   // Unique identifier for the book.
        public string Title { get; set; }
        public string ISBN { get; set; }  // International Standard Book Number (ISBN) of the book.
        public int GenreId { get; set; }  // Foreign key referencing the genre of the book.
        public int AuthorId { get; set; } // Foreign key referencing the author of the book.
        public bool IsAvailable { get; set; } = false;
        public ICollection<Review> Reviews { get; set; }
    }
}

