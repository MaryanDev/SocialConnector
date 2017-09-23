using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SocialConnector.Entites.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int OwnerId { get; set; }

        [ForeignKey(nameof(OwnerId))]
        public User Owner { get; set; }
        public List<UsersToGroups> Members { get; set; }
        public List<GroupImage> GroupImages { get; set; }
        public List<PostsToGroup> PostsToGroup { get; set; }

        public Group()
        {
            Members = new List<UsersToGroups>();
            GroupImages = new List<GroupImage>();
            PostsToGroup = new List<PostsToGroup>();
        }
    }
}
