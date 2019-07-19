using System.Data.Entity;
using Store.Domain.Interfaces;

namespace Store.Repository {
   public class StoreDbTransaction : IStoreDbTransaction {
      private readonly DbContextTransaction _transaction;

      public StoreDbTransaction(DbContextTransaction transaction) {
         _transaction = transaction;
      }

      public void Commit() {
         _transaction.Commit();
      }

      public void Rollback() {
         _transaction.Rollback();
      }
   }
}
