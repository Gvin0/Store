using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Domain;

namespace Store.Repository {
    public class ProductTypeRepository : BaseRepository<ProductType> {
        internal ProductTypeRepository(StoreDbContext context) : base(context) {

        }
    }
}
