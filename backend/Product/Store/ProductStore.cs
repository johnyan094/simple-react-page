using Product.Models;
using System.Collections.Generic;

namespace Product.Store
{
    public class ProductStore : IProductStore
    {
        public List<ProductModel> Get()
        {
            List<ProductModel> products = new List<ProductModel>
            {
                new ProductModel
                {
                    Name = "product 1",
                    Id = 1,
                    SKU = "0001",
                    Description = "product 1 desc",
                    Price = 1.01,
                    Quantity = 1
                },
                new ProductModel
                {
                    Name = "product 2",
                    Id = 2,
                    SKU = "0002",
                    Description = "product 2 desc",
                    Price = 2.00,
                    Quantity = 20
                },
                new ProductModel
                {
                    Name = "product 3",
                    Id = 3,
                    SKU = "0003",
                    Description = "product 3 desc",
                    Price = 3.00,
                    Quantity = 33
                },
                new ProductModel
                {
                    Name = "product 4",
                    Id = 4,
                    SKU = "0004",
                    Description = "product 4 desc",
                    Price = 4.00,
                    Quantity = 400
                },
            };
            return products;
        }
    }
}
