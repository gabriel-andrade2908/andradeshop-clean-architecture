using AndradeShop.Core.Application.Services.EventSourcing.DTOs;
using AndradeShop.Core.Domain.EventSourcing;
using MediatR;

namespace AndradeShop.Core.Application.Services.EventSourcing.OnError
{
    public class OnErrorCommand : BaseEventStored, IRequest
    {
        public OnErrorCommand(object command, EventType commandType, Exception exception) : base(command, commandType)
        {
            Exception = exception;
        }


        public Exception Exception { get; private set; }
    }
}
