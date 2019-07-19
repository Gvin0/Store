using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Store.Domain.Domains;
using Store.Domain.Interfaces;
using Store.Repository;

namespace Store.Services {
   public abstract class BaseService<TEntity, TRepository> : IBaseService<TEntity>
              where TEntity : class
              where TRepository : IBaseRepository<TEntity> {

      protected TRepository _repository;

      public BaseService(TRepository repository) {
         if(repository == null) {
            throw new ArgumentNullException("Repository is null.");
         }
         _repository = repository;
      }

      public TEntity Fetch(int id) {
         return _repository.Fetch(id);
      }

      public IEnumerable<TEntity> Set() {
         return _repository.Set();
      }

      public void Save(TEntity entity) {
         _repository.Save(entity);
      }

      public void Delete(int id) {
         _repository.Delete(id);
      }

      public void Commit() {
         _repository.Commit();
      }
   }
}
