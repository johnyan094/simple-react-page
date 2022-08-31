using AutoMapper;
using Product.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Product.AutoMapper
{

    public class ProductMappingProfiler: Profile
    {
        public ProductMappingProfiler()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<ProductModel, ProductDto>();
            CreateMap<ProductModel, ProductDetailsDto>();
        }
    }
}
