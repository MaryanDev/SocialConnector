using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SocialConnector.Entites.EF_DbContext;
using SocialConnector.Entites.Entities;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using SocialConnector.Models.Security;
using SocialConnector.Services.Abstract;

namespace SocialConnector.Web.Controllers
{
    public class AccountController : Controller
    {
        private ISocialAuthenticationService _authService;
        public AccountController(ISocialAuthenticationService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        public IActionResult Login()
        {
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
                else
                    ModelState.AddModelError("", "Incorrect login or password");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
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
                else
                    ModelState.AddModelError("", "Incorrect login or password");
            }
            return View(model);
        }

        public IActionResult Logout()
        {
            _authService.Logout();
            return RedirectToAction("Login", "Account");
        }
    }
}
