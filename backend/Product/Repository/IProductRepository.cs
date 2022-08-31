using Product.Models;
using System.Collections.Generic;

namespace Product.Repository
{
    public interface IProductRepository
    {
        List<ProductDto> GetAllProduct();
        ProductModel GetProductDetails(int id);
    }
}
