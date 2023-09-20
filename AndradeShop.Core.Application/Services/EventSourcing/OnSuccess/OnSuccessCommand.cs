using AndradeShop.Core.Application.Services.EventSourcing.DTOs;
using AndradeShop.Core.Domain.EventSourcing;
using MediatR;

namespace AndradeShop.Core.Application.Services.EventSourcing.OnSuccess
{
    public class OnSuccessCommand : BaseEventStored, IRequest
    {
        public OnSuccessCommand(object command, EventType commandType) : base(command, commandType)
        {
        }
    }

}
