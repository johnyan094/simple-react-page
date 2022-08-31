using Product.Models;
using System.Collections.Generic;

namespace Product.Services
{
    public interface IProductService
    {
        List<ProductDto> GetAllProducts();
        ProductModel GetProductDetails(int id);
    }
}
