using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCatalog.Models
{
    class Genre
    {
        [Key]
        public int GenreId { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
