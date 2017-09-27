using System;
using System.Collections.Generic;
using System.Text;
using SocialConnector.Entites.Entities;
using SocialConnector.Models.Enums;

namespace SocialConnector.Models.UserProfile
{
    public class FriendViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public Genders Gender { get; set; }
    }
}
