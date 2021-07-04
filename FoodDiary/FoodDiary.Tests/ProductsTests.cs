using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using FoodDiary.Data;
using FoodDiary.Repositories.Entities;
using FoodDiary.Repositories.Implementations;
using FoodDiary.Services.Implementation;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace FoodDiary.Tests
{
    public class ProductsTests
    {
        private readonly ApplicationDbContext _context;

        private readonly List<ProductEntity> productEntities = new()
        {
            new()
            {
                ProductName = "Banana",
                Carb = 10,
                Protein = 10,
                Fat = 3,
                Kcal = KcalCalculatorService.KcalCalculator(10, 10, 3)
            },
            new()
            {
                ProductName = "Apple",
                Carb = 10,
                Protein = 10,
                Fat = 3,
                Kcal = KcalCalculatorService.KcalCalculator(10, 10, 3)
            }
        };

        public ProductsTests()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            _context = new ApplicationDbContext(options);
            _context.ProductEntities.AddRange(productEntities);
            _context.SaveChanges();
        }

        [Fact]
        public async Task ShouldRemoveProduct()
        {
            var lastProduct = productEntities.Last();
            var productsRepository = new ProductsRepository(_context);
            await productsRepository.DeleteProductFromDataBase(lastProduct.Id);
            var products = await productsRepository.GetAllProducts();

            products.Should().HaveCount(1);
            products.Should().NotContain(lastProduct);
            products[0].Should().BeEquivalentTo(productEntities[0]);
        }

        [Fact]
        public async Task ShouldGetAllProductsFromContext()
        {
            var productsRepository = new ProductsRepository(_context);
            var result = (await productsRepository.GetAllProducts()).ToList();

            result.Should().HaveCount(2);
            result.Should().BeOfType<List<ProductEntity>>();
            result[0].Should().BeEquivalentTo(productEntities[0]);
            result[1].Should().BeEquivalentTo(productEntities[1]);
        }

        [Fact]
        public async Task ShouldGetSavedProduct()
        {
            var thirdObjest = new ProductEntity
            {
                ProductName = "Orange",
                Carb = 10,
                Protein = 10,
                Fat = 3,
                Kcal = KcalCalculatorService.KcalCalculator(10, 3, 10)
            };

            var productsRepository = new ProductsRepository(_context);
            await productsRepository.AddProductToDataBase(thirdObjest);
            var products = await productsRepository.GetAllProducts();

            var allProducts = products.Should().HaveCount(3);
            products.LastOrDefault().Should().BeEquivalentTo(thirdObjest);
            products.LastOrDefault().Kcal.Should().Be(KcalCalculatorService.KcalCalculator(10, 3, 10));
        }

        [Fact]
        public void ShouldGetProperValue()
        {
            var exampel = 0;
            var result = KcalCalculatorService.KcalCalculator(2, 2, 2);
            result.Should().Be(34);
            result.Should().NotBe(36);
            result.Should().BeOfType(exampel.GetType());
        }

        [Fact]
        public async Task ShouldGetProductById()
        {
            var newObject = new ProductEntity
            {
                Id = Guid.NewGuid(),
                ProductName = "Orange",
                Carb = 10,
                Protein = 10,
                Fat = 3,
                Kcal = KcalCalculatorService.KcalCalculator(10, 3, 10)
            };

            var productsRepository = new ProductsRepository(_context);
            await productsRepository.AddProductToDataBase(newObject);
            var id = await productsRepository.GetProductById(newObject.Id);

            id.Id.Should().Be(newObject.Id);
            id.ProductName.Should().Be(newObject.ProductName);
            id.Carb.Should().Be(newObject.Carb);
            id.Protein.Should().Be(newObject.Protein);
            id.Fat.Should().Be(newObject.Fat);
        }

        [Fact]
        public async Task ShouldGetUpdatedProduct()
        {
            var newObject = new ProductEntity
            {
                Id = Guid.NewGuid(),
                ProductName = "Orange",
                Carb = 10,
                Protein = 10,
                Fat = 3,
                Kcal = KcalCalculatorService.KcalCalculator(10, 3, 10)
            };

            var productsRepository = new ProductsRepository(_context);
            var productsList = await productsRepository.GetAllProducts();
            var productToUpdate = productsList.Last();
            await productsRepository.EditProductInDataBase(newObject, productToUpdate.Id);

            productToUpdate.ProductName.Should().Be("Orange");
            productToUpdate.Carb.Should().Be(10);
            productToUpdate.Protein.Should().Be(10);
            productToUpdate.Fat.Should().Be(3);
            productToUpdate.Kcal.Should().Be(newObject.Kcal);
        }
    }
}