
namespace LiqourShop.Data.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public decimal Volume { get; set; }
        public string VolumeUnit{ get; set; }
    }
}
