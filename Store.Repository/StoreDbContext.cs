using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Store.Repository.Migrations;
using Store.Domain.Domains;
using System.Data.Entity.ModelConfiguration.Conventions;
using Store.Domain.Interfaces;

namespace Store.Repository {
    public class StoreDbContext : DbContext, IStoreDbContext {
        public StoreDbContext() : base("name = StoreDbContext") {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StoreDbContext, Configuration>());
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Feature> Features { get; set; }
        public virtual DbSet<FeatureValue> FeatureValues { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
