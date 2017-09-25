using System;
using System.Collections.Generic;
using System.Text;

namespace SocialConnector.Entites.Entities
{
    public class Gender
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public List<User> Users { get; set; }

        public Gender()
        {
            Users = new List<User>();
        }
    }
}
