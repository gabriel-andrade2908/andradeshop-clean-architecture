using AndradeShop.BackOffice.Application.In.Products.Commands.AddProduct;
using AndradeShop.BackOffice.Application.In.Products.Commands.Shared;
using AndradeShop.BackOffice.Application.In.Products.Contexts.Categories.Commands.AddCategory;
using AndradeShop.BackOffice.Application.In.Products.Contexts.Colors.Commands.AddColor;
using AndradeShop.BackOffice.Domain.Products;
using AndradeShop.BackOffice.Domain.Products.Contexts.Colors;
using AndradeShop.BackOffice.Domain.Products.ValueObjects.DTOs;
using AndradeShop.BackOffice.Infrastructure.Tests.Integration.Infrastructure;
using AndradeShop.Core.Domain.GenericDTOs.Entities;
using AndradeShop.Core.Domain.Services.Bus;
using AndradeShop.Core.Domain.Services.Bus.Models;
using Microsoft.Extensions.DependencyInjection;
using ShopOnContainers.BackOffice.Domain.Products.Contexts.Categories;
using Xunit;

namespace AndradeShop.BackOffice.Infrastructure.Tests.Integration.Products
{
    [Collection(nameof(ProductHandlerCollection))]
    public class ProductTests
    {
        private readonly BusService _bus;
        private readonly ProductHandlerFixture _fixture;
        private readonly IProductRepository _repository;
        private readonly ServiceProvider _serviceProvider;

        public ProductTests(ProductHandlerFixture fixture)
        {
            _fixture = fixture;

            _serviceProvider = new TestServiceProvider().ServiceProvider;
            _bus = _serviceProvider.GetRequiredService<BusService>();
            _repository = _serviceProvider.GetRequiredService<IProductRepository>();
        }

        [Trait("Category", "3 - BackOffice.Product")]
        [Fact(DisplayName = "1 - AddProduct Success")]
        public async Task CreateEntityComandHandler_NewEntity_Success()
        {
            IReadOnlyCollection<ProductColorDTO> colors = await GetColorsAsync();
            IReadOnlyCollection<EntityDTO> categories = await GetCategoriesAsync();

            var command = new AddProductCommand()
            {
                Id = Guid.NewGuid(),
                Name = "test",
                Description = "test",
                Enable = true,
                Price = new ProductPriceDTO() { Cost = 10, Sale = 20 },
                ProductCategories = categories,
                ProductColors = colors
            };

            CommandResult<Guid?> commandResult = await _bus.SendMessage<AddProductCommand, Guid?>(command);
            Assert.NotNull(commandResult.Result);
            Assert.NotEqual(Guid.Empty, commandResult.Result);

            Product addedEntity = await _repository.GetByIdAsync(commandResult.Result!.Value);

            Assert.Equal(command.Id, addedEntity!.Id);
            Assert.Equal(command.Name, addedEntity.Name.Value);
            Assert.Equal(command.Description, addedEntity.Description);
            Assert.Equal(command.Enable, addedEntity.Enable);
            Assert.Equal(command.Price.Cost, addedEntity.Price.Cost);
            Assert.Equal(command.Price.Sale, addedEntity.Price.Sale);

            Assert.Equal(command.ProductCategories.Count, addedEntity.ProductCategories.Count);
            Assert.Collection(command.ProductCategories, pc => Assert.Equal(pc.Id, addedEntity.ProductCategories.ToList()[0].CategoryId),
                                                         pc => Assert.Equal(pc.Id, addedEntity.ProductCategories.ToList()[1].CategoryId));

            Assert.Equal(command.ProductColors.Count, addedEntity.ProductColors.Count);
            Assert.Collection(command.ProductColors, pc => Assert.Equal(pc.Id, addedEntity.ProductColors.ToList()[0].ColorId),
                                                     pc => Assert.Equal(pc.Id, addedEntity.ProductColors.ToList()[1].ColorId));

            _fixture.AddProduct(addedEntity!);

        }
        private static IReadOnlyCollection<AddColorCommand> GetDefaultColors()
        {

            var addColor1Command = new AddColorCommand()
            {
                Id = new Guid("18b71e22-53bb-4645-a28d-b913d816dd61"),
                Name = "test color - red",
            };
            var addColor2Command = new AddColorCommand()
            {
                Id = new Guid("877e4e8e-675a-4d5e-85c8-07929a90431d"),
                Name = "test color - blue",
            };

            var comands = new List<AddColorCommand>() { addColor1Command, addColor2Command };
            return comands;
        }
        private static IReadOnlyCollection<AddCategoryCommand> GetDefaultCategories()
        {
            var addCategory1Command = new AddCategoryCommand()
            {
                Id = new Guid("be4c77e3-a9e7-41b6-a764-a30454c7ed44"),
                Name = "test category 1",
            };
            var addCategory2Command = new AddCategoryCommand()
            {
                Id = new Guid("ee4c29df-1876-4052-8256-77d1e0f2d714"),
                Name = "test category 2"
            };
            var comands = new List<AddCategoryCommand>() { addCategory1Command, addCategory2Command };
            return comands;
        }

        private async Task<IReadOnlyCollection<ProductColorDTO>> GetColorsAsync()
        {
            var colorRepository = _serviceProvider.GetRequiredService<IColorRepository>();

            IEnumerable<NamedEntityDTO> databaseColors = colorRepository.SearchByKeywordAsync().Result;
            var colorsIds = new List<Guid>();
            if (databaseColors.Any())
                colorsIds.AddRange(databaseColors.Select(color => color.Id));
            else
                colorsIds.AddRange(await CreateDefaultColorsAsync());

            var colorsResponse = new List<ProductColorDTO>();
            foreach (Guid id in colorsIds)
            {
                colorsResponse.Add(new ProductColorDTO { Id = id, StockQuantity = 5 });
            }
            return colorsResponse;
        }

        private async Task<IList<Guid>> CreateDefaultColorsAsync()
        {
            var colorsIds = new List<Guid>();

            foreach (AddColorCommand color in GetDefaultColors())
            {
                CommandResult<Guid?> colorId = await _bus.SendMessage<AddColorCommand, Guid?>(color);
                Guid generatedGuid = colorId.Result.Value;
                colorsIds.Add(generatedGuid);
            }

            return colorsIds;
        }

        private async Task<IReadOnlyCollection<EntityDTO>> GetCategoriesAsync()
        {
            var categoryRepository = _serviceProvider.GetRequiredService<ICategoryRepository>();

            IEnumerable<NamedEntityDTO> databaseCategories = categoryRepository.SearchByKeywordAsync().Result;
            var categoriesIds = new List<Guid>();
            if (databaseCategories.Any())
                categoriesIds.AddRange(databaseCategories.Select(color => color.Id));
            else
                categoriesIds.AddRange(await CreateDefaultCategoriesAsync());

            var categoriesResponse = new List<EntityDTO>();
            foreach (Guid id in categoriesIds)
            {
                categoriesResponse.Add(new EntityDTO { Id = id });
            }
            return categoriesResponse;
        }

        private async Task<IList<Guid>> CreateDefaultCategoriesAsync()
        {
            var categoriesIds = new List<Guid>();

            foreach (AddCategoryCommand category in GetDefaultCategories())
            {
                CommandResult<Guid?> categoryId = await _bus.SendMessage<AddCategoryCommand, Guid?>(category);
                Guid generatedGuid = categoryId.Result.Value;
                categoriesIds.Add(generatedGuid);
            }

            return categoriesIds;
        }
    }
}
