using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCatalog.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public int GenreId { get; set; }
        public int AuthorId { get; set; }
        public bool IsAvailable { get; set; } = false;
        public ICollection<Review> Reviews { get; set; }
    }
}

