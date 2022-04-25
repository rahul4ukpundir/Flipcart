#nullable disable;

namespace Flipkart.Products.DTO
{
    public class ResponseDTO
    {
        public bool IsSuccess { get; set; }
        public object Result { get; set; }
        public string DispalyMessage { get; set; }

        public List<string> ErrorMessage { get; set; }
    }
}
