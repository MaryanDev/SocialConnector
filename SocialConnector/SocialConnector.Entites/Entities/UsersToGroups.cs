using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SocialConnector.Entites.Entities
{
    public class UsersToGroups
    {
        public int Id { get; set; }
        public bool IsContact { get; set; }

        [Required]
        public User User { get; set; }
        [Required]
        public Group Group { get; set; }
    }
}
