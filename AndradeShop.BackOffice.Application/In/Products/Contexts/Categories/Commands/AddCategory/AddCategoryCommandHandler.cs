using AndradeShop.BackOffice.Domain.Products.Contexts.Categories;
using AndradeShop.Core.Application.In.Commands.AddEntity;
using AndradeShop.Core.Domain.Services.DomainNotifications;
using MediatR;
using ShopOnContainers.BackOffice.Domain.Products.Contexts.Categories;

namespace AndradeShop.BackOffice.Application.In.Products.Contexts.Categories.Commands.AddCategory
{
    internal class AddCategoryCommandHandler : AddEntityCommandHandler<Category, ICategoryRepository, AddCategoryCommand>
    {
        public AddCategoryCommandHandler(IMediator mediator, ICategoryRepository repository, DomainNotificationService domainNotificationService) : base(mediator, repository, domainNotificationService)
        {
        }

        protected override Category ParseCommandToEntity(AddCategoryCommand request)
        {
            return new Category(request.Id, request.Name);
        }
    }
}
