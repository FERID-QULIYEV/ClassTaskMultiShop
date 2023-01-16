using MultiShop.Models.Base;

namespace MultiShop.Models
{
    public class Size:BaseId
    {
        public string Name { get; set; }
        public Product? Product { get; set; }
    }
}
