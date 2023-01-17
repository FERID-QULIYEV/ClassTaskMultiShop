using Microsoft.EntityFrameworkCore;
using MultiShop.Models.Base;
using Stripe;
using System.ComponentModel.DataAnnotations;

namespace MultiShop.Models
{
    public class Product:BaseId
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        [Range(0.0, Double.MaxValue)]
        public decimal CostPrice { get; set; }
        [Range(0.0, Double.MaxValue)]
        public string Description { get; set; }
        [Range(0, 100)]
        public Discount? Discount { get; set; }
        public int? DiscountId { get; set; }
        public ICollection<ProductColor> ProductColors { get; set; }
        public ICollection<ProductImage> ProductImages { get; set;}
        public ICollection<Size> Sizes { get; set;}
        public ICollection<Color> Colors { get; set; }
        public ICollection<ProductCategory> ProductCategories{ get; set; }
    }
}
