using AndradeShop.Core.Domain.GenericDTOs.Entities;
using AndradeShop.Core.Domain.GenericDTOs.Search;
using AndradeShop.Core.Domain.Services.Bus.Interfaces;

namespace AndradeShop.BackOffice.Application.In.Products.Contexts.Colors.Queries.SearchColor
{
    public class SearchColorQuery : SearchQuery, IAppMessage<IEnumerable<NamedEntityDTO>>
    {
    }
}
