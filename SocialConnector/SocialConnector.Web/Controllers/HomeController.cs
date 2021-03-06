﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SocialConnector.Entites.Entities;
using SocialConnector.Models.UserProfile;
using SocialConnector.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.Net;

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
        public IActionResult AddPost(AddWallPostViewModel newPost)
        {
            var isAjax = IsAjaxRequest(Request);
            if (ModelState.IsValid)
            {
                newPost.AuthorName = User.Identity.Name;
                _userProfileService.AddNewPost(newPost);
            }
            
            return RedirectToAction(nameof(Profile), new { id = newPost.Id });
        }
        public  bool IsAjaxRequest(HttpRequest request)
        {
            if (request == null)
                throw new ArgumentNullException("request");

            if (request.Headers != null)
                return request.Headers["X-Requested-With"] == "XMLHttpRequest";
            return false;
        }

        [HttpPost]
        public IActionResult UploadAvatar([FromForm]IFormFile uploadedAvatar)
        {
            if(uploadedAvatar != null)
            {
                if(_userProfileService.UpdateProfileAvatar(uploadedAvatar, User.Identity.Name))
                {
                    return StatusCode((int)HttpStatusCode.Created, value: new { message = "Avatar updated successfully!" });
                    //return RedirectToAction(nameof(Profile), new { });
                }
            }
            return StatusCode((int)HttpStatusCode.InternalServerError, value: new { message = "Error while uploading avatar." });
        }
    }
}
