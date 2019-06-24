using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Domain.Interfaces;
using Store.Domain.Domains;

namespace Store.Repository {
    public class CartProductRepository : BaseRepository<CartProduct>, ICartProductRepository {
        public CartProductRepository(IStoreDbContext context) : base(context) {

        }
    }
}
