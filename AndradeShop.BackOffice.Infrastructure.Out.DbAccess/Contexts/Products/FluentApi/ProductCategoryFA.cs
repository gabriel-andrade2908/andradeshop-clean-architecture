using AndradeShop.BackOffice.Domain.Products.SubEntities;
using AndradeShop.Core.Infrastructure.Out.DbAccess.FluentApi.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AndradeShop.BackOffice.Infrastructure.Out.DbAccess.Contexts.Products.FluentApi
{
    internal class ProductCategoryFA : EntityFA<ProductCategory>
    {
        public override void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasOne(productCategory => productCategory.Product).WithMany(product => product.ProductCategories).HasForeignKey(productCategory => productCategory.ProductId);
            builder.HasOne(productCategory => productCategory.Category).WithMany(category => category.ProductCategories).HasForeignKey(productCategory => productCategory.CategoryId);
            base.Configure(builder);
        }
    }
}
