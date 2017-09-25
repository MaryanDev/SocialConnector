using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SocialConnector.Entites.Entities
{
    public class PostsToGroup
    {
        [Key]
        public int PostId { get; set; }

        [ForeignKey(nameof(PostId))]
        public Post Post { get; set; }
        [Required]
        public Group Group { get; set; }
    }
}
