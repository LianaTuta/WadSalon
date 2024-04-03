namespace Salon.Models
{
    public class UserPassword
    {
        public int Id { get; set; }
        public int UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }
        public string Password {  get; set; }
    }
}
