using AndradeShop.Core.Application.In.Commands.DeleteEntity;
using AndradeShop.Core.Application.Tests.Integration.Domain.FakieEntities;
using MediatR;

namespace AndradeShop.Core.Application.Tests.Integration.Tests.FakeCommandHandlers.FakeDeleteEntity
{
    internal class FakeDeleteEntityCommandHandler : DeleteEntityCommandHandler<FakeEntity, IFakeEntityRepository, FakeDeleteEntityCommand>
    {
        public FakeDeleteEntityCommandHandler(IMediator mediator, IFakeEntityRepository repository) : base(mediator, repository)
        {
        }
    }
}
