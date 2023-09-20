using AndradeShop.BackOffice.Application.In.Products.Commands.AddProduct;
using AndradeShop.BackOffice.Application.In.Products.Commands.DeleteProduct;
using AndradeShop.BackOffice.Application.In.Products.Commands.UpdateProduct;
using AndradeShop.BackOffice.Application.In.Products.Queries.GetProductById;
using AndradeShop.Core.Domain.Auth;
using AndradeShop.Core.Domain.Services.Bus;
using AndradeShop.Core.Domain.Services.DomainNotifications;
using AndradeShop.Infrastructure.In.Controllers;
using AndradeShop.Infrastructure.In.Services;
using Microsoft.AspNetCore.Mvc;

namespace AndradeShop.BackOffice.Infrastructure.In.Http.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : EntityController<GetProductByIdQuery, GetProductByIdViewModel, AddProductCommand, UpdateProductCommand, DeleteProductCommand>
    {
        public ProductController(DomainNotificationService domainNotificationService, UserHttpRequest usuarioHttpRequest, BusService busService) : base(domainNotificationService, usuarioHttpRequest, busService)
        {
        }

        protected override HttpAuthParameters GetAuthParameters()
        {
            return HttpAuthParameters.GetAnonymousAuth();
        }
    }
}
