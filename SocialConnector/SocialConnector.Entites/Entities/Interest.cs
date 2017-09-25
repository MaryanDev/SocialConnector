using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SocialConnector.Entites.Entities
{
    public class Interest
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public List<InterestsToUsers> Users { get; set; }
        public Category Category { get; set; }

        public Interest()
        {
            Users = new List<InterestsToUsers>();
        }
    }
}
