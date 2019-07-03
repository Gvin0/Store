using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Domains {
   public class RelatedProducts {
        [Key]
        public int ID { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
