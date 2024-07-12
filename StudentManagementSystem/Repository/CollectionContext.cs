using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Models;
using System.Globalization;

namespace StudentManagementSystem.Repository
{
    public class CollectionContext : DbContext
    {
       public DbSet<Students> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "server=localhost;port=3306;username=root;password=iacsd123;database=dotlab;";
            optionsBuilder.UseMySQL(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Students>(Entity =>
            {
                Entity.HasKey(s => s.Id);
                Entity.Property(s => s.Name).IsRequired();
                Entity.Property(s=>s.Email).IsRequired();
                Entity.Property(s=>s.Phone).IsRequired();
                Entity.Property(s=>s.Address).IsRequired();
                Entity.Property(s=>s.Admission_Date).IsRequired(); 
                Entity.Property(s=>s.Fees).IsRequired();
                Entity.Property(s=>s.Status).IsRequired();
            });
            modelBuilder.Entity<Students>().ToTable("Students");
        }
    }
}

