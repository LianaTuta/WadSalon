using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Salon.Models
{
    public class UserProfileView
    {
        [Required(ErrorMessage = "Please provide your first name", AllowEmptyStrings = false)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please provide your last name", AllowEmptyStrings = false)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please provide your email", AllowEmptyStrings = false)]
        public string Email { get; set; }
        public string Number { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        [Required(ErrorMessage = "Please provide your password", AllowEmptyStrings = false)]
        public string Password { get; set; }
    }
}