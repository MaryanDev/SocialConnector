using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
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
        [Route("/profile/{id?}")]
        [Route("/Home/Profile/{id?}")]
        public IActionResult Profile(int? id)
        {
            if (id != null)
            {
                var user = _userProfileService.GetProfileInfo(id.Value);
                if (user == null)
                {
                    return NotFound();
                }
            }
            else
            {
                id = _userProfileService.GetProfileInfo(User.Identity.Name).Id;
            }
            return View(id.Value);
        }
    }
}
