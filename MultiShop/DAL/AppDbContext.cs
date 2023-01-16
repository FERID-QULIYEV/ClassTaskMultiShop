using Microsoft.EntityFrameworkCore;
using MultiShop.Models;

namespace MultiShop.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }
        public DbSet<Category> Categories;
        public DbSet<Product> Products;
        public DbSet<ProductImage> ProductImages;
        public DbSet<Color> Colors;
        public DbSet<Size> Sizes;
    }
}
