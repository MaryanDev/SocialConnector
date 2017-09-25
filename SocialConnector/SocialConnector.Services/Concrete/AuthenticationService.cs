using SocialConnector.Services.Abstract;
using System.Collections.Generic;
using System.Linq;
using SocialConnector.Entites.EF_DbContext;
using SocialConnector.Entites.Entities;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using SocialConnector.Models.Security;
using SocialConnector.Services.Abstract.Base;
using Microsoft.AspNetCore.Http;
using SocialConnector.Models.Enums;

namespace SocialConnector.Services.Concrete
{
    public class AuthenticationService : BaseService, ISocialAuthenticationService
    {
        private readonly HttpContext _httpContext;
        public AuthenticationService(SocialConnectorDbContext context, IHttpContextAccessor accessor) : base(context)
        {
            _httpContext = accessor.HttpContext;
        }
        public bool Login(LoginModel loginModel)
        {
            User user = context.Users.FirstOrDefault(u => u.Email == loginModel.LoginName && u.Password == loginModel.Password) ??
                        context.Users.FirstOrDefault(u => u.UserName == loginModel.LoginName && u.Password == loginModel.Password);
            if (user != null)
            {
                Authenticate(loginModel.LoginName);
                return true;
            }
            return false;
        }

        public void Logout()
        {
            _httpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }

        public User Register(RegisterModel registerModel)
        {
            User user = context.Users.FirstOrDefault(u => u.Email == registerModel.Email);
            if (user == null)
            {
                var newUser = new User
                {
                    Email = registerModel.Email,
                    Password = registerModel.Password,
                    UserName = registerModel.UserName,
                    Role = GetUserRole(SocialConnectorRoles.User)
                };
                context.Users.Add(newUser);
                context.SaveChanges();

                Authenticate(registerModel.Email);
                return newUser;
            }
            return null;
        }

        private void Authenticate(string userName)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            _httpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        private Role GetUserRole(SocialConnectorRoles role)
        {
            return context.Roles.FirstOrDefault(r => r.RoleTitle == role.ToString());
        }
    }
}
