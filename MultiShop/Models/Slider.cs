using MultiShop.Models.Base;
using System.Reflection;

namespace MultiShop.Models
{
    public class Slider:BaseId
    {
        public string PrimaryTitle { get; set; }
        public string SecondaryTitle { get; set;}
        public string Description { get; set;} 
        public string ImageUrl { get; set;}
        public int Order { get; set; }
    }
}
