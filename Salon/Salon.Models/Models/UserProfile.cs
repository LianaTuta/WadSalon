namespace Salon.Model.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public int UserLoginId{ get; set; }
        public UserLogin UserLogin { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


    }
}
