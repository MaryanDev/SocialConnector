using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SocialConnector.Services.Abstract;

namespace SocialConnector.Web.Components.UserProfile
{
    public class ProfileMainComponent : ViewComponent
    {
        protected IUserProfileService _userProfileService;

        public ProfileMainComponent(IUserProfileService userProfileService)
        {
            _userProfileService = userProfileService;
        }
        public IViewComponentResult Invoke(int userId)
        {
            var profileModel = _userProfileService.GetProfileInfo(userId);

            return View("ProfileMain", profileModel);
        }
    }
}
