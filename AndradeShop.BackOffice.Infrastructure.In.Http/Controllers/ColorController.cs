using AndradeShop.BackOffice.Application.In.Products.Contexts.Colors.Commands.AddColor;
using AndradeShop.BackOffice.Application.In.Products.Contexts.Colors.Commands.DeleteColor;
using AndradeShop.BackOffice.Application.In.Products.Contexts.Colors.Commands.UpdateColor;
using AndradeShop.BackOffice.Application.In.Products.Contexts.Colors.Queries.GetColorById;
using AndradeShop.Core.Domain.Auth;
using AndradeShop.Core.Domain.GenericDTOs.Entities;
using AndradeShop.Core.Domain.Services.Bus;
using AndradeShop.Core.Domain.Services.DomainNotifications;
using AndradeShop.Infrastructure.In.Services;
using Microsoft.AspNetCore.Mvc;

namespace AndradeShop.BackOffice.Infrastructure.In.Http.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ColorController : AndradeShop.Infrastructure.In.Controllers.EntityController<GetColorByIdQuery, NamedEntityDTO, AddColorCommand, UpdateColorCommand, DeleteColorCommand>
    {
        public ColorController(DomainNotificationService domainNotificationService, UserHttpRequest usuarioHttpRequest, BusService busService) : base(domainNotificationService, usuarioHttpRequest, busService)
        {
        }

        protected override HttpAuthParameters GetAuthParameters()
        {
            return HttpAuthParameters.GetAnonymousAuth();
        }
    }
}
