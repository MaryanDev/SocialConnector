using System;
using System.Collections.Generic;
using System.Text;
using SocialConnector.Entites.Entities;

namespace SocialConnector.Models.UserProfile
{
    public class WallPostViewModel 
    {
        public int PostId { get; set; }
        public FriendViewModel Author { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
        public DateTime PostedDate { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
    }
}
