using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SocialConnector.Models.UserProfile;
using SocialConnector.Services.Abstract;

namespace SocialConnector.Web.Components.UserProfile
{
    public class WallComponent : ViewComponent
    {
        private IUserProfileService _userProfileService;

        public WallComponent(IUserProfileService userProfileService)
        {
            _userProfileService = userProfileService;
        }

        public IViewComponentResult Invoke(UserProfileModel userProfile)
        {
            var wallViewModel = _userProfileService.GetPostsForUser(userProfile.Id);
            wallViewModel.Id = userProfile.Id;
            wallViewModel.IsMyPage = userProfile.IsMyPage;
            return View("Wall", wallViewModel);
        }
    }
}
