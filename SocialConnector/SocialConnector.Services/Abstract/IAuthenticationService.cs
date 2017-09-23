using SocialConnector.Entites.Entities;
using SocialConnector.Models.Security;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialConnector.Services.Abstract
{
    public interface ISocialAuthenticationService
    {
        bool Login(LoginModel loginModel);
        User Register(RegisterModel registerModel);
        void Logout();
    }
}
