using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SocialConnector.Entites.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public DateTime SendDate { get; set; }
        public string Text { get; set; }
        public int FromUserId { get; set; }
        public int ToUserId { get; set; }

        [Required]
        [ForeignKey(nameof(FromUserId))]
        public User FromUser { get; set; }

        [Required]
        [ForeignKey(nameof(ToUserId))]
        public User ToUser { get; set; }
    }
}
