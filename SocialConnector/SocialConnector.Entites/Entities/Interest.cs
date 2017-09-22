using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SocialConnector.Entites.Entities
{
    public class Interest
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey(nameof(UserId))]
        public AdditinalUserInfo User { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }
    }
}
