using AndradeShop.Core.Domain.Auth;
using AndradeShop.Core.Domain.GenericDTOs.Search;
using AndradeShop.Core.Domain.Interfaces.DTOs;
using AndradeShop.Core.Domain.Services.Bus;
using AndradeShop.Core.Domain.Services.Bus.Interfaces;
using AndradeShop.Core.Domain.Services.DomainNotifications;
using Microsoft.AspNetCore.Mvc;

namespace AndradeShop.Infrastructure.In.Controllers
{
    public abstract class NamedEntityController<TGetByIdQuery, TGetByIdViewModel, TSearchEntityQuery, TSearchEntityViewModel, TAddCommand, TUpdateCommand, TDeleteCommand> : EntityController<TGetByIdQuery, TGetByIdViewModel, TAddCommand, TUpdateCommand, TDeleteCommand>
        where TGetByIdQuery : class, IEntityDTO, IAppMessage<TGetByIdViewModel>, new()
        where TSearchEntityQuery : SearchQuery, IAppMessage<IEnumerable<TSearchEntityViewModel>>, new()
        where TAddCommand : class, IEntityDTO, IAppMessage<Guid?>
        where TUpdateCommand : class, IEntityDTO, IAppMessage
        where TDeleteCommand : class, IEntityDTO, IAppMessage, new()
    {
        protected NamedEntityController(DomainNotificationService domainNotificationService, UserHttpRequest usuarioHttpRequest, BusService busService) : base(domainNotificationService, usuarioHttpRequest, busService)
        {
        }

        [HttpGet]
        public virtual async Task<IActionResult> Search([FromQuery] TSearchEntityQuery query)
        {
            var queryResult = await BusService.SendMessage<TSearchEntityQuery, IEnumerable<TSearchEntityViewModel>>(query);
            return ResponseCareErrors(() => Ok(queryResult.Result));
        }
    }
}
