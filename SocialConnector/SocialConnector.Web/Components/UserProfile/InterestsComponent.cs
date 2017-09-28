using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SocialConnector.Services.Abstract;

namespace SocialConnector.Web.Components.UserProfile
{
    public class InterestsComponent : ViewComponent
    {
        protected IUserProfileService _userProfileService;

        public InterestsComponent(IUserProfileService userProfileService)
        {
            _userProfileService = userProfileService;
        }

        public IViewComponentResult Invoke(int userId)
        {
            var profileInterests = _userProfileService.GetProfileInterests(userId);
            return View("Interests", profileInterests);
        }
    }
}
