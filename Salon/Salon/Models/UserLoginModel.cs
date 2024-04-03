using System.ComponentModel.DataAnnotations;

namespace Salon.Models
{
    public class UserLoginModel
    {
        [Required(ErrorMessage = "Please Provide Username", AllowEmptyStrings = false)]
        public string Email
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Please provide password", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Password
        {
            get;
            set;
        }

    }
}
