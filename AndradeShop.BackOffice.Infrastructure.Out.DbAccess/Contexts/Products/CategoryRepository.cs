using AndradeShop.BackOffice.Domain.Products.Contexts.Categories;
using AndradeShop.Core.Infrastructure.Out.DbAccess.Repositories;
using ShopOnContainers.BackOffice.Domain.Products.Contexts.Categories;

namespace AndradeShop.BackOffice.Infrastructure.Out.DbAccess.Contexts.Products
{
    internal class CategoryRepository : NamedEntityRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(BackOfficeDb dbContext) : base(dbContext)
        {
        }
    }
}
