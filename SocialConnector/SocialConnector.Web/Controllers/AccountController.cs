using Microsoft.AspNetCore.Mvc;
using SocialConnector.Entites.Entities;
using SocialConnector.Models.Security;
using SocialConnector.Services.Abstract;
using System.Linq;

namespace SocialConnector.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly ISocialAuthenticationService _authService;
        private readonly IPredefinedDataService _predefDataService;
        public AccountController(ISocialAuthenticationService authService, IPredefinedDataService predefDataService)
        {
            _authService = authService;
            _predefDataService = predefDataService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Profile", "Home");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                if (_authService.Login(model))
                    return RedirectToAction("Profile", "Home");

                ModelState.AddModelError("", "Incorrect login or password");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Profile", "Home");
            }
            return View(PopulatePredefinedData(new RegisterModel()));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                User newUser = _authService.Register(model);
                if (newUser != null)
                    return RedirectToAction("Profile", "Home");

                ModelState.AddModelError("", "Something gone wrong, please try later");
            }
            return View(PopulatePredefinedData(model));
        }

        public IActionResult Logout()
        {
            _authService.Logout();
            return RedirectToAction("Login", "Account");
        }

        private RegisterModel PopulatePredefinedData(RegisterModel rm)
        {
            rm.AllNationalities = _predefDataService.GetNationalities().Select(n => n.Title);
            rm.AllReligions = _predefDataService.GetReligions().Select(r => r.Title);
            return rm;
        }
    }
}
