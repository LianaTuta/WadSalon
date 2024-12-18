

using Microsoft.AspNetCore.Identity;

namespace Salon.Model.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string AspNetUserId { get; set; }
        public IdentityUser AspNetUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


    }
}
