using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using SocialConnector.Models.Enums;

namespace SocialConnector.Models.Security
{
    public class RegisterModel
    {
        #region Required Data
        [Required]
        [MinLength(5, ErrorMessage = "User name must be at least 5 characters long")]
        [MaxLength(120, ErrorMessage = "User name cannot contain more 120 characters")]
        [DisplayName("User Name*")]
        public string UserName { get; set; }

        [Required]
        [DisplayName("Gender*")]
        public Genders Gender { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email address*")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(5, ErrorMessage = "Password maust be at least 5 characters long")]
        [MaxLength(50, ErrorMessage = "Password cannot contain more than 50 characters")]
        [DisplayName("Password*")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Passwords does not match")]
        [DisplayName("Confirm Password*")]
        public string ConfirmPassword { get; set; }
        #endregion

        #region OptionalData

        [DisplayName("First Name")]
        [MinLength(2, ErrorMessage = "First name must be at least 2 characters long")]
        [MaxLength(100, ErrorMessage = "First name cannot contain more than 100 characters")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [MinLength(2, ErrorMessage = "Last name must be at least 2 characters long")]
        [MaxLength(100, ErrorMessage = "Last name cannot contain more than 100 characters")]
        public string LastName { get; set; }

        [DisplayName("Date of birth")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [MinLength(2, ErrorMessage = "Last name must be at least 2 characters long")]
        public string Workplace { get; set; }

        public string Nationality { get; set; }

        [DisplayName("Hometown")]
        public string PlaceOfBirth { get; set; }

        public string Religion { get; set; }
        #endregion

    }
}
