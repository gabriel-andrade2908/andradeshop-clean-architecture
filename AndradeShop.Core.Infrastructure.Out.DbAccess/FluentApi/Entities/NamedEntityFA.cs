﻿using AndradeShop.Core.Domain.Entities;
using AndradeShop.Core.Infrastructure.Out.DbAccess.FluentApi.ValueObjects;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AndradeShop.Core.Infrastructure.Out.DbAccess.FluentApi.Entities
{
    public class NamedEntityFA<TEntity> : EntityFA<TEntity> where TEntity : NamedEntity<TEntity>
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.OwnsOne(entity => entity.Name, SearchableStringVOFA.Map<TEntity>(true, MAX_LENGTH_DEFAULT));
            base.Configure(builder);

        }
    }
}
