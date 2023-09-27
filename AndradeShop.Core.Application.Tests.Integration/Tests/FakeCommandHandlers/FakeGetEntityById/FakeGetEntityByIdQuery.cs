using AndradeShop.Core.Domain.GenericDTOs.Entities;
using AndradeShop.Core.Domain.Services.Bus.Interfaces;

namespace AndradeShop.Core.Application.Tests.Integration.Tests.FakeCommandHandlers.FakeGetEntityById
{
    internal class FakeGetEntityByIdQuery : EntityDTO, IAppMessage<FakeGetEntityByIdViewModel>
    {
    }
}
