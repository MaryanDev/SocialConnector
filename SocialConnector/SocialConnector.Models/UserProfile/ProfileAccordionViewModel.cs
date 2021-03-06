﻿using System;
using System.Collections.Generic;
using System.Text;
using SocialConnector.Entites.Entities;

namespace SocialConnector.Models.UserProfile
{
    public class ProfileAccordionViewModel : UserProfileModel
    {
        public IEnumerable<Group> Groups { get; set; }
        public IEnumerable<Event> Events { get; set; }
        public IEnumerable<Image> Photos { get; set; }
        public IEnumerable<FriendViewModel> Friends { get; set; }
    }
}
