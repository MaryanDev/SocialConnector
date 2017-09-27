using System;
using System.Collections.Generic;
using System.Text;
using SocialConnector.Entites.EF_DbContext;
using SocialConnector.Models.UserProfile;
using SocialConnector.Services.Abstract;
using SocialConnector.Services.Abstract.Base;
using System.Linq;
using SocialConnector.Entites.Entities;
using SocialConnector.Mappings.Profile;

namespace SocialConnector.Services.Concrete
{
    public class UserProfileService : BaseService, IUserProfileService
    {
        public UserProfileService(SocialConnectorDbContext context) : base(context)
        {

        }

        public ProfileMainViewModel GetProfileInfo(string identityName)
        {
            User user = context.Users.FirstOrDefault(u => u.Email == identityName) ??
                        context.Users.FirstOrDefault(u => u.UserName == identityName);

            return UserMapping.MapProfileFromDb(user);
        }

        public ProfileMainViewModel GetProfileInfo(int userId)
        {
            User user = context.Users.FirstOrDefault(u => u.Id == userId);

            return UserMapping.MapProfileFromDb(user);
        }
    }
}
