using AndradeShop.BackOffice.Domain.Products;
using AndradeShop.Core.Infrastructure.Out.DbAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AndradeShop.BackOffice.Infrastructure.Out.DbAccess.Contexts.Products
{
    internal class ProductRepository : NamedEntityRepository<Product>, IProductRepository
    {
        public ProductRepository(BackOfficeDb dbContext) : base(dbContext)
        {
        }

        protected override IQueryable<Product> ConfigureQueryOnGetByIdTemplateMethod(IQueryable<Product> query)
        {
            return query.Include(product => product.ProductCategories)
                .ThenInclude(productCategory => productCategory.Category)
                .Include(product => product.ProductColors)
                .ThenInclude(productColor => productColor.Color);
        }

    }
}
