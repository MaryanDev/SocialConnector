using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SocialConnector.Models.Security
{
    public class RegisterModel
    {
        [Required]
        [MinLength(5, ErrorMessage = "User name must be at least 5 characters long")]
        [MaxLength(120, ErrorMessage = "User name cannot contain more 120 characters")]
        [DisplayName("User Name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(5, ErrorMessage = "Password maust be at least 5 characters long")]
        [MaxLength(50, ErrorMessage = "Password cannot contain more than 50 characters")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Passwords does not match")]
        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}
