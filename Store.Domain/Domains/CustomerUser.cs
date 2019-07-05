using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Domains {
  [Table("CustomerUsers")]
  public class CustomerUser : ExternalUser {

    public virtual ICollection<ProductList> Wishlists { get; set; }

    public virtual ICollection<Orders> Orders { get; set; }
  }
}
