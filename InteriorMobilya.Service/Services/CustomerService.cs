using System.Linq;
using InteriorMobilya.Model.Entities;
using InteriorMobilya.DataAccess.Interfaces;
using InteriorMobilya.Service.Interfaces;

namespace InteriorMobilya.Service.Services
{
    public class CustomerService : BaseService<Customer>, ICustomerService
    {
        public CustomerService(IRepository<Customer> repository) : base(repository)
        {
        }

        public Customer FindByEmailAddress(string email)
        {
            return GetAll(x => x.Email == email).FirstOrDefault();
        }

    }
}
