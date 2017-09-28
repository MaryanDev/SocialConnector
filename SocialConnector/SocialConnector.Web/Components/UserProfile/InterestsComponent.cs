using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SocialConnector.Services.Abstract;
using SocialConnector.Models.UserProfile;

namespace SocialConnector.Web.Components.UserProfile
{
    public class InterestsComponent : ViewComponent
    {
        protected IUserProfileService _userProfileService;

        public InterestsComponent(IUserProfileService userProfileService)
        {
            _userProfileService = userProfileService;
        }

        public IViewComponentResult Invoke(UserProfileModel userProfile)
        {
            var profileInterests = _userProfileService.GetProfileInterests(userProfile.Id);
            profileInterests.IsMyPage = userProfile.IsMyPage;
            profileInterests.FirstName = userProfile.FirstName;
            return View("Interests", profileInterests);
        }
    }
}
