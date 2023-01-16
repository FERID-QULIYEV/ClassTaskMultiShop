using MultiShop.Models.Base;

namespace MultiShop.Models
{
    public class Category:BaseId
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<ProductCategory> ProductsCategories { get; set;}
    }
}
