using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SocialConnector.Entites.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Password { get; set; }
        public DateTime? DateStarted { get; set; }
        public string WorkPlace { get; set; }
        public string PlaceOfBirth { get; set; }
        public Religion Religion { get; set; }
        public Nationality Nationality { get; set; }
        public string Avatar { get; set; }
        public List<InterestsToUsers> Interests { get; set; }
        public int GenderId { get; set; }

        [Required]
        public Role Role { get; set; }
        [Required]
        [ForeignKey(nameof(GenderId))]
        public Gender Gender { get; set; }

        public List<Group> GroupsInOwn { get; set; }
        public List<UsersToGroups> Groups { get; set; }
        public List<PostToUser> PostsToUser { get; set; }
        public List<Post> PostsByUser { get; set; }

        public List<Image> Images { get; set; }


        public User()
        {
            GroupsInOwn = new List<Group>();
            Groups = new List<UsersToGroups>();
            PostsToUser = new List<PostToUser>();
            PostsByUser = new List<Post>();
            Interests = new List<InterestsToUsers>();
            Images = new List<Image>();
        }
    }
}
