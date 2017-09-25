using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SocialConnector.Entites.Entities
{
    public class AdditionalUserInfo
    {
        [Key]
        public int UserId { get; set; }
        public string WorPlace { get; set; }
        public string PlaceOfBirth { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        public Religion Religion { get; set; }
        public Nationality Nationality { get; set; }
        public List<Interest> Interests { get; set; }

        public AdditionalUserInfo()
        {
            Interests = new List<Interest>();
        }
    }
}
