﻿using AndradeShop.Core.Domain.Services.Bus.Interfaces;
using AndradeShop.Core.Domain.Services.Bus.Models;

namespace AndradeShop.Core.Application.Tests.Integration.Infrastructure.FakesInfra
{
    public class FakeCleanInfrastructureBus : IInfrastructureBusService
    {
        public FakeCleanInfrastructureBus()
        {
        }

        public Task ConsumerAsync<TData>(Func<TData, Task> onConsume, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task PublishEvent<TData>(TData data, CancellationToken cancellationToken = default)
        {
            return Task.CompletedTask;
        }

        public Task<CommandResult> SendMessage<TData>(TData data, CancellationToken cancellationToken = default)
        {
            return Task.FromResult(CommandResult.CommandFinished());
        }

        public Task<CommandResult<TResponse>> SendMessage<TData, TResponse>(TData data, CancellationToken cancellationToken = default)
        {
#pragma warning disable CS8619 // A anulabilidade de tipos de referência no valor não corresponde ao tipo de destino.
            return Task.FromResult(CommandResult<TResponse>.CommandFinished(default));
#pragma warning restore CS8619 // A anulabilidade de tipos de referência no valor não corresponde ao tipo de destino.
        }

    }
}
