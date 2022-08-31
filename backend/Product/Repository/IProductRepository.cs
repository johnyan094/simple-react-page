using Product.Models;
using System.Collections.Generic;

namespace Product.Repository
{
    public interface IProductRepository
    {
        List<ProductDto> GetAllProduct();
        ProductDetailsDto GetProductDetails(int id);
    }
}
