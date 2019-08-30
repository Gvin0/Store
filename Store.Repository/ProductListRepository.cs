using Store.Domain.Domains;
using Store.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Repository
{
    class ProductListRepository : BaseRepository<ProductList>, IProductListRepository
    {
        public ProductListRepository(IStoreDbContext context) : base(context)
        {

        }
    }
}
