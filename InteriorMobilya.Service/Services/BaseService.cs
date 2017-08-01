using InteriorMobilya.DataAccess.Interfaces;
using InteriorMobilya.Model;
using InteriorMobilya.Service.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace InteriorMobilya.Service.Services
{
    public abstract class BaseService<TEntity> : IBaseService<TEntity>
        where TEntity : class, IEntity
    {
        protected readonly IRepository<TEntity> _repository;

        public BaseService(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual void Add(TEntity entity)
        {
            _repository.Add(entity);
        }

        public virtual void Delete(object id)
        {
            _repository.Delete(id);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public virtual IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            return _repository.GetAll(predicate);
        }

        public virtual TEntity GetByID(object id)
        {
            return _repository.GetByID(id);
        }

        public virtual void Update(TEntity entity)
        {
            _repository.Update(entity);
        }
    }
}
