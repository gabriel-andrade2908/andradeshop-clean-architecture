using AndradeShop.BackOffice.Domain.Products;
using AndradeShop.Core.Infrastructure.Out.DbAccess.FluentApi.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AndradeShop.BackOffice.Infrastructure.Out.DbAccess.Contexts.Products.FluentApi
{
    internal class ProductFA : NamedEntityFA<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Description).HasMaxLength(MAX_LENGTH_DEFAULT);
            builder.Property(p => p.Description).IsRequired();
            builder.OwnsOne(p => p.Price, price =>
            {
                price.Property(pp => pp.Sale).IsRequired();
                price.Property(pp => pp.Cost).IsRequired();
            });
            base.Configure(builder);
        }
    }
}
