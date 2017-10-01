using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using SocialConnector.Entites.EF_DbContext;
using SocialConnector.Models.UserProfile;
using SocialConnector.Services.Abstract;
using SocialConnector.Services.Abstract.Base;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SocialConnector.Entites.Entities;
using SocialConnector.Mappings.Profile;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace SocialConnector.Services.Concrete
{
    public class UserProfileService : BaseService, IUserProfileService
    {
        private IHostingEnvironment _appEnvironment;
        public UserProfileService(SocialConnectorDbContext context, IHostingEnvironment appEnvironment) : base(context)
        {
            _appEnvironment = appEnvironment;
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
                    .Where(r => r.User.Id == userId && r.IsConfirmed)
                    .Select(r => r.Friend)
                    .Select(f => UserMapping.MapFriendViewModelFromUser(f))
                    .ToList();

            var friends2 = context.Relationships.Include(r => r.User)
                    .Include(r => r.Friend)
                    .ThenInclude(r => r.Gender)
                    .Where(r => r.Friend.Id == userId && r.IsConfirmed)
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

        public WallViewModel GetPostsForUser(int userId)
        {
            WallViewModel result = new WallViewModel();
             result.Posts = context.Posts.Include(p => p.Author)
                .Include(p => p.Comments)
                .Include(p => p.ToUser)
                .Where(p => p.ToUser != null)
                .Where(p => p.ToUser.Id == userId)
                .OrderByDescending(p => p.PublishedDate)
                .Select(p => UserMapping.MapPostViewModelFromDb(p))
                .ToList();

            return result;
        }

        public void AddNewPost(AddWallPostViewModel newPost)
        {
            context.Posts.Add(new Post
            {
                Text = newPost.Text,
                Author = context.Users.FirstOrDefault(u => u.UserName == newPost.AuthorName),
                ToUser = context.Users.FirstOrDefault(u => u.Id == newPost.Id),
                PublishedDate = DateTime.Now
            });

            context.SaveChanges();
        }

        public bool UpdateProfileAvatar(IFormFile avatar, string currentUserName)
        {
            try
            {
                string path = $"/Content/DatabaseImages/Users/{currentUserName}/";
                var fullPath = _appEnvironment.WebRootPath + path;

                if(!Directory.Exists(fullPath))
                {
                    Directory.CreateDirectory(fullPath);
                }

                fullPath += avatar.FileName;

                using (var fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    avatar.CopyTo(fileStream);
                }
                SaveAvatarToDb(path + avatar.FileName, currentUserName);

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        private void SaveAvatarToDb(string avatarPath, string userName)
        {
            var user = context.Users.FirstOrDefault(u => u.UserName == userName);
            context.Images.Add(new Image
            {
                Path = avatarPath,
                User = user
            });
            user.Avatar = avatarPath;
            context.Entry(user).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
