using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Domain.Interfaces;
using Store.Domain.Domains;

namespace Store.Repository {
    public class Order_DetailsRepository : BaseRepository<Order_Details>, IOrder_DetailsRepository {
        internal Order_DetailsRepository(IStoreDbContext context) : base(context) {

        }
    }
}
