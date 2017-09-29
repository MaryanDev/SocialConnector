using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SocialConnector.Entites.Entities;
using SocialConnector.Models.UserProfile;
using SocialConnector.Services.Abstract;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SocialConnector.Web.Controllers
{
    public class HomeController : Controller
    {
        private IUserProfileService _userProfileService;

        public HomeController(IUserProfileService userProfileService)
        {
            _userProfileService = userProfileService;
        }
        // GET: /<controller>/
        [Authorize]
        public IActionResult Profile(int? id)
        {
            ProfileMainViewModel user;
            if (id != null)
            {
                user = _userProfileService.GetProfileInfo(id.Value);
                if (user == null)
                {
                    return NotFound();
                }
            }
            else
            {
                user = _userProfileService.GetProfileInfo(User.Identity.Name);
                id = user.Id;
            }
            var profileModel = new UserProfileModel
            {
                Id = id.Value,
                IsMyPage = user.UserName == User.Identity.Name,
                FirstName = user.FirstName
            };
            return View(profileModel);
        }

        [HttpPost]
        public IActionResult AddPost(WallPostViewModel newPost)
        {
            return null;
        }
    }
}
