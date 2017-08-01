using InteriorMobilya.DataAccess.Interfaces;
using InteriorMobilya.Model;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;

namespace InteriorMobilya.DataAccess.Repositories
{
    public class BaseEFRepository<TEntity> : IRepository<TEntity>,IDisposable where TEntity : class, IEntity
    {
        private readonly DbContext _context;

        protected DbSet<TEntity> DbSet
        {
            get
            {
                return _context.Set<TEntity>();
            }
        }

        public BaseEFRepository(DbContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {
            try
            {
                DbSet.Add(entity);
                Save();
            }
            catch (Exception)
            {
            }
        }

        public void Delete(object id)
        {
            try
            {
                DbSet.Remove(GetByID(id));
                Save();
            }
            catch (Exception)
            {
            }
        }

        public IQueryable<TEntity> GetAll()
        {
            return DbSet.AsQueryable();
        }

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate).AsQueryable();
        }

        public TEntity GetByID(object id)
        {
            return DbSet.Find(id);
        }

        public void Update(TEntity entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Modified;
                Save();
            }
            catch (Exception)
            {
            }
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
