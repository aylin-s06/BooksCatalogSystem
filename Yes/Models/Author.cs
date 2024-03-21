using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCatalog.Models
{
    class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
