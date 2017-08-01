using InteriorMobilya.DataAccess.Context;
using InteriorMobilya.Model.Entities.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace InteriorMobilya.WebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ApplicationDbContext db = new ApplicationDbContext();

            UserStore<ApplicationUser> userStore = new UserStore<ApplicationUser>(db);

            UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(userStore);

            RoleStore<Role> roleStore = new RoleStore<Role>(db);

            RoleManager<Role> roleManager = new RoleManager<Role>(roleStore);

            if(!roleManager.RoleExists("Admin"))
            {
                Role adminRole = new Role("Admin");
                roleManager.Create(adminRole);
            }

            if(!roleManager.RoleExists("Customer"))
            {
                Role customerRole = new Role("Customer");
                roleManager.Create(customerRole);
            }

            ApplicationUser Admin = new ApplicationUser { Email = "admin@admin.com", UserName = "Admin", EmailConfirmed = true };

            if(userManager.Create(Admin,"asd123").Succeeded)
            {
                userManager.AddToRole(userManager.FindByName("Admin").Id, "Admin");
            }

        }
    }
}
