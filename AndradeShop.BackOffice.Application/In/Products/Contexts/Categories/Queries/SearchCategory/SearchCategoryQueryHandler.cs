using AndradeShop.BackOffice.Domain.Products.Contexts.Categories;
using AndradeShop.Core.Application.In.Queries.SearchNamedEntity;
using AndradeShop.Core.Domain.GenericDTOs.Entities;
using MediatR;
using ShopOnContainers.BackOffice.Domain.Products.Contexts.Categories;

namespace AndradeShop.BackOffice.Application.In.Products.Contexts.Categories.Queries.SearchCategory
{
    internal class SearchCategoryQueryHandler : SearchNamedEntityQueryHandler<Category, ICategoryRepository, SearchCategoryQuery, NamedEntityDTO>
    {
        public SearchCategoryQueryHandler(IMediator mediator, ICategoryRepository repository) : base(mediator, repository)
        {
        }
    }
}