using System.ComponentModel.DataAnnotations;

#nullable disable
namespace Flipkart.Products.Model
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public int ProductPrice { get; set; }
    }
}
