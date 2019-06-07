using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Store.Domain.Interfaces;

namespace Store.Repository {
    public abstract class BaseRepository<T> where T : class {

        internal StoreDbContext _context;

        public BaseRepository(IStoreDbContext context) {
            _context = context as StoreDbContext;
        }

        public virtual T Fetch(int id) {
            return _context.Set<T>().Find(id);
        }

        public virtual IEnumerable<T> Set() {
            return _context.Set<T>();
        }

        public virtual void Save(T entity) {
            Save(_context.Set<T>(), entity);
        }

        public virtual void Delete(int id) {
            Delete(Fetch(id));
        }

        public virtual void Delete(T entity) {
            Delete(_context.Set<T>(), entity);
        }

        public virtual void Save(DbSet<T> set, T entity) {
            var entry = _context.Entry(entity);
            if(entry == null || entry.State == EntityState.Detached)
                set.Add(entity);
        }

        public virtual void Delete(DbSet<T> set, T entity) {
            set.Remove(entity);
        }

        public virtual void Commit() {
            _context.SaveChanges();
        }

    }
}
