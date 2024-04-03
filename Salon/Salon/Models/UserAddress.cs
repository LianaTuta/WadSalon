using Microsoft.Identity.Client;

namespace Salon.Models
{
    public class UserAddress
    {
        public int Id { get; set; }

        public int UserProfileId  { get; set; }
        public UserProfile UserProfile { get; set; }
        public string Number { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
