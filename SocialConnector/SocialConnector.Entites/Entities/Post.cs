using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SocialConnector.Entites.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime PublishedDate { get; set; }

        [Required]
        public User Author { get; set; }
        public PostToUser PostToUser { get; set; }
        public PostsToGroup PostToGroup { get; set; }
        public Image Image { get; set; }

        public List<Comment> Comments { get; set; }

        public Post()
        {
            Comments = new List<Comment>();
        }
    }
}
