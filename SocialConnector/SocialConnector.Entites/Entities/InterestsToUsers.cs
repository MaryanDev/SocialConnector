using System;
using System.Collections.Generic;
using System.Text;

namespace SocialConnector.Entites.Entities
{
    public class InterestsToUsers
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Interest Interest { get; set; }
    }
}
