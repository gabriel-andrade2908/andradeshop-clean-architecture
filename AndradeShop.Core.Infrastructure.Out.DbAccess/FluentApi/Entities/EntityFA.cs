using AndradeShop.Core.Domain.Entities;
using AndradeShop.Core.Domain.Helperrs.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AndradeShop.Core.Infrastructure.Out.DbAccess.FluentApi.Entities
{
    public class EntityFA<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : Entity<TEntity>
    {
        protected readonly int MAX_LENGTH_DEFAULT = CoreConstants.MAX_LEN;
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            var tableName = typeof(TEntity).ToString().Split('.').Last();

            builder.HasKey(e => e.Id);

            builder.Property(e => e.CreationDate).IsRequired();
            builder.Property(e => e.Deleted).IsRequired();

            builder.ToTable(tableName);
        }
    }
}
