using Microsoft.EntityFrameworkCore;
using System.Linq;
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

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            foreach (var relationship in modelbuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            modelbuilder.Entity<Message>().HasIndex(m => new {m.FromUserId, m.ToUserId, m.SendDate}).IsUnique();
            modelbuilder.Entity<Relationship>().HasIndex(r => new {r.UserId, r.FriendId}).IsUnique();

            base.OnModelCreating(modelbuilder);
        }


        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Relationship> Relationships { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Religion> Religions { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Post> Posts { get; set; }
        //public DbSet<PostToUser> PostsToUser { get; set; }
        //public DbSet<PostsToGroup> PotsToGroup { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<UsersToGroups> UsersToGroups { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<InterestsToUsers> InterestsToUsers { get; set; }
    }
}
