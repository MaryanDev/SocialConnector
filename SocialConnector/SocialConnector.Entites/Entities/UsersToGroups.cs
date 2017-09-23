using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SocialConnector.Entites.Entities
{
    public class UsersToGroups
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int GroupId { get; set; }
        public bool IsContact { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        [ForeignKey(nameof(GroupId))]
        public Group Group { get; set; }
    }
}
