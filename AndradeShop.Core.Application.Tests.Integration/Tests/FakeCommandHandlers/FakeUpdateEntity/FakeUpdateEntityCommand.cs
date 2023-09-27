using AndradeShop.Core.Domain.GenericDTOs.Entities;
using AndradeShop.Core.Domain.Services.Bus.Interfaces;

namespace AndradeShop.Core.Application.Tests.Integration.Tests.FakeCommandHandlers.FakeUpdateEntity
{
    internal class FakeUpdateEntityCommand : NamedEntityDTO, IAppMessage
    {
        public string Description { get; set; }
    }
}
