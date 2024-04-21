namespace Salon.Model.Models
{
    public class Appoinment
    {
        public int Id { get; set; }
        public int UserLoginId { get; set; }
        public UserLogin UserLogin { get; set; }
        public int ServiceId {  get; set; }
        public SalonService Service { get; set; }
        public DateTime AppoinmentDate { get; set; }
    }
}
