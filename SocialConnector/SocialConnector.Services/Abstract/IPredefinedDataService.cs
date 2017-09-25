using SocialConnector.Entites.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialConnector.Services.Abstract
{
    public interface IPredefinedDataService
    {
        IEnumerable<Nationality> GetNationalities();
        IEnumerable<Religion> GetReligions();
    }
}
