using Microsoft.AspNetCore.Identity;

namespace Salon.Model.Models
{
    public class Appoinment
    {
        public int Id { get; set; }
        public string AspNetUserId { get; set; }
        public IdentityUser AspNetUser { get; set; }
        public int ServiceId {  get; set; }
        public SalonService Service { get; set; }
        public DateTime AppoinmentDate { get; set; }
    }
}
