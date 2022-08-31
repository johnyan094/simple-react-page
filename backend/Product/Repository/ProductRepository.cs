using AutoMapper;
using Product.Exceptions;
using Product.Models;
using Product.Store;
using System.Collections.Generic;
using System.Linq;

namespace Product.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IMapper _mapper;
        private List<ProductModel> _products;

        public ProductRepository(IMapper mapper, IProductStore store)
        {
            _mapper = mapper;
            _products = store.Get();
        }
        public List<ProductDto> GetAllProduct()
        {
            return _mapper.Map<List<ProductDto>>(_products);
        }

        public ProductModel GetProductDetails(int id)
        {
            var product = _products.FirstOrDefault(x => x.Id == id);

            if(product == null)
            {
                throw new NotFoundException();
            }

            return product;
        }
    }
}
