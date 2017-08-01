using InteriorMobilya.DataAccess.Context;
using InteriorMobilya.Model.Entities.Identity;
using InteriorMobilya.WebUI.Models.User;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Web.Mvc;
using System.Data.Entity;
using System;
using InteriorMobilya.Service.Interfaces;
using Microsoft.AspNet.Identity.Owin;
using InteriorMobilya.WebUI.App_Start;
using System.Web;

namespace InteriorMobilya.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly ICustomerService _customerService;
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        public AccountController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }


        // GET: Account
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = UserManager.FindByEmail(model.Email);
            var result = SignInManager.PasswordSignIn(user.UserName, model.Password, model.RememberMe, shouldLockout: false);

            switch (result)
            {
                case SignInStatus.Success:
                    return RedirectToAction("Index", "Home");
                default:
                    ModelState.AddModelError("", "Email Address or Password is wrong");
                    return View(model);
            }

        }

        [AllowAnonymous]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            ApplicationUser user = new ApplicationUser
            {
                Email = model.Email,
                UserName = model.Email
            };

            var result = UserManager.Create(user, model.Password);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("Email", "This mail address is used");
                return View(model);

            }

            var identity = UserManager.FindByEmail(user.Email);
            //Kullanıcıya rol atama
            UserManager.AddToRole(identity.Id, "Customer");
            _customerService.Add(new Model.Entities.Customer
            {
                CustomerID = identity.Id,
                CustomerName = model.Name,
                CustomerSurname = model.Surname,
                Email = user.Email
            });

            return RedirectToAction("Login");
        }
    }
}