using MultiShop.Models.Base;

namespace MultiShop.Models
{
    public class Setting:BaseId
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
