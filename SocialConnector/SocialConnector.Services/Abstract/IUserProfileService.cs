using System;
using System.Collections.Generic;
using System.Text;
using SocialConnector.Models.UserProfile;

namespace SocialConnector.Services.Abstract
{
    public interface IUserProfileService
    {
        ProfileMainViewModel GetProfileInfo(string identityName);
    }
}
