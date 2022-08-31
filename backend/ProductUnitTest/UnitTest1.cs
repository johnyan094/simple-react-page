using AutoMapper;
using Moq;
using NUnit.Framework;
using Product.AutoMapper;
using Product.Exceptions;
using Product.Models;
using Product.Repository;
using Product.Services;
using Product.Store;
using System.Collections.Generic;

namespace ProductUnitTest
{
    public class Tests
    {
        private IProductService _productService;

        [SetUp]
        public void Setup()
        {
            //auto mapper configuration
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ProductMappingProfiler());
            });
            var mapper = mockMapper.CreateMapper();

            List<ProductModel> fakeProducts = new List<ProductModel>
            {
                new ProductModel
                {
                    Name = "fake product 1",
                    Id = 343,
                    SKU = "0001",
                    Description = "product 1 desc",
                    Price = 1.01,
                    Quantity = 1
                },
                new ProductModel
                {
                    Name = "fake product 2",
                    Id = 655,
                    SKU = "0002",
                    Description = "product 2 desc",
                    Price = 2.00,
                    Quantity = 20
                },
                new ProductModel
                {
                    Name = "fake product 3",
                    Id = 123,
                    SKU = "0003",
                    Description = "product 3 desc",
                    Price = 3.00,
                    Quantity = 33
                },
                new ProductModel
                {
                    Name = "fake product 4",
                    Id = 424,
                    SKU = "0004",
                    Description = "product 4 desc",
                    Price = 4.00,
                    Quantity = 400
                },
            };

            Mock<IProductStore> mockProductStore = new Mock<IProductStore>();
            mockProductStore.Setup(s => s.Get()).Returns(fakeProducts);

            var repo = new ProductRepository(mapper, mockProductStore.Object);
            _productService = new ProductService(repo);
        }

        [Test]
        public void GetAllProduct_Successfully()
        {
            var products = _productService.GetAllProducts();
            Assert.AreEqual(4, products.Count);
            Assert.IsTrue(products[0].Id == 343);
        }

        [TestCase(343, "0001")]
        [TestCase(655, "0002")]
        public void GetProductById_Successfully(int productId, string expectedSKU)
        {
            var product = _productService.GetProductDetails(productId);
            Assert.IsTrue(product.SKU == expectedSKU);
        }

        [TestCase(999)]
        public void GetProductById_NotFoundException(int productId)
        {
            Assert.Throws<NotFoundException>(() => _productService.GetProductDetails(productId));
        }
    }
}