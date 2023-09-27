using AndradeShop.Core.Application.Tests.Integration.Domain.FakieEntities;
using AndradeShop.Core.Application.Tests.Integration.Infrastructure.DbAccess.DbConnection;
using AndradeShop.Core.Infrastructure.Out.DbAccess.Repositories;

namespace AndradeShop.Core.Application.Tests.Integration.Infrastructure.DbAccess.FakeEntities
{
    public class FakeEntityRepository : NamedEntityRepository<FakeEntity>, IFakeEntityRepository
    {
        public FakeEntityRepository(TestDb dbContext) : base(dbContext)
        {
        }

    }
}
