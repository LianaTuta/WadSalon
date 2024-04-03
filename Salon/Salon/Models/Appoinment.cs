namespace Salon.Models
{
    public class Appoinment
    {
        public int Id { get; set; }
        public int UserProfileId {  get; set; }
        public UserProfile Profile { get; set; }
        public int ServiceId {  get; set; }
        public SalonService Service { get; set; }
        public DateTime AppoinmentDate { get; set; }
    }
}
