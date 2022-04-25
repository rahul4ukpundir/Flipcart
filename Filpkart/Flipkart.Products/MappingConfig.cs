using AutoMapper;
using Flipkart.Products.DTO;
using Flipkart.Products.Model;

namespace Flipkart.Products
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDTO, Product>();
                config.CreateMap<Product, ProductDTO>();
            });
            return mappingConfig; 
        }
    }
}
