using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Domain.Domains;
using Store.Domain.Interfaces;

namespace Store.Repository {
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        internal ProductRepository(IStoreDbContext context) : base(context) {

        }
    }
}
