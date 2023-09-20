using AndradeShop.BackOffice.Domain.Products.Contexts.Colors;
using AndradeShop.Core.Application.In.Queries.GetEntityById;
using AndradeShop.Core.Domain.GenericDTOs.Entities;
using MediatR;

namespace AndradeShop.BackOffice.Application.In.Products.Contexts.Colors.Queries.GetColorById
{
    internal class GetColorByIdQueryHandler : GetEntityByIdQueryHandler<Color, IColorRepository, GetColorByIdQuery, NamedEntityDTO>
    {
        public GetColorByIdQueryHandler(IMediator mediator, IColorRepository repository) : base(mediator, repository)
        {
        }

        protected override NamedEntityDTO MapEntityToViewModel(Color entity)
        {
            return new NamedEntityDTO
            {
                Id = entity.Id,
                Name = entity.Name.Value
            };
        }
    }
}
