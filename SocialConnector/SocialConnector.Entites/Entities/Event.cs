using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SocialConnector.Entites.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateStarted { get; set; }

        [Required]
        public User Author { get; set; }
        public int Image { get; set; }
        [Required]
        public Category Category { get; set; }
    }
}
