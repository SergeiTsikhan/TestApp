using Microsoft.EntityFrameworkCore;
using TestApp.Models;


namespace TestApp.Data
{
    public class BooksContext : DbContext
    {
        public BooksContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Author>().ToTable("Authors");
            modelBuilder.Entity<Book>().ToTable("Books");

        }
    }
}
