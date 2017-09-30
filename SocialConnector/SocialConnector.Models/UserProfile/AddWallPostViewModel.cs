using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SocialConnector.Models.UserProfile
{
    public class AddWallPostViewModel : UserProfileModel
    {
        [Required]
        public string Text { get; set; }
        public string AuthorName { get; set; }
    }
}
