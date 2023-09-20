using AndradeShop.BackOffice.Domain.Products;
using AndradeShop.Core.Application.In.Queries.SearchNamedEntity;
using MediatR;

namespace AndradeShop.BackOffice.Application.In.Products.Queries.SearchProduct
{
    internal class SearchProductQueryHandler : SearchNamedEntityQueryHandler<Product, IProductRepository, SearchProductQuery, SearchProductViewModel>
    {
        public SearchProductQueryHandler(IMediator mediator, IProductRepository repository) : base(mediator, repository)
        {
        }

    }
}
