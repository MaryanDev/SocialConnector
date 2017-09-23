using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SocialConnector.Entites.Entities
{
    public class GroupImage
    {
        [Key]
        public int ImageId { get; set; }
        public int GroupId { get; set; }

        [ForeignKey(nameof(ImageId))]
        public Image Image { get; set; }
        [ForeignKey(nameof(GroupId))]
        public Group Group { get; set; }
    }
}
