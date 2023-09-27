﻿// <auto-generated />
using System;
using AndradeShop.Core.Application.Tests.Integration.Infrastructure.DbAccess.DbConnection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AndradeShop.Core.Application.Tests.Integration.Migrations
{
    [DbContext(typeof(TestDb))]
    partial class TestDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AndradeShop.Core.Application.Tests.Integration.Domain.FakieEntities.FakeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("FakeEntity", (string)null);
                });

            modelBuilder.Entity("AndradeShop.Core.Application.Tests.Integration.Domain.FakieEntities.FakeEntity", b =>
                {
                    b.OwnsOne("AndradeShop.Core.Domain.ValueObject.SearchableStringVO", "Name", b1 =>
                        {
                            b1.Property<Guid>("FakeEntityId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("SearchableValue")
                                .IsRequired()
                                .HasMaxLength(150)
                                .HasColumnType("nvarchar(150)");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(150)
                                .HasColumnType("nvarchar(150)");

                            b1.HasKey("FakeEntityId");

                            b1.ToTable("FakeEntity");

                            b1.WithOwner()
                                .HasForeignKey("FakeEntityId");
                        });

                    b.Navigation("Name")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
