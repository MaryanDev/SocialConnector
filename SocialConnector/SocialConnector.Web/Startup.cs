using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SocialConnector.Entites.EF_DbContext;
using SocialConnector.Services.Abstract;
using SocialConnector.Services.Concrete;

namespace SocialConnector.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            string conncetion = Configuration.GetConnectionString("SocialConnectorDb");

            services.AddDbContext<SocialConnectorDbContext>(options => options.UseSqlServer(conncetion));


            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.LoginPath = new PathString("/Account/Login");
            });

            services.AddTransient<ISocialAuthenticationService, AuthenticationService>();
            services.AddTransient<IPredefinedDataService, PredefinedDataService>();
            services.AddTransient<IUserProfileService, UserProfileService>();
            services.AddTransient<ISearchService, SearchService>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, SocialConnectorDbContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute("profile", "profile/{id?}", defaults: new {controller = "Home", action = "Profile"});
                routes.MapRoute("default", "{controller=Home}/{action=Profile}/{id?}");
            });
        }  
    }
}
