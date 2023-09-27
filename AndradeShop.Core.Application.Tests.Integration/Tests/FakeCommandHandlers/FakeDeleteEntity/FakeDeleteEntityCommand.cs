using AndradeShop.Core.Domain.GenericDTOs.Entities;
using AndradeShop.Core.Domain.Services.Bus.Interfaces;

namespace AndradeShop.Core.Application.Tests.Integration.Tests.FakeCommandHandlers.FakeDeleteEntity
{
    internal class FakeDeleteEntityCommand : EntityDTO, IAppMessage
    {
    }
}
