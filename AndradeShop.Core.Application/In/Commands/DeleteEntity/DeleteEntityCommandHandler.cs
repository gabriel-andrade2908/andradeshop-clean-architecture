﻿using AndradeShop.Core.Application.In.Commands.Bases;
using AndradeShop.Core.Domain.EventSourcing;
using AndradeShop.Core.Domain.Helpers.Exceptions;
using AndradeShop.Core.Domain.Interfaces.DTOs;
using AndradeShop.Core.Domain.Interfaces.Entities;
using AndradeShop.Core.Domain.Interfaces.Repositories;
using AndradeShop.Core.Domain.Services.Bus.Interfaces;
using AndradeShop.Core.Domain.Services.Bus.Models;
using MediatR;

namespace AndradeShop.Core.Application.In.Commands.DeleteEntity
{
    public abstract class DeleteEntityCommandHandler<TEntity, TRepository, TDeleteCommand> : BaseRequestHandler<TDeleteCommand>
        where TEntity : IEntityWithDomainValidations<TEntity>
        where TRepository : IWriterRepository<TEntity>
        where TDeleteCommand : IEntityDTO, IAppMessage
    {
        protected readonly TRepository Repository;

        protected DeleteEntityCommandHandler(IMediator mediator, TRepository repository) : base(mediator)
        {
            Repository = repository;
        }

        protected override EventType GetEventType() => EventType.Delete;
        public override async Task<CommandResult> ExecuteAsync(TDeleteCommand request, CancellationToken cancellationToken)
        {
            await BeforeDelete(request, cancellationToken);
            await Repository.DeleteAsync(request.Id, cancellationToken);
            await AfterDeleteEntity(request, cancellationToken);

            return CommandResult.CommandFinished();
        }

        private Task BeforeDelete(TDeleteCommand request, CancellationToken cancellationToken)
        {
            try
            {
                return BeforeDeleteTemplateMethod(request, cancellationToken);
            }
            catch (Exception ex)
            {
                throw GetTemplateMethodException(request.Id, "BeforeDeleteTemplateMethod", ex);
            }
        }
        protected virtual Task BeforeDeleteTemplateMethod(TDeleteCommand request, CancellationToken cancellationToken) => Task.CompletedTask;

        private Task AfterDeleteEntity(TDeleteCommand request, CancellationToken cancellationToken)
        {
            try
            {
                return AfterDeleteEntityTemplateMethod(request, cancellationToken);
            }
            catch (Exception ex)
            {
                throw GetTemplateMethodException(request.Id, "AfterDeleteEntityTemplateMethod", ex);
            }
        }
        protected virtual Task AfterDeleteEntityTemplateMethod(TDeleteCommand request, CancellationToken cancellationToken) => Task.CompletedTask;
        private static TemplateMathodException GetTemplateMethodException(Guid? entityId, string templateMathodName, Exception ex)
        {
            return TemplateMathodException.Create(typeof(TEntity), typeof(DeleteEntityCommandHandler<TEntity, TRepository, TDeleteCommand>), entityId, templateMathodName, ex);
        }
    }
}
