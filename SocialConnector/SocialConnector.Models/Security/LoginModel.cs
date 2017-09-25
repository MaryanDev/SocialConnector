using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SocialConnector.Models.Security
{
    public class LoginModel
    {
        [Required]
        [DisplayName("User Name")]
        public string LoginName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
