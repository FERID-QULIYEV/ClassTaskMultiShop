using MultiShop.Models.Base;

namespace MultiShop.Models
{
    public class Color:BaseId
    {
        public string Name { get; set; }
        public Product? Products { get; set; }
    }
}
