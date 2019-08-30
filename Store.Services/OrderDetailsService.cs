using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Domain.Domains;
using Store.Domain.Interfaces;

namespace Store.Services {
   public class OrderDetailsService : BaseService<OrderDetails, IOrderDetailsRepository>, IOrderDetailsService {
      public OrderDetailsService(IOrderDetailsRepository repository) : base(repository) {

      }
   }
}
