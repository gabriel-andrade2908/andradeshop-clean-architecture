using AndradeShop.Core.Domain.GenericDTOs.Entities;
using AndradeShop.Core.Domain.Services.Bus.Interfaces;

namespace AndradeShop.BackOffice.Application.In.Products.Contexts.Colors.Queries.GetColorById
{
    public class GetColorByIdQuery : EntityDTO, IAppMessage<NamedEntityDTO>
    {
    }
}
