using InteriorMobilya.Model.Entities;
using InteriorMobilya.DataAccess.Interfaces;
using InteriorMobilya.Service.Interfaces;

namespace InteriorMobilya.Service.Services
{
    public class CategoryService : BaseService<Category>, ICategoryService
    {
        public CategoryService(IRepository<Category> repository) : base(repository)
        {
        }

    }
}
