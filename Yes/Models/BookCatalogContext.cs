using System.Data.Entity;

namespace BookCatalog.Models
{
    class BookCatalogContext : DbContext
    {
        public BookCatalogContext() : base("BookCatalogDB")
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Genre> Genre  { get; set; }
        public DbSet<Review> Review { get; set; }

    }
}
