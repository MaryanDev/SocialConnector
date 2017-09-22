using System;
using System.Collections.Generic;
using System.Text;

namespace SocialConnector.Entites.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Password { get; set; }
        public DateTime DateStrted { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }
        public AdditinalUserInfo UserDetails { get; set; }

        //public List<Relationship> Relationships { get; set; }
        //public List<Relationship> Relationships1 { get; set; }


        //public User()
        //{
        //    Relationships = new List<Relationship>();
        //    Relationships1 = new List<Relationship>();
        //}
    }
}
