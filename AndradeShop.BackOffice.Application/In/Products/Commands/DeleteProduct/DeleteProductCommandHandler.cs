using AndradeShop.BackOffice.Domain.Products;
using AndradeShop.Core.Application.In.Commands.DeleteEntity;
using MediatR;

namespace AndradeShop.BackOffice.Application.In.Products.Commands.DeleteProduct
{
    internal class DeleteProductCommandHandler : DeleteEntityCommandHandler<Product, IProductRepository, DeleteProductCommand>
    {
        public DeleteProductCommandHandler(IMediator mediator, IProductRepository repository) : base(mediator, repository)
        {
        }
    }
}
