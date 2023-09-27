using AndradeShop.Core.Domain.Interfaces.DTOs;
using AndradeShop.Core.Domain.Services.Bus.Interfaces;

namespace AndradeShop.Core.Domain.Tests.Unit.Bus.TestBusMemory.Commands.TestBusMemoryWithReturn
{
    public class TestBusMemoryWithReturnCommand : IAppMessage<Guid>, IEntityDTO
    {
        public Guid Id { get; set; }
    }
}
