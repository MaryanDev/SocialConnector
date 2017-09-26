using System;
using System.Collections.Generic;
using System.Text;
using SocialConnector.Entites.EF_DbContext;
using SocialConnector.Services.Abstract;
using SocialConnector.Services.Abstract.Base;

namespace SocialConnector.Services.Concrete
{
    public class SearchService : BaseService, ISearchService
    {
        public SearchService(SocialConnectorDbContext context) : base(context)
        {
                
        }
    }
}
