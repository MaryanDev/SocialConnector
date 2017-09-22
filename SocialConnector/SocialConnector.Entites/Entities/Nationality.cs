using System;
using System.Collections.Generic;
using System.Text;

namespace SocialConnector.Entites.Entities
{
    public class Nationality
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public List<AdditinalUserInfo> Users { get; set; }

        public Nationality()
        {
            Users = new List<AdditinalUserInfo>();
        }
    }
}
