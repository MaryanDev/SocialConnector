using SocialConnector.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using SocialConnector.Entites.Entities;
using SocialConnector.Services.Abstract.Base;
using SocialConnector.Entites.EF_DbContext;
using System.Linq;

namespace SocialConnector.Services.Concrete
{
    public class PredefinedDataService : BaseService, IPredefinedDataService
    {
        public PredefinedDataService(SocialConnectorDbContext context) : base(context)
        {

        }
        public IEnumerable<Nationality> GetNationalities()
        {
            return context.Nationalities.ToList();
        }

        public IEnumerable<Religion> GetReligions()
        {
            return context.Religions.ToList();
        }
    }
}
