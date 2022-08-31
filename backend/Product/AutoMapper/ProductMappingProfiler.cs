using AutoMapper;
using Product.Models;

namespace Product.AutoMapper
{

    public class ProductMappingProfiler: Profile
    {
        public ProductMappingProfiler()
        {
            CreateMap<ProductModel, ProductDto>();
        }
    }
}
