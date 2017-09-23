using SocialConnector.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using SocialConnector.Entites.Entities;
using SocialConnector.Models.Security;
using SocialConnector.Entites.EF_DbContext;
using SocialConnector.Services.Abstract.Base;

namespace SocialConnector.Services.Concrete
{
    public class AuthenticationService : BaseService, IAuthenticationService
    {
        public AuthenticationService(SocialConnectorDbContext context) : base(context)
        {

        }
        public bool Login(LoginModel loginModel)
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public User Register(RegisterModel registerModel)
        {
            throw new NotImplementedException();
        }
    }
}
