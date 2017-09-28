using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SocialConnector.Services.Abstract;

namespace SocialConnector.Web.Components.UserProfile
{
    public class ProfileAccordionComponent : ViewComponent
    {
        protected IUserProfileService _userProfileService;

        public ProfileAccordionComponent(IUserProfileService userProfileService)
        {
            _userProfileService = userProfileService;
        }
        public IViewComponentResult Invoke(int userId)
        {
            var profileAccordion = _userProfileService.GetProfileAccordionContent(userId);
            return View("ProfileLEftAccordion", profileAccordion);
        }
    }
}
