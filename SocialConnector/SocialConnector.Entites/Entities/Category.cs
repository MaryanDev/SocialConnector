using System;
using System.Collections.Generic;
using System.Text;

namespace SocialConnector.Entites.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public List<Interest> Interests { get; set; }
        public List<Event> Events { get; set; }

        public Category()
        {
            Interests = new List<Interest>();
            Events = new List<Event>();
        }
    }
}
