namespace Salon.Models
{
    public class SalonService
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public int SalonId { get; set; }
        public Salon Salon {  get; set; }
        public DateTime AppoinmentDate { get; set; }
    }
}
