using AndradeShop.Core.Domain.Interfaces.Entities;

namespace AndradeShop.Core.Domain.Interfaces.Repositories
{
    public interface IEntityRepository<TEntity> : IReaderRepository<TEntity>, IWriterRepository<TEntity>
        where TEntity : IEntity
    {
    }
}
