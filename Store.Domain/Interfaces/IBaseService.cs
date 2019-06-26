using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Store.Domain.Interfaces {
    public interface IBaseService<T> where T : class {
        T Fetch(int id);
        IEnumerable<T> Set();
        void Save(T entity);
        void Delete(int id);
        //void Delete(T entity);
        //void Save(DbSet<T> set, T entity);
        //void Delete(DbSet<T> set, T entity);
        void Commit();
    }
}
