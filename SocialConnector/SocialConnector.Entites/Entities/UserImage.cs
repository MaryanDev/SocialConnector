using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SocialConnector.Entites.Entities
{
    public class UserImage
    {
        [Key]
        public int ImageId { get; set; }
        public int UserId { get; set; }

        [ForeignKey(nameof(ImageId))]
        public Image Image { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
    }
}
