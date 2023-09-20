using AndradeShop.BackOffice.Domain.Products;
using AndradeShop.BackOffice.Domain.Products.SubEntities;
using AndradeShop.Core.Application.In.Commands.UpdateEntity;
using AndradeShop.Core.Domain.Services.DomainNotifications;
using MediatR;

namespace AndradeShop.BackOffice.Application.In.Products.Commands.UpdateProduct
{
    internal class UpdateProductCommandHandler : UpdateEntityCommandHandler<Product, IProductRepository, UpdateProductCommand>
    {
        public UpdateProductCommandHandler(IMediator mediator, IProductRepository repository, DomainNotificationService domainNotificationService) : base(mediator, repository, domainNotificationService)
        {
        }

        protected override void SetUpdateDataInEntity(Product entity, UpdateProductCommand request)
        {
            entity.UpdateFormData(
                request.Name,
                request.Price,
                request.Description,
                request.ProductCategories.Select(categoryDTO => new ProductCategory(Guid.NewGuid(), request.Id, categoryDTO.Id)).ToList(),
                request.ProductColors.Select(colorDTO => new ProductColor(Guid.NewGuid(), request.Id, colorDTO.Id, colorDTO.StockQuantity)).ToList()
                );

        }
    }
}
