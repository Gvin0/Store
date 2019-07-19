using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Domains
{
    [Table("Carts")]
    public class Cart : ProductList
    {
        public virtual ICollection<CartProduct> CartProducts { get; set; }
    }
}
