using InteriorMobilya.DataAccess.Context;
using InteriorMobilya.Model.Entities;
using InteriorMobilya.Model.Entities.Identity;
using InteriorMobilya.Service.Interfaces;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Web.Mvc;

namespace InteriorMobilya.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ICustomerService _service;
        private readonly UserStore<ApplicationUser> _userStore;
        private readonly UserManager<ApplicationUser> _userManager;

        public DefaultController(ICustomerService service,IdentityDbContext context)
        {
            _service = service;
            _context = new ApplicationDbContext();
            _userStore = new UserStore<ApplicationUser>(_context);
            _userManager = new UserManager<ApplicationUser>(_userStore);
        }
        // GET: Default
        public string Index()
        {
            var db = new ApplicationDbContext();
            
            //var result = _userManager.Create(new Identity.Models.ApplicationUser { Email = "mentesess@gmail.com", UserName = DateTime.Now.Ticks.ToString()}, "123123");
            //_context.SaveChanges();
           
            //var result = _repository.GetAll();
            return "";
        }

        private bool ValidateCustomer(Customer customer)
        {
           
            return ModelState.IsValid;
        }
    }
}