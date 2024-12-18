

using Microsoft.AspNetCore.Identity;

namespace Salon.Model.Models
{
    public class UserAddress
    {
        public int Id { get; set; }
        public string AspNetUserId { get; set; }
        public IdentityUser AspNetUser { get; set; }
        public string Number { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
