using AndradeShop.BackOffice.Domain.Products.Contexts.Colors;
using AndradeShop.Core.Infrastructure.Out.DbAccess.Repositories;

namespace AndradeShop.BackOffice.Infrastructure.Out.DbAccess.Contexts.Products
{
    internal class ColorRepository : NamedEntityRepository<Color>, IColorRepository
    {
        public ColorRepository(BackOfficeDb dbContext) : base(dbContext)
        {
        }
    }
}
