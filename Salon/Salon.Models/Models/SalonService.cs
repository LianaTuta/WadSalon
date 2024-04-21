namespace Salon.Model.Models
{
    public class SalonService
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public int SalonId { get; set; }
        public SalonModel Salon {  get; set; }
    }
}
