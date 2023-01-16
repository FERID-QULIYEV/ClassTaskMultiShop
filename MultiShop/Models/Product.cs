using Microsoft.EntityFrameworkCore;
using MultiShop.Models.Base;

namespace MultiShop.Models
{
    public class Product:BaseId
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public ICollection<ProductImage> ProductImages { get; set;}
        public ICollection<Size> Sizes { get; set;}
        public ICollection<Color> Colors { get; set; }
        public ICollection<ProductCategory> ProductCategories{ get; set; }
    }
}
