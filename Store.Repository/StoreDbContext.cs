using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Store.Domain.Domains;
using System.Data.Entity.ModelConfiguration.Conventions;
using Store.Domain.Interfaces;
using Store.Repository.Migrations;

namespace Store.Repository {
   public class StoreDbContext : DbContext, IStoreDbContext {
      public StoreDbContext() : base("name = StoreDbContext") {
         Database.SetInitializer(new MigrateDatabaseToLatestVersion<StoreDbContext, Configuration>());
      }

      #region DbSets
      public virtual DbSet<Product> Products { get; set; }
      public virtual DbSet<TemplateProperty> TemplateProperties { get; set; }
      public virtual DbSet<Category> Categories { get; set; }
      public virtual DbSet<ProductTemplate> ProductTemplates { get; set; }
      public virtual DbSet<PropertyValue> PropertyValues { get; set; }
      public virtual DbSet<Property> Properties { get; set; }
      public virtual DbSet<OperatorUser> OperatorUsersUsers { get; set; }
      public virtual DbSet<AdminUser> AdminUsersUsers { get; set; }
      public virtual DbSet<OrderDetails> Order_Details { get; set; }
      public virtual DbSet<Orders> Orders { get; set; }
      public virtual DbSet<WishList> WishLists { get; set; }
      public virtual DbSet<Cart> Carts { get; set; }
      public virtual DbSet<CartProduct> CartProducts { get; set; }
      public virtual DbSet<RelatedProducts> RelatedProducts { get; set; }
      public virtual DbSet<User> Users { get; set; }
      public virtual DbSet<ProductList> ProductLists { get; set; }
      #endregion

      public IStoreDbTransaction BeginTransaction() {
         var transaction = Database.BeginTransaction();
         return new StoreDbTransaction(transaction);
      }

      public override int SaveChanges() {
         try {
            return base.SaveChanges();
         }
         catch(Exception ex) {
            // aq gavaketot logireba
            throw;
         }
      }

      protected override void OnModelCreating(DbModelBuilder modelBuilder) {
         modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
      }
   }
}
