﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SocialConnector.Entites.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public User Owner { get; set; }
        public DateTime DateCreated { get; set; }
        public List<UsersToGroups> Members { get; set; }
        public List<Image> Images { get; set; }
        public List<Post> Posts { get; set; }

        public Group()
        {
            Members = new List<UsersToGroups>();
            Images = new List<Image>();
            Posts = new List<Post>();
        }
    }
}
