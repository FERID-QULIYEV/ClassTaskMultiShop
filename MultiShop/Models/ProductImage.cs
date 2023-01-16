using MultiShop.Models.Base;

namespace MultiShop.Models
{
    public class ProductImage:BaseId
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string ProductId { get; set; }
        public Product? Products { get; set; }
    }
}
