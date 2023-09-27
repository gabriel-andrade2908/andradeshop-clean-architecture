using AndradeShop.Core.Application.In.Commands.Bases;
using AndradeShop.Core.Domain.EventSourcing;
using AndradeShop.Core.Domain.Services.Bus.Models;
using AndradeShop.Core.Domain.Services.DomainNotifications;
using MediatR;

namespace AndradeShop.Core.Domain.Tests.Unit.Bus.TestBusMemory.Commands.TestBusMemoryWithoutReturn
{
    internal class TestBusMemoryWithoutReturnCommandHandler : BaseRequestHandler<TestBusMemoryWithoutReturnCommand>
    {
        private readonly DomainNotificationService _domainNotificationService;

        public TestBusMemoryWithoutReturnCommandHandler(IMediator mediator, DomainNotificationService domainNotificationService) : base(mediator)
        {
            _domainNotificationService = domainNotificationService;
        }

        public override Task<CommandResult> ExecuteAsync(TestBusMemoryWithoutReturnCommand request, CancellationToken cancellationToken)
        {
            _domainNotificationService.Add("test", "the first message has proccess");
            if (request.ThrowError)
                throw new Exception("Expected Error");

            return Task.FromResult(CommandResult.CommandFinished());
        }

        protected override EventType GetEventType()
        {
            return EventType.Create;
        }
    }
}
