using System.Data.Entity;

namespace BookCatalog.Models
{
    /// <summary>
    /// Represents the database context for the book catalog application.
    /// </summary>
    class BookCatalogContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the BookCatalogContext class.
        /// </summary>
        public BookCatalogContext() : base("BookCatalogDB")
        {

        }
        // DbSet properties represent tables in the database.
        public DbSet<User> User { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Genre> Genre  { get; set; }
        public DbSet<Review> Review { get; set; }

    }
}
