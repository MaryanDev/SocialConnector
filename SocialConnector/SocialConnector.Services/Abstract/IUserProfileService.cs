using System;
using System.Collections.Generic;
using System.Text;
using SocialConnector.Models.UserProfile;
using Microsoft.AspNetCore.Http;

namespace SocialConnector.Services.Abstract
{
    public interface IUserProfileService
    {
        ProfileMainViewModel GetProfileInfo(string identityName);
        ProfileMainViewModel GetProfileInfo(int userId);

        ProfileAccordionViewModel GetProfileAccordionContent(int userId);
        ProfileInterestsViewModel GetProfileInterests(int userId);
        WallViewModel GetPostsForUser(int userId);

        void AddNewPost(AddWallPostViewModel newPost);

        bool UpdateProfileAvatar(IFormFile avatar, string currentUserName);
    }
}
