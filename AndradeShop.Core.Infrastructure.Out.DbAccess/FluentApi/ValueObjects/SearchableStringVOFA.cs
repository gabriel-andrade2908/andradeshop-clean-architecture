﻿using AndradeShop.Core.Domain.Interfaces.Entities;
using AndradeShop.Core.Domain.ValueObject;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AndradeShop.Core.Infrastructure.Out.DbAccess.FluentApi.ValueObjects
{
    public class SearchableStringVOFA
    {
        public static Action<OwnedNavigationBuilder<TEntity, SearchableStringVO>> Map<TEntity>(bool requied, int maxLength) where TEntity : class, IEntity
        {
            return searchableStringBuilder =>
            {
                if (requied)
                {
                    searchableStringBuilder.Property(stringPesquisavel => stringPesquisavel.Value).IsRequired();
                    searchableStringBuilder.Property(stringPesquisavel => stringPesquisavel.SearchableValue).IsRequired();
                }
                searchableStringBuilder.Property(stringPesquisavel => stringPesquisavel.Value).HasMaxLength(maxLength);
                searchableStringBuilder.Property(stringPesquisavel => stringPesquisavel.SearchableValue).HasMaxLength(maxLength);
            };
        }
    }
}
