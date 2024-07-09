using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ProductsOnline.Models;

namespace ProductsOnline.Repositories
{
    public class EStoreCollectionContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string constr = @"server=localhost;port=3306;user=root;database=dotnetdb;password=root";
            optionsBuilder.UseMySQL(constr);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Title).IsRequired();
                entity.Property(e => e.Description).IsRequired();
                //entity.Property(e => e.UnitPrice).IsRequired();
                entity.Property(e => e.Quantity).IsRequired();
            });
            modelBuilder.Entity<Product>().ToTable("products");
        }
    }
}
