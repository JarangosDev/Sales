using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Sales.Shared.Entities;

namespace Sales.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Category> ProdCategories { get; set; }

        public DbSet<Category> Products { get; set; }
        public  DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<State> States { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<ProdCategory>().HasIndex("CategoryId", "Name").IsUnique();
            modelBuilder.Entity<Product>().HasIndex("ProdCategoryId", "Name").IsUnique();

            modelBuilder.Entity<Country>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<State>().HasIndex("CountryId", "Name").IsUnique();
            modelBuilder.Entity<City>().HasIndex("StateId", "Name").IsUnique();
        }
    }


}
