using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Domain.Domains
{
    [Table("WishLists")]
    public class WishList : ProductList
    {
        [Required]
        public string Title { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
