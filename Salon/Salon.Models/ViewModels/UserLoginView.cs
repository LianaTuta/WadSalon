using System.ComponentModel.DataAnnotations;
namespace Salon.Model.ViewModels
{
    public class UserLoginView
    {
        [Required(ErrorMessage = "Please Provide Username", AllowEmptyStrings = false)]
        public string Email
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Please provide password", AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        public string Password
        {
            get;
            set;
        }

    }
}
