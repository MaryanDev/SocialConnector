using System;
using System.Collections.Generic;
using System.Text;

namespace SocialConnector.Entites.Entities
{
    public class Image
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public User User { get; set; }
        public Group Group { get; set; }
    }
}
