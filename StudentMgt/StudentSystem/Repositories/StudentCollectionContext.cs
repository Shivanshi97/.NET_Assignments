using Microsoft.EntityFrameworkCore;
using StudentSystem.Models;

namespace StudentSystem.Repositories
{
    public class StudentCollectionContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            string connectionString = @"server=localhost;port=3306;database=dotnetdb;user=root;password=root;";
            optionsBuilder.UseMySQL(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>(entity => { 
            entity.HasKey(s => s.Id);
                entity.Property(s => s.Name).IsRequired();
                entity.Property(s => s.Email).IsRequired();
                entity.Property(s => s.MobileNumber).IsRequired();
                entity.Property(s => s.Address).IsRequired();
                entity.Property(s => s.AdmissionDate).IsRequired();
                entity.Property(s => s.Fees).IsRequired();
                entity.Property(s => s.Status).IsRequired();
            });
            modelBuilder.Entity<Student>().ToTable("students");
        }
    }
}
