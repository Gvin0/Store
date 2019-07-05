using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Domain.Domains;
using Store.Domain.Interfaces;

namespace Store.Services {
  public class ProductListService : BaseService<ProductList, IProductListRepository>, IProductListService {
    public ProductListService(IProductListRepository repository) : base(repository) {

    }
  }
}
