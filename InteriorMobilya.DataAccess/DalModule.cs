using InteriorMobilya.DataAccess.Context;
using Ninject.Modules;
using System.Data.Entity;

namespace InteriorMobilya.DataAccess
{
    public class DalModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<DbContext>().To<ApplicationDbContext>();
        }
    }
}
