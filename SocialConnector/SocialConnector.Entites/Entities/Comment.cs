using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SocialConnector.Entites.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int PostId { get; set; }
        public DateTime PublishDate { get; set; }
        public string Text { get; set; }

        [ForeignKey(nameof(PostId))]
        public Post Post { get; set; }
        [ForeignKey(nameof(AuthorId))]
        public User Author { get; set; }
    }
}
