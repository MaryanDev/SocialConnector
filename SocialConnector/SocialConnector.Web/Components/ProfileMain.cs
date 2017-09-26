using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SocialConnector.Services.Abstract;

namespace SocialConnector.Web.Components
{
    public class ProfileMain : ViewComponent
    {
        private IUserProfileService _userProfileService;
        public ProfileMain(IUserProfileService userProfileService)
        {
            _userProfileService = userProfileService;
        }
        public IViewComponentResult Invoke()
        {
            var profileModel = _userProfileService.GetProfileInfo(User.Identity.Name);
            return View("ProfileMain", profileModel);
        }
    }
}
