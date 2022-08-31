using AutoMapper;
using Product.Models;
using System.Collections.Generic;
using System.Linq;

namespace Product.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IMapper _mapper;
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

        public ProductRepository(IMapper mapper)
        {
            _mapper = mapper;
        }
        public List<ProductDto> GetAllProduct()
        {
            return _mapper.Map<List<ProductDto>>(products);
        }

        public ProductDetailsDto GetProductDetails(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            return _mapper.Map<ProductDetailsDto>(product);
        }
    }
}
