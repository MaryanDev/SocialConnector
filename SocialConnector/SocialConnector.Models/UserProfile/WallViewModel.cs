using System;
using System.Collections.Generic;
using System.Text;

namespace SocialConnector.Models.UserProfile
{
    public class WallViewModel : UserProfileModel
    {
        public IEnumerable<WallPostViewModel> Posts { get; set; }
    }
}
