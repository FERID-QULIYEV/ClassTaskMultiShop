namespace MultiShop.Models.Base
{
    public class BaseAccountable:BaseId
    {
        public DateTime? CreateDat { get; set; }
        public DateTime? ModifieDat { get; set; }
        public string Created { get; set; }
    }
}
