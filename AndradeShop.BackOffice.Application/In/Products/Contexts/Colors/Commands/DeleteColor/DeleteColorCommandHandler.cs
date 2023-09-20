using AndradeShop.BackOffice.Domain.Products.Contexts.Colors;
using AndradeShop.Core.Application.In.Commands.DeleteEntity;
using MediatR;

namespace AndradeShop.BackOffice.Application.In.Products.Contexts.Colors.Commands.DeleteColor
{
    public class DeleteColorCommandHandler : DeleteEntityCommandHandler<Color, IColorRepository, DeleteColorCommand>
    {
        public DeleteColorCommandHandler(IMediator mediator, IColorRepository repository) : base(mediator, repository)
        {
        }
    }
}
