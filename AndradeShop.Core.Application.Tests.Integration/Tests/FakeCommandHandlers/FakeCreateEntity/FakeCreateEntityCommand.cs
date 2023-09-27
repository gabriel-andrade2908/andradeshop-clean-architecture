using AndradeShop.Core.Domain.GenericDTOs.Entities;
using AndradeShop.Core.Domain.Services.Bus.Interfaces;

namespace AndradeShop.Core.Application.Tests.Integration.Tests.FakeCommandHandlers.FakeCreateEntity
{
    internal class FakeCreateEntityCommand : NamedEntityDTO, IAppMessage<Guid?>
    {
        public FakeCreateEntityCommand()
        {
        }

        public string Description { get; set; }
    }
}
