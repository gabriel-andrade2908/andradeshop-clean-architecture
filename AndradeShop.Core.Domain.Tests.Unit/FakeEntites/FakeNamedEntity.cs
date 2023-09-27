using AndradeShop.Core.Domain.Entities;

namespace AndradeShop.Core.Domain.Tests.Unit.FakeEntites
{
    internal class FakeNamedEntity : NamedEntity<FakeNamedEntity>
    {
        public FakeNamedEntity(Guid id, string name) : base(id, name)
        {
        }
    }
}
