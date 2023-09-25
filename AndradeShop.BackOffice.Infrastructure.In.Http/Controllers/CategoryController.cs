using AndradeShop.BackOffice.Application.In.Products.Contexts.Categories.Commands.AddCategory;
using AndradeShop.BackOffice.Application.In.Products.Contexts.Categories.Commands.DeleteCategory;
using AndradeShop.BackOffice.Application.In.Products.Contexts.Categories.Commands.UpdateCategory;
using AndradeShop.BackOffice.Application.In.Products.Contexts.Categories.Queries.GetCategoryById;
using AndradeShop.Core.Domain.Auth;
using AndradeShop.Core.Domain.GenericDTOs.Entities;
using AndradeShop.Core.Domain.Services.Bus;
using AndradeShop.Core.Domain.Services.DomainNotifications;
using AndradeShop.Infrastructure.In.Controllers;
using AndradeShop.Infrastructure.In.Services;
using Microsoft.AspNetCore.Mvc;

namespace AndradeShop.BackOffice.Infrastructure.In.Http.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : EntityController<GetCategoryByIdQuery, NamedEntityDTO,
        AddCategoryCommand, UpdateCategoryCommand, DeleteCategoryCommand>
    {
        public CategoryController(DomainNotificationService domainNotificationService, UserHttpRequest usuarioHttpRequest, BusService busService) : base(domainNotificationService, usuarioHttpRequest, busService)
        {
        }

        protected override HttpAuthParameters GetAuthParameters()
        {
            return HttpAuthParameters.GetAnonymousAuth();
        }
    }
}
