using System;
using System.Collections.Generic;
using System.Text;

namespace SocialConnector.Models.UserProfile
{
    public class ProfileMainViewModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Avatar { get; set; }
        public string WorkPlace { get; set; }
        public string Hometown { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public bool IsFullNameEmpty()
        {
            return string.IsNullOrWhiteSpace(FirstName + " " + LastName);
        }
    }
}
