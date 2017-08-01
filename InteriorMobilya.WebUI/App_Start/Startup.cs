using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using InteriorMobilya.DataAccess.Context;

[assembly: OwinStartup(typeof(InteriorMobilya.WebUI.App_Start.Startup))]

namespace InteriorMobilya.WebUI.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext(ApplicationDbContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            app.CreatePerOwinContext<ApplicationSignInManager>(ApplicationSignInManager.Create);

            app.UseCookieAuthentication(new Microsoft.Owin.Security.Cookies.CookieAuthenticationOptions
            {
                AuthenticationType = "ApplicationCookie",
                LoginPath = new PathString("/Account/Login")
            });
        }
    }
}
