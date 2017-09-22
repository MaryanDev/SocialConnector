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
    }
}
