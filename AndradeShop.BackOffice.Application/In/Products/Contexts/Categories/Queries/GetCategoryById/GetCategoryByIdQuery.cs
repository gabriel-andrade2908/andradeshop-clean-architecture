using AndradeShop.Core.Domain.GenericDTOs.Entities;
using AndradeShop.Core.Domain.Services.Bus.Interfaces;

namespace AndradeShop.BackOffice.Application.In.Products.Contexts.Categories.Queries.GetCategoryById
{
    public class GetCategoryByIdQuery : EntityDTO, IAppMessage<NamedEntityDTO>
    {
    }
}
