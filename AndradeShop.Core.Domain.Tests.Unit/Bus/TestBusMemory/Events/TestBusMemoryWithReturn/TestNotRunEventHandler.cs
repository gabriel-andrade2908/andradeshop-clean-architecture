using AndradeShop.Core.Domain.Services.DomainNotifications;
using MediatR;

namespace AndradeShop.Core.Domain.Tests.Unit.Bus.TestBusMemory.Events.TestBusMemoryWithReturn
{
    internal class TestNotRunEventHandler : INotificationHandler<TestNotRunEvent>
    {
        private readonly DomainNotificationService _domainNotificationService;

        public Task Handle(TestNotRunEvent notification, CancellationToken cancellationToken)
        {
            _domainNotificationService.Add("error", "the handler shouldn't run");
            return Task.CompletedTask;
        }
    }
}
