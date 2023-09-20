using AndradeShop.BackOffice.Domain.Products;
using AndradeShop.BackOffice.Domain.Products.SubEntities;
using AndradeShop.Core.Application.In.Commands.AddEntity;
using AndradeShop.Core.Domain.Services.DomainNotifications;
using MediatR;

namespace AndradeShop.BackOffice.Application.In.Products.Commands.AddProduct
{
    internal class AddProductCommandHandler : AddEntityCommandHandler<Product, IProductRepository, AddProductCommand>
    {
        public AddProductCommandHandler(IMediator mediator, IProductRepository repository, DomainNotificationService domainNotificationService) : base(mediator, repository, domainNotificationService)
        {
        }

        protected override Product ParseCommandToEntity(AddProductCommand request)
        {
            return new Product(request.Id,
                request.Name,
                request.Price,
                request.Enable,
                request.Description,
                request.ProductCategories.Select(categoryDTO => new ProductCategory(Guid.NewGuid(), request.Id, categoryDTO.Id)).ToList(),
                request.ProductColors.Select(colorDTO => new ProductColor(Guid.NewGuid(), request.Id, colorDTO.Id, colorDTO.StockQuantity)).ToList()
                );
        }

    }
}
