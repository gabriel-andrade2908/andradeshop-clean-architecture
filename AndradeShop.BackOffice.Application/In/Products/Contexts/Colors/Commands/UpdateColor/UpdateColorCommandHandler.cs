using AndradeShop.BackOffice.Domain.Products.Contexts.Colors;
using AndradeShop.Core.Application.In.Commands.UpdateEntity;
using AndradeShop.Core.Domain.Services.DomainNotifications;
using MediatR;

namespace AndradeShop.BackOffice.Application.In.Products.Contexts.Colors.Commands.UpdateColor
{
    internal class UpdateColorCommandHandler : UpdateEntityCommandHandler<Color, IColorRepository, UpdateColorCommand>
    {
        public UpdateColorCommandHandler(IMediator mediator, IColorRepository repository, DomainNotificationService domainNotificationService) : base(mediator, repository, domainNotificationService)
        {
        }

        protected override void SetUpdateDataInEntity(Color entity, UpdateColorCommand request)
        {
            entity.SetName(request.Name);
        }
    }
}
