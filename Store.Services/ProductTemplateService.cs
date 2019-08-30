using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Domain.Domains;
using Store.Domain.Interfaces;

namespace Store.Services {
  public class ProductTemplateService : BaseService<ProductTemplate, IProductTemplateRepository>, IProductTemplateService {
    public ProductTemplateService(IProductTemplateRepository repository) : base(repository) {

    }
  }
}
