using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SocialConnector.Services.Abstract;
using SocialConnector.Models.UserProfile;

namespace SocialConnector.Web.Components.UserProfile
{
    public class ProfileAccordionComponent : ViewComponent
    {
        protected IUserProfileService _userProfileService;

        public ProfileAccordionComponent(IUserProfileService userProfileService)
        {
            _userProfileService = userProfileService;
        }
        public IViewComponentResult Invoke(UserProfileModel userProfile)
        {
            var profileAccordion = _userProfileService.GetProfileAccordionContent(userProfile.Id);
            profileAccordion.IsMyPage = userProfile.IsMyPage;
            profileAccordion.FirstName = userProfile.FirstName;
            return View("ProfileLEftAccordion", profileAccordion);
        }
    }
}
