using InteriorMobilya.DataAccess.Interfaces;
using InteriorMobilya.DataAccess.Repositories;
using InteriorMobilya.Model.Entities;
using Ninject.Modules;

namespace InteriorMobilya.Service
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<Customer>>().To<BaseEFRepository<Customer>>();
            Bind<IRepository<Address>>().To<BaseEFRepository<Address>>();
            Bind<IRepository<Category>>().To<BaseEFRepository<Category>>();
        }
    }
}
