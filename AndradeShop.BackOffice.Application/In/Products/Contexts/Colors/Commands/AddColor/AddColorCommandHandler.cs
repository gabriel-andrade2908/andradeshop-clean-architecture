using AndradeShop.BackOffice.Domain.Products.Contexts.Colors;
using AndradeShop.Core.Application.In.Commands.AddEntity;
using AndradeShop.Core.Domain.Services.DomainNotifications;
using MediatR;

namespace AndradeShop.BackOffice.Application.In.Products.Contexts.Colors.Commands.AddColor
{
    internal class AddColorCommandHandler : AddEntityCommandHandler<Color, IColorRepository, AddColorCommand>
    {
        public AddColorCommandHandler(IMediator mediator, IColorRepository repository, DomainNotificationService domainNotificationService) : base(mediator, repository, domainNotificationService)
        {
        }

        protected override Color ParseCommandToEntity(AddColorCommand request)
        {
            return new Color(request.Id, request.Name);
        }
    }
}
