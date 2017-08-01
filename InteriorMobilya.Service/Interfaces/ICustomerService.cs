using InteriorMobilya.Model.Entities;

namespace InteriorMobilya.Service.Interfaces
{
    public interface ICustomerService:IBaseService<Customer>
    {
        Customer FindByEmailAddress(string email);        
    }
}
