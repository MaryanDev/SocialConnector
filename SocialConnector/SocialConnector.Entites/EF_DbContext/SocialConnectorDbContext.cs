using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using SocialConnector.Entites.Entities;

namespace SocialConnector.Entites.EF_DbContext
{
    public class SocialConnectorDbContext : DbContext
    {
        public SocialConnectorDbContext(DbContextOptions<SocialConnectorDbContext> options) : base(options)
        {
                
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Relationship> Relationships { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<AdditinalUserInfo> UserInfo { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Religion> Religions { get; set; }
        public DbSet<UserImage> UserImages { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
