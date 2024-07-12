using Microsoft.EntityFrameworkCore;
using TempProduct.Models;

namespace TempProduct.Repository
{
    public class CollectionContext : DbContext
    {
        public DbSet<Products> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "server=localhost; port=3306;username=root;password=iacsd123;database=practise";
            optionsBuilder.UseMySQL(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Products>(Entity =>
            {
                Entity.HasKey(p => p.Id);
                Entity.Property(p => p.Title);
                Entity.Property(p => p.Description);
                Entity.Property(p => p.UnitPrice);
                Entity.Property(p => p.ImageUrl);
                Entity.Property(p => p.Quantity);
            });
            modelBuilder.Entity<Products>().ToTable("Products");
        }


    }
}
