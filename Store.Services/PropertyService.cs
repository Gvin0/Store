using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Domain.Domains;
using Store.Domain.Interfaces;

namespace Store.Services {
  public class PropertyService : BaseService<Property, IPropertyRepository>, IPropertyService {
    public PropertyService(IPropertyRepository repository) : base(repository) {

    }
  }
}
