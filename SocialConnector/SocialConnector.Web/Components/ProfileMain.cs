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
        private readonly IUserProfileService _userProfileService;
        public ProfileMain(IUserProfileService userProfileService)
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
