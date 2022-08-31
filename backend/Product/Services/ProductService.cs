using Product.Models;
using Product.Repository;
using System.Collections.Generic;

namespace Product.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public List<ProductDto> GetAllProducts()
        {
            return _productRepository.GetAllProduct();
        }

        public ProductDetailsDto GetProductDetails(int id)
        {
            return _productRepository.GetProductDetails(id);
        }
    }
}
