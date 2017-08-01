using InteriorMobilya.Model;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace InteriorMobilya.DataAccess.Interfaces
{
    public interface IRepository<TEntity>where TEntity: class,IEntity
    {
        void Add(TEntity entity);
        void Delete(object id);
        void Update(TEntity entity);
        TEntity GetByID(object id);
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetAll(Expression<Func<TEntity,bool>> predicate);
        int Save();

    }
}
