using MultiShop.Models.Base;

namespace MultiShop.Models
{
    public class ProductInformation:BaseId
    {
        public string Shipping { get; set; }
        public string AboutReturnRequest { get; set; }
        public string Guarantee { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
