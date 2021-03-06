﻿using System;
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

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }

        public virtual CustomerUser CustomerUser { get; set; }

    }
}
