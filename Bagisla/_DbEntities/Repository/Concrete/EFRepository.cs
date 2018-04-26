using _DbEntities.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;
using System.Data.Entity;
using _DbEntities.Models;
namespace _DbEntities.Repository.Concrete
{
    public class EFRepository<T> : IRepository<T> where T : class
    {/*

        private BagislarDBEntities2 _context;

        public BagislarDBEntities2 Context
        {
            get
            {
                if (_context == null)
                    _context = new BagislarDBEntities2();
                return _context;
            }
            set { _context = value; }
        }*/
        


        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;
        public EFRepository(DbContext dbContext) {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }
        public void Delete(int id)
        {
          _dbSet.Remove(GetById(id));
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public T Get(Expression<Func<T, bool>> where)
        {
           return _dbSet.Where(where).SingleOrDefault();
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }
        public List<T> GetList()
        {
            return _dbContext.Set<T>().ToList();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> where)
        {
            return _dbSet.Where(where);
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Insert(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Updete(T entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}