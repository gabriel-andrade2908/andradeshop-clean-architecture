namespace AndradeShop.Core.Domain.Interfaces.Entities
{
    public interface IEntityWithDomainValidations<TEntity> : IEntity, IClassWithDomainValidations<TEntity> where TEntity : IEntity
    {
    }
}
