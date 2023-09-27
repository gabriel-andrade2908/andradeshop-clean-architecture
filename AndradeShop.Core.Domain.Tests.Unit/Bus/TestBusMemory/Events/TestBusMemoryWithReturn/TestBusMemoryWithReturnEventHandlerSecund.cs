using AndradeShop.Core.Domain.Services.DomainNotifications;
using MediatR;

namespace AndradeShop.Core.Domain.Tests.Unit.Bus.TestBusMemory.Events.TestBusMemoryWithReturn
{
    internal class TestBusMemoryWithReturnEventHandlerSecund : INotificationHandler<TestBusMemoryWithReturnEvent>
    {
        private readonly DomainNotificationService _domainNotificationService;

        public TestBusMemoryWithReturnEventHandlerSecund(DomainNotificationService domainNotificationService)
        {
            _domainNotificationService = domainNotificationService;
        }

        public Task Handle(TestBusMemoryWithReturnEvent notification, CancellationToken cancellationToken)
        {
            _domainNotificationService.Add("test2", "the secund message has proccess");
            return Task.CompletedTask;
        }
    }
}
