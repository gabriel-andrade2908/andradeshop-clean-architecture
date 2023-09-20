using AndradeShop.Core.Domain.GenericDTOs.Search;
using AndradeShop.Core.Domain.Services.Bus.Interfaces;

namespace AndradeShop.BackOffice.Application.In.Products.Queries.SearchProduct
{
    public class SearchProductQuery : SearchQuery, IAppMessage<IEnumerable<SearchProductViewModel>>
    {

    }
}
