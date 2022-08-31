using Product.Models;
using System.Collections.Generic;

namespace Product.Store
{
    public interface IProductStore
    {
        List<ProductModel> Get();
    }
}
