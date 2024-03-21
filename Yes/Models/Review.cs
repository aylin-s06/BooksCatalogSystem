using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCatalog.Models
{
    /// <summary>
    /// Represents a review of a book written by a user.
    /// </summary>
    public class Review
    {
        [Key]
        public int ReviewId { get; set; } // Unique identifier for the review.
        public string Comment { get; set; }
        public int Rating { get; set; }
        public int UserId { get; set; }  // Foreign key referencing the user who wrote the review.
        public User User { get; set; }
        public int BookId { get; set; } // Foreign key referencing the book being reviewed.
        public Book Book { get; set; }
    }
}
