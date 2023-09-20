using AndradeShop.Core.Domain.GenericDTOs.Entities;
using AndradeShop.Core.Domain.GenericDTOs.Search;
using AndradeShop.Core.Domain.Services.Bus.Interfaces;

namespace AndradeShop.BackOffice.Application.In.Products.Contexts.Categories.Queries.SearchCategory
{
    public class SearchCategoryQuery : SearchQuery, IAppMessage<IEnumerable<NamedEntityDTO>>
    {

    }
}
