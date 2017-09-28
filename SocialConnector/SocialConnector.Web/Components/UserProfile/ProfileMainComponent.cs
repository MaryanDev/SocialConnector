using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SocialConnector.Services.Abstract;
using SocialConnector.Models.UserProfile;

namespace SocialConnector.Web.Components.UserProfile
{
    public class ProfileMainComponent : ViewComponent
    {
        protected IUserProfileService _userProfileService;

        public ProfileMainComponent(IUserProfileService userProfileService)
        {
            _userProfileService = userProfileService;
        }
        public IViewComponentResult Invoke(UserProfileModel userProfile)
        {
            var profileModel = _userProfileService.GetProfileInfo(userProfile.Id);
            profileModel.IsMyPage = userProfile.IsMyPage;
            profileModel.FirstName = userProfile.FirstName;
            return View("ProfileMain", profileModel);
        }
    }
}
