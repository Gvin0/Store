//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.Entity;
//using Store.Domain.Domains;
//using Store.Domain.Interfaces;

//namespace Store.Services {
//   public abstract class BaseService<T> : IBaseService<T> where T : class {
//        public T Fetch(int id) {
//            return UnitOfWork.Instance.GetRepository<T>().Fetch(id);
//        }

//        public IEnumerable<T> Set() {
//            return UnitOfWork.Instance.GetRepository<T>().Set();
//        }

//        public void Save(T entity) {
//            UnitOfWork.Instance.GetRepository<T>().Save(entity);

//        }

//        public void Delete(int id) {
//            UnitOfWork.Instance.GetRepository<T>().Delete(id);
//        }

//        public void Delete(T entity) {
//            UnitOfWork.Instance.GetRepository<T>().Delete(entity);
//        }

//        public void Commit() {
//            UnitOfWork.Instance.Commit();
//        }
//    }
//}
