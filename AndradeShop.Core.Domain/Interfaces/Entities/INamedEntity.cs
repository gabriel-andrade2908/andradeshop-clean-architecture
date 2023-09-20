using AndradeShop.Core.Domain.ValueObject;

namespace AndradeShop.Core.Domain.Interfaces.Entities
{
    public interface INamedEntity : IEntity
    {
        public SearchableStringVO Name { get; }
    }
}
