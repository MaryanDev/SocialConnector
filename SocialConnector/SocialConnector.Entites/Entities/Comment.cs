using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SocialConnector.Entites.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public DateTime PublishDate { get; set; }
        public string Text { get; set; }

        [Required]
        public Post Post { get; set; }
        [Required]
        public User Author { get; set; }
    }
}
