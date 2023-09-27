using AndradeShop.Core.Domain.Entities;

namespace AndradeShop.Core.Domain.Tests.Unit.FakeEntites
{
    internal class FakeEntity : Entity<FakeEntity>
    {
        public FakeEntity(Guid id) : base(id)
        {
        }
    }
}
