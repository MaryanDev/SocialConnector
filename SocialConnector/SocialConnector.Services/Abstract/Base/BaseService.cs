using SocialConnector.Entites.EF_DbContext;
using System;
using System.Collections.Generic;
using System.Text;
using SocialConnector.Entites.Entities;

namespace SocialConnector.Services.Abstract.Base
{
    public abstract class BaseService
    {
        protected SocialConnectorDbContext context;

        public BaseService(SocialConnectorDbContext context)
        {
            this.context = context;
        }
    }
}
