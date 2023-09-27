﻿using AndradeShop.Core.Application.Tests.Integration.Domain.FakieEntities;
using AndradeShop.Core.Domain.Interfaces.Helpers;
using AndradeShop.Core.Domain.Services.Validations;
using AndradeShop.Core.Domain.Services.Validations.Results;

namespace AndradeShop.Core.Application.Tests.Integration.Tests.FakeCommandHandlers.FakeCreateEntity
{
    internal class MinhaCustomValidation : IValidationStrategyPolicy<FakeEntity>
    {
        private readonly IFakeEntityRepository _repository;

        public MinhaCustomValidation(IFakeEntityRepository repository)
        {
            _repository = repository;
        }

        public ValidationStrategyType WhatDoWhenInvalidStateType => ValidationStrategyType.InGroupValidationResult;

        public async Task<ValidationStrategyPolicyResult> ValidateAsync(FakeEntity entity, CancellationToken cancellationToken = default)
        {
            await _repository.GetByIdAsync(entity.Id);

            // TODO: TODA VALIDA~]AO

            return ValidationStrategyPolicyResult.Valid();
        }
    }
}
