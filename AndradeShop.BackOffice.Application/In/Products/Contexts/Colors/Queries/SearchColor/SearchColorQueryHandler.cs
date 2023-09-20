using AndradeShop.BackOffice.Domain.Products.Contexts.Colors;
using AndradeShop.Core.Application.In.Queries.SearchNamedEntity;
using AndradeShop.Core.Domain.GenericDTOs.Entities;
using MediatR;

namespace AndradeShop.BackOffice.Application.In.Products.Contexts.Colors.Queries.SearchColor
{
    internal class SearchColorQueryHandler : SearchNamedEntityQueryHandler<Color, IColorRepository, SearchColorQuery, NamedEntityDTO>
    {
        public SearchColorQueryHandler(IMediator mediator, IColorRepository repository) : base(mediator, repository)
        {
        }
    }
}
