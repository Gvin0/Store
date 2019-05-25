using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Store.Domain;

namespace Store.Repository {
    public class ProductRepository : BaseRepository<Product> {
        internal ProductRepository(StoreDbContext context) : base(context) {

        }
    }
}
