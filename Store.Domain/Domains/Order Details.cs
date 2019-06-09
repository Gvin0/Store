using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Domains {
    public class Order_Details {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "money"), Required]
        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public virtual Orders Order { get; set; }

        public virtual Product Product { get; set; }


    }
}
