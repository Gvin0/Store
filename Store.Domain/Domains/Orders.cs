using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Domain.Domains {
   public class Orders {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "datetime"), Required]
        public DateTime OrderDate { get; set; }

        public virtual ICollection<Order_Details> Order_Details { get; set; }

        public virtual User User { get; set; }

    }
}
