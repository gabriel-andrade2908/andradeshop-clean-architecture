using AndradeShop.Core.Application.In.Commands.AddEntity;
using AndradeShop.Core.Application.Tests.Integration.Domain.FakieEntities;
using AndradeShop.Core.Domain.Services.DomainNotifications;
using MediatR;

namespace AndradeShop.Core.Application.Tests.Integration.Tests.FakeCommandHandlers.FakeCreateEntity
{
    internal class FakeCreateEntityCommandHandler : AddEntityCommandHandler<FakeEntity, IFakeEntityRepository, FakeCreateEntityCommand>
    {
        public FakeCreateEntityCommandHandler(IMediator mediator, IFakeEntityRepository repository, DomainNotificationService domainNotificationService) : base(mediator, repository, domainNotificationService)
        {

        }

        protected override FakeEntity ParseCommandToEntity(FakeCreateEntityCommand request)
        {
            return new FakeEntity(Guid.NewGuid(), request.Name, request.Description);
        }

    }
}
