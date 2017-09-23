using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SocialConnector.Entites.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int ImageId { get; set; }
        public string Description { get; set; }
        public DateTime DateStarted { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public User Author { get; set; }
        [ForeignKey(nameof(ImageId))]
        public int Image { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }
    }
}
