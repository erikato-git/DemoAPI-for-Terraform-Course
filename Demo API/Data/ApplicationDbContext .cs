using Demo_API.Model;
using Microsoft.EntityFrameworkCore;

namespace Demo_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<Product> Products => Set<Product>();
        public DbSet<Course> Courses => Set<Course>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Laptop", Price = 1200m },
                new Product { Id = 2, Name = "Keyboard", Price = 150m },
                new Product { Id = 3, Name = "Mouse", Price = 80m }
            );
        }
    }
}
