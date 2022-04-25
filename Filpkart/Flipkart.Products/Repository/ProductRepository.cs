using Flipkart.Products.DTO;
using Flipkart.Products.Repository;
using Flipkart.Products.DBContext;
using AutoMapper;
using Flipkart.Products.Model;
using Microsoft.EntityFrameworkCore;
#nullable disable

namespace Flipkart.Products.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly IMapper _mapper;
        public ProductRepository(ApplicationDBContext dBContext, IMapper mapper)
        {
            _dbContext = dBContext;
            _mapper = mapper;
        }
        async Task<ProductDTO> IProductRepository.CreateUpdateProduct(ProductDTO productDTO)
        {
            Product product = _mapper.Map<Product>(productDTO); ;
            _dbContext.Add(product);
           await _dbContext.SaveChangesAsync();
            return  _mapper.Map<Product, ProductDTO>(product);
        }

        async Task<bool> IProductRepository.DeleteProduct(int id)
        {
            Product product = await _dbContext.Product.Where(x => x.ProductId == id).FirstOrDefaultAsync();
            _dbContext.Remove(product);
            _dbContext.SaveChanges();
            return true;

        }

        async Task<IEnumerable<ProductDTO>> IProductRepository.GetProduct()
        {
            List<Product> products = await _dbContext.Product.ToListAsync();
            return _mapper.Map<List<ProductDTO>>(products);
        }

        async Task<ProductDTO> IProductRepository.GetProductById(int id)
        {
            Product product = await _dbContext.Product.Where(x=>x.ProductId == id).FirstOrDefaultAsync();
            return _mapper.Map<ProductDTO>(product);
        }
    }
}
