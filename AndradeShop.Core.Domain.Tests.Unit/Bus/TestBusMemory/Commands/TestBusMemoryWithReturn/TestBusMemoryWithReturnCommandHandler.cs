using AndradeShop.Core.Application.In.Commands.Bases;
using AndradeShop.Core.Domain.EventSourcing;
using AndradeShop.Core.Domain.Services.Bus.Models;
using AndradeShop.Core.Domain.Services.DomainNotifications;
using MediatR;

namespace AndradeShop.Core.Domain.Tests.Unit.Bus.TestBusMemory.Commands.TestBusMemoryWithReturn
{
    internal class TestBusMemoryWithReturnCommandHandler : BaseRequestHandler<TestBusMemoryWithReturnCommand, Guid>
    {
        private readonly DomainNotificationService _domainNotificationService;

        public TestBusMemoryWithReturnCommandHandler(IMediator mediator, DomainNotificationService domainNotificationService) : base(mediator)
        {
            _domainNotificationService = domainNotificationService;
        }

        public override Task<CommandResult<Guid>> ExecuteAsync(TestBusMemoryWithReturnCommand request, CancellationToken cancellationToken)
        {
            _domainNotificationService.Add("test", "the first message has proccess");
            return Task.FromResult(CommandResult<Guid>.CommandFinished(Guid.NewGuid()));
        }

        protected override EventType GetEventType()
        {
            return EventType.Create;
        }
    }
}
