using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MultiShop.DAL;

namespace MultiShop.Areas.Manage.Controllers
{
    public class ProductController: Controller
    {
        readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Products.Include(p => p.ProductColors).ThenInclude(pc => pc.Color).Include(p => p.ProductSizes).ThenInclude(ps => ps.Size).Include(p => p.ProductImages));
        }
        public IActionResult Create() 
        {
            ViewBag.Color
            return View();
        }
    }
}
