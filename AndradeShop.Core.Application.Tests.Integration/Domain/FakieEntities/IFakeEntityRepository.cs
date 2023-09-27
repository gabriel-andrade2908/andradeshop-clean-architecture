using AndradeShop.Core.Domain.Interfaces.Repositories;

namespace AndradeShop.Core.Application.Tests.Integration.Domain.FakieEntities
{
    public interface IFakeEntityRepository : IWriterRepository<FakeEntity>, IReaderRepository<FakeEntity>
    {
    }
}
