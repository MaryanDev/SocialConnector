using System;
using System.Collections.Generic;
using System.Text;
using SocialConnector.Entites.EF_DbContext;
using SocialConnector.Models.UserProfile;
using SocialConnector.Services.Abstract;
using SocialConnector.Services.Abstract.Base;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SocialConnector.Entites.Entities;
using SocialConnector.Mappings.Profile;

namespace SocialConnector.Services.Concrete
{
    public class UserProfileService : BaseService, IUserProfileService
    {
        public UserProfileService(SocialConnectorDbContext context) : base(context)
        {

        }

        public ProfileMainViewModel GetProfileInfo(string identityName)
        {
            User user = context.Users.Include(u => u.Gender).FirstOrDefault(u => u.Email == identityName) ??
                        context.Users.Include(u => u.Gender).FirstOrDefault(u => u.UserName == identityName);

            return UserMapping.MapProfileFromDb(user);
        }

        public ProfileMainViewModel GetProfileInfo(int userId)
        {
            User user = context.Users.Include(u => u.Gender).FirstOrDefault(u => u.Id == userId);

            return UserMapping.MapProfileFromDb(user);
        }

        public ProfileAccordionViewModel GetProfileAccordionContent(int userId)
        {
            ProfileAccordionViewModel result = new ProfileAccordionViewModel();
            result.Groups =
                context.UsersToGroups.Include(ug => ug.User)
                    .Include(ug => ug.Group)
                    .Where(ug => ug.User.Id == userId)
                    .Select(ug => ug.Group).ToList();

            result.Photos = context.Users.Include(u => u.Images).FirstOrDefault(u => u.Id == userId).Images;

            var friends1 =
                context.Relationships.Include(r => r.User)
                    .Include(r => r.Friend)
                    .ThenInclude(r => r.Gender)
                    .Where(r => r.User.Id == userId)
                    .Select(r => r.Friend)
                    .Select(f => UserMapping.MapFriendViewModelFromUser(f))
                    .ToList();

            var friends2 = context.Relationships.Include(r => r.User)
                    .Include(r => r.Friend)
                    .ThenInclude(r => r.Gender)
                    .Where(r => r.Friend.Id == userId)
                    .Select(r => r.User)
                    .Select(f => UserMapping.MapFriendViewModelFromUser(f))
                    .ToList();
            friends1.AddRange(friends2);
            result.Friends = friends1.Take(9);

            result.Id = userId;

            //var userCategories =
            //    context.Users.Include(u => u.Interests)
            //        .ThenInclude(i => i.Interest.Category)
            //        .ThenInclude(c => c.Events)
            //        .FirstOrDefault(u => u.Id == userId)
            //        .Interests.Select(i => i.Interest.Category);

            //result.Events = context.Events.Include(e => e.Category).Where(e => userCategories.Contains(e.Category)).ToList();
            return result;
        }

        public ProfileInterestsViewModel GetProfileInterests(int userId)
        {
            ProfileInterestsViewModel result = new ProfileInterestsViewModel();
            result.Interests = context.Users
                .Include(u => u.Interests)
                .ThenInclude(i => i.Interest)
                .FirstOrDefault(u => u.Id == userId)
                .Interests
                .Select(i => i.Interest);

            return result;
        }
    }
}
