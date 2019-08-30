using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Domain.Domains;
using Store.Domain.Interfaces;

namespace Store.Services {
  public class RelatedProductsService : BaseService<RelatedProducts, IRelatedProductsRepository>, IRelatedProductsService {
    public RelatedProductsService(IRelatedProductsRepository repository) : base(repository) {

    }
  }
}