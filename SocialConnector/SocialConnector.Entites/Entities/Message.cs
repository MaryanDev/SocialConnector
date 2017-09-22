using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SocialConnector.Entites.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public int FromId { get; set; }
        public int ToId { get; set; }
        public DateTime SendDate { get; set; }
        public string Text { get; set; }

        [ForeignKey(nameof(FromId))]
        public User FromUser { get; set; }

        [ForeignKey(nameof(ToId))]
        public User ToUser { get; set; }
    }
}
