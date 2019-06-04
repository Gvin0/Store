using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Domains {
   public class Wishlist {

        public int ID { get; set; }

        public string Title { get; set; }

        public virtual Product Product { get; set; }

        public virtual User User { get; set; }
    }
}
