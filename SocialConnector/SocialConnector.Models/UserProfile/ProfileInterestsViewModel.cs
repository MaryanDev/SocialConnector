﻿using System;
using System.Collections.Generic;
using System.Text;
using SocialConnector.Entites.Entities;

namespace SocialConnector.Models.UserProfile
{
    public class ProfileInterestsViewModel : UserProfileModel
    {
        public IEnumerable<Interest> Interests { get; set; }
    }
}
