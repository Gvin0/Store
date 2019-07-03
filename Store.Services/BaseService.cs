using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Store.Domain.Domains;
using Store.Domain.Interfaces;
using Store.Repository;

namespace Store.Services
{
    public abstract class BaseService<TEntity, TRepo> : IBaseService<TEntity>  
                                                       where TEntity : class 
                                                       where TRepo : IBaseRepository<TEntity>
    {
        private TRepo _repo;
        //private IStoreDbContext _context;
        public BaseService(/*IStoreDbContext context, */TRepo repo)
        {
            _repo = repo;
            //_context  = context as StoreDbContext;
        }    
        public TEntity Fetch(int id)
        {
            return _repo.Fetch(id);
        }

        public IEnumerable<TEntity> Set()
        {
            return _repo.Set();
        }

        public void Save(TEntity entity)
        {
            _repo.Save(entity);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }
        public void Commit()
        {
            _repo.Commit();
        }
    }
}
