using AndradeShop.BackOffice.Domain.Products;
using AndradeShop.BackOffice.Domain.Products.Contexts.Categories;
using AndradeShop.BackOffice.Domain.Products.Contexts.Colors;
using AndradeShop.BackOffice.Infrastructure.Out.DbAccess.Contexts.Products.FluentApi;
using AndradeShop.Core.Infrastructure.Out.DbAccess.FluentApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace AndradeShop.BackOffice.Infrastructure.Out.DbAccess
{
    internal class BackOfficeDb : DbContext
    {
        public BackOfficeDb(DbContextOptions<BackOfficeDb> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductFA());
            modelBuilder.ApplyConfiguration(new ProductCategoryFA());
            modelBuilder.ApplyConfiguration(new ProductColorFA());
            modelBuilder.ApplyConfiguration(new NamedEntityFA<Color>());
            modelBuilder.ApplyConfiguration(new NamedEntityFA<Category>());

            base.OnModelCreating(modelBuilder);
        }
    }
}
