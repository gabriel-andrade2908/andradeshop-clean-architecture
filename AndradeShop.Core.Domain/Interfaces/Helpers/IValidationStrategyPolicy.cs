using AndradeShop.Core.Domain.Services.Validations;
using AndradeShop.Core.Domain.Services.Validations.Results;

namespace AndradeShop.Core.Domain.Interfaces.Helpers
{
    public interface IValidationStrategyPolicy<TEntity>
    {
        ValidationStrategyType WhatDoWhenInvalidStateType { get; }
        Task<ValidationStrategyPolicyResult> ValidateAsync(TEntity entity, CancellationToken cancellationToken = default);
    }
}
