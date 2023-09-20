using AndradeShop.BackOffice.Domain.Products.Contexts.Categories;
using AndradeShop.Core.Application.In.Commands.UpdateEntity;
using AndradeShop.Core.Domain.Services.DomainNotifications;
using MediatR;
using ShopOnContainers.BackOffice.Domain.Products.Contexts.Categories;

namespace AndradeShop.BackOffice.Application.In.Products.Contexts.Categories.Commands.UpdateCategory
{
    internal class UpdateCategoryCommandHandler : UpdateEntityCommandHandler<Category, ICategoryRepository, UpdateCategoryCommand>
    {
        public UpdateCategoryCommandHandler(IMediator mediator, ICategoryRepository repository, DomainNotificationService domainNotificationService) : base(mediator, repository, domainNotificationService)
        {
        }

        protected override void SetUpdateDataInEntity(Category entity, UpdateCategoryCommand request)
        {
            entity.SetName(request.Name);
        }
    }
}
