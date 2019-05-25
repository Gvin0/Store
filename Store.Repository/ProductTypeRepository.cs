using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Domain.Domains;
using Store.Domain.Interfaces;

namespace Store.Repository {
    public class ProductTypeRepository : BaseRepository<ProductType>, IProductTypeRepository
    {
        internal ProductTypeRepository(IStoreDbContext context) : base(context) {

        }
    }
}
