using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialConnector.Entites.EF_DbContext
{
    public class SocialConnectorDbContext : DbContext
    {
        public SocialConnectorDbContext(DbContextOptions<SocialConnectorDbContext> options) : base(options)
        {
                
        }
    }
}
