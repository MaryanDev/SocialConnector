using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SocialConnector.Entites.Entities
{
    public class PostToUser
    {
        [Key]
        public int PostId { get; set; }

        public User User { get; set; }
        [ForeignKey(nameof(PostId))]
        [Required]
        public Post Post { get; set; }
    }
}
