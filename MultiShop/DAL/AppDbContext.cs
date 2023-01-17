using Microsoft.EntityFrameworkCore;
using MultiShop.Models;

namespace MultiShop.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }
        public DbSet<Addvertising> Addvertisings;
        public DbSet<Category> Categories;
        public DbSet<Color> Colors;
        public DbSet<Discount> Discounts;
        public DbSet<ProductCategory> ProductCategories;
        public DbSet<ProductColor> ProductColors;
        public DbSet<Product> Products;
        public DbSet<ProductImage> ProductImages;
        public DbSet<ProductInformation> ProductInformation;
        public DbSet<ProductSize> ProductSizes;
        public DbSet<Setting> Settings;
        public DbSet<Size> Sizes;
    }
}
