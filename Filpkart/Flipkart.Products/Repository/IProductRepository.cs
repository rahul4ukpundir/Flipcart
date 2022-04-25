using Flipkart.Products.DTO;

namespace Flipkart.Products.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDTO>> GetProduct();
        Task<ProductDTO> GetProductById(int id);

        Task<ProductDTO> CreateUpdateProduct(ProductDTO productDTO);

        Task<bool> DeleteProduct(int id);
    }
}
