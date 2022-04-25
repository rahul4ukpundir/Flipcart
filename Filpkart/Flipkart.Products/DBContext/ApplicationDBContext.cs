using Microsoft.EntityFrameworkCore;
using Flipkart.Products.Model;

#nullable disable
namespace Flipkart.Products.DBContext
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {

        }
        public virtual DbSet<Product> Product { get; set; }
    }
}
