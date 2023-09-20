using AndradeShop.BackOffice.Domain.Products.SubEntities;
using AndradeShop.Core.Infrastructure.Out.DbAccess.FluentApi.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AndradeShop.BackOffice.Infrastructure.Out.DbAccess.Contexts.Products.FluentApi
{
    internal class ProductColorFA : EntityFA<ProductColor>
    {
        public override void Configure(EntityTypeBuilder<ProductColor> builder)
        {
            builder.HasOne(productColor => productColor.Product).WithMany(product => product.ProductColors).HasForeignKey(productColor => productColor.ProductId);
            builder.HasOne(productColor => productColor.Color).WithMany(color => color.ProductColors).HasForeignKey(productColor => productColor.ColorId);
            base.Configure(builder);
        }
    }
}
