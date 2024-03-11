namespace Salon.Models
{
    public class ServiceModel
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public int SalonId { get; set; }
        public DateTime AppoinmentDate { get; set; }
    }
}
