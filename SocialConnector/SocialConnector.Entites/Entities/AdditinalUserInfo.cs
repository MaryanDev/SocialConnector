using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SocialConnector.Entites.Entities
{
    public class AdditinalUserInfo
    {
        public int UserId { get; set; }
        public string WorPlace { get; set; }
        public string PlaceOfBirth { get; set; }
        public int ReligionId { get; set; }
        public int NationalityId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        [ForeignKey(nameof(ReligionId))]
        public Religion Religion { get; set; }
        [ForeignKey(nameof(NationalityId))]
        public Nationality Nationality { get; set; }
        public List<Interest> Interests { get; set; }

        public AdditinalUserInfo()
        {
            Interests = new List<Interest>();
        }
    }
}
