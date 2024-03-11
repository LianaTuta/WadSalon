namespace Salon.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int SalonId { get; set; }
        public string Description { get; set; }
    }
}
