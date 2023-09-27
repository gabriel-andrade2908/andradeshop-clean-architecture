using AndradeShop.Core.Application.In.Commands.UpdateEntity;
using AndradeShop.Core.Application.Tests.Integration.Domain.FakieEntities;
using AndradeShop.Core.Domain.Services.DomainNotifications;
using MediatR;

namespace AndradeShop.Core.Application.Tests.Integration.Tests.FakeCommandHandlers.FakeUpdateEntity
{
    internal class FakeUpdateEntityCommandHandler : UpdateEntityCommandHandler<FakeEntity, IFakeEntityRepository, FakeUpdateEntityCommand>
    {
        public FakeUpdateEntityCommandHandler(IMediator mediator, IFakeEntityRepository repository, DomainNotificationService domainNotificationService) : base(mediator, repository, domainNotificationService)
        {
        }

        protected override void SetUpdateDataInEntity(FakeEntity entity, FakeUpdateEntityCommand request) => entity.Update(request.Name, request.Description);
    }
}
